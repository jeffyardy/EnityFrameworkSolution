using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthEFConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      NorthwindEntities nEnntities = new NorthwindEntities();

      nEnntities.Database.Log = (log) => Console.WriteLine(log);
      #region Get all customers from city 'London'
      //var result = (from c in nEnntities.Customers
      //              where c.City == "London"
      //              select new { c.CustomerID, c.CompanyName, c.ContactName, c.City, c.Country }).ToList();

      //foreach (var item in result)
      //{
      //  Console.WriteLine(item);
      //}
      #endregion


      #region Insert data

      //Customer cust = new Customer
      //{
      //  CustomerID = "AAA",
      //  CompanyName = "Span",
      //  ContactName = "jeff",
      //  City = "Mumbai",
      //  Country = "India"
      //};

      //nEnntities.Customers.Add(cust);

      //try
      //{
      //  nEnntities.SaveChanges();
      //  Console.WriteLine("Customer added..");
      //}
      //catch (Exception ex)
      //{

      //  Console.WriteLine(ex.ToString());
      //}



      #endregion


      #region Getting data from databae
      var cust = nEnntities.Customers.FirstOrDefault(c => c.CustomerID == "AAA");
      var ord = nEnntities.Orders.FirstOrDefault(c => c.OrderID == 10248);
      Console.WriteLine(cust);
      cust.City = "Bombay123";
      //ord.ShipCity = "Mumbaisfdsfffsdfdsfsdfsfsdfsdf";
      Console.ReadKey(true);
      try
      {
        nEnntities.SaveChanges();
        Console.WriteLine("Rec Updated...");
      }
      catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.ToString());
        var data = ex.Entries.Single();
        var orginalvalues = data.OriginalValues;
        var currentvalues = data.CurrentValues;
        var databasevalues = data.GetDatabaseValues();

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Orginal values \n");
        Console.WriteLine($"\t orginalvalues.getValue<string>('city')-> {orginalvalues.GetValue<string>("City")}");

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Current values \n");
        Console.WriteLine($"\t currentvalue.getValue<string>('city')-> {currentvalues.GetValue<string>("City")}");


        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Database values \n");
        Console.WriteLine($"\t database.getValue<string>('city')-> {databasevalues.GetValue<string>("City")}");

        Console.WriteLine("------------------------------------------------------------------");


        Console.ReadKey(true);
        data.OriginalValues.SetValues(data.GetDatabaseValues());
        nEnntities.SaveChanges();

      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.ToString());
      }

      #endregion


      #region Deleting data

      var Cus = nEnntities.Customers.FirstOrDefault(c => c.CustomerID == "AAA");
      Console.WriteLine(cust);
      Console.WriteLine("Pres any key to delete the customer");
      Console.ReadKey(true);
      nEnntities.Customers.Remove(Cus);
      try
      {
        nEnntities.SaveChanges();
        Console.WriteLine("Customer is deleted");
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.ToString());
      }

      #endregion




    }
  }
}
