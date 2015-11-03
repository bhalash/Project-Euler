using System;

public class Twelve
{
	static void Main()
	{
		long a = 1;
		long b = 1;
		long c = 0;

		while (c <= 500)
		{
			c = factors(a);

			if (c > 500)
			{
				Console.Write("\n{0}\n", a);
				break;
			}
			else
			{
				a += b + 1;
				b++;
			}
		}
	}

	static long factors(long a)
	{
		long b = 1;

		for (int i = 1; i <= Math.Sqrt(a); i++)
			if (a % i == 0)
				b++;

		return 2 * b;
	}
}
