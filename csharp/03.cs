using System;

public class Three
{
	static void Main()
	{
		long a = 600851475143;
		int  b = Convert.ToInt32(Math.Sqrt(a));

		for (int i = b; i >= 0; i--)
			if (Factor(a,i))
				if (Prime(i))
				{
					Console.WriteLine("\n{0}\n",i);
					break;
				}
	}

	static bool Factor(long x, int z)
	{
		if (x % z == 0)
			return true;

		return false;
	}

	static bool Prime(int z)
	{
		if (z % 2 == 0)
			return false;

		for (int i = 3; i < (z/2); i += 2)
			if (z % i == 0)
				return false;

		return true;
	}
}
