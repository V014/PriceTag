using System.Data;
using System.Data.SQLite;


namespace Prices
{
    class Connection
    {
        // declare connection variables
        private static SQLiteConnection con;
        private static SQLiteCommand cmd;
        private static DataSet DS = new DataSet();
        private static DataTable DT = new DataTable();

        // connection to database file
        public void setConnection()
        {
            con = new SQLiteConnection("Data Source=prices.db;Version=3;New=Flase;Compress=True;");
        }

        // execute query function
        public void ExecuteQuery(string txtQuery)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SQLiteConnection GetConnection()
        {
            setConnection();
            con.Open();
            return con;
        }

        public string ReadString(string txtQuery)
        {
            using(SQLiteConnection con = GetConnection())
            using (SQLiteCommand cmd = new SQLiteCommand(txtQuery, con))
            {
                object result = cmd.ExecuteScalar();
                return (result == null ? "" : result.ToString());
            }
        }
    }
}
