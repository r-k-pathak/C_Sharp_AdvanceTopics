using AssemblyForInternal;
using C_Sharp_AdvanceTopics.Section1.Exercise_Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.AccessModifiers
{
    /*
     * In C# There are Five Types of Access Modifiers
     * Access modifiers are used to define accesiblity or visibility of class and of it's members
     * public:-Accessbile anywhere(withing or outside of assembly)
     * private :-Accissible onyl within the class
     * Protected:-Accessible within the class as well as in immediate next derived class
     * Internal :-Accessible anywhere within the assebly
     * Protected Internal:Accessibl within the assembly as well as in immediate next derived class
     * Priavte Protected: inside same class or in side derived class in same assembly valid in 7.2 or later version.
     * Top level types can only have Public or Internal Accessiblity levels
     */
     class Product
    {
        AdvancedFeature advancedFeature;
        public Product()
        {
            advancedFeature = new AdvancedFeature();

        }
        public void GetProductDetail()
        {
            advancedFeature.FeatureIntroOutsideAssembly();
            //for Internal
            //Not accesible because this resides in another assebly and have intenal access modifier
            //advancedFeature.FeatureIntroInsideAssembly();

            //For ProtectedInternal
            //Below method can not be accesed as this has protected internal 
            //so this will be accessed either in same class or same assembly derived class or in another assebly inside the derived class
            //advancedFeature.FeatureIntroInsideAssemblyAndNextDerivedClass();
        }
    }
    class RealState:AdvancedFeature
    {
        //Private protected
        private protected string _propertyInfo;
        public void GetLandInfo()
        {
            FeatureIntroInsideAssemblyAndNextDerivedClass();
        }
    }
    class RealState2:RealState
    {
       
            public void GetInfo()
        {
            _propertyInfo = "RealState2";
            FeatureIntroInsideAssemblyAndNextDerivedClass();
        }
    }
}
