using System;

//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

class Employee_Data
{
    static void Main()
    {
        Random rndGen = new Random(); // it makes only integers - long is calculated from 2 integers;

        employee OneEmployee = new employee("Fisrt", "Last", (byte)rndGen.Next(1, 100), rndGen.Next(0, 100) % 2 == 0, (long)rndGen.Next(0, 1000000000) + (long)rndGen.Next(0, 8) * 1000000000L, (int)rndGen.Next(27560000, 27569999));
        
        Console.WriteLine("First name is: {0,18}", OneEmployee.firstName);
        Console.WriteLine("Last name is: {0,19}", OneEmployee.lastName);
        Console.WriteLine("Age: {0,28}", OneEmployee.age);
        Console.WriteLine("Gender: {0,25}", OneEmployee.gender ? "f" : "m");
        Console.WriteLine("Personal ID number: {0,13}", OneEmployee.idNumber);
        Console.WriteLine("Unique employee number: {0,9}", OneEmployee.employeeNumber);
    }

    public struct employee
    {
        public string firstName;
        public string lastName;
        public byte age;
        public bool gender;
        public long idNumber;
        public int employeeNumber;

        public employee(string firstName_c, string lastName_c, byte age_c, bool gender_c, long idNumber_c, int employeeNumber_c)
        {

            firstName = firstName_c;
            lastName = lastName_c;
            age = age_c;
            gender = gender_c;
            idNumber = idNumber_c;
            employeeNumber = employeeNumber_c;
        }
    }
}

