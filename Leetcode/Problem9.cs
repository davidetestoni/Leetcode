namespace Leetcode;

public static class Problem9
{
	public static bool IsPalindrome(int x)
	{
		if (x < 0)
		{
			return false;
		}

		if (x == 0)
		{
			return true;
		}

		var digits = CountDigits(x);

		var minPos = 0;
		var maxPos = digits - 1;

		while (minPos < maxPos)
		{
			var minDigit = GetNumberAt(x, minPos);
			var maxDigit = GetNumberAt(x, maxPos);

			if (minDigit != maxDigit)
			{
				return false;
			}

			minPos++;
			maxPos--;
		}

		return true;
	}

	private static int CountDigits(int number) => (int)Math.Log(number, 10) + 1;

	private static int GetNumberAt(int number, int pos) => (number / (int)Math.Pow(10, pos)) % 10;
}
