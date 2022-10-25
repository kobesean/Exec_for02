using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] items = { 0, 3, 3, 0, 0, 3, 3, 3, };

			int maxsum = 0;

			int sum = 0;

			for (int i = 0; i < items.Length; i++)
			{
				int item = items[i];
				if (item == 0)
				{
					sum = 0;
					continue;
				}

				sum += item;
				if (sum > maxsum)
				{
					maxsum = sum;
				}
			}
			Console.WriteLine(maxsum);
		}
	}
}
