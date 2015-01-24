using System;

//Problem 2. Gravitation on the Moon

//    The gravitational field of the Moon is approximately 17% of that on the Earth.
//    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

//Examples:
//weight 	weight on the Moon
//86 	14.62
//74.6 	12.682
//53.7 	9.129

class Gravitation_on_the_Moon
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture; 

        double weightEarth = 0;
        Console.Write("Input number:");
        while (!double.TryParse(Console.ReadLine(), out weightEarth))
        {
            Console.WriteLine("Input {0} Number!", Convert.GetTypeCode(weightEarth));
        }
        double weightMoon = 0;
        weightMoon = weightEarth * 0.17d;
        Console.WriteLine("Weight of a man on the moon is: {0:g}", weightMoon);
    }
}

