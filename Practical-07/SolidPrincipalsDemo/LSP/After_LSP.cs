using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.LSP
{
  public interface IStaff
    {
        string GetSalary();

    }
  public class LSPDeveloper: IStaff
    {
        public string GetSalary()
        {
            return "45000";
        }

    }

  public class LSPTester : IStaff
    {
        public string GetSalary()
        {
            return "40000";
        }
    }

}
