namespace _1.Class_123inCSharp
{
    using System;

    public class SimpleClass
    {
        // const int maxCount = 6; //someone may need it later
        public static void EntryMethod()
        {
            SimpleClassHelper printer = new SimpleClassHelper();
            printer.Print(true);
        }

        public static void Main()
        {
            EntryMethod();
        }
    }
}
