using System;
using System.IO;

public class TwentyTwo
{
	static void Main()
	{
		string[] a = Import("22.txt");
		long 		b = 0;

		for (int i = 0; i < a.Length; i++)
			b += Tally(a[i]) * (i + 1);

		Console.WriteLine("\n{0}\n", b);
	}

	static int Tally(string a)
	{
		char[] b = a.ToCharArray();
		int    c = 0;
		int    d = 0;

		for (int i = 0; i < b.Length; i++)
		{
			c = ((b[i] - '0') + 10) % 26;
			if (c == 0)
				c = 26;
			d += c;
		}

		return d;
	}

	static string[] Import(string path)
	{
		string[] a = File.ReadAllLines(path);
		string[] b = a[0].Split(',');
		Array.Sort(b);
		return b;
	}
}