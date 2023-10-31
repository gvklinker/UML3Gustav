using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> _items;

        public MenuCatalog() { _items = new List<IMenuItem>(); }
        public int Count { get { return _items.Count; } }

        public void Add(IMenuItem item) {
            if (Search(item.Number) != null)
                throw new MenuItemNumberExist();
            _items.Add(item); 
        }
        public void Delete(int num) {  _items.Remove(Search(num)); }
        public IMenuItem Search(int num) {  return _items.Find(x=>x.Number == num); }
        public void Update(int num, IMenuItem item)
        {
            _items.Insert(_items.IndexOf(Search(num)), item); 
        }
        
        public void PrintPizzasMenu()
        {
            foreach (var item in _items)
            {
                if(item.Type == ItemType.Pizza)
                    Console.WriteLine(item.PrintInfo);
            }
        }
        public void PrintBeveragesMenu()
        {
            foreach (var item in _items)
            {
                if (item.Type == ItemType.Beverage)
                    Console.WriteLine(item.PrintInfo);
            }
        }

        public void PrintToppingsMenu()
        {
            foreach (var item in _items)
            {
                if (item.Type == ItemType.Topping)
                    Console.WriteLine(item.PrintInfo);
            }
        }

        public void PrintItemTypeMenu(ItemType type)
        {
            foreach (var item in _items)
            {
                if (item.Type == type)
                    Console.WriteLine(item.PrintInfo);
            }
        }

        public List<IMenuItem> FindAllVegan(ItemType type)
        {
            List<IMenuItem > items = new List<IMenuItem>();
            foreach (var item in _items)
            {
                if(item.IsVegan && item.Type == type)
                    items.Add(item);
            }
            return items;
        }
        public List<IMenuItem> FindAllOrganic(ItemType type)
        {
            List<IMenuItem> items = new List<IMenuItem>();
            foreach (var item in _items)
            {
                if (item.IsOrganic && item.Type == type)
                    items.Add(item);
            }
            return items;
        }

        public IMenuItem FindMostExpensiveMenuItem()
        {
            IMenuItem mostExpensive = null;
            int comparer = 0;
            foreach(var item in _items)
            {
                if (item.Price > comparer)
                    mostExpensive = item;
            }
            return mostExpensive;
        }
    }
}
