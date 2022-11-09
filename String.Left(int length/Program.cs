using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Left_int_length
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "0123456789351435614356104";
			
			
		}
	}
	public static class StringExtensions
	{
		public static string Left(this string source, int length)
		{
			if (string.IsNullOrEmpty(source))  return string.Empty;
			if (length <= 0) return string.Empty;
			if (source.Length <= length) return source;

			return source.Substring(0, length);
		}
	}
}
