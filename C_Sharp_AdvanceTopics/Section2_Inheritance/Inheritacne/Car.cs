using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.Inheritacne
{
    class Car:Vehicle
    {
        /* Here we have inherited Vehicle class and in Program.cs you can see that we are access getregistration number method
         * of vehicle with the instance of car class because of inheritance now that member is also available into Car class
         * One more important concept of inheritance that Constructors are never inherited
         * if comment the line before base keyconver on Car constructor you will get compile time message.
         * incase of default contructor or empty constructor you will not see this differnce becuase you not going to
         * initialize any instance member with user values, if you will use parametrised contructor in parent class
         * Then try to derive class from that parent with empty constructor or parameterised contructor without base then you will
         * see that this will now allow you hene this proves that contructors are never inherited.
         */
        //public Car()
        //{

        //}
       
        public Car(string regsitrationNumber):base(regsitrationNumber)
        {
            //this.regsitrationNumber = regsitrationNumber;
        }
        public string GetCarSpecs()
        {
            return "Just dummy sepcs";
        }

    }
    class Car2:Car
    {
        public Car2(string regsitrationNumber) : base(regsitrationNumber)
        {
            //this.regsitrationNumber = regsitrationNumber;
        }
        public string GetCarSpecs()
        {
            GetRegistationNumber();
            return "Just dummy sepcs";
        }
    }
}
