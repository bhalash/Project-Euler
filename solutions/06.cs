using System;

public class Six
{
	static void Main()
	{
		double a = 100;
		double b = 0;
		double c = 0;
		
		for (int i = 1; i <= a; i++)
		{
			b += (i * i);
			c += i;
		}

		c = c * c;

		if (b > c)
			Console.WriteLine("\n{0}\n", b - c);
		else if (c > b)
			Console.WriteLine("\n{0}\n", c - b);
	}
}