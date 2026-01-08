using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Province:EntityBase
    {
        public Country Country { get; set; } 
        public List<Canton> Cantons { get; set; } 
    }

}
