using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTableToSingleTableConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      MultiDbEntities mEntities = new MultiDbEntities();

      mEntities.Database.Log = (log) => { Console.WriteLine(log); };


      #region insert employee data
      //Employee emp1 = new Employee { EmployeeID = 101, FirstName = "jeff", LastName = "yardy", Salary = 2010.39m };
      //Employee emp2 = new Employee { EmployeeID = 102, FirstName = "sandy", LastName = "rejo", Salary = 5010.39m };
      //Employee emp3 = new Employee { EmployeeID = 103, FirstName = "riya", LastName = "madhav", Salary = 3010.39m };
      //Employee emp4 = new Employee { EmployeeID = 104, FirstName = "jigu", LastName = "kiyo", Salary = 4010.39m };

      //mEntities.Employees.Add(emp1);
      //mEntities.Employees.Add(emp2);
      //mEntities.Employees.Add(emp3);
      //mEntities.Employees.Add(emp4);

      //int recEffected = mEntities.SaveChanges();
      //Console.WriteLine($"{recEffected} - Employee Added.");

      #endregion Insert Employeee


      #region Select employee data
      var result = (from e in mEntities.Employees
                    select e);

      foreach (var item in result)
      {
        Console.WriteLine(item);
      }
      #endregion


    }
  }
}
