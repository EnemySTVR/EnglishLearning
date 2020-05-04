using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearning
{
    class Program
    {
        static void Main(string[] args)
        {
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
                            lib = appInterface.NewWordMenu(lib);
                            lib.Save();
                            break;
                        }
                    case 2: { appInterface.ConsolidationMenu(lib); break; }
                    case 3:
                        {
                            lib = appInterface.LibraryMenu(lib);
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
