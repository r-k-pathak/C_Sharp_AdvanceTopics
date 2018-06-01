using System;

namespace AssemblyForInternal
{
    //This class has public Access Modifier so available out the assembly  as well
    public class AdvancedFeature
    {
        //inside this class, this method has internal access specifier so this will only be available within this assembly
        //Internal are mostly used when develop , component which can be referenced or integrated with others
        protected int Year = 0;
       internal  void FeatureIntroInsideAssembly()
        {
            Console.WriteLine("Just for Explation of Concept");
        }
        public void FeatureIntroOutsideAssembly()
        {
            Console.WriteLine("Just for Explation of Concept");
        }
        //Protected Internal:-
        /*
         * Inside the assebly but in  derived class
         */
        protected internal void FeatureIntroInsideAssemblyAndNextDerivedClass()
        {
            this.Year = 2013;
            Console.WriteLine("Just for Explation of Concept");
        }


    }
}
