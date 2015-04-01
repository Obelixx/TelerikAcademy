namespace _2.Students_and_workers
{
    using System;
    using System.Collections.Generic;

    using Students_and_workers.Models;
    using Students_and_workers.Extensions;

    class TestProgram
    {
        static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 4));
            students.Add(new Student("Stoyan", "Ivanov", 4));
            students.Add(new Student("Pepi", "Petrov", 3));
            students.Add(new Student("Petyr", "Dimitrov", 4));
            students.Add(new Student("Dimityr", "Asenov", 6));
            students.Add(new Student("Asen", "Stoyanov", 5));
            students.Add(new Student("Drago", "Draganov", 6));
            students.Add(new Student("Koko", "Lambov", 3));
            students.Add(new Student("Lambi", "Stanoev", 2));
            students.Add(new Student("Stanoi", "Sholov", 2));

            students = students.SortedByGrade();

            foreach (var stud in students)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("---");


            var workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Ivanov", 400));
            workers.Add(new Worker("Stoyan", "Ivanov", 400));
            workers.Add(new Worker("Pepi", "Petrov", 300));
            workers.Add(new Worker("Petyr", "Dimitrov", 400));
            workers.Add(new Worker("Dimityr", "Asenov", 600));
            workers.Add(new Worker("Asen", "Stoyanov", 500));
            workers.Add(new Worker("Drago", "Draganov", 600));
            workers.Add(new Worker("Koko", "Lambov", 300));
            workers.Add(new Worker("Lambi", "Stanoev", 200));
            workers.Add(new Worker("Stanoi", "Sholov", 200));

            workers = workers.SortedByMoneyPerHour();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine("---");


            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(humans);

            humans = humans.SortedByfirstNameAndLastName();

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
            Console.WriteLine("---");

        }
    }
}
