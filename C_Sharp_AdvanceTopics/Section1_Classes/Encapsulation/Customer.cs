using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Encapsulation
{
    class Customer
    {
        /*
         * Encapsulation is also known as Information Hiding
         * Encapsulation is all about put limit to access data member and member functions of a class from outside
         * to Achieve this .net framework has provided us 6 access modifiers
         * Namely:Public ,Private,Protected, Internal and Protected Internal.
         * Here we will cover the concept of Private and rest while covering Inheritance
         */
        private DateTime _birthdate;//Not Accessible to OutSide Directly
        //Below is Property in C#
        public DateTime BirthDate//Can Be Used to Access _birthDate 
        {
            get { return _birthdate; }
           private set { _birthdate = value; }//birthdate can only be set inside the class
        }
      //here we dont want out side world to set age as this is  correct, Age should be calculated based on dateofbirth
      //Now we have'nt defined any field for Age but C# compiler will generate it for us
      public string Name { get; set; }
        public int Age
        {
            get
            {
                var birthDayTimeSpan = DateTime.Today - BirthDate;
                return (birthDayTimeSpan.Days / 365);
            }
         
        }
        public void SetBirthday(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
    }
}
