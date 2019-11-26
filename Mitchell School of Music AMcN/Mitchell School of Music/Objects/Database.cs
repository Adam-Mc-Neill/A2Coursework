using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Mitchell_School_of_Music.Objects
{
    public class Database
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataReader rdr;

        public Database() {}
        

        public bool connect()
        {
            SqlConnectionStringBuilder scStrBuilder = new SqlConnectionStringBuilder();

            scStrBuilder.DataSource = "(LocalDB)\\v11.0";
            scStrBuilder.IntegratedSecurity = true;
            scStrBuilder.AttachDBFilename = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..\\..\\MitchellMusic.mdf"));
            scStrBuilder.ConnectTimeout = 60;



            //scStrBuilder.DataSource = ".\\sqlexpress";
            //scStrBuilder.InitialCatalog = "ProjectManagement";
            //scStrBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(scStrBuilder.ToString());
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            if (conn.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }
    }
}

    

