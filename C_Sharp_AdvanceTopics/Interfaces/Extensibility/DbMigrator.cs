using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp_AdvanceTopics.Interfaces.Extensibility.Enums;

namespace C_Sharp_AdvanceTopics.Interfaces.Extensibility
{
    

    class DbMigrator
    {
        public readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at{0}"+ DateTime.Now);
            _logger.LogError("Migration finished at{0}" + DateTime.Now);
        }
    }
}
