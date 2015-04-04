namespace Student_and_Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    class TestProgram
    {
        static void Main()
        {
            Console.WriteLine("Student Tests:");
            var st1 = new Student("First", "Mid", "Last", 123123123, "mladost", "+359123123123", "Mail@me.to", 3, specialties.TK, universities.TU, faculties.FTK);
            var st2 = new Student("Second", "Mid", "Last", 123123124, "mladost 1", "+359123123124", "Mail@me.too", 3, specialties.TK, universities.TU, faculties.FTK);

            if (st1 != st2) // doing something just to test
            {
                Console.WriteLine(st1);
            }

            Console.WriteLine("Student 1 Hash: {0}", st1.GetHashCode());
            Console.WriteLine("Student 2 Hash: {0}", st2.GetHashCode());

            Line(2);

            var st3 = (Student)st1.Clone(); // clone them
            var st4 = st2.CloneStudent(); //bonus method that stndart clone() uses;

            Console.WriteLine("Student 3 Hash: {0}", st3.GetHashCode());
            Console.WriteLine("Student 4 Hash: {0}", st4.GetHashCode());

            Line(2);

            var list = new List<Student>() { st1, st2, st3, st4 };
            foreach (var stud in list)
            {
                Console.WriteLine(stud);
            }

            Line(2);

            list.Sort(); //sorting them using some default method

            foreach (var stud in list) // and printing them again
            {
                Console.WriteLine(stud);
            }


            LineWaitAndClear();
            Console.WriteLine("Person Tests:");

            var niki = new Person("Niki");
            var pepi = new Person("Pepi", 22);

            Console.WriteLine(niki);
            Console.WriteLine(pepi);

            LineWaitAndClear();
            Console.WriteLine("64 Bit array Tests:");

            var bArr = new BitArray64(123123); // some random number
            int truesCount = 0;
            foreach (var item in bArr)
            {
                if (item == 1)
                    truesCount++;
            }
            Console.WriteLine("Count of true bits: {0}", truesCount);

            for (int i = 0; i < bArr.Count(); i++) // listing ture values
            {
                if (bArr[i] == 1)
                    Console.WriteLine("Bit [{0}] is with value: [{1}]",i, bArr[i]);
            }

        }

        private static void Line(int count)
        {
            Console.WriteLine(new string('-', count));
        }

        private static void LineWaitAndClear()
        {
            Line(12);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
