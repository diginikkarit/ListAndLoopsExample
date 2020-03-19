using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>() {};

        //test data makes testing easier!
        public void FillPersonsWithTestData()
        {
            this.persons.Add(new Person("Teppo", "Testipersoona", "050-888 4444", "teppo@testaus.fi"));
            this.persons.Add(new Person("Tapio", "Tapaustesti", "030-448 2244", "tapsa@testaus.fi"));
        }

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki.");
            var merkki = Console.ReadLine();
            //syötetään hinta, paahto 1-5,
            //ei companyä
            Coffee toReturn = new Coffee(merkki);
            var paahto  = Console.ReadLine();
            int luku = Int16.Parse(paahto);
            toReturn.roast = (Coffee.Roast)luku;
            return toReturn;
        }

        public Person CreatePerson()
        {
            //kysyy henkilötiedot käyttäjältä ja palauttaa Person-luokkaa olevan objectin.
            Console.WriteLine("Anna etunimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Anna sukunimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Anna puhelinnumero:");
            string phone = Console.ReadLine();
            Console.WriteLine("Anna email: ");
            string email = Console.ReadLine();

            Person person = new Person(firstName, lastName, phone, email);

            return person;
        }

        public void AddPersonToList()
        {
            var person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö Lisätty listaan");
        }

        public void PrintPersonList()
        {
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i+1}. {this.persons[i].firstName} {this.persons[i].lastName}");
            }
        }

        public Person SelectPersonFromList()
        {
            PrintPersonList();
            Console.WriteLine("Syötä valittavan henkilön numero:");
            //parse to int
            var selected = int.Parse(Console.ReadLine());
            //Get Person object from the list and return it. 
            //since the list starts with 1 but list index with 0, we need to -1 from selected.
            return this.persons[selected-1];
        }
    }
}
