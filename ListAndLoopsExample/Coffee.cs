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
        public string brand;        
        public decimal price;        
        public int roast;
        public string importer;
        public Coffee()
        {

        }

        public Coffee(string brand)
        {
            this.brand = brand;
        }

        public Coffee(string brand, decimal price, int roast, string importer)
        {
            this.brand = brand;
            this.price = price;
            this.roast = roast;
            this.importer = importer;
        }
    }
}
