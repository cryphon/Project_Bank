﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon() => Console.WriteLine("Cutting with a knife");
    }
}
