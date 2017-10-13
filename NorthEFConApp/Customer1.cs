using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEFConApp
{
  public partial class Customer
  {
    public override string ToString()
    {
      return string.Format($"{CustomerID} ,{CompanyName},{ContactName},{City},{Country}");
    }
  }
}
