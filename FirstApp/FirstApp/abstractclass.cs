using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    //abstract class : it cannot be instantiated
    //abstract class will have abstract as well as non abstract members

    abstract class Animal
    {
        abstract public void run();

        abstract public void eat();

        public void method1()
        {

        }
    }

    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dogs eat dog food");
            //throw new NotImplementedException();
        }
        public override void run()
        {
            Console.WriteLine("Dogs run fast");
            //throw new NotImplementedException();
        }
    }

    class puppy : Dog
    {
        public override void eat()
        {
            Console.WriteLine("eat from puppy");
        }
        public override void run()
        {
            Console.WriteLine("run from puppy");
        }
    }

    class abstractclass
    {
        static void Main(string[] args)
        {
            puppy p = new puppy();
            p.eat();
            p.run();
            Console.Read();
        }
    }
}
