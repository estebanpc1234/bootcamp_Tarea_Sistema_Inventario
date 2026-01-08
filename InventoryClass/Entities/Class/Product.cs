using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Product:EntityBase
    {
        public double Price { get; set; }
        public Brand Brand { get; set; } 
        public Category Category { get; set; } 
        public SubCategory SubCat { get; set; } 
    }

}
