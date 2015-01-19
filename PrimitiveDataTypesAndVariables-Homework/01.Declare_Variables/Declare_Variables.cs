using System;

//Problem 1. Declare Variables

//    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

//Submit the source code of your Visual Studio project as part of your homework submission.

class Declare_Variables
{
    static void Main()
    {
        //52130, -115, 4825932, 97, -10000.
        ushort typeUShort = 52130;
        sbyte typeSByte = -115;
        int typeInt = 4825932;
        byte typeByte = 97;
        short typeShort = -10000;

       // Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n", typeUShort, typeSByte, typeInt, typeByte, typeShortTwo);
        Console.WriteLine("Data Type for [{0,8}] is: [{1,16}]", typeUShort, typeUShort.GetType().ToString());
        Console.WriteLine("Data Type for [{0,8}] is: [{1,16}]", typeSByte, typeSByte.GetType().ToString());
        Console.WriteLine("Data Type for [{0,8}] is: [{1,16}]", typeInt, typeInt.GetType().ToString());
        Console.WriteLine("Data Type for [{0,8}] is: [{1,16}]", typeByte, typeByte.GetType().ToString());
        Console.WriteLine("Data Type for [{0,8}] is: [{1,16}]", typeShort, typeShort.GetType().ToString());
    }
}

