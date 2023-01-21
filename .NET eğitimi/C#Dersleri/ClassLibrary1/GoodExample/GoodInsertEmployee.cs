using ClassLibrary1.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.GoodExample
{
    public class GoodInsertEmployee
    {
        GoodLogger logger;

        public GoodInsertEmployee() => logger = new GoodLogger();

        string log;

        public bool CreatEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(employee.Id);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.AppendLine(employee.LastName);
                sb.AppendLine();
                sb.Append(employee.HireDate);
                sb.AppendLine();

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SOLID\EmployeeData.txt",log);

                log =logger.BuildLog(employee.Id.ToString());
                logger.LogFile(@"C:\SOLID\Log.txt", log);


                return true;
            }

            catch (Exception ex)
            {

                log = logger.BuildLog(ex.Message);
                logger.LogFile(@"C:\\SOLID\\Log.txt\",log);
                return false;
            }
        }
    }
}
