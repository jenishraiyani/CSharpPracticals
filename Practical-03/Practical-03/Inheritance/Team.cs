using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03.Inheritance
{
    public class Team : Sponsor
    {
        private string _teamName;

        public Team(string name) { 
            this._teamName = name;
        }
      
        /// <summary>
        /// This method will concate owner and _teamName and return full detail of team
        /// </summary>
        public string printInfo()
        {
            string teamDetails = string.Concat(owner, _teamName);
            return teamDetails;
        }
    }

    
}
