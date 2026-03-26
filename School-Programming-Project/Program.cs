using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class CafeContext: DbContext
{
    public DbSet<Purchaser> Purchasers { get; set; }

    public DbSet<Item> Items { get; set; }

    public DbSet<Order> Orders { get; set; }

    // Where the database is located.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=/home/Lachlan/School-Programming-Projects/crispy-umbrella/cafe.d;Mode=ReadWrite");
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

    public Purchaser(int purchaserID, string name, int count, int reservedTable)
    {
        PurchaserID = purchaserID;

        Name = name;

        Count = count;

        ReservedTable = reservedTable;
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (var db = new CafeContext())
        {
            Console.WriteLine("Connection successful.");
            var Purchser = new Purchaser(1, "Lachlan", 1, 4);

            db.Purchasers.Add(Purchser);
            Console.WriteLine("Adding successful");

            db.SaveChanges();
            Console.WriteLine("Saving successful");
        };

        Console.WriteLine("Succeeded");
    }
}