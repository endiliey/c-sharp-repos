using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #2: Write one string to a text file.
            string text = "We want to write this to our file";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"C:\Users\User\Documents\Visual Studio 2015\Projects\AssembliesAndNamespaces\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            File.WriteAllText(@"C:\Users\User\Documents\Visual Studio 2015\Projects\AssembliesAndNamespaces\WriteText.txt", reply);
            Console.WriteLine(reply);


            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
