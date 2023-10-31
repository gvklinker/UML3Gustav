using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public abstract class MenuItem : IMenuItem
    {
        public int Number { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }
        public ItemType Type { get; set; }
        public bool IsOrganic { get; set; }
        public bool IsVegan {  get; set; }
        public MenuItem(int num, string name, string desc, double price, ItemType type, bool organic, bool vegan)
        {
            Number = num;
            Name = name;
            Description = desc;
            Price = price;
            Type = type;
            IsOrganic = organic;
            IsVegan = vegan;
        }

        public virtual string PrintInfo()
        {
            return $"Info about item";
        }

        public override string ToString()
        {
            return $"Number {Number} Name {Name} {Description} {Price}\n {Type} Organic: {IsOrganic} Vegan: {IsVegan} ";
        }

    }
}
