//Problem 7. One system to any other

//    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).


namespace _07.One_system_to_any_other
{
    using System;
    class One_system_to_any_other
    {
        public static int All_to_Dec(int s, int[] arr)
        {
            int from_count_system = s;
            //int to_count_system = 10;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i] * (int)(Math.Pow(from_count_system, i));
            }
            return (result);
        }
        public static int[] Dec_to_all(int d, int dec)
        {
            //int from_count_system = 10;
            int to_count_system = d;
            int[] result = new int[1000]; // todo: determine size

            int i = 0;
            while (dec != 0)
            {
                result[i] = (dec % to_count_system);
                dec /= to_count_system;
                i++;
            }




            return (result);

        }


        static void Main()
        {
            //s to d
            Console.WriteLine("input s:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("input d:");
            int d = int.Parse(Console.ReadLine());

            //if (s > d)

            Console.WriteLine("Input number:");
            char[] input = Console.ReadLine().ToCharArray();

            input = string.Join(null, input).ToUpper().ToCharArray();
            //not checking input.


            //puttin strig/char[] to int[]
            int[] input_arr = new int[input.Length];

            Array.Reverse(input);
            for (int i = 0; i < input_arr.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                    input_arr[i] = (input[i] - '0');
                else
                    if (input[i] >= 'A')
                        input_arr[i] = ((input[i] - 'A') + 10);
            }

            //call our methods:

            int dec = All_to_Dec(s, input_arr);
            int[] output = Dec_to_all(d, dec);

            Console.WriteLine("Output:");

            string print = string.Empty;
            foreach (var item in output)
            {
                if (item >= 0 && item <= 9)
                    print = item.ToString() + print;
                else
                {
                    print = (char)('A' + item - 10) + print;
                }
            }
            print = print.TrimStart('0');
            char[] printC = print.ToCharArray();
            Array.Reverse(printC);
            print = string.Join(null, printC);
            Console.WriteLine(print);

        }
    }
}
