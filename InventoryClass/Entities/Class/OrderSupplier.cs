using InventoryClass.Entities.AbstracClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.Class
{
    public  class OrderSupplier:EntityBase
    {
        public DateTime DateTime { get; set; }

        public DateTime ArrivalDate { get; set; }

        public DateTime DepartureDate { get; set; }

        public Supplier Supplier { get; set; }

        public WareHouse WareHouse { get; set; }
        public bool isFinish {  get; set; }
    }
}
