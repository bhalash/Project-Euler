using System;
using System.Numerics;

public class Twenty
{
	static void Main()
	{
		BigInteger 	a = 100;
		string 		b;
		int 			c = 0;

		for (int i = 99; i >= 1; i--)
			a *= i;
		
		b = Convert.ToString(a);

		for (int i = 0; i < b.Length; i++)
			c += b[i] - '0';

		Console.WriteLine("\n{0}\n", c); 
	}
}