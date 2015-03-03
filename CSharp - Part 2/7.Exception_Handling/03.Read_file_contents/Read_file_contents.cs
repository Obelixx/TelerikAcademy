//Problem 3. Read file contents

//    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//    Find in MSDN how to use System.IO.File.ReadAllText(…).
//    Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03.Read_file_contents
{
    using System;
    using System.IO;
    using System.Security;
    using System.Text;

    class Read_file_contents
    {
        static string ReadFileToConsole(string path)
        {
            string str = string.Empty;

            try
            {
                str = File.ReadAllText(path, Encoding.UTF8);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");

            }
            catch (ArgumentException)
            {
                Console.WriteLine("path is null. ");

            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. ");

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive). ");

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found. ");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file. ");

            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(@"path specified a file that is read-only.
-or-
This operation is not supported on the current platform.
-or-
path specified a directory.
-or-
The caller does not have the required permission. ");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("path is in an invalid format. ");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission. ");
            }
            return (str);
        }


        static void Main()
        {
            Console.Write(@"Input full file path (for example: C:\WINDOWS\win.ini) here: ");
            string path = Console.ReadLine();
            string file = ReadFileToConsole(path);
            Console.WriteLine(file);
        }
    }
}
