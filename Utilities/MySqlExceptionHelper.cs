using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace DeltaSchool.Utilities
{
    public static class MySqlExceptionHelper
    {
        // Retourne null si ce n'est pas un duplicate entry, sinon un message lisible
        public static string TryParseDuplicateEntry(MySqlException ex)
        {
            // 1062 est le code MySQL pour duplicate entry
            if (ex.Number != 1062)
                return null;

            // Exemple message MySQL:
            // "Duplicate entry '0601234567' for key 'IX_Parent_Phone'"
            var m = Regex.Match(ex.Message, @"Duplicate entry '(.+?)' for key '(.+?)'", RegexOptions.IgnoreCase);
            if (!m.Success)
                return "Valeur en double déjà existante dans la base.";

            var value = m.Groups[1].Value;
            var key = m.Groups[2].Value;

            // Mapper les noms de clé d'index à un message lisible
            key = key.ToLowerInvariant();

            if (key.Contains("phone") || key.Contains("phone_number"))
                return $"Le numéro '{value}' est déjà utilisé.";
            if (key.Contains("email"))
                return $"L'email '{value}' est déjà utilisé.";
            if (key.Contains("username"))
                return $"Le nom d'utilisateur '{value}' est déjà utilisé.";
            // Pour des index composites, on peut renvoyer un message générique :
            return $"Une valeur en double a été détectée ({value}).";
        }
    }
}
