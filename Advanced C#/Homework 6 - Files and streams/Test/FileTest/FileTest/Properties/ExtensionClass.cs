using System;
using System.Text;

namespace FileTest
{
	public static class ExtensionClass
	{
		public static int DigitMultiplier(this int nums) {
			return nums*5;
		}

		public static string Substring(this StringBuilder target, int startIndex, int count) {
			return target.ToString ().Substring (startIndex, count);
		}
	}
}

