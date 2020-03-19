using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Person> persons = new List<Person>();
        public List<Company> companies = new List<Company>();
        public List<Coffee> coffees = new List<Coffee>();
        //test data makes testing easier!
        public void FillPersonsWithTestData()
        {
            this.persons.Add(new Person("Teppo", "Testipersoona", "050-888 4444", "teppo@testaus.fi"));
            this.persons.Add(new Person("Tapio", "Tapaustesti", "030-448 2244", "tapsa@testaus.fi"));
        }

        public void FillCompaniesWithTestData()
        {
            Person contactPerson1 = new Person("Teppo", "Testipersoona", "050-888 4444", "teppo@testaus.fi");
            Company testCompany = new Company("testiyritys-1", contactPerson1, "Finland");
            this.companies.Add(testCompany);      
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

        #region Person stuff
        public void AddNewPersonToList()
        {
            Person person = CreatePerson();
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

        #endregion

        #region Company stuff
        
        public Company CreateCompany()
        {
            Console.WriteLine("Anna yrityksen nimi:");
            string name = Console.ReadLine();
            Console.WriteLine("Anna yrityksen maa:");
            string country = Console.ReadLine();

            //later we add possibility to choose from list or add a new person.
            Console.WriteLine("Valitse yhteyshenkilö listasta");
            Person contactPerson = SelectPersonFromList();

            Company company = new Company(name, contactPerson, country);

            return company;
        }

        public void AddNewCompanyToList()
        {
            Company company = CreateCompany();
            this.companies.Add(company);
            Console.WriteLine("Yritys lisättiin listaan.");
        }

        public void PrintCompanyList()
        {
            int i = 1;
            foreach (Company company in this.companies)
            {

                Console.WriteLine($"{i}.\tNimi:{company.name}");
                Console.WriteLine($"\tYhteyshenkilö:{company.contactPerson.firstName} {company.contactPerson.lastName}");
                i++;
            }
        }

        public Company SelectCompanyFromList()
        {
            PrintCompanyList();
            Console.WriteLine("Syötä valittavan yrityksen numero:");
            //parse to int
            var selected = int.Parse(Console.ReadLine());
            //Get Person object from the list and return it. 
            //since the list starts with 1 but list index with 0, we need to -1 from selected.
            return this.companies[selected - 1];
        }

        #endregion
    }
}
