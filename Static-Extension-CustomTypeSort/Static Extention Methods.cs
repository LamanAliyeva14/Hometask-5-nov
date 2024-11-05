using System;
namespace Static_Extension_CustomTypeSort
{
	public static class Static_Extention_Methods
	{
		public static bool Isodd(this int a)
		{
			return a % 2 == 1;
		}

		public static bool isEven(this int a)
		{
			return a % 2 == 0;
		}

		public static bool isContainsDigit(this string a)
		{
			foreach (char c in a)
			{
				if (char.IsDigit(c))
				{
					return true;
				}
			}
            return false;
        }

		public static string ToCapitalize(this string a)
		{
			return char.ToUpper(a[0]) + a.Substring(1).ToLower();
		}

		public static int[] GetVaueIndexes(this string word, char b)
		{
			int[] ints = new int[0];
			for (int i=0; i<word.Length; i++)
			{
				 if (word[i] == b)
				 {
					Array.Resize(ref ints, ints.Length + 1);
					ints[ints.Length - 1] = i;
				 }
			}
			return ints;
		}

		public static string GetFirstSentence(this string word)
		{
			int index = 0;
			for (int i=0; i<word.Length; i++)
			{
				if (word[i]=='.')
				{
					index = i;
					break;
				}
			}
			return word.Substring(0, index);
		}

		
	}
}

