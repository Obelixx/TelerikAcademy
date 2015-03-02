
//Problem 1. Strings in C#.

//    Describe the strings in C#.
//    What is typical for the string data type?
//    Describe the most important methods of the String class.

namespace _01.Strings_in_CSharp
{
    using System;
    using System.Text;
    class Strings_in_CSharp
    {
        static string StringDescription()
        {
//The string type represents a sequence of zero or more Unicode characters. string is an alias for String in the .NET Framework.
//Although string is a reference type, the equality operators (== and !=) are defined to compare the values of string objects, not references. This makes testing for string equality more intuitive.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The string type represents a sequence of zero or more Unicode characters. string is an alias for String in the .NET Framework.");
            sb.AppendLine("Although string is a reference type, the equality operators (== and !=) are defined to compare the values of string objects, not references. This makes testing for string equality more intuitive.");
            return (sb.ToString());
        }
        static string StringDataType()
        {
            //Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this.
            //For example, when you write { b += " world"; } , the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b.

            //The [] operator can be used for readonly access to individual characters of a string.
            //String literals can contain any character literal. Escape sequences are included.

            //Verbatim string literals start with @ and are also enclosed in double quotation marks.
            //The advantage of verbatim strings is that escape sequences are not processed, which makes it easy to write, for example, a fully qualified file name.
            //To include a double quotation mark in an @-quoted string, double it.
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this.");
            sb.AppendLine("For example, when you write { b += \" world\"; } , the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b.");
            sb.AppendLine();
            sb.AppendLine("The [] operator can be used for readonly access to individual characters of a string.");
            sb.AppendLine("String literals can contain any character literal. Escape sequences are included.");
            sb.AppendLine();
            sb.AppendLine("Verbatim string literals start with @ and are also enclosed in double quotation marks.");
            sb.AppendLine("The advantage of verbatim strings is that escape sequences are not processed, which makes it easy to write, for example, a fully qualified file name.");
            return (sb.ToString());
        }

        static string StringClassMostImportatntMethods()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Format(IFormatProvider, String, Object)");
            sb.AppendLine("Replaces the format item or items in a specified string with the string representation of the corresponding object. A parameter supplies culture-specific formatting information. ");
            sb.AppendLine();
            sb.AppendLine("IndexOf(String, Int32)");
            sb.AppendLine("Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position.");
            sb.AppendLine();
            sb.AppendLine("Insert(int startIndex,string value)");
            sb.AppendLine("Returns a new string in which a specified string is inserted at a specified index position in this instance.");
            sb.AppendLine();
            sb.AppendLine("Join(String separator, String[] value, Int32 startIndex, Int32 count)");
            sb.AppendLine("Concatenates the specified elements of a string array, using the specified separator between each element. ");
            sb.AppendLine();
            sb.AppendLine("PadLeft(Int32, Char)");
            sb.AppendLine("Returns a new string that right-aligns the characters in this instance by padding them on the left with a specified Unicode character, for a specified total length.");
            sb.AppendLine();
            sb.AppendLine("PadRight(Int32, Char)");
            sb.AppendLine("Returns a new string that left-aligns the characters in this string by padding them on the right with a specified Unicode character, for a specified total length.");
            sb.AppendLine();
            sb.AppendLine("Remove(Int32, Int32)");
            sb.AppendLine("Returns a new string in which a specified number of characters in the current instance beginning at a specified position have been deleted.");
            sb.AppendLine();
            sb.AppendLine("Replace(String, String)");
            sb.AppendLine("Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.");
            sb.AppendLine();
            sb.AppendLine("Split(Char[], Int32)");
            sb.AppendLine("Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array. A parameter specifies the maximum number of substrings to return.");
            sb.AppendLine();
            sb.AppendLine("StartsWith(String, Boolean, CultureInfo)");
            sb.AppendLine("Determines whether the beginning of this string instance matches the specified string when compared using the specified culture.");
            sb.AppendLine();
            sb.AppendLine("Substring(Int32, Int32)");
            sb.AppendLine("Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.");
            sb.AppendLine();
            sb.AppendLine("ToLower(CultureInfo)");
            sb.AppendLine("Returns a copy of this string converted to lowercase, using the casing rules of the specified culture.");
            sb.AppendLine();
            sb.AppendLine("ToUpper(CultureInfo)");
            sb.AppendLine("Returns a copy of this string converted to uppercase, using the casing rules of the specified culture.");
            sb.AppendLine();
            sb.AppendLine("ToString(IFormatProvider)");
            sb.AppendLine("Returns this instance of String; no actual conversion is performed.");
            sb.AppendLine();
            sb.AppendLine("ToUpperInvariant()");
            sb.AppendLine("Returns a copy of this String object converted to uppercase using the casing rules of the invariant culture.");
            sb.AppendLine();
            sb.AppendLine("Trim(Char[])");
            sb.AppendLine("Removes all leading and trailing occurrences of a set of characters specified in an array from the current String object.");
            return (sb.ToString());
        }



        static void Main()
        {
            Console.WriteLine("1. Describe the strings in C#.");
            Console.WriteLine(StringDescription());
            Console.WriteLine("Press [ENTER] key to continue...");
            Console.ReadLine();

            Console.WriteLine("2. What is typical for the string data type?");
            Console.WriteLine(StringDataType());
            Console.WriteLine("Press [ENTER] key to continue...");
            Console.ReadLine();

            Console.WriteLine("3. Describe the most important methods of the String class.");
            Console.WriteLine(StringClassMostImportatntMethods());
            Console.WriteLine("Press [ENTER] key to continue...");
            Console.ReadLine();
        }
    }
}
