using InventoryClass.Entities.AbstracClass;

namespace InventoryClass.Entities.Class
{
    public class SubCategory:EntityBase
    {
        public string Description { get; set; } 
        public Category Category { get; set; } 
    }

}
