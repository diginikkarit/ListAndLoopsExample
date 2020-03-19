using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{

    //kahvit
    //-merkki, hinta, paahto,maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla

    class Coffee
    {
        public enum Roast {light=1,lightmedium,medium,darkmedium,dark}

        public string brand;        
        public decimal price;        
        public Roast roast;
        public string importer;
        public Coffee()
        {

        }

        public Coffee(string brand)
        {
            this.brand = brand;
        }

        public Coffee(string brand, decimal price, Roast roast, string importer = "default")
        {
            this.brand = brand;
            this.price = price;
            this.roast = roast;
            this.importer = importer;
        }
    }
}
