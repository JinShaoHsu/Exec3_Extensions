using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32.IsOdd__IsEven
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入數字,判斷是否為偶數:");
			string intput = Console.ReadLine();
			bool Isint = int.TryParse(intput, out int GetNumber);
			
			bool result = MyMath.IsEven(GetNumber); 
			Console.WriteLine(result);

			Console.WriteLine("請輸入數字,判斷是否為奇數:");
			string intput2 = Console.ReadLine();
			bool Isint2 = int.TryParse(intput, out int GetNumber2);

			bool result2 = MyMath.IsOld(GetNumber2);
			Console.WriteLine(result2);
		}
	}
	public static class MyMath
	{
		public static bool IsOld(this int source)//奇數
		{
			return source % 2 == 1;
		}

		public static bool IsEven(this int source)//偶數
		{
			return source % 2 == 0;
		}
	}
}
