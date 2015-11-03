using System;
using System.Linq;
using System.Collections.Generic;

public class TwentyThree
{
	static void Main()
	{
		int		 n = 28123;
		List<int> a = AbundantSums(n);
		int		 b = 0;

		for (int i = 0; i <= n; i++)
			if (!a.Contains(i))
				b += i;

		Console.WriteLine("\n{0}\n", b);
	}

	// List all possible sums of abundant numbers up to n using Abundant().
	static List<int> AbundantSums(int n)
	{
		List<int> a = ListA(n);
		List<int> b = new List<int>();

		for (int i = 0; i < a.Count; i++)
			for (int j = 0; j < a.Count; j++)
				b.Add(a[i] + a[j]);

		b = b.Distinct().ToList();

		return b;
	}

	// Generates list of abundant numbers up to n (inclusive).
	static List<int> ListA(int n)
	{
		List<int> b = new List<int>();

		for (int i = 1; i <= n; i++)
			if (!Prime(i))
				if (Abundant(i))
					b.Add(i);

		return b;
	}

	// Test for abundancy up to n.
	static bool Abundant(int n)
	{
		int  b = 0;

		for (int i = 1; i <= (n/2); i++)
			if (n % i == 0)
				b += i;

		if (b > n)
			return true;

		return false;
	}

	// Test for primality up to n.
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
