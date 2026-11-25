using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogger
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string next = "Game";
            Form1 game;
            Form3 mainMenu;
            while (next != "Leave")
            {
                switch (next)
                {
                    case "Game":
                        game = new Form1();
                        Application.Run(game);
                        next = game.getNext();
                        break;
                    case "MainMenu":
                        mainMenu = new Form3();
                        Application.Run(mainMenu);
                        next = mainMenu.getNext();
                        break;


                }
            }

        }
    }
}
