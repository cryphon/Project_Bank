using System;

namespace Assignment1
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
            IStack stack = new ArrayStack(50);
            AddValues(stack);
            CheckValues(stack);
            ProcessValues(stack);
        }

        void AddValues(IStack stack)
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int val = r.Next(1,100); 
                stack.Push(val);
                Console.WriteLine($"pushed {val}, new count: {stack.Count()}");
            }
            Console.WriteLine();
        }


        void CheckValues(IStack stack)
        {
            int num;
            do
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (stack.Contains(num))
                    Console.WriteLine($"stack contains value {num}");
                else
                    Console.WriteLine($"stack does not contain value {num}");
            } while (num != 0);
            
        }

        void ProcessValues(IStack stack) 
        {
            Console.WriteLine();
            while (!stack.IsEmpty())
            {
                int val = stack.Pop();
                Console.WriteLine($"popped {val}, new count: {stack.Count()}");
            }
        }
    }
}
