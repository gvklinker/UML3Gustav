using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public class Beverage : MenuItem
    {
        public bool IsAlcoholic { get; set; }
        public int Size { get; set; }
        public Beverage(int number, string name, string desc, double price, ItemType type, bool organic, bool vegan, bool alcoholic, int size) :
            base(number, name, desc, price, type, organic, vegan)
        {
            IsAlcoholic = alcoholic;
            Size = size;
        }

        public override string PrintInfo()
        {
            return base.ToString()+ $" {(IsAlcoholic ? "Alcoholic": "Non-Alcoholic")} \n {Size} cl";
        }
    }
}
