using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DesignPattern.Singleton;
using DesignPattern.FactoryPattern;
using Assignment2.Adapter;
using Assignment2.DecoratorPattern;

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

            AdapterRun();

            DecoratorRun();

            Console.Read();
        }

        public static void DecoratorRun()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user

            Console.ReadKey();

        }
        public static void AdapterRun()
        {
            Adapter ad = new Adapter();
            ad.Request();

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
