using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstEfConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      MultiDbModelContainer mcontainer = new MultiDbModelContainer();

      mcontainer.Database.Log = (log) => Console.WriteLine(log);


      #region Insert data in table
      //Member m1 = new Member { MemberName = "jeff" };
      //Member m2 = new Member { MemberName = "sandy" };
      //Member m3 = new Member { MemberName = "jiya" };
      //Member m4 = new Member { MemberName = "reshma" };

      //Game g1 = new Game { GameName = "cricket" };
      //Game g2 = new Game { GameName = "football" };
      //Game g3 = new Game { GameName = "soccer" };
      //Game g4 = new Game { GameName = "chess" };


      //m1.Games.Add(g1);
      //m1.Games.Add(g2);

      //m2.Games.Add(g2);

      //m3.Games.Add(g3);
      //m3.Games.Add(g4);

      //m4.Games.Add(g4);


      //mcontainer.Members.Add(m1);
      //mcontainer.Members.Add(m2);
      //mcontainer.Members.Add(m3);
      //mcontainer.Members.Add(m4);
      //int recEffected = mcontainer.SaveChanges();
      //Console.WriteLine($"{recEffected} - Member and Games inserted.");

      #endregion


      #region MyRegion
      //var result = (from m in mcontainer.Members
      //              select m);


      foreach (var item in mcontainer.Members)
      {
        Console.WriteLine($"Name: {item.MemberName}");
        foreach (var gg in item.Games)
        {
          Console.WriteLine($"\tGame:{gg.GameName}, Fess:{gg.Fees}");
        }
      }
          
      #endregion

    }
  }
}
