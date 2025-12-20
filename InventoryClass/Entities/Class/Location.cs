using System;


namespace InventoryClass.Entities.Class
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<Office> offices { get; set; } 
        public List<Warehouse> Warehouses { get; set; }
    }

}
