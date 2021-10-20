using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp87 {
	public class Order {
		public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
	}

	public class OrderLine {
		public string Name { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }
		public Category Category { get; set; }

	}

	public enum Category {
		CategoryA,
		CategoryB
	}
}

