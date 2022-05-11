using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon() => Console.WriteLine("Chopping with an axe");
    }
}
