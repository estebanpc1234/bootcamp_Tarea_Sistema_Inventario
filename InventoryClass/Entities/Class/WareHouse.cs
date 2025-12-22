using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class WareHouse:EntityBase
    {
        public Location Location { get; set; } 
        public WarehouseType WarehouseType { get; set; } 

        public Dictionary<Product, int> Products { get; set; } 

        public List<OrderSupplier> OrderSuppliers { get; set; }
        public Product GetProductStock(Product product) { }

        public void CancelOrderSupplir(OrderSupplier order) { }
    }

}
