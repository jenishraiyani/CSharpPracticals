using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03.Polymorphism
{
    internal class Bird
    {
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
}
