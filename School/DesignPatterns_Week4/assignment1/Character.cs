using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Character
    {
        public IWeaponBehaviour Weapon;
        public Character(){ }

        public void Fight() => Weapon.UseWeapon();
    }
}
