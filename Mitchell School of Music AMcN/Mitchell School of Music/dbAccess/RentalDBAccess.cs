using Mitchell_School_of_Music.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.dbAccess
{
    public class RentalDBAccess
    {
         private Database db;

        public RentalDBAccess()
         {
             db = new Database();
         }

        public RentalDBAccess(Database db)
        {
            this.db = db;
        }

        public List<Rental> getAllRental()
        {
            List<Rental> results = new List<Rental>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Rental";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getRentalFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }       

        public Rental getRentalByID(int id)
        {
            Rental newRental = new Rental();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Rental WHERE RentalNo =" + id;
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                newRental = getRentalFromReader(db.Rdr);
            }
            db.Rdr.Close();
            return newRental;
        }
        
        public Rental getRentalFromReader(SqlDataReader reader)
        {
            Rental newRental = new Rental();
            newRental.RentalID = reader.GetInt32(0);
            newRental.InstrumentID = reader.GetInt32(1);
            newRental.StudentID = reader.GetInt32(2);
            newRental.DateRented = reader.GetDateTime(3);
            newRental.ReturnDate = reader.GetDateTime(4);
            newRental.PaymentDate = reader.GetDateTime(5);
            return newRental;
        }

        public void insertRental(Rental r)
        {
            db.Cmd = db.Conn.CreateCommand();//String in apostrophes
            db.Cmd.CommandText = "INSERT INTO Rental  "
                + "VALUES (" + r.InstrumentID + ", " + r.StudentID + "," + "@DateRented" + "," + "@DateReturned" + "," + "@DatePayed" + ")";
            db.Cmd.Parameters.AddWithValue("@DateRented", r.DateRented);
            db.Cmd.Parameters.AddWithValue("@DateReturned", r.ReturnDate);
            db.Cmd.Parameters.AddWithValue("@DatePayed", r.PaymentDate);
            db.Cmd.ExecuteNonQuery();
        }
    }
}
