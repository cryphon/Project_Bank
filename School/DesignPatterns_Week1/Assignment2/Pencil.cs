using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;

        public Pencil(int maxToWrite) => this.maxToWrite = maxToWrite;

        public bool canWrite => maxToWrite == nrOfCharsWritten ? true : false;

        public void AfterSharpening() => nrOfCharsWritten = 0;

        public void Write(string msg)
        {
            foreach(char c in msg)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (!canWrite)
                {
                    Console.Write(c);
                    nrOfCharsWritten++;
                }            
                else
                    Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
