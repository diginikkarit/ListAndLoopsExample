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

            //Testing Person stuff
            //dh.AddPersonToList();
            //dh.PrintPersonList();
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("Valitse henkilö");
            //var person = dh.SelectPersonFromList();
            //Console.WriteLine("\n\n");
            //Console.WriteLine($"Valittu : {person.firstName} {person.lastName} {person.email}");

            //Testing Company stuff
            //dh.AddNewCompanyToList();
            //dh.PrintCompanyList();
            //Console.ReadKey();
            //Console.Clear();
            //Company company = dh.SelectCompanyFromList();
            //Console.WriteLine($"Valittu {company.name} ");

   
            //testing coffee things.
            //dh.AddNewCoffeeToList();
            //dh.PrintCoffeeList();
                                 
        }
    }
}
