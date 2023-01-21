using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1.Entity;

namespace ClassLibrary1.BadExample
{
    internal class BadEmployee
    {
        void CreadEmoloyee(Employee employee)
        {
            StringBuilder sb=new StringBuilder();
            try
            {
                #region Çalışan kaydının girilmesini sağlar.

                sb.Append(employee.Id);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.AppendLine(employee.LastName);
                sb.AppendLine();
                sb.Append(employee.HireDate);
                File.WriteAllText(@"C:\SOLID\EmployeeData.txt", sb.ToString());
                #endregion


                #region Çalışanın sisteme giriş yapılması sonucunda doğan logların sisteme kayıt edilmesi.

                sb=new StringBuilder();
                sb.Append("Kayıt Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.Append(employee.Id);
                File.WriteAllText(@"C:\SOLID\Log.txt", sb.ToString());

                #endregion


            }
            catch (Exception ex)
            {
                sb= new StringBuilder();
                sb.Append(ex.Message);
                sb.Append(DateTime.Now.ToString());
                File.WriteAllText(@"C:\SOLID\Log.txt",sb.ToString());

            }
            
            
        }

        
    }
}
