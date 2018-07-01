using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Pollymorphism.Sealed
{
    /*
     * sealed is a keyword which can be applied on class,members and properties.
     * If Sealed is applied on classs then this can be the base class
     * If Sealed is applied on properties then it can not be overriden in derived class.
     * just statement is true for methods as well
     * */
    #region abstract properties and methods
    class FirstClass
    {
        public virtual int PropOne { get; set; }
        public  virtual string PropTwo { get; set; }
        public virtual void MethodOne ()
        {
            Console.WriteLine("Method One of class FirstClass");
        }
        public virtual void MethodTwo()
        {
            Console.WriteLine("Method two of class FirstClass");
        }

    }
    class SecondClass:FirstClass
    {
        public override  sealed  int PropOne { get; set; }
        //PropTwo is not virtual so it's inherited in SecondClass as it is in FirstClass

        public override sealed void MethodOne()
        {
            Console.WriteLine("Method One of class FirstClass is overriden in class Second and marked as sealed");
        }
        //MethodOne is not virtual so it's inherited in SecondClass as it is in FirstClass

    }
    class ThirdClass :SecondClass
    {
        //So below statement is an compile time error because it is declared as sealed in the base class(Second Class)
        //public override int PropOne { get; set; }
        //So below statement is an compile time error because it is declared as sealed in the base class(Second Class)
        //public override void MethodOne()
        //{
        //    Console.WriteLine("Method One of SecondClass is overriden in class thirdClass");
        //}
        //Sealed properties and members cannot be overriden in derived but but they can obiously be used in chield class like below one

        public override void MethodTwo()
        {
            Console.WriteLine("value of PropOn:{0}",PropOne);
            MethodOne();
        }
    }
    #endregion
    #region Shealed Class
    public sealed class ShealedClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    /*
     * so below inheritance is invalide and show compile time error "InheritShealedClass: can not drive from sealed type 'ShealedClass' "
     * */
    //public class InheritShealedClass:ShealedClass
    //{

    //}
    #endregion
}
