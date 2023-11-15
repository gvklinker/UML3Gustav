using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public class Pizza : MenuItem
    {
        public bool IsDeep {  get; set; }

        public Pizza(int num, string name, string desc, double price, ItemType type, bool vegan, bool organic, bool deep) : 
            base(num, name, desc, price, type, organic, vegan)
        {
            IsDeep = deep;
        }

        public override string PrintInfo()
        {
            return base.ToString()+ $"{(IsDeep? "Deep pan":"Alm")}";
        }
    }

   
}
