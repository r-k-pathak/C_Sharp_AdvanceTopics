using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance
{
    class Vehicle
    {
        private readonly string regsitrationNumber;
        static string a = "";
   
       public Vehicle(string regsitrationNumber)
        {
            this.regsitrationNumber = regsitrationNumber;
            
        }
        public string GetRegistationNumber()
        {
            return this.regsitrationNumber;
        }
       
    }
}
