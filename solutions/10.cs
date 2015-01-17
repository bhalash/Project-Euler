using System;

public class Ten
{
	static void Main()
	{
		long a = 2000000;
		long b = 0;

		for (int i = 2; i <= a; i++)
			if (Prime(i))
				b += i;

		Console.WriteLine("\n{0}\n", b);
	}

	static bool Prime(int n)
	{
		if (n % 2 == 0)
			return false

		for (int i = 3; i <= Math.Sqrt(n); i += 2)
			if (n % i == 0)
				return false;

		return true;
	}
}