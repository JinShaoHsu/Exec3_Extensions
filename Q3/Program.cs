using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	// 將 List<string> 轉型為 int[]
	// 並且只列出轉成功的
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}
	}

	public static class StringExtensions
	{
		public static int ToInt(this string source, int defaultValue)
		{
			bool isInt = int.TryParse(source, out int number);

			return isInt ? number : defaultValue;
		}
	
	}
}
