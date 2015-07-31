namespace ComparePerformance
{
    using System;
    using Maths.ComparePerformance;

    public class Tester
    {
        private const int TIMES_TO_TEST = 1000000;

        public static void Main()
        {
            //int    
            //long   
            //float  
            //double 
            //decimal

            Console.WriteLine("--- Simple Math ---");
            Console.WriteLine("Add..");
            var intDelegate = new MyTimer<int>.TasksDelegate(SimpleMaths.Add);
            var longDelegate = new MyTimer<long>.TasksDelegate(SimpleMaths.Add);
            var floatDelegate = new MyTimer<float>.TasksDelegate(SimpleMaths.Add);
            var doubleDelegate = new MyTimer<double>.TasksDelegate(SimpleMaths.Add);
            var decimalDelegate = new MyTimer<decimal>.TasksDelegate(SimpleMaths.Add);
            long intAddMs, intAddTicks;
            long longAddMs, longAddTicks;
            long floatAddMs, floatAddTicks;
            long doubleAddMs, doubleAddTicks;
            long decimalAddMs, decimalAddTicks;
            MyTimer<int>.Test(intDelegate, int.MinValue, int.MaxValue, TIMES_TO_TEST, out intAddMs, out intAddTicks);
            MyTimer<long>.Test(longDelegate, long.MinValue, long.MaxValue, TIMES_TO_TEST, out longAddMs, out longAddTicks);
            MyTimer<float>.Test(floatDelegate, float.MinValue, float.MaxValue, TIMES_TO_TEST, out floatAddMs, out floatAddTicks);
            MyTimer<double>.Test(doubleDelegate, double.MinValue, double.MaxValue, TIMES_TO_TEST, out doubleAddMs, out doubleAddTicks);
            MyTimer<decimal>.Test(decimalDelegate, decimal.MinValue, decimal.MaxValue, TIMES_TO_TEST, out decimalAddMs, out decimalAddTicks);

            Console.WriteLine("Subtract..");
            intDelegate = new MyTimer<int>.TasksDelegate(SimpleMaths.Subtract);
            longDelegate = new MyTimer<long>.TasksDelegate(SimpleMaths.Subtract);
            floatDelegate = new MyTimer<float>.TasksDelegate(SimpleMaths.Subtract);
            doubleDelegate = new MyTimer<double>.TasksDelegate(SimpleMaths.Subtract);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(SimpleMaths.Subtract);
            long intSubtractMs, intSubtractTicks;
            long longSubtractMs, longSubtractTicks;
            long floatSubtractMs, floatSubtractTicks;
            long doubleSubtractMs, doubleSubtractTicks;
            long decimalSubtractMs, decimalSubtractTicks;
            MyTimer<int>.Test(intDelegate, int.MaxValue, int.MaxValue, TIMES_TO_TEST, out intSubtractMs, out intSubtractTicks);
            MyTimer<long>.Test(longDelegate, long.MaxValue, long.MaxValue, TIMES_TO_TEST, out longSubtractMs, out longSubtractTicks);
            MyTimer<float>.Test(floatDelegate, float.MaxValue, float.MaxValue, TIMES_TO_TEST, out floatSubtractMs, out floatSubtractTicks);
            MyTimer<double>.Test(doubleDelegate, double.MaxValue, double.MaxValue, TIMES_TO_TEST, out doubleSubtractMs, out doubleSubtractTicks);
            MyTimer<decimal>.Test(decimalDelegate, decimal.MaxValue, decimal.MaxValue, TIMES_TO_TEST, out decimalSubtractMs, out decimalSubtractTicks);

            Console.WriteLine("Increment..");
            intDelegate = new MyTimer<int>.TasksDelegate(SimpleMaths.Increment);
            longDelegate = new MyTimer<long>.TasksDelegate(SimpleMaths.Increment);
            floatDelegate = new MyTimer<float>.TasksDelegate(SimpleMaths.Increment);
            doubleDelegate = new MyTimer<double>.TasksDelegate(SimpleMaths.Increment);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(SimpleMaths.Increment);
            long intIncrementMs, intIncrementTicks;
            long longIncrementMs, longIncrementTicks;
            long floatIncrementMs, floatIncrementTicks;
            long doubleIncrementMs, doubleIncrementTicks;
            long decimalIncrementMs, decimalIncrementTicks;
            MyTimer<int>.Test(intDelegate, 1000, 1001, TIMES_TO_TEST, out intIncrementMs, out intIncrementTicks);
            MyTimer<long>.Test(longDelegate, 1000L, 1001L, TIMES_TO_TEST, out longIncrementMs, out longIncrementTicks);
            MyTimer<float>.Test(floatDelegate, 1000f, 1001f, TIMES_TO_TEST, out floatIncrementMs, out floatIncrementTicks);
            MyTimer<double>.Test(doubleDelegate, 1000d, 1001d, TIMES_TO_TEST, out doubleIncrementMs, out doubleIncrementTicks);
            MyTimer<decimal>.Test(decimalDelegate, 1000m, 1001m, TIMES_TO_TEST, out decimalIncrementMs, out decimalIncrementTicks);

            Console.WriteLine("Multiply..");
            intDelegate = new MyTimer<int>.TasksDelegate(SimpleMaths.Multiply);
            longDelegate = new MyTimer<long>.TasksDelegate(SimpleMaths.Multiply);
            floatDelegate = new MyTimer<float>.TasksDelegate(SimpleMaths.Multiply);
            doubleDelegate = new MyTimer<double>.TasksDelegate(SimpleMaths.Multiply);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(SimpleMaths.Multiply);
            long intMultiplyMs, intMultiplyTicks;
            long longMultiplyMs, longMultiplyTicks;
            long floatMultiplyMs, floatMultiplyTicks;
            long doubleMultiplyMs, doubleMultiplyTicks;
            long decimalMultiplyMs, decimalMultiplyTicks;
            MyTimer<int>.Test(intDelegate, int.MaxValue / 3, 2, TIMES_TO_TEST, out intMultiplyMs, out intMultiplyTicks);
            MyTimer<long>.Test(longDelegate, long.MaxValue / 3, 2L, TIMES_TO_TEST, out longMultiplyMs, out longMultiplyTicks);
            MyTimer<float>.Test(floatDelegate, float.MaxValue / 3, 2f, TIMES_TO_TEST, out floatMultiplyMs, out floatMultiplyTicks);
            MyTimer<double>.Test(doubleDelegate, double.MaxValue / 3, 2.0d, TIMES_TO_TEST, out doubleMultiplyMs, out doubleMultiplyTicks);
            MyTimer<decimal>.Test(decimalDelegate, decimal.MaxValue / 3, 2m, TIMES_TO_TEST, out decimalMultiplyMs, out decimalMultiplyTicks);


            Console.WriteLine("Divide..");
            intDelegate = new MyTimer<int>.TasksDelegate(SimpleMaths.Divide);
            longDelegate = new MyTimer<long>.TasksDelegate(SimpleMaths.Divide);
            floatDelegate = new MyTimer<float>.TasksDelegate(SimpleMaths.Divide);
            doubleDelegate = new MyTimer<double>.TasksDelegate(SimpleMaths.Divide);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(SimpleMaths.Divide);
            long intDivideMs, intDivideTicks;
            long longDivideMs, longDivideTicks;
            long floatDivideMs, floatDivideTicks;
            long doubleDivideMs, doubleDivideTicks;
            long decimalDivideMs, decimalDivideTicks;
            MyTimer<int>.Test(intDelegate, int.MaxValue, 2, TIMES_TO_TEST, out intDivideMs, out intDivideTicks);
            MyTimer<long>.Test(longDelegate, long.MaxValue, 2L, TIMES_TO_TEST, out longDivideMs, out longDivideTicks);
            MyTimer<float>.Test(floatDelegate, float.MaxValue, 2f, TIMES_TO_TEST, out floatDivideMs, out floatDivideTicks);
            MyTimer<double>.Test(doubleDelegate, double.MaxValue, 2d, TIMES_TO_TEST, out doubleDivideMs, out doubleDivideTicks);
            MyTimer<decimal>.Test(decimalDelegate, decimal.MaxValue, 2m, TIMES_TO_TEST, out decimalDivideMs, out decimalDivideTicks);
            Console.WriteLine("..Done!");

            Console.WriteLine();
            string[] dataTypes = { "int", "long", "float", "double", "decimal" };
            long[] AddMs = { intAddMs, longAddMs, floatAddMs, doubleAddMs, decimalAddMs };
            long[] AddTicks = { intAddTicks, longAddTicks, floatAddTicks, doubleAddTicks, decimalAddTicks };

            long[] SubtractMs = { intSubtractMs, longSubtractMs, floatSubtractMs, doubleSubtractMs, decimalSubtractMs };
            long[] SubtractTicks = { intSubtractTicks, longSubtractTicks, floatSubtractTicks, doubleSubtractTicks, decimalSubtractTicks };

            long[] IncrementMs = { intIncrementMs, longIncrementMs, floatIncrementMs, doubleIncrementMs, decimalIncrementMs };
            long[] IncrementTicks = { intIncrementTicks, longIncrementTicks, floatIncrementTicks, doubleIncrementTicks, decimalIncrementTicks };

            long[] MultiplyMs = { intMultiplyMs, longMultiplyMs, floatMultiplyMs, doubleMultiplyMs, decimalMultiplyMs };
            long[] MultiplyTicks = { intMultiplyTicks, longMultiplyTicks, floatMultiplyTicks, doubleMultiplyTicks, decimalMultiplyTicks };

            long[] DivideMs = { intDivideMs, longDivideMs, floatDivideMs, doubleDivideMs, decimalDivideMs };
            long[] DivideTicks = { intDivideTicks, longDivideTicks, floatDivideTicks, doubleDivideTicks, decimalDivideTicks };

            Console.Write("FOR " + TIMES_TO_TEST + " times\t");
            Console.WriteLine(string.Join("\t ", dataTypes));

            Console.Write("Add [ms]:         \t");
            Console.WriteLine(string.Join("\t ", AddMs));
            Console.Write("Add [ticks]:      \t");
            Console.WriteLine(string.Join("\t ", AddTicks));

            Console.Write("Subtract [ms]:    \t");
            Console.WriteLine(string.Join("\t ", SubtractMs));
            Console.Write("Subtract [ticks]: \t");
            Console.WriteLine(string.Join("\t ", SubtractTicks));

            Console.Write("Increment [ms]:   \t");
            Console.WriteLine(string.Join("\t ", IncrementMs));
            Console.Write("Increment [ticks]:\t");
            Console.WriteLine(string.Join("\t ", IncrementTicks));

            Console.Write("Multiply [ms]:    \t");
            Console.WriteLine(string.Join("\t ", MultiplyMs));
            Console.Write("Multiply [ticks]: \t");
            Console.WriteLine(string.Join("\t ", MultiplyTicks));

            Console.Write("Divide [ms]:      \t");
            Console.WriteLine(string.Join("\t ", DivideMs));
            Console.Write("Divide [ticks]:   \t");
            Console.WriteLine(string.Join("\t ", DivideTicks));

            Console.WriteLine("--- Advanced Math ---");

            Console.WriteLine("Sqrt..");
            floatDelegate = new MyTimer<float>.TasksDelegate(AdvancedMath.MySqrt);
            doubleDelegate = new MyTimer<double>.TasksDelegate(AdvancedMath.MySqrt);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(AdvancedMath.MySqrt);
            long floatSqrtMs, floatSqrtTicks;
            long doubleSqrtMs, doubleSqrtTicks;
            long decimalSqrtMs, decimalSqrtTicks;
            MyTimer<float>.Test(floatDelegate, float.MaxValue, 2f, TIMES_TO_TEST, out floatSqrtMs, out floatSqrtTicks);
            MyTimer<double>.Test(doubleDelegate, double.MaxValue, 2d, TIMES_TO_TEST, out doubleSqrtMs, out doubleSqrtTicks);
            MyTimer<decimal>.Test(decimalDelegate, decimal.MaxValue, 2m, TIMES_TO_TEST, out decimalSqrtMs, out decimalSqrtTicks);

            Console.WriteLine("Log..");
            floatDelegate = new MyTimer<float>.TasksDelegate(AdvancedMath.MyLog);
            doubleDelegate = new MyTimer<double>.TasksDelegate(AdvancedMath.MyLog);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(AdvancedMath.MyLog);
            long floatLogMs, floatLogTicks;
            long doubleLogMs, doubleLogTicks;
            long decimalLogMs, decimalLogTicks;
            MyTimer<float>.Test(floatDelegate, float.MaxValue, 2f, TIMES_TO_TEST, out floatLogMs, out floatLogTicks);
            MyTimer<double>.Test(doubleDelegate, double.MaxValue, 2d, TIMES_TO_TEST, out doubleLogMs, out doubleLogTicks);
            MyTimer<decimal>.Test(decimalDelegate, decimal.MaxValue, 2m, TIMES_TO_TEST, out decimalLogMs, out decimalLogTicks);

            Console.WriteLine("Sin..");
            floatDelegate = new MyTimer<float>.TasksDelegate(AdvancedMath.MySin);
            doubleDelegate = new MyTimer<double>.TasksDelegate(AdvancedMath.MySin);
            decimalDelegate = new MyTimer<decimal>.TasksDelegate(AdvancedMath.MySin);
            long floatSinMs, floatSinTicks;
            long doubleSinMs, doubleSinTicks;
            long decimalSinMs, decimalSinTicks;
            MyTimer<float>.Test(floatDelegate, 2f, float.MaxValue, TIMES_TO_TEST, out floatSinMs, out floatSinTicks);
            MyTimer<double>.Test(doubleDelegate, 2d, double.MaxValue, TIMES_TO_TEST, out doubleSinMs, out doubleSinTicks);
            MyTimer<decimal>.Test(decimalDelegate, 2m, decimal.MaxValue, TIMES_TO_TEST, out decimalSinMs, out decimalSinTicks);
            Console.WriteLine("..Done!");

            Console.WriteLine();
            string[] dataTypesTwo = { "float", "double", "decimal" };
            long[] SqrtMs = { floatSqrtMs, doubleSqrtMs, decimalSqrtMs };
            long[] SqrtTicks = { floatSqrtTicks, doubleSqrtTicks, decimalSqrtTicks };

            long[] LogMs = { floatLogMs, doubleLogMs, decimalLogMs };
            long[] LogTicks = { floatLogTicks, doubleLogTicks, decimalLogTicks };

            long[] SinMs = { floatSinMs, doubleSinMs, decimalSinMs };
            long[] SinTicks = { floatSinTicks, doubleSinTicks, decimalSinTicks };


            Console.Write("FOR " + TIMES_TO_TEST + " times\t\t\t");
            Console.WriteLine(string.Join("\t ", dataTypesTwo));

            Console.Write("Sqrt [ms]:         \t\t\t");
            Console.WriteLine(string.Join("\t ", SqrtMs));
            Console.Write("Sqrt [ticks]:      \t\t\t");
            Console.WriteLine(string.Join("\t ", SqrtTicks));

            Console.Write("Log [ms]:    \t\t\t\t");
            Console.WriteLine(string.Join("\t ", LogMs));
            Console.Write("Log [ticks]: \t\t\t\t");
            Console.WriteLine(string.Join("\t ", LogTicks));

            Console.Write("Sin [ms]:   \t\t\t\t");
            Console.WriteLine(string.Join("\t ", SinMs));
            Console.Write("Sin [ticks]:\t\t\t\t");
            Console.WriteLine(string.Join("\t ", SinTicks));

            Console.WriteLine("--- THE END ---");
        }
    }
}
