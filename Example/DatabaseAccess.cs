using System.Data.SQLite;
using Dapper;

public static class DatabaseAccess
{
    private static SQLiteConnection? _dbConnection;

    public static void CreateAndOpenDb()
    {
        var dbFilePath = "./TestDb.sqlite";
        if (!File.Exists(dbFilePath))
        {
            SQLiteConnection.CreateFile(dbFilePath);
        }
        _dbConnection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", dbFilePath));
        _dbConnection.Open();
    }

    public static List<Customer> GetCustomers()
    {
        return _dbConnection.Query<Customer>("SELECT * FROM Customer").ToList();
    }
}