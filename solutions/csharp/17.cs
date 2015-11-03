using System;

public class Seventeen
{
	static void Main()
	{
		int a = 0;
		
		for (int i = 1; i <= 1000; i++)
			a += chars(i);

		Console.WriteLine("\n{0}\n", a);
	}

	static int chars(int n)
	{
		string[] w = {"", "thousand","hundred","and"};
		string[] x = {"", "ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
		string[] y = {"", "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
		string[] z = {"", "one","two","three","four","five","six","seven","eight","nine"};

		string   v = "";

		int a = n / 1000;
		int b = (n / 100) % 10;
		int c = (n / 10) % 10;
		int d = n % 10;

		// 1: If n has 4 digits.
		if (a > 0)
			v += z[a] + w[1];
		// 2: If n has 3 digits.
		if (b > 0)
		{
			v += z[b] + w[2];
			// 2.5: If n is not evenly on the hundred, add "and".
			if ((c > 0) || (d > 0))
				v += w[3];
		}
		// 3: If the last two digits of n are a "teen" (11-19) number.
		if ((c == 1) && (d != 0))
			v += y[d];
		// 4: A specific case for if n is == 10.
		if ((c == 1) && (d == 0))
			v += x[1];
		// 5: If n ranges from from 21-99.
		if ((c > 0) && (c != 1))
		{
			v += x[c];
			v += z[d];
		}
		// 6: If n ranges 0-9.
		if ((c == 0) && (d > 0))
			v += z[d];

		return v.Length;
	}
}