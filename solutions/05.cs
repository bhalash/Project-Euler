using System;

public class Five
{
	static void Main()
	{
		int a = 20;
		int b = 0;

		while (b <= 0)
		{
			for (int i = 11; i < 20; i++)
			{
				if (a % i != 0)
				{
					a += 20;
					break;
				}
				else if (i == 19)
				{
					b = a;
					break;
				}
			}
		}

		Console.WriteLine("\n{0}\n", b);
	}
}