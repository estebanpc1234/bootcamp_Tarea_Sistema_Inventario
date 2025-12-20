using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<Product> Products { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
    }

}
