using System;

class Home2
{
    static void Main()
    {

        int width = Convert.ToInt32(Console.ReadLine());
        if (width >= 2 || width <= 75)
        {
            int height = 2 * width - 1;
            int br = height;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (j == i || j == br)
                        Console.Write("*");

                    else if (j <= width)
                        Console.Write(".");
                }
                br--;
                Console.WriteLine();
            }
        }
    }
}