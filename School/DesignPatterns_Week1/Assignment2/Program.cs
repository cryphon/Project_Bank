﻿using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            string msg = "";
            IPencil pencil = new Pencil(16);
            do
            {
                Console.ResetColor();
                Console.Write("Enter a word: ");
                msg = Console.ReadLine();

                if(msg == "sharpen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("sharpening the pencil...");
                    SharpenPencil(pencil);
                    continue;
                }
                WriteMessage(pencil, msg);
            } while (msg != "stop");
        }

        void WriteMessage(IPencil pencil, string msg) => pencil.Write(msg);

        void SharpenPencil(IPencil pencil)
        {
            PencilSharpener pencilSharpener = new PencilSharpener();
            pencilSharpener.Sharpen(pencil);
        }
    }
}
