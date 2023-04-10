using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.LSP
{
    public class Developer
    {
        public virtual string GetSalary()
        {
            return "45000";
        }
    }
    public class Tester : Developer
    {
        public override string GetSalary()
        {
            return "40000";
        }
    }

}
