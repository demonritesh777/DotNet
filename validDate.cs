using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		string inputStr = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
        	string dateFormat = "MMddyyyy";
  		string datePattern=@"\b\d{2}\d{2}\d{4}\b";
		
		
		string dateStr;
		
		Match match=Regex.Match(inputStr,datePattern);
		if(match.Success)
		{
			dateStr=match.Value;
			DateTime date;
			if(DateTime.TryParseExact(dateStr, dateFormat, null, System.Globalization.DateTimeStyles.None, out date))
			{
				Console.WriteLine("Valid date :" +date.ToString(dateFormat));
			}
			else
			{
				Console.WriteLine("Invalid date");
			}
			
		}
		else
		{
			Console.WriteLine("No valid date found");
		}
	}
}