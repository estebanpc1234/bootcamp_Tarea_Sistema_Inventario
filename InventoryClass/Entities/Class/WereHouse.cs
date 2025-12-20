using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public Location Location { get; set; } 
        public WarehouseType WarehouseType { get; set; } 
        public List<Product> Products { get; set; } 
    }

}
