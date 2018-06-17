using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.Association
{
    class Installer
    {
        /*
         * Now here, Installer has a Logger and we are instantiating it here withing Constructor.
         * so we can acces it's methods here as per their accessiblity level
         */
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }
        public void Install()
        {
            logger.Log("we are installing th appplication");
        }
    }
}
