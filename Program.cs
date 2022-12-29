namespace no._5
{
    // C# program to show the
    // working of abstract class
    using System;

    // abstract class 'Animal'
    public abstract class Animal
    {

        // abstract method 'gfg()'
        public abstract void pet();

    }

    // class 'Animal' inherit
    // in child class 'Geek1'
    public class Spider : Animal
    {

        // abstract method 'pet()'
        // declare here with
        // 'override' keyword
        public override void pet()
        {
            Console.WriteLine("Spider not a pet");
        }
    }

    public class Cat : Animal
    {

        // abstract method 'pet()'
        // declare here with
        // 'override' keyword
        public override void pet()
        {
            Console.WriteLine("Cat is pet");
        }
    }
    // class 'GeeksForGeeks' inherit in
    // another child class 'Geek2'
    public class Fish : Animal
    {

        // same as the previous class
        public override void pet()
        {
            Console.WriteLine("Fish is a pet ");
        }
    }

    // Driver Class
    public class main_method
    {

        // Main Method
        public static void Main()
        {

            // 'g' is object of class
            // 'Animal' class '
            // Animal' cannot
            // be instantiate
            Animal g;

            // instantiate class 'Geek1'
            g = new Spider();

            // call 'gfg()' of class 'Geek1'
            g.pet();

            // instantiate class 'Geek2'
            g = new Cat();

            // call 'pet()' of class 'Geek2'
            g.pet();

            g = new Fish();

            // call 'pet()' of class 'Geek2'
            g.pet();

        }
    }

}