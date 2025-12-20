namespace InventoryClass.Entities.Class
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 
        public Category Category { get; set; } 
    }

}
