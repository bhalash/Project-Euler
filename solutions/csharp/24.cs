using System;

public class TwentyFour
{
	static void Main()
	{
		int[] a = {0,1,2,3,4,5,6,7,8,9};	
		int   b = 1000000;

		for (int i = 1; i < b; i++)
			a = Permute(a);

		Print(a);
	}

	static void Print(int[] z)
	{
		Console.WriteLine();
		for (int i = 0; i < z.Length; i++)
			Console.Write(z[i]);
		Console.WriteLine("\n");
	}

	static int[] Permute(int[] z)
	{
		int k = -1;
		int l =  0;

		for (int i = (z.Length - 2); i >= 0; i--)
			if (z[i] < z[i + 1])
			{
				k = i;
				break;
			}

		for (int i = z.Length - 1; i > k; i--)
			if (z[i] > z[k])
			{
				l = i;
				break;
			}

		int tmp = z[k];
		z[k] = z[l];
		z[l] = tmp;

		Array.Reverse(z, k + 1, z.Length - (k + 1));
		return z;
	}
}