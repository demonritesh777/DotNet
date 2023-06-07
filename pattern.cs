using System;
					
public class Program
{
	public static void Main()
	{
		int i,r;
		Console.WriteLine("Enter Number of rows");
		r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		for( i=1; i<=r; i++)
		{
		for(int j=0; j<i; j++)
		{
			Console.Write("*");
		}
			Console.WriteLine("\n");
		}
		Console.ReadLine();
	}
}