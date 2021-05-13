using System;
using System.Windows.Forms;
using WinFormInfSys.Window;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());

            //Tuple<Role, int> role = new Tuple<Role, int>(Role.Teacher, 2);

            //Application.Run(new TeacherProject(role));

        }
    }
}
