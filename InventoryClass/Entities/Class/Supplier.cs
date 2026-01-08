using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Supplier:EntityBase
    {
        public List<Product> Products { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }

        public List<OrderSupplier> OrderSuppliers { get; set; }
    }

}
