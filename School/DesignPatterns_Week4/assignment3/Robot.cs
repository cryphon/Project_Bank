using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Robot
    {
        public string Person;
        public void BashWithHands() => Console.WriteLine("Robot causes damage with hands");

        public void MoveByPerson(string Driver)
        {
            Person = Driver;
            Console.WriteLine($"Robot is moved by {Person}");
        }

        public void WalkForward() => Console.WriteLine("Robot walks forward");
    }
}
