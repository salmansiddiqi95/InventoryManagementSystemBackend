using System;
namespace InventoryManagementSystem.Models
{
	public class Purchase
	{
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuantityPurchased { get; set; }
        public DateTime DatePurchased { get; set; }

        public Product? Product { get; set; }
    }
}

