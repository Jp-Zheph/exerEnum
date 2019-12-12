using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exerEnum.Entitites
{
	class OrderItem
	{
		private int Quantity { get; set; }
		private	double Price { get; set; }
		private	Product Product { get; set; }

		OrderItem() { }

		public OrderItem(int quantity, double price, Product product)
		{
			Quantity = quantity;
			Price = price;
			Product = product;
		}

		public double SubTotal()
		{
			return Quantity * Price;
		}

		public override string ToString()
		{
			return Product
				+ ", $"
				+ Price.ToString("F2", CultureInfo.InvariantCulture)
				+ ", Quantity: "
				+ Quantity
				+ ", Subtotal: $"
				+ SubTotal().ToString("F2", CultureInfo.InvariantCulture);
		}


	}
}
