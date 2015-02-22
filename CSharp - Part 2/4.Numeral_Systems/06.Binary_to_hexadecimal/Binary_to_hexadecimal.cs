
//Problem 6. Binary to hexadecimal

//    Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace _06.Binary_to_hexadecimal
{
    using System;

    class Binary_to_hexadecimal
    {
        public static byte[] Bin_To_Hex(bool[] bin)
        {
            int from_count_system = 2;
            int to_count_system = 16;

            //adding leading zeros:
            int lz_toAdd = 4 - bin.Length % (int)Math.Log(to_count_system, from_count_system);
            //bin = bin.
            bool[] tempBin = new bool[bin.Length + lz_toAdd];
            for (int i = 0; i < bin.Length; i++)
            {
                tempBin[i] = bin[i];
            }
            bin = tempBin;

            byte[] result = new byte[bin.Length / (int)Math.Log(to_count_system, from_count_system)]; // 2^4 = 16   log(2)16 = 4 ... To Learn: how to calculate log? -- done!

            int j = 0;
            for (int i = 0; i < bin.Length; i += 4)
            {
                result[j] =
                    (byte)(
                      (Math.Pow(from_count_system, 0) * Convert.ToByte(bin[i]))
                    + (Math.Pow(from_count_system, 1) * Convert.ToByte(bin[i + 1]))
                    + (Math.Pow(from_count_system, 2) * Convert.ToByte(bin[i + 2]))
                    + (Math.Pow(from_count_system, 3) * Convert.ToByte(bin[i + 3]))
                    );
                j++;
            }

            return (result);
        }

        static void Main()
        {
            Console.WriteLine("Input Bin number:");
            char[] inputBin = Console.ReadLine().ToCharArray();

            //checking input:
            foreach (var item in inputBin)
            {
                if (!(item >= '0' && item <= '1'))
                {
                    Console.WriteLine("This is not Bin number!");
                    return;
                }
            }

            //puttin strig/char[] to bool[]
            bool[] bin = new bool[inputBin.Length];

            Array.Reverse(inputBin);
            for (int i = 0; i < bin.Length; i++)
            {
                bin[i] = inputBin[i] == '1';
            }

            //call our method:
            byte[] hex = Bin_To_Hex(bin);

            //print results
            Console.WriteLine("Hex number is:");
            string print = string.Empty;
            foreach (var item in hex)
            {
                if (item >= 0 && item <= 9)
                    print = item.ToString() + print;
                else
                    print = (char)('A' + item - 10) + print;
            }
            Console.WriteLine(print.TrimStart('0'));
        }
    }
}
