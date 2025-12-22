using InventoryClass.Entities.AbstracClass;
using System;


namespace InventoryClass.Entities.Class
{
    public class Location:EntityBase
    {
        public List<Office> offices { get; set; } 
        public List<WareHouse> WareHouses { get; set; }
    }

}
