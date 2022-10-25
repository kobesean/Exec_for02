using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入階乘數字");
			string input = Console.ReadLine();
			int n = int.Parse(input);
			int result = 1;
			while (n > 1)
			{
				result *= n;

				n--;
			}
			Console.WriteLine("數值階乘=" + result);
		}
	}
}
