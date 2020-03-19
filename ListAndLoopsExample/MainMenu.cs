using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class MainMenu
    {
        public DataHandler dataHandler;
        public MainMenu()
        {

        }

        public MainMenu(DataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }
    
    
        public void InitializeMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        private bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Lisää henkilö. ");
            Console.WriteLine("2. Näytä henkilölista. ");
            Console.WriteLine("0. Exit ");
            var selected = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selected)
            {
                case 1:
                    dataHandler.AddNewPersonToList();
                    Console.ReadKey();
                    break;
                case 2:
                    dataHandler.PrintPersonList();
                    Console.ReadKey();
                    break;
                case 0:
                    return false;
                default:
                    Console.Clear();
                    return true;
            }
            return true;

        }
    }
}
