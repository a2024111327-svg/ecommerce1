namespace ecommerce1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CompanyId { get; set; } // Relación con User rol Empresa
        public User? Company { get; set; }
    }
}