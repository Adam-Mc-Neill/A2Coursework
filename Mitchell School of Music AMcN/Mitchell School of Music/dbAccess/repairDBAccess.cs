using Mitchell_School_of_Music.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.dbAccess
{
    public class RepairDBAccess
    {
        private Database db;

        public RepairDBAccess()
        {
            db = new Database();
        }

        public RepairDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Repairs> getAllRepairs()
        {
            List<Repairs> results = new List<Repairs>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Repair";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getRepairsFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public Repairs getRepairsByID(int id)
        {
            Repairs newRepair = new Repairs();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Repair WHERE RepairNo =" + id;
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                newRepair = getRepairsFromReader(db.Rdr);
            }
            db.Rdr.Close();
            return newRepair;
        }

        public Repairs getRepairsFromReader(SqlDataReader reader)
        {
            Repairs newRepair = new Repairs();
            newRepair.RepairID = reader.GetInt32(0);
            newRepair.RentalID = reader.GetInt32(1);
            newRepair.DamageDetails = reader.GetString(2);
            newRepair.RepairCost = reader.GetDouble(3);
            newRepair.RepairDate = reader.GetDateTime(4);
            newRepair.RepairPaymentDate = reader.GetDateTime(5);
            return newRepair;
        }

        public void insertRepair(Repairs re)
        {
            db.Cmd = db.Conn.CreateCommand();//String in apostrophes
            db.Cmd.CommandText = "INSERT INTO Repairs "
                + "VALUES (" + re.RentalID + ", '" + re.DamageDetails + "' ," + re.RepairCost + "," + "@RepairDate" + "," + "@RepairPaymentDate" + ")";
            db.Cmd.Parameters.AddWithValue("@RepairDate", re.RepairDate);
            db.Cmd.Parameters.AddWithValue("@RepairPaymentDate", re.RepairPaymentDate);
            db.Cmd.ExecuteNonQuery();
        }
    }
}
