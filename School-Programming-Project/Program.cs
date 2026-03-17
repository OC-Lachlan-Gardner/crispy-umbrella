using Microsoft.Data.Sqlite;

class Purchaser
{
    public int PurchaserID;
    public string Name;
    public int Count;
    public string ReservedTable;

    public Purchaser(int purchaserID, string name, int count, string reservedTable)
    {
        PurchaserID = purchaserID;

        Name = name;

        Count = count;

        ReservedTable = reservedTable;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Started");

        using var connection = new SqliteConnection("Data Source=:memory:");

        connection.Open();

        using var command = connection.CreateCommand();

        // Gets all names?
        command.CommandText = """
        CREATE TABLE Purchasers {
            PurchaseID Int64 AUTO_INCREMENT PRIMARY KEY,
            FirstName String NOT NULL,
            Count Int DEFAULT 1,
            ReservedTable String
        }

        CREATE TABLE Orders {
            OrderID Int64 AUTO_INCREMENT PRIMARY KEY
        }
        """;

        using var reader = command.ExecuteReader();

        List<Purchaser> purchasers = new List<Purchaser>();

        // While there are still things to read.
        while (reader.Read())
        {
            int ID = reader.GetInt16(0);
            // The number is the column that the reader returns.
            // Reader outputs everything as a 3d array(?).
            string name = reader.GetString(1);

            int count = reader.GetInt16(2);

            string reservedTable = reader.GetString(3);

            Purchaser newPurchaser = new Purchaser(ID, name, count, reservedTable);

            purchasers.Add(newPurchaser);

        }
        
        foreach (Purchaser purchaser in purchasers)
        {
            Console.Write("ID: {0} ", purchaser.PurchaserID);
            Console.Write("Name: {0} ", purchaser.Name);
            Console.Write("Count: {0} ", purchaser.Count);
            Console.Write("Reserved Table: {0}\n", purchaser.ReservedTable);
        }

        Console.WriteLine("Finished printing purchasers");
    }
}
