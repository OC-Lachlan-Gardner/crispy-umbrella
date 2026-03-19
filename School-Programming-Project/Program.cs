using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class CafeContext: DbContext
{
    public string DbPath { get; }

    public DbSet<Purchaser> Purchasers { get; set; }

    public DbSet<Item> Items { get; set; }

    public DbSet<Order> Orders { get; set; }

    // Where the database is located.
    public CafeContext()
    {
        DbPath = "cafe.db";
    }

}

// Tables.
public class Item
{
    required public int ItemId { get; set; }
    required public string Name { get; set; }

    required public double Price {get; set;}
}

public class Order
{
    required public int OrderId { get; set; }
    required public string PurchaserID { get; set; }
    required public string Amount { get; set; }
}

public class Purchaser
{
    public int PurchaserID {get; set;}

    public string Name {get; set;}

    public int Count {get; set;}

    public int ReservedTable {get; set;}
}

class Program
{
    static void Main(string[] args)
    {
        using (var db = new CafeContext())
        {
            var Purchser = new Purchaser()
            {
            }
        };

        Console.WriteLine("Succeeded");
    }
}