public class Four
{
	static void Main()
	{
		int a = 0;
		int b = -1;
		int c = 999;

		for (int i = 100; i <= c; i++)
			for (int j = 100; j <= c; j++)
			{
				a = i * j;

				if ((a == Reverse(a)) && (a > b))
					b = a;
			}

		Console.WriteLine("\n{0}\n", b);
	}

	static int Reverse(int m)
	{
		int n = 0;

		while (m != 0)
		{
			n *= 10;
			n += m % 10;
			m /= 10;
		}

		return m;
	}
}
