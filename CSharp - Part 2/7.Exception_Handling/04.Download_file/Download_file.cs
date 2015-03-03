//Problem 4. Download file

//    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//    Find in Google how to download files in C#.
//    Be sure to catch all exceptions and to free any used resources in the finally block.

namespace _04.Download_file
{
    using System;
    using System.Net;
    using System.Windows.Forms;

    class Download_file
    {
        static void DownloadFile(string path)
        {
            var wc = new WebClient();
            try
            {
                string filename = "ninja.png";
                wc.DownloadFile(path, filename);
                Console.WriteLine("File Downloaded to:\n" + Application.StartupPath + "\\" + filename);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine(@"The URI formed by combining BaseAddress and address is invalid.
-or-
filename is null or Empty.
-or-
The file does not exist.
-or- 
An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            finally
            {
                Console.WriteLine("Bye-Bye!");
            }
        }
        static void Main()
        {
            string path = @"https://telerikacademy.com/Content/Images/news-img01.png";
            DownloadFile(path);
        }

    }
}
