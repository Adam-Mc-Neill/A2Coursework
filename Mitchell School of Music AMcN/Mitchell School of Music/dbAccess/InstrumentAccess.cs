using Mitchell_School_of_Music.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.dbAccess
{
    class InstrumentAccess
    {
          private Database db;

        public InstrumentAccess(Database db)
        {
            this.db = db;
        }

        public List<Instrument> getAllInstrument()
        {
            List<Instrument> results = new List<Instrument>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Instrument";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getInstrumentFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }       

        public Instrument getInstrumentByID(int id)
        {
            Instrument newInstrument = new Instrument();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Instrument WHERE Instrument ID =" + id;
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                newInstrument = getInstrumentFromReader(db.Rdr);
            }
            db.Rdr.Close();
            return newInstrument;
        }

        public List<Instrument> getInstrumentsByType(string type)
        {
            List<Instrument> results = new List<Instrument>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Instrument WHERE '" + "InstrumentType" + "' = '" + type + "'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getInstrumentFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }
        
        public Instrument getInstrumentFromReader(SqlDataReader reader)
        {
            Instrument newInstrument = new Instrument();
            newInstrument.InstrumentID = reader.GetInt32(0);
            newInstrument.InstrumentType = reader.GetString(1);
            newInstrument.InstrumentName = reader.GetString(2);
            newInstrument.InstrumentBrand = reader.GetString(3);
            newInstrument.StockistID = reader.GetInt32(4);
            newInstrument.InstrumentCost = reader.GetDouble(5);
            newInstrument.DateOfPurchase = reader.GetDateTime(6);
            return newInstrument;
        }

        public void insertInstrument(Instrument i)
        {
            db.Cmd = db.Conn.CreateCommand();//String in apostrophes
            db.Cmd.CommandText = "INSERT INTO Instrument (Instrument ID, Instrument Type, Instrument Name, Instrument Brand, Stockist ID, Instrument Cost, Date Of Purchase) "
                + "VALUES (" + i.InstrumentID + ", '" + i.InstrumentType + "', '" + i.InstrumentName + "', '" + i.InstrumentBrand + "'," + i.StockistID + "," + i.InstrumentCost + "," + i.DateOfPurchase + ")";
            db.Cmd.ExecuteNonQuery();
        }
    }
    
}
