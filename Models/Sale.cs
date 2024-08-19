using System;
namespace InventoryManagementSystem.Models
{
	public class Sale
	{
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuantitySold { get; set; }
        public DateTime DateSold { get; set; }

        public Product? Product { get; set; }
    }
}

