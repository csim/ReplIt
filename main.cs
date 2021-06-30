using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
        //Console.WriteLine(123456.12M.ToString("$#,###.00", new CultureInfo("fr-FR")));
        //Console.WriteLine(123456.12M.ToString("#,###.00 $", new CultureInfo("fr-FR")));
        //Console.WriteLine(DateTime.Parse("Monday, April 12, 2021").ToString(new CultureInfo("en-US")//.DateTimeFormat.LongDatePattern));

        //"M/d/yyyy", 
        // var gb = new CultureInfo("en-GB");
        // var us = new CultureInfo("en-US");
        // var es = new CultureInfo("en-US");
        // //dddd, d de MMMM de yyyy H:mm:ss

        // var c = es;
        // var f = c.DateTimeFormat.FullDateTimePattern;
        // //var f = "dddd, d de MMMM de yyyy H:mm:ss";
        // Console.WriteLine(f);
        // Console.WriteLine(DateTime.Parse("10/31/2021").ToString(f));

        var us = new CultureInfo("en-US");
        Console.WriteLine(us.NumberFormat.CurrencyDecimalSeparator);

        DateTime(1, 1, 2020).ToString("Mddyy").Print();


        //Console.WriteLine(new CultureInfo("en-GB").NumberFormat.CurrencySymbol);
        //Console.WriteLine((char)("A"[0] + 1));
        //Console.WriteLine(")".Replace(")", @"\)"));
        //Console.WriteLine("abc"[^1]);
        // Console.WriteLine("123456".Substring(1));
        // var input = "Clint Simon";
        // var o = Enumerable.Range(1, input.Length - 1).Select(i => input.Substring(i));

        // foreach (var i in o) {
        //     Console.WriteLine(i);
        // }

        // Console.WriteLine(Math.Log(0.001d, 10));
        // Console.WriteLine(Math.Log(1, 10));
        // Console.WriteLine(Math.Log(10, 10));
	}
}