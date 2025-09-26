using MySql.Data.MySqlClient;
using System.Data.Entity.Infrastructure;
using System.Text.RegularExpressions;

namespace DeltaSchool.Utilities
{
    public static class DbExceptionHandler
    {
        public static void HandleDbUpdateException(DbUpdateException dbEx)
        {
            var baseEx = dbEx.GetBaseException();

            if (baseEx is MySqlException myEx)
            {
                // 1062 = Duplicate entry
                if (myEx.Number == 1062)
                {
                    var friendly = TryParseDuplicateEntry(myEx);
                    ShowAlert.DisplayMessage(friendly ?? "Valeur en double détectée.", ShowAlert.A_type.Error);
                    return;
                }

                // 1452 = Cannot add or update a child row: a foreign key constraint fails
                if (myEx.Number == 1452)
                {
                    ShowAlert.DisplayMessage("Contrainte de clé étrangère violée (FK). Vérifie les relations existantes.", ShowAlert.A_type.Error);
                    return;
                }

                // 1048 = Column cannot be null
                if (myEx.Number == 1048)
                {
                    ShowAlert.DisplayMessage("Une colonne obligatoire est nulle. Vérifie les champs requis.", ShowAlert.A_type.Error);
                    return;
                }

                // 1406 = Data too long for column
                if (myEx.Number == 1406)
                {
                    ShowAlert.DisplayMessage("Une valeur est trop longue pour sa colonne. Vérifie les longueurs (StringLength).", ShowAlert.A_type.Error);
                    return;
                }

                // fallback
                ShowAlert.DisplayMessage($"Erreur MySQL #{myEx.Number}: {myEx.Message}", ShowAlert.A_type.Error);
                return;
            }

            // Si ce n'est pas MySqlException
            ShowAlert.DisplayMessage($"Erreur de mise à jour : {baseEx.Message}", ShowAlert.A_type.Error);
        }

        private static string TryParseDuplicateEntry(MySqlException ex)
        {
            // "Duplicate entry 'value' for key 'index_name'"
            var m = Regex.Match(ex.Message, @"Duplicate entry '(.+?)' for key '(.+?)'", RegexOptions.IgnoreCase);
            if (!m.Success) return null;

            var value = m.Groups[1].Value;
            var key = m.Groups[2].Value.ToLowerInvariant();

            if (key.Contains("phone") || key.Contains("phone_number"))
                return $"Le numéro '{value}' est déjà utilisé.";
            if (key.Contains("email"))
                return $"L'email '{value}' est déjà utilisé.";
            if (key.Contains("username"))
                return $"Le nom d'utilisateur '{value}' est déjà utilisé.";

            return $"Une valeur existante a été détectée -> ({value}).";
        }
    }
}
