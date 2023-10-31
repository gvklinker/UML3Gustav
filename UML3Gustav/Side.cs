using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public class Side : MenuItem
    {
        public Side(int num, string name, string desc, double price, ItemType type, bool vegan, bool organic) :
            base(num, name, desc, price, type, organic, vegan)
        { }
    }
}
