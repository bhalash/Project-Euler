using System;

public class Eighteen
{
	static void Main()
	{
		int[][] a = new int[15][];

		// Initialize a.
		a[0]  = new int[1]  {75};
		a[1]  = new int[2]  {95,64};
		a[2]  = new int[3]  {17,47,82};
		a[3]  = new int[4]  {18,35,87,10};
		a[4]  = new int[5]  {20,04,82,47,65};
		a[5]  = new int[6]  {19,01,23,75,03,34};
		a[6]  = new int[7]  {88,02,77,73,07,63,67};
		a[7]  = new int[8]  {99,65,04,28,06,16,70,92};
		a[8]  = new int[9]  {41,41,26,56,83,40,80,70,33};
		a[9]  = new int[10] {41,48,72,33,47,32,37,16,94,29};
		a[10] = new int[11] {53,71,44,65,25,43,91,52,97,51,14};
		a[11] = new int[12] {70,11,33,28,77,73,17,78,39,68,17,57};
		a[12] = new int[13] {91,71,52,38,17,14,91,43,58,50,27,29,48};
		a[13] = new int[14] {63,66,04,68,89,53,67,30,73,16,69,87,40,31};
		a[14] = new int[15] {04,62,98,27,23,09,70,98,73,93,38,53,60,04,23};

		for (int i = 14; i > 0; i--)
			for (int j = 0; j < (a[i].Length-1); j++)
				if (a[i][j] > a[i][j+1])
					a[i-1][j] += a[i][j];
				else if (a[i][j+1] > a[i][j])
					a[i-1][j] += a[i][j+1];

		Console.WriteLine("\n{0}\n", a[0][0]);
	}
}