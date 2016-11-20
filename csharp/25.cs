using System;
using System.Numerics;

public class TwentyFive
{
	static void Main()
	{
		BigInteger 	a = 1;
		BigInteger 	b = 2;
		BigInteger 	c = 0;
		string 		d = "";
		// Starting from 3 because my algorithm excludes the leading "0,1,1"
		int 		e = 3;

		do
		{
			c = a + b;
			a = b;
			b = c;
			e++;

			d = Convert.ToString(c);

			if (d.Length == 1000)
				break;

		} while (e < 31337);

		Console.WriteLine("\n{0}\n", e);
	}
}
