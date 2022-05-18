using System;
using System.Collections.Generic;

namespace assignment3
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
            //create tank n assign driver
            Tank t = new Tank();
            t.AssignDriver("Frank");           

            //create robot
            RobotAdapter rA  = new RobotAdapter(new Robot());
            rA.AssignDriver("Mark");

            //create attacker list
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(t);
            attackers.Add(rA);
            //process all attackers

            foreach(IAttacker attacker in attackers)
            {
                Console.WriteLine($"\nDriver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }
    }
}
