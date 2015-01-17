using System;

public class Fourteen
{
	static void Main()
	{
		long a = 1000000;
		long b = 0;
		long c = 0;
		long d = 0;

		for (int i = 1; i <= a; i++)
		{
			b = Chain(i);

			if (b >= c)
			{
				c = b;
				d = i;
			}
		}

		Console.WriteLine("\n{0}\n", d);
	}

	static long Chain(long a)
	{
		long b = 1;

		while (a != 1)
		{
			if (a % 2 == 0)
				a /= 2;
			else
				a = (3 * a) + 1;

			b++;
		}

		return b;
	}
}