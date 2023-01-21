using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.GoodExample
{
    public class GoodLogger
    {
        //public void LogFile(string filePath, string log)
        //{ 
        //    File.WriteAllText(filePath, log);
        //}
        public void LogFile(string filePath, string log) => File.WriteAllText(filePath, log);
        public string BuildLog(string LogInformation)
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("Date: ");
            stringBuilder.Append(DateTime.Now);
            stringBuilder.Append("Log Info: ");
            stringBuilder.Append(LogInformation);
            return stringBuilder.ToString();
        }
    }
}
