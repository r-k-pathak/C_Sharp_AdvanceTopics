using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.Association
{
    class Logger
    {
        /*
         * Logger is here somewhat comming functionality which is going to be used in DbMigrator and Installer Both
         *so we will utilize this with the concept of HAS-A or Composition
         */
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
