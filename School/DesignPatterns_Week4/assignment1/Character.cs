using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }

        public Character(){ /*default */ Weapon = new SwordBehaviour(); }

        public void Fight() => Weapon.UseWeapon();
    }
}
