using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
   public  class Adapter : Target
    {
        Adaptee ad = new Adaptee();
        public override void Request()
        {
            ad.Request();           
        }
    }
}
