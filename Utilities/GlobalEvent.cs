using RenComponent;
using System.Windows.Forms;

namespace DeltaSchool.Utilities
{
    public static class GlobalEvent
    {
        public static void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
                // La touche est un chiffre, un espace ou une touche de contrôle (comme Retour arrière, Suppr, etc.)
                e.Handled = false; // Permettre la saisie de la touche
            else
                // La touche n'est pas un chiffre, un espace ou une touche de contrôle
                e.Handled = true;  // Annuler la saisie de la touche
        }

        public static void NumericWithDecimal(object sender, KeyPressEventArgs e)
        {
            RenTextBox textBox = sender as RenTextBox;
            if (textBox == null)
            {
                e.Handled = true;
                return;
            }
            string currentText = textBox.Texts;
            char key = e.KeyChar;
            // Autoriser les touches de contrôle
            if (char.IsControl(key))
            {
                e.Handled = false;
                return;
            }
            // Autoriser les chiffres et les espaces
            if (char.IsDigit(key) || char.IsWhiteSpace(key))
            {
                e.Handled = false;
                return;
            }
            // Gestion du point décimal
            if (key == '.')
            {
                if (currentText.Length == 0)
                {
                    // Refuser si le texte est vide
                    e.Handled = true;
                    return;
                }

                // Le point ne peut apparaître qu'une seule fois
                if (currentText.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
                return;
            }

            // Gestion du signe -
            if (key == '-')
            {
                // Autoriser uniquement si le texte ne contient pas déjà - et qu'on est au début
                if (!currentText.Contains("-") && currentText.Length == 0)
                    e.Handled = false;
                else
                    e.Handled = true;
                return;
            }
            // Tout autre caractère est interdit
            e.Handled = true;
        }

        public static void Letters(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
                // La touche est une lettre, un espace ou une touche de contrôle (comme Retour arrière, Suppr, etc.)
                e.Handled = false; // Permettre la saisie de la touche
            else
                // La touche n'est pas une lettre, un espace ou une touche de contrôle
                e.Handled = true;  // Annuler la saisie de la touche
        }

        public static void PhoneNumber(object sender, KeyPressEventArgs e)
        {
            RenTextBox textBox = sender as RenTextBox;
            if (textBox == null)
            {
                e.Handled = true;
                return;
            }

            string currentText = textBox.Texts;
            char key = e.KeyChar;

            // Autoriser les touches de contrôle
            if (char.IsControl(key))
            {
                e.Handled = false;
                return;
            }

            // Autoriser les chiffres et les espaces
            if (char.IsDigit(key) || char.IsWhiteSpace(key))
            {
                e.Handled = false;
                return;
            }

            // Gestion du signe +
            if (key == '+')
            {
                // Autoriser uniquement si le texte ne contient pas déjà + et qu'on est au début
                if (!currentText.Contains("+") && currentText.Length == 0)
                    e.Handled = false;
                else
                    e.Handled = true;
                return;
            }

            // Gestion du signe -
            if (key == '-')
            {
                // Refuser si le texte est vide ou si le curseur est en début ou fin
                int length = currentText.Length;
                if (length == 0)
                {
                    e.Handled = true;
                    return;
                }

                // On autorise le - uniquement s'il sera inséré en position intermédiaire
                e.Handled = length < 2;
                return;
            }

            // Tout autre caractère est interdit
            e.Handled = true;
        }

    }
}
