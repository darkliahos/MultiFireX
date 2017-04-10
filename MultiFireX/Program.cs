using System;
using System.Configuration;
using System.Windows.Forms;

namespace MultiFireX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string mode = ConfigurationSettings.AppSettings["BrowserMode"];
            switch (mode)
            {
                case "Gecko":
                    Application.Run(new frmGeckoBrowser());
                    break;
                case "Webkit":
                    Application.Run(new frmWebkit());
                    break;
                case "All":
                    Application.Run(new frmGeckoBrowser());
                    Application.Run(new frmWebkit());
                    break;
                default:
                    throw new Exception("No Browser found");
                    break;
            }
        }
    }
}
