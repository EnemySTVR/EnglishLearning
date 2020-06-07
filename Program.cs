using EnglishLearning.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishLearning
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome_menu());
            Library lib = new Library();
            lib.Load();

            var appInterface = new Interface();

            appInterface.StartMenu();
            while (true)
            {
                var menuValue = appInterface.MainMenu(lib);
                switch (menuValue)
                {
                    case 1:
                        {
                            appInterface.NewWordMenu(lib);
                            lib.Save();
                            break;
                        }
                    case 2: { appInterface.ConsolidationMenu(lib); break; }
                    case 3:
                        {
                            appInterface.LibraryMenu(lib);
                            lib.Save();
                            break;
                        }
                    case 4: { Environment.Exit(0); break; }
                    default: break;
                }
            }
        }
    }
}
