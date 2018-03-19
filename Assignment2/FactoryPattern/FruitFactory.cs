using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    public class FruitFactory
    {
        public IProduct CreateFruit(string name) {
            IProduct product = new DefaultProduct();
            if (name == "apple") {
                product = new Apple();
            }
            else if (name == "orange")
            {
                product = new Orange();
            }
            else if(name == "mango")
            {
                product = new Mango();
            }
            else if (name == "banana")
            {
                product = new Banana();
            }
            return product;
        }

        public IProduct CreateFruit()
        {
           
            IProduct product = new DefaultProduct();
            Random r = new Random();
            int number = r.Next(10);
            
            if (number  >= 1 && number <=3) {  
                product = new Apple();
            }
            else if (number >= 4 && number <= 6)
            {
                product = new Orange();
            }
            else if (number >= 6 && number <= 8)
            {
                product = new Mango();
            }
            else if (number >= 9 && number < 10)
            {
                product = new Banana();
            }
            return product;
        }
    }
}
