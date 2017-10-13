using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceEfAConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      MultiDbEntities mEntities = new MultiDbEntities();
      mEntities.Database.Log = (log) => Console.WriteLine(log);


      #region MyRegion

      //Account sa1 = new SavingAccount { AccountNumber = 104, HoldersName = "jeff", Balance = 2000.21m };
      //Account ca1 = new SavingAccount { AccountNumber = 204, HoldersName = "sandy", Balance = 9000.21m };
      //Account sa2 = new SavingAccount { AccountNumber = 106, HoldersName = "ramo", Balance = 8000.21m };
      //Account ca2 = new SavingAccount { AccountNumber = 109, HoldersName = "tarence", Balance = 5000.21m };
      //Account sa3 = new SavingAccount { AccountNumber = 209, HoldersName = "lewis", Balance = 4000.21m };
      //Account ca3 = new SavingAccount { AccountNumber = 105, HoldersName = "manto", Balance = 3000.21m };
      //Account sa4 = new SavingAccount { AccountNumber = 205, HoldersName = "kiyo", Balance = 7600.21m };
      //Account ca4 = new SavingAccount { AccountNumber = 206, HoldersName = "simran", Balance = 8200.21m };

      //mEntities.Accounts.Add(sa1);
      //mEntities.Accounts.Add(ca1);
      //mEntities.Accounts.Add(sa2);
      //mEntities.Accounts.Add(ca2);
      //mEntities.Accounts.Add(sa3);
      //mEntities.Accounts.Add(ca3);
      //mEntities.Accounts.Add(sa4);
      //mEntities.Accounts.Add(ca4);

      //int recEffected = mEntities.SaveChanges();
      //Console.WriteLine($"{recEffected} - Records Inserted Successfully...");


      var result = (from a in mEntities.Accounts
                    select a).ToList();

      foreach (var item in result)
      {
        Console.WriteLine($"{item}, and Account type : {item.GetType().Name}");
      }

      #endregion
    }
  }
}
