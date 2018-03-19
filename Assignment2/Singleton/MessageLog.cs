using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class MessageLog : Log
    {
        DateTime logDate { get; set; }
        public  MessageLog() {
            logDate = DateTime.Now;
        }
        public override void AddLog(string message) { Console.WriteLine(string.Format("Error: {0} at time {1}", message, logDate)); }
    }
}
