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
		public int Age { get; set; }	// added in coredevelop branch
		public int ExtraFeaure { get; set; }    // added extrafeature in extrafeature branch
		public int AnotherFeature { get; set; }	// added in conflict resolve result window
	}
}
