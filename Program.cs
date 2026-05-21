using System;
using System.Windows.Forms;

namespace Shift_Sync
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ✅ Sabse pehle tables banao
            DatabaseHelper.GetConnection().Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}