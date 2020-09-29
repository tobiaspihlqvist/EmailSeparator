using System;
using System.IO;

namespace EmailStringSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                StreamReader sr = new StreamReader("C:\\Temp/Emails.txt");
                var line = sr.ReadLine();
                while (line != null){
                    if (!line.Contains("@"))
                    {
                        for(int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine(line);
                          line = sr.ReadLine();
                    }
                    string email = line.Substring(line.LastIndexOf(", ") + 1);
                    Console.WriteLine(email);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
