using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitchell_School_of_Music.Objects;
using Mitchell_School_of_Music.dbAccess;

namespace Mitchell_School_of_Music
{
    public partial class frmMenu : Form
    {
        private Database db;
        public frmMenu()
        {
            db = new Database();
            if (!db.connect())
            {
                MessageBox.Show("Could not connect to database", "Error");
                Application.Exit();
            }
            InitializeComponent();
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Maintenance, Come Back Later");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseStudents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Maintenance, Come Back Later");
            
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Maintenance, Come Back Later");
            
        }

        private void btnBrowseRepairs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Maintenance, Come Back Later");
            
        }


        private void btnBrowseInstruments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Maintenance, Come Back Later");
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddForm(db).Show();
        }

        private void btnBrowseRentals_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAddInstrument_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Under Maintenance, Come Back Later");
        }

        private void tspAddNewUser_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddUser().Show();
        }
    }
}
