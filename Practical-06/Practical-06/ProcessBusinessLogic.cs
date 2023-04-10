using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_06
{
    public delegate void Notification();
    internal class ProcessBusinessLogic
    {
        public event Notification ProcessCompleted;

        /// <summary>
        /// Print the result and call OnProcessCompleted method. 
        /// </summary>
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            OnProcessCompleted();
        }

        /// <summary>
        /// Triger event ProcessCompleted, when StartProcess() finish it's execution.
        /// </summary>
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
