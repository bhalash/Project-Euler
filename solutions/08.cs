using System;
using System.IO;

public class Eight
{
	static void Main()
	{
		int[] a = Import();
		int   b = 0;
		int   c = 0;

		for (int i = 4; i < a.Length; i++)
		{
			b = a[i] * a[i-1] * a[i-2] * a[i-3] * a[i-4];

			if (b > c)
				c = b;
		}

		Console.WriteLine("\n{0}\n", c);
	}

	static int[] Import()
	{
		string a = "";

		using (StreamReader z = new StreamReader("08.txt"))
			a = (z.ReadLine());

		int[] b = new int [a.Length];

		for (int i = 0; i < a.Length; i++)
			b[i] = a[i] - '0';

		return b;
	}
}