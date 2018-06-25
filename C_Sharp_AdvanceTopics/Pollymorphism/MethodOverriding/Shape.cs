using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.MethodOverriding
{
    /*
     * Method overriding or also known as Polymorphism
     * Method overriding allows us to override the behaviours of base class into drived class
     * In C# this Can be Achieved with virtual and override keyword
     * virtual with base class method which be overriden in drived class
     * Override on same method in drived class
     * this provides us loose coupling
     * Like in future if need a new shape you will just have to add new class drived from shape and then override the behavoir of the method
     * */
    class Shape
    {
        /*
         * Like we have here Draw class and any drived class may need to override it's definition
         * */
        public virtual void Draw() {
            Console.Write("Draw shape");
        }
    }
    class Circle:Shape
    {
        /*
         * While overriding the method in the drived class you can not change the signature(signature includes Access modifier,return type,name, and number/type of arguments )
         * */
        public override void Draw()
        {
            // base.Draw();
            //return 1;
            Console.WriteLine("Draw Circle");
        }
    }
    class Rectangle:Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw Rectangle");
        }
    }
}
