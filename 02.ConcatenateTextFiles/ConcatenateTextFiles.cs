// Problem 2. Concatenate text files
// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\text3.txt"))
        {
            using (StreamReader readerOne = new StreamReader(@"..\..\text1.txt"))
            {
                string line = readerOne.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = readerOne.ReadLine();
                }
            }

            using (StreamReader readerTwo = new StreamReader(@"..\..\text2.txt"))
            {
                string line = readerTwo.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = readerTwo.ReadLine();
                }
            }

            Console.WriteLine("See text3.txt for the concatenated text!");
        }
    }
}


