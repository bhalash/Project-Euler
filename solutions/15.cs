using System;
using System.Linq;

public class Fifteen
{
	static void Main()
	{
		int z 	 = 20;
		int a 	 = 15; // (2 * z) +1;
		long[][] b = new long[a][];

		for (int i = 0; i < a; i++)
			b[i] = new long[i + 1];

		b[0][0] = 1;

		for (int i = 1; i < a; i++)
			for (int j = 0; j < b[i].Length; j++)
			{
				if (j == 0)
					b[i][j] = b[i-1][j];
				if ((j > 0) && (j < b[i].Length-1))
					b[i][j] = b[i-1][j-1] + b[i-1][j];
				if (j == (b[i].Length -1))
					b[i][j] = b[i-1][j-1];
			}

		Console.WriteLine("\n{0}\n", b[a-1].Max());
	}
}