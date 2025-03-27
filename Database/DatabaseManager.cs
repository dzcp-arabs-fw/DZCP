using System;

namespace DZCP.Database
{
    public static class DatabaseManager
    {
        public static IDatabase Database;

        public static void InitializeDatabase(IDatabase database)
        {
            Database = database;
            Database.Connect();
        }
    }

    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
    }
}