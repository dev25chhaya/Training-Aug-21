using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void Notify();  

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; 

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            
            OnProcessCompleted();
        }


        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; 
            bl.StartProcess();
            Console.ReadLine();



        }

        
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }


        
    }
}
