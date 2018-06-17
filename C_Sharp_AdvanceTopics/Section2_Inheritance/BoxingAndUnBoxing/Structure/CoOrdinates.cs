using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.BoxingAndUnBoxing.Structure
{
    //This is dummy class just Used to Explain The concept of struture
    /*
     * 1)It is also an error to initialize an instance field in a struct body. 
     * 2)You can initialize externally accessible struct members only by using a parameterized constructor, the implicit, 
     * default constructor, an object initializer, or by accessing the members individually after the struct is declared.
     * Any private or otherwise inaccessible members require the use of constructors exclusively.
     * 3)When you create a struct object using the new operator, it gets created and the appropriate constructor is called 
     * according to the constructor's signature. Unlike classes, structs can be instantiated without using the new operator.
     * In such a case, there is no constructor call, which makes the allocation more efficient. 
     * However, the fields will remain unassigned and the object cannot be used until all of the fields are initialized.
     * This includes the inability to get or set values through auto-implemented properties.
     * 4)If you instantiate a struct object using the default, parameterless constructor, all members are assigned according 
     * to their default values.
     * 5)When writing a constructor with parameters for a struct, you must explicitly initialize all members; otherwise 
     * one or more members remain unassigned and the struct cannot be used, producing compiler error CS0171.
     * 6)There is no inheritance for structs as there is for classes.A struct cannot inherit from another struct or class, 
     * and it cannot be the base of a class. 
     * Structs, however, inherit from the base class Object.
     *7) A struct can implement interfaces, and it does that exactly as classes do.
     * You cannot declare a class using the keyword struct. In C#, classes and structs are semantically different.
     * A struct is a value type, while a class is a reference type.
     * Unless you need reference-type semantics, a small class may be more efficiently handled by the system 
     * if you declare it as a struct instead.
     */

    public struct OutSideTheClass
    {
        public int a;
        public string b;
        //you can use parameterized constructor to initialize the member or can be explicitly initialized before being used
    }
    class CoOrdinates
    {
        public int t;
        static string k;
        //structure can be declared inside or outside of the class
        public  struct SampleStruct
        {
            public int a;
            public string b;
            //declaring empty constructor inside the stack is not valid.
            public SampleStruct(int a,string b)
            {
                this.a = a;
                this.b = b;
                //Inside the Struct , this is not allowed to initiaze instance member below is an error statement
                //this.t = 7;
                //You can Initialize the class members inside the structure,this is valid in c#
                CoOrdinates.k = "";
                

            }
           
            
        }
        //public static void StaticMethod()
        //{

        //    k = "Rakesh";
        //    Console.WriteLine(k);
            
        //}
        //public void InstanceMethod()

        //{
            
        //    Console.WriteLine(k);
        //    k = "Dinesh";
        //}
        public void PrintstrutureMember()
        {
            //Console.WriteLine(k);
            SampleStruct ttt = new SampleStruct();
            SampleStruct tt;
            //if you don't use new you will have to initialize structure members before using them otherwise it's error
            tt.a = 5;
            Console.WriteLine(tt.a);
            Console.WriteLine(ttt.a);

        }
        public void StrucOutSideTheClass()
        {
            OutSideTheClass sampleStruct;
            sampleStruct.a = 4;
            sampleStruct.b = "Explicit Inicialization";
            Console.WriteLine("a:{0},b:{1}", sampleStruct.a, sampleStruct.b);
        }
        
    }


}
