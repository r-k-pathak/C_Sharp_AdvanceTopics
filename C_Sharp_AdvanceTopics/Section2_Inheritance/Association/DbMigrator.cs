using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.Association
{
    class DbMigrator
    {
        /*
         * Now here, DbMigrator has a Logger and we are instantiating it here withing Constructor.
         * so we can acces it's methods here as per their accessiblity level
         */
        private readonly Logger logger;

        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.Log("We are migrating the db");
        }
    }
}
