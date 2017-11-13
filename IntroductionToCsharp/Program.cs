using System;
using System.Collections.Generic;
using PATA = ProjectA.TeamA.ClassA;
using PBTB = ProjectB.TeamB.ClassA;

namespace IntroductionToCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer c = new Customer()
			{
				ID = 101,
				Name = "srividhya",
				Sal = 6000
			};

			Customer c1 = new Customer()
			{
				ID = 102,
				
				Sal = 6000
			};

			Dictionary<int, Customer> dictionaryvalues = new Dictionary<int, Customer>();
			dictionaryvalues.Add(c.ID, c);
			dictionaryvalues.Add(c1.ID, c1);
			Customer customer101 = dictionaryvalues[101];
			Console.WriteLine("ID={0},Name={1},Sal={2}", customer101.ID, customer101.Name, customer101.Sal);

			Customer customer102 = dictionaryvalues[102];
			Console.WriteLine("ID={0},Name={1},Sal={2}", customer102.ID, customer102.Name, customer102.Sal);

			Console.Read();
		}


	}
	public class Customer
	{
		public int ID
		{
			get;
			set;
		}
		public String Name
		{
			get;
			set;
		}
		public Double Sal
		{
			get;
			set;
		}
	}
}

