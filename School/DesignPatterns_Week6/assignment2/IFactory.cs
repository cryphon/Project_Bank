﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface IFactory
    {
        IProcessor CreateProcessor();
        IHardDisk CreateHardDisk();
        IMonitor CreateMonitor();
    }
}