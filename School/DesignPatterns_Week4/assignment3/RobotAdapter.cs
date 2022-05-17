using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class RobotAdapter : IAttacker
    {
        public Robot _robot = new Robot();

        public string Driver => _robot.Person;

        public void AssignDriver(string Driver) => _robot.MoveByPerson(Driver);

        public void DriveForward() => _robot.WalkForward();

        public void UseWeapon() => _robot.BashWithHands();
    }
}
