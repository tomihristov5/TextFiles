// Problem 4. Compare text files
// Write a program that compares two text files line by line and prints the number of lines that are the same and the 
// number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        using (StreamReader readerOne = new StreamReader(@"..\..\input1.txt"))
        {
            using (StreamReader readerTwo = new StreamReader(@"..\..\input2.txt"))
            {
                int same = 0;
                int diff = 0;
                string readerOneLine = readerOne.ReadLine();
                string readerTwoLine = readerTwo.ReadLine();
                while (readerOneLine != null)
                {
                    if (readerOneLine == readerTwoLine)
                    {
                        same++;
                    }
                    else
                        diff++;
                        readerOneLine = readerOne.ReadLine();
                        readerTwoLine = readerTwo.ReadLine();
                }
                Console.WriteLine("The number of lines that are the same: " + same);
                Console.WriteLine("The number of lines that are different: " + diff);
            }
        }
    }
}

