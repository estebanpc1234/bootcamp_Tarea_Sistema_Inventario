using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Category:EntityBase
    {
        public string Description { get; set; } 
        public List<SubCategory> SubCategories { get; set; } 
    }

}
