using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTableToSingleTableConApp
{
  public partial class Employee
  {
    public override string ToString()
    {
      return string.Format($"{EmployeeID},{FirstName},{LastName},{Salary}");
    }

  }
}
