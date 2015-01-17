using System;

public class Two
{
	static void Main()
	{
		int a = 1;
		int b = 1;
		int c = 0;

		int sum	= 0;
		int cap	= 4000000;

		do
		{
			c = a + b;

			if (c % 2 == 0)
			 	sum += c;

			a = b;
			b = c;

		} while (c <= cap);

		Console.WriteLine("\n{0}\n",sum);
	}

}