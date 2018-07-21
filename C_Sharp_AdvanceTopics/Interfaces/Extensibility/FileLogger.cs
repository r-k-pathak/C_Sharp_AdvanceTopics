using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp_AdvanceTopics.Interfaces.Extensibility.Enums;

namespace C_Sharp_AdvanceTopics.Interfaces.Extensibility
{
    
        class FileLogger : ILogger
        {
            private readonly string _filePath;
            public FileLogger(string filePath)
            {
                _filePath = filePath;
            }
            public void LogError(string message)
            {
                LogMessages(message, LogType.Error.ToString());
            }

            private void LogMessages(string message, string messagetype)
            {
                using (StreamWriter streamWriter = new StreamWriter(_filePath, true))
            {
                streamWriter.WriteLineAsync(messagetype + " : " + message);
            }
                
            }

            public void LogInfo(string message)
            {
                LogMessages(message, LogType.Info.ToString());
            }
        }
    
}
