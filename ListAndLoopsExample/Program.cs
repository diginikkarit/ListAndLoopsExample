using System;
using System.Collections.Generic;

namespace ListAndLoopsExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Init datahandler with test data
            DataHandler dh = new DataHandler();
            dh.FillPersonsWithTestData();
            dh.FillCompaniesWithTestData();
            dh.FillCoffeesWithTestData();

            MainMenu mainMenu = new MainMenu(dh);
            mainMenu.InitializeMainMenu();


                                 
        }
    }
}
