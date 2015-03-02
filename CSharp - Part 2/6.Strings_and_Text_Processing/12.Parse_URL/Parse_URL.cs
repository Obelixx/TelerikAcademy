//Problem 12. Parse URL

//    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

//Example:
//URL 	Information
//http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
//[server] = telerikacademy.com
//[resource] = /Courses/Courses/Details/212

namespace _12.Parse_URL
{
    using System;

    class Parse_URL
    {
        static void Main()
        {
            string input = "http://telerikacademy.com/Courses/Courses/Details/212";
            Uri url = new Uri(input);

            string protocol = url.Scheme;
            string server = url.Host;
            string resource = url.AbsolutePath;

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[restource] = {0}", resource);
        }
    }
}
