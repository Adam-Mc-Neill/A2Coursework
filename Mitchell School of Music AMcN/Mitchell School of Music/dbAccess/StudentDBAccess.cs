using Mitchell_School_of_Music.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music.dbAccess
{
    public class StudentDBAccess
    {
         private Database db;

        public StudentDBAccess()
         {
             db = new Database();
         }

        public StudentDBAccess(Database db)
        {
            this.db = db;  
        }

        public List<Student> getAllStudent()
        {
            List<Student> results = new List<Student>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Student";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getStudentFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }       

        public Student getStudentByID(int id)
        {
            Student newStudent = new Student();
            try
            {
                
                db.Cmd = db.Conn.CreateCommand();
                db.Cmd.CommandText = "SELECT * FROM Student WHERE StudentNo =" + id;
                db.Rdr = db.Cmd.ExecuteReader();
                while (db.Rdr.Read())
                {
                    newStudent = getStudentFromReader(db.Rdr);
                }
                db.Rdr.Close();
                
            }            
            catch(Exception e)
            {
                
            }
            return newStudent;
        }

        public List<Student> getStudentByRentalStatus(string status)
        {
            List<Student> results = new List<Student>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Student WHERE RequiresRental = '" + status + "'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getStudentFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }
        
        public Student getStudentFromReader(SqlDataReader reader)
        {
            Student newStudent = new Student();
            newStudent.StudentID = reader.GetInt32(0);
            newStudent.StudentForename = reader.GetString(1);
            newStudent.StudentSurname = reader.GetString(2);
            newStudent.StudentAddressLine1 = reader.GetString(3);
            if (reader.IsDBNull(4))
            {
                newStudent.StudentAddressLine2 = " ";
            }
            else
            {
                newStudent.StudentAddressLine2 = reader.GetString(4);
            }
            newStudent.StudentCity = reader.GetString(5);
            newStudent.StudentPostCode = reader.GetString(6);
            newStudent.StudentPhone = reader.GetString(7);
            newStudent.StudentGender = reader.GetString(8);
            newStudent.StudentInstrument = reader.GetString(9);
            newStudent.StudentRequiresRental = reader.GetString(10);
            
            return newStudent;
        }
        //public int generateNewID()
        //{
        //    List<Student> students = new List<Student>();
        //    int ID = 1;
        //    //try
        //    //{
        //        students = getAllStudent();
        //    //}
        //    //catch
        //    //{
        //       // students = new List<Student>();
        //    //}
            
        //    if (students.Count > 0)
        //    {
        //        int lastID = students[students.Count - 1].StudentID;
        //        ID = lastID + 1;
        //    }           

        //    return ID;
        //}

        public void insertStudent(Student s)
        {
            db.Cmd = db.Conn.CreateCommand();//String in apostrophes
            db.Cmd.CommandText = "INSERT INTO Student "
                + "VALUES ('" + s.StudentForename + "', '" + s.StudentSurname + "', '" + s.StudentAddressLine1 + "','" + s.StudentAddressLine2 + "','" + s.StudentCity + "','" + s.StudentPostCode + "','" + s.StudentPhone + "', '" + s.StudentGender.ToString() + "','" + s.StudentInstrument + "','" + s.StudentRequiresRental.ToString() + "')";
            db.Cmd.ExecuteNonQuery(); 
        }
    }
}
