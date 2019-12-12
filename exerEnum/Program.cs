using exerEnum.Entitites;
using exerEnum.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exerEnum
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter cliente data:");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Email: ");
			string email = Console.ReadLine();
			DateTime date = DateTime.Now;
			Console.WriteLine("Birth date  " + date);
			Console.Write("Enter order data: ");
			Console.Write("Status: ");
			OrderStatus order = Enum.Parse<OrderStatus>(Console.ReadLine());

			Client cliente = new Client(name, email, date);
			Order ordem = new Order(date, order, cliente);


			Console.Write("How many items to this order? ");
			int qitems = int.Parse(Console.ReadLine());
			List<OrderItem> items = new List<OrderItem>();

			for (int i = 1; i <= qitems; i++)
			{
				Console.Write($"Enter #{i} item data: ");
				Console.Write("Product name: ");
				String prodname = Console.ReadLine();
				Console.Write("Product price: ");
				double prodprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.WriteLine("Quantity: ");
				int quantity = int.Parse(Console.ReadLine());
				Product produto = new Product(prodname, prodprice);
				OrderItem item = new OrderItem(quantity, prodprice, produto);
				ordem.AddItem(item);
			}

			Console.WriteLine("ORDER SUMMARY: ");
			Console.Write(order);
			

		}


	}
}

