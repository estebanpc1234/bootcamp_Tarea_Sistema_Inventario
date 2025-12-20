using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public class Office
    {
        public int Id { get; set; }
        public string Direction { get; set; } 
        public string Name { get; set; } 
        public Location Location { get; set; } 
    }

}
