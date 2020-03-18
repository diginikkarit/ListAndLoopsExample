using System;
using System.Collections.Generic;

namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();
            var kahvi = dh.CreateCoffee();
            dh.coffees.Add(kahvi);

            var paketti = new Coffee("pressa", 4.50 , Coffee.Roast.light, "joku");
            Console.WriteLine($"enum:{(int)paketti.roast}");



           // var paketti1 = new Coffee("Presidentti");
           // var paketti2 = new Coffee("Kulta Katriina");
           // var paketti3 = new Coffee("Brazil");
           // var paketti4 = new Coffee("Löfberg");

           // List<Coffee> coffees = new List<Coffee>();
           // coffees.Add(paketti1);
           // coffees.Add(paketti2);
           // coffees.Add(paketti3);
           // coffees.Add(paketti4);

           //// Console.WriteLine(coffees[2].brand);

           // foreach (var paketti in coffees)
           // {
           //     Console.WriteLine($"Merkki {paketti.brand}");
           // }

           // for (int i = 0; i < coffees.Count; i++)
           // {
           //     Console.WriteLine($"{i}. Merkki : {coffees[i].brand}");
           // }

            //Company -luokka. nimi, yhteyshenkilö(luokkaa person), maa
            //person -luokka etunimi, sukunimi, puhelinnumero, email
            //DataHandler -luokka. list<cofee>, list<person>
            //metodi joka kysyy kahvin merkin, hinnan,roast -> luo näistä instanssin Coffee -> lisää ko. instanssin listaan.
        }
    }


    //kahvit
    //-merkki, hinta, paahto,maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla


}
