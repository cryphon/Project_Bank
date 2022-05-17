using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal interface IAttacker
    {
        public string Driver { get; }
        public void AssignDriver(string Driver);
        public void DriveForward();
        public void UseWeapon();
    }
}
