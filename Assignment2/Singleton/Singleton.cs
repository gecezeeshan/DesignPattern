using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        public static Log logger;
        public static Log getLogger()
        {
            if (logger == null)
            {
                logger = new MessageLog();                
                Console.WriteLine("Instantiate logger");
                return logger;
            }
            else {
                Console.WriteLine("Logger already instantiated");
                return logger;
        }
        }
    }
}
