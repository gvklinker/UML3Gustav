using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Gustav
{
    public class MenuItemNumberExist : Exception
    {
        public MenuItemNumberExist(string mes) : base(mes) { }
    }
}
