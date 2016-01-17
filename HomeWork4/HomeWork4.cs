using System;
using System.Threading;
using System.Globalization;
using System.Text;


class HomeWork4
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding=Encoding.UTF8;
        char c='\u20ac';
        Console.WriteLine(c);

        Console.WriteLine(DateTime.Now);

        Console.WriteLine("dfgfdgdfgfd" + Environment.NewLine + "New Line");
        Console.WriteLine("dfgfdgdfgfd" + "\nNew Line 6");



        //int n;
        //bool tryParceN = false;
        //tryParceN = int.TryParse(Console.ReadLine(), out n);
        //Console.WriteLine(n);
        //Console.WriteLine(tryParceN);

        double n;

        try
        {
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}",Math.Pow(n,.5));
        }
          catch (FormatException e)
        {
            Console.WriteLine(e);
        }
    }
}
