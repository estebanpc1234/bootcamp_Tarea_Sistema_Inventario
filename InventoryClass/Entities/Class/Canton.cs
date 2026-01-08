using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Canton : EntityBase
    {
        public List<Location> Locations { get; set; }
    }

}
