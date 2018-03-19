using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DesignPattern.Singleton;
using DesignPattern.FactoryPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = Singleton.Singleton.getLogger();
            log.AddLog("test");
            Thread.Sleep(1000);
            log = Singleton.Singleton.getLogger();
            log.AddLog("test1");
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(2000);
            log = Singleton.Singleton.getLogger();
            log.AddLog("test2");

            FactoryRun();


            Console.Read();
        }

        public static void FactoryRun()
        {
            IProduct product;
            FruitFactory factory = new FruitFactory();
            product = factory.CreateFruit("apple");
            Console.WriteLine(string.Format("{0} is available", product.getName()));
            product = factory.CreateFruit("orange");
            Console.WriteLine(string.Format("{0} is available", product.getName()));
            product = factory.CreateFruit("mango");
            Console.WriteLine(string.Format("{0} is available", product.getName()));
            Console.WriteLine("Fun with random numbers");
            for (int i = 0; i < 10; i++)
            {
                product = factory.CreateFruit();
                Console.WriteLine(string.Format("{0} is available", product.getName()));
                Thread.Sleep(500);
            }
        }
    }
}
