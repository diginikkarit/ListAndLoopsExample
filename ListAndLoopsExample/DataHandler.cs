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

        public void FillCoffeesWithTestData()
        {
            Person contactPerson1 = new Person("Teppo", "Testipersoona", "050-888 4444", "teppo@testaus.fi");
            Company testCompany = new Company("testiyritys-1", contactPerson1, "Finland");
            Coffee coffee = new Coffee("Presidentti", 3.20, Coffee.Roast.medium, testCompany);
            this.coffees.Add(coffee);
            coffee = new Coffee("Brazil", 4.80, Coffee.Roast.darkmedium, testCompany);
            this.coffees.Add(coffee);
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
            return this.companies[selected - 1];
        }

        #endregion

        #region Coffee Stuff
        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki:");
            string brand = Console.ReadLine();
            Console.WriteLine("Anna kahvin hinta.");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Anna paahteisuus aste(1-5):");
            int number = int.Parse(Console.ReadLine());
            //cast number to Roast Enum.
            Coffee.Roast roast = (Coffee.Roast)number;

            Console.WriteLine("Valitse maahantuonnin tekevä yritys.");
            Company importer = SelectCompanyFromList();

            Coffee newCoffeeObject = new Coffee(brand, price, roast, importer);
            return newCoffeeObject;
        }

        public void AddNewCoffeeToList()
        {
            Coffee toAdd = CreateCoffee();
            this.coffees.Add(toAdd);
            Console.WriteLine("Kahvi lisättiin listaan.");
        }

        public void PrintCoffeeList()
        {
            int i = 1;
            foreach (Coffee coffee in this.coffees)
            {

                Console.WriteLine($"{i}.\tMerkki:{coffee.brand}");
                Console.WriteLine($"\tPaahteisuus:{coffee.roast}");
                Console.WriteLine($"\tMaahantuoja:{coffee.importer.name}");
                i++;
            }
        }

        public Coffee SelectCoffeeFromList()
        {
            PrintCoffeeList();
            Console.WriteLine("Syötä valittavan yrityksen numero:");
            //parse to int
            var selected = int.Parse(Console.ReadLine());
            return this.coffees[selected - 1];
        }

        #endregion

    }
}
