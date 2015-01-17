using System;
using System.Numerics;

class Program
{
	static void Main()
	{
		BigInteger	  a;
		string		  b;
		int           c = 0;

		a = BigInteger.Pow(2, 1000);
		b = Convert.ToString(a);

		for (int i = 0; i < b.Length; i++)
			c += b[i] - '0';

		Console.WriteLine("\n{0}\n", c);
	}
}