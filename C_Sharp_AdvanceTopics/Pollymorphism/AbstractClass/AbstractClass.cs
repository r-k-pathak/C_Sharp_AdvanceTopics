using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Pollymorphism.AbstractClass
{
    /*
     * The abstract keyword enables you to create classes and class members 
     * that are incomplete and must be implemented in a derived class.
     * An abstract class cannot be instantiated.
     * The purpose of an abstract class is to provide a common definition of a base class 
     * that multiple derived classes can share
     * If a virtual method is declared abstract, it is still virtual to any class inheriting from the abstract class. 
     * A class inheriting an abstract method cannot access the original implementation of the method
     * The abstract modifier can be used with classes, methods, properties, indexers, and events
     * */
   public abstract class Shape
    {
        /**
         * Abstract class can have non abstract member as well but it's not the sole use abstract
         * Abstract says it self it is incomplete.
         * */
        public  int Side { get; set; }
        /*
         * Abstract class can have contructor but can not be instantiated .althought it can perform pollymorphic behaivour
         **/
        public Shape(int Side)
        {
            this.Side = 4;
        }
        public abstract int Area();
    }
    public class Square : Shape
    {
        //public override int Side { get; set; }
        public Square(int side) : base(side) { }
        public override int Area()
        {
            return Side * Side;
        }
    }
}
