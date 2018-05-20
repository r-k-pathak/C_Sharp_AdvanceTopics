using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics
{
    class Calculations
    {
        
        public int Add(params int[] numbers)
        {
            int sum = 0; 
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
            
        }
    }
}
