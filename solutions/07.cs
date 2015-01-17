using System;

public class Seven
{
	static void Main()
	{
		int a = 2;
		int b = 0;
		int c = 10001;
		
		while (b <= c)
		{	
			if (Prime(a))				
				b++;
			if (b < c)
				a++;
		}
		Console.WriteLine("{0}", a);
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