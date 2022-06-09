using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class ComputerShop
    {
        IFactory _factory;

        public ComputerShop(IFactory factory) => _factory = factory;

        public Computer AssembleComputer() => new Computer(_factory.CreateProcessor(), _factory.CreateHardDisk(), _factory.CreateMonitor());
    }
}
