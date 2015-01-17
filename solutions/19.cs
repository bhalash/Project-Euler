using System;

public class Nineteen
{
	static void Main()
	{	
		int a = 0;

		for (int i = 1901; i <= 2000; i++)
			for (int j = 1; j <= 12; j++)
				 if (Dow(i,j,1) == 0)
				 	a++;

		Console.WriteLine("\n{0}\n", a);
	}

	// Day of week. Good from 1900 to whenever.
	static int Dow(int year, int month, int day)
	{
		int a = 1900;
		int b = 1;
		int c = 1;
		int d = Elapsed(a,b,c,year,month,day);

		return d %= 7;
	}

	// Days between any two arbitrary dates. Inclusive!
	static int Elapsed(int yOne, int mOne, int dOne, int yTwo, int mTwo, int dTwo)
	{
		int a = 0;

		for (int i = yOne; i < yTwo; i++)
			a += DaysYear(i);
		for (int i = mOne; i < mTwo; i++)
			a += DaysMonth(yTwo, i);
		if (dTwo >= dOne)
			a += dTwo;
		else 
			a += dOne;

		return a;
	}

	// Days in one month. Assumes "1-12" input. Adjusts for leap year.
	static int DaysMonth(int year, int month)
	{
		int[]  a = new int[13] {-1,31,28,31,30,31,30,31,31,30,31,30,31};
		int	 b = 0;

		b = a[month];

		if ((Leap(year)) && (month == 2))
			b += 1;

		return b;
	}

	// Days in one year period.
	static int DaysYear(int year)
	{
		int a = 0;

		for (int i = 1; i <= 12; i++)
			a += DaysMonth(year, i);

		return a;
	}

	static bool Leap(int year)
	{
		if (year % 400 == 0)
			return true;
		else if (year % 100 == 0)
			return false;
		else if (year % 4 == 0)
			return true;

		return false;
	}
}