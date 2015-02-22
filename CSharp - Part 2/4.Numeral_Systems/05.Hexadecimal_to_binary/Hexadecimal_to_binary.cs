
//Problem 5. Hexadecimal to binary

//    Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05.Hexadecimal_to_binary
{
    using System;
    class Hexadecimal_to_binary
    {
        public static bool[] Hex_to_bin(byte[] hex)
        {
            //int from_count_system = 16;
            int to_count_system = 2;


            bool[] result = new bool[hex.Length * 4];

            int j = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                int hexPart = hex[i];
                if (hexPart == 0) j += 4;
                while (hexPart != 0)
                {
                    result[j] = (hexPart % to_count_system) == 1;
                    hexPart /= to_count_system;
                    j++;
                }
            }
            return (result);
        }

        static void Main()
        {
            Console.WriteLine("Input Hex number:");
            char[] inputHex = Console.ReadLine().ToCharArray();

            inputHex = string.Join(null, inputHex).ToUpper().ToCharArray();
            //checking input:
            foreach (var item in inputHex)
            {
                if (item <= '0' || item >= 'F')
                    if (item > '9' && item < 'A')
                    {
                        Console.WriteLine("This is not Hex number!");
                        return;
                    }
            }

            //puttin strig/char[] to byte[]
            byte[] hex = new byte[inputHex.Length];

            Array.Reverse(inputHex);
            for (int i = 0; i < hex.Length; i++)
            {
                if (inputHex[i] >= '0' && inputHex[i] <= '9')
                    hex[i] = (byte)(inputHex[i] - '0');
                else
                    if (inputHex[i] >= 'A')
                        hex[i] = (byte)((inputHex[i] - 'A') + 10);
            }

            //call our method:
            bool[] bin = Hex_to_bin(hex);

            //print results
            Console.WriteLine("Bin number is:");
            string print = string.Empty;
            foreach (var item in bin)
            {
                print = (item ? '1' : '0') + print;
            }
            Console.WriteLine(print.TrimStart('0'));
        }
    }
}
