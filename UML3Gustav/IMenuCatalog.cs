using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public interface IMenuCatalog
    {
        int Count { get; }
        void Add(IMenuItem aMenuItem);
        IMenuItem Search(int number);
        void Delete(int number);
        void PrintPizzasMenu();
        void PrintBeveragesMenu();
        void PrintToppingsMenu();
        void Update(int number, IMenuItem theMenuItem);
        List<IMenuItem> FindAllVegan(ItemType type);
        List<IMenuItem> FindAllOrganic(ItemType type);
        IMenuItem MostExpensiveMenuItem();
    }

}
