using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03.Polymorphism
{
    internal class Duck : Bird
    {
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
