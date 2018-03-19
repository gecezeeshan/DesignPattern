using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public abstract class Log
    {
        public string Message { get; set; }

        public virtual void AddLog(string message) { Console.WriteLine(message); }
    }
}
