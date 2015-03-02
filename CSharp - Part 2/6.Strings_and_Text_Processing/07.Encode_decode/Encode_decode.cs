//Problem 7. Encode/decode

//    Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters.
//    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

namespace _07.Encode_decode
{
    using System;
    using System.Text;

    class Encode_decode
    {
        static string En_DeCode(string text, string chiper)
        {
            StringBuilder code = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                code.Append((char)(text[i]^chiper[i % chiper.Length]));
            }
            return (code.ToString());
        }

        static void Main()
        {
            string str = string.Empty;
            do
            {
                Console.Write("Input String:");
                str = Console.ReadLine();
            } while (str == string.Empty || str == null);

            string chiper = string.Empty;
            do
            {
                Console.Write("Input chiper:");
                chiper = Console.ReadLine();
            } while (chiper == string.Empty || chiper == null);

            Console.WriteLine();
            string encoded = En_DeCode(str, chiper);
            Console.WriteLine("Encoded: {0}", encoded);

            Console.WriteLine();
            string decoded = En_DeCode(encoded, chiper);
            Console.WriteLine("Decoded: {0}", decoded);

        }
    }
}
