using Examination_PRL.Forms;
using Examination_PRL.Forms.Participant;
using Examination_PRL.Forms.Staff;
using Examination_PRL.Forms.Staff.Home;

namespace Examination_PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}