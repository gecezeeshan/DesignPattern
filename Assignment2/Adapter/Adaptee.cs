using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class Adaptee
    {
        public void Request() {
            Console.WriteLine("request adaptee");
        }
    }
}
