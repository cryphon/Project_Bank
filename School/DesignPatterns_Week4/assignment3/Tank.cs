using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Tank : IAttacker
    {
        private string _Driver;
        public string Driver => _Driver;

        public void AssignDriver(string Driver)
        {
            _Driver = Driver; 
            Console.WriteLine($"{_Driver} is steering the tank");
        }

        public void DriveForward() => Console.WriteLine("Tank moves forward");

        public void UseWeapon() => Console.WriteLine("Tank causes damage with weapon");
    }
}
