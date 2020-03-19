using System;
using System.Collections.Generic;

namespace ListAndLoopsExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DataHandler dh = new DataHandler();
            dh.FillPersonsWithTestData();
            dh.FillCompaniesWithTestData();
            dh.AddNewCompanyToList();
            dh.PrintCompanyList();
            Console.ReadKey();
            Console.Clear();
            Company company = dh.SelectCompanyFromList();
            Console.WriteLine($"Valittu {company.name} ");

            //fill dataHandler persons with test data


            //dh.FillPersonsWithTestData();

            //dh.AddPersonToList();
            //dh.PrintPersonList();
            //Console.ReadKey();

            //Console.Clear();
            //Console.WriteLine("Valitse henkilö");
            //var person = dh.SelectPersonFromList();
            //Console.WriteLine("\n\n");
            //Console.WriteLine($"Valittu : {person.firstName} {person.lastName} {person.email}");

        }
    }
}
