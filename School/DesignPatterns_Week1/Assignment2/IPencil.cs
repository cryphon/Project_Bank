using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal interface IPencil
    {
        bool canWrite { get; }
        void Write(string msg);
        void AfterSharpening();
    }

    internal interface IPencilSharpener { void Sharpen(IPencil pencil); }

}
