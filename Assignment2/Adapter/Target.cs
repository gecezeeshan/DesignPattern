using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public abstract class Target
    {
        public virtual void Request() {
            Console.WriteLine("request target");
        }
    }
}
