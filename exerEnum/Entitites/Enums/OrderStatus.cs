using System;
using System.Collections.Generic;
using System.Text;

namespace exerEnum.Entitites.Enums
{
	enum OrderStatus : int
	{
		Pending_Payment,
		Processing = 1,
		Shipped = 2,
		Delivered = 3
	}
}
