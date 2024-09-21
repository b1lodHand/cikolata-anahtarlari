using System.Diagnostics;

namespace tester_forms
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
            Application.Run(new Form1());

            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.FileName = Application.StartupPath + "\\build\\um.exe"; // Note the absolute path

                // Some example settings that are availible.
                // If the process doesn't terminate by itself I would recommend
                // setting CreateNoWindow to false since you won't be able to 
                // terminate the process on the desktop (Though you can programmatically)
                myProcess.StartInfo.CreateNoWindow = false;
                myProcess.StartInfo.UseShellExecute = true;

                // This will actually run the process.
                myProcess.Start();

            }
            catch (Exception e)
            {
                Application.Exit();
            }
        }
    }
}