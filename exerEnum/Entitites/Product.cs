using System;
using System.Collections.Generic;
using System.Text;

namespace exerEnum.Entitites
{
	class Product
	{
		private string Name { get;set; }
		private double Price { get; set; }

		Product() { }

		public Product(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}
