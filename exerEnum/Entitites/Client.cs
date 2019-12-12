using System;
using System.Collections.Generic;
using System.Text;

namespace exerEnum.Entitites
{
	class Client
	{
		private string Name { get; set; }
		private string Email { get; set; }
		private DateTime BirthDate { get; set; }

		Client() { }

		public Client(string name, string email, DateTime birthdate)
		{
			Name = name;
			Email = email;
			BirthDate = birthdate;
		}
		public override string ToString()
		{
			return Name
				+ ", ("
				+ BirthDate.ToString("dd/MM/yyyy")
				+ ") - "
				+ Email;
		}
	}
}
