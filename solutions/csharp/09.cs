using System;

public class Nine
{
	static void Main()
	{
		int a = 0;
		int b = 0;
		int c = 0;

		for (int i = 2; i < 50; i++)
			for (int j = 1; j < i; j++)
			{
				a = (i * i) - (j * j);
				b = 2 * i * j;
				c = (i * i) + (j * j);

				if (a + b + c == 1000)
				{
					Console.WriteLine("\n{0}\n", a * b * c);
					break;
				}
			}
	}
}