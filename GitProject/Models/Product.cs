using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProject.Models
{
	public class Product : IProduct			// added interface in master branch
	{
		public int id { get; set; }
		public string Name { get; set; }
	}
}
