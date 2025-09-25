using System.Windows.Forms;

namespace DeltaSchool.Utilities
{
    class ShowAlert
    {
        //
        // Résumé :
        //     Affiche une fenêtre contenant un message d'alert
        //     Type : 0 -> Info ; 1 -> Succès ; 2 -> Attention ; 3 -> Erreur
        //

        public enum A_type
        {
            Info,
            Success,
            Warning,
            Error
        }
        public static void DisplayMessage(string msg, A_type type)
        {
            AlertForm frm = new AlertForm();
            frm.TopMost = true;
            switch (type)
            {
                case A_type.Info:
                    frm.ShowAlert(message: msg, AlertForm.EnmType.Info);
                    break;
                case A_type.Success:
                    frm.ShowAlert(message: msg, AlertForm.EnmType.Success);
                    break;
                case A_type.Warning:
                    frm.ShowAlert(message: msg, AlertForm.EnmType.Warning);
                    break;
                case A_type.Error:
                    frm.ShowAlert(message: msg, AlertForm.EnmType.Error);
                    break;
                default:
                    frm.ShowAlert("Type choisi incorrect", AlertForm.EnmType.Error);
                    break;
            }

        }

        public static DialogResult RemoveItem()
        {
            return MessageBox.Show("Voulez-vous supprimer cet élément", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
