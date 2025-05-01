using System;
using humanFeature;

namespace inforProduct {
	public class Inventory
	{
		public int productId { get; set; }
		public int inventoryId { get; set; }
		public int Quantity { get; set; }
		public decimal ReorderLevel { get; set; }
		public Location Location { get; set; }
		public DateTime lastUpdate { get; set; }
		public Inventory(int ProductId, int initialQuantity, int ReorderQuantity) 
		{
			productId = ProductId;
			Quantity = initialQuantity;
			ReorderLevel = ReorderQuantity;
			lastUpdate = DateTime.Now;
		}
		//Khi hàng dưới 50 thì cần nhập hàng lại
		public bool NeedRestock() => Quantity <= ReorderLevel - 50;

	}
}