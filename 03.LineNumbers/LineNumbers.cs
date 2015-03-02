﻿// Problem 3. Line numbers
// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string line = reader.ReadLine();
                int counter = 1;
                while (line != null)
                {
                    writer.WriteLine("{0}. {1}", counter, line);
                    counter++;
                    line = reader.ReadLine();
                }
            }

            Console.WriteLine("See output.txt for the numbered text!");
        }
    }
}

