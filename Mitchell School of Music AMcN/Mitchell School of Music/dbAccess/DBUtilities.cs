using Mitchell_School_of_Music.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.dbAccess
{
    public class DBUtilities
    {
        
        private Database db;

        public DBUtilities(Database db)
        {
            this.db = db;
        }

        public List<String> getColsFromTable(string tableName)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT TOP 0 * FROM " + tableName;

            db.Rdr = db.Cmd.ExecuteReader();
            List<String> colNames = new List<String>();

            db.Rdr.Read();
            for (int i = 0; i < db.Rdr.FieldCount; i++)
            {
                colNames.Add(db.Rdr.GetName(i));
            }
            db.Rdr.Close();
            return colNames;
        }

        public List<String> getTablesFromDB()
        {
            String table = db.Conn.Database;

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            db.Rdr = db.Cmd.ExecuteReader();
            List<String> tableNames = new List<string>();

            while (db.Rdr.Read())
            {
                tableNames.Add(db.Rdr.GetString(0));
            }
            db.Rdr.Close();
            return tableNames;
        }

        public void selectAll(String tableName)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM " + tableName;
            db.Rdr = db.Cmd.ExecuteReader();
        }

    }
    
}
