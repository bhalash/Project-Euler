using System;

public class One
{
	static void Main()
	{
		int a = 0;
		int b = 1000;

		for (int i = 1; i < b; i++)
		{
			if ((i % 5 == 0) || (i % 3 ==0))
				a += i;
		}

		Console.WriteLine("\n{0}\n", a);
	}
}
