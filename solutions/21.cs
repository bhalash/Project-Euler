using System;

public class TwentyOne
{
	static void Main()
	{
		int a = 1;
		int b = 0;

		for (int i = 1; i <= 10000; i++)
			if (!Prime(i))
			{
				a = Sum(i);

				if ((Sum(a) == i) && (a != i))
					b += i;
			}

		Console.WriteLine("\n{0}\n", b);
	}

	static int Sum(int a)
	{
		int b = 0;

		for (int i = 1; i <= (a/2); i++)
			if (a % i == 0)
				b += i;

		return b;
	}

	static bool Prime(int a)
	{
		bool b = true;

		for (int i = 2; i <= Math.Sqrt(a); i++)
			if (a % i == 0)
			{
				b = false;
				break;
			}

		return b;
	}
}