using System.Windows.Forms;

namespace Vhdgamer.Common
{
    public static class MessageBoxHelper
    {
        public static void ShowErrorMessageBox(string text)
        {
            MessageBox.Show(text, "Vhdgamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}