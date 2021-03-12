using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var culture = CultureInfo.GetCultureInfo(Properties.Settings.Default.lang);

            // this may fail sometimes: (see Drachenkatze's comment below)
            // var culture = new CultureInfo("en-US");

            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;

            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
