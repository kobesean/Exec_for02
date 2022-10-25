using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 20; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine("foo");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("bar");
				}
				else if (i % 15 == 0)
				{
					Console.WriteLine("forbar");
				}
				else
				{
					Console.WriteLine(i);
				}

			}
		}
	}
}
