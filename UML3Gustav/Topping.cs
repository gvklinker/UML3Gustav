using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public class Topping : MenuItem
    {
        public Topping(int num, string name, string desc, double price, ItemType type, bool vegan, bool organic) :
            base(num, name, desc, price, type, organic, vegan)
        { }
        public override string PrintInfo()
        {
            return base.ToString();
        }
    }
}
