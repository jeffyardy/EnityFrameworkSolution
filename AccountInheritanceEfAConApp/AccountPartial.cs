using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceEfAConApp
{
  public partial class Account
  {
    public override string ToString()
    {
      return string.Format($"get account no {AccountNumber}, holders name : {HoldersName}, balance: {Balance}");
    }
  }
}
