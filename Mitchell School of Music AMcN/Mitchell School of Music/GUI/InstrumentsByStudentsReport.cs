using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_of_Music.GUI
{
    public partial class frmInstrumentsByStudentsReport : Form
    {
        public frmInstrumentsByStudentsReport()
        {
            InitializeComponent();
        }

        private void InstrumentsByStudentsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mitchellMusicDataSet2.Student);

            this.rvStudentInstrument.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void mitchellMusicDataSet2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByInstrumentToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillByInstrument(this.mitchellMusicDataSet2.Student, studentInstrumentToolStripTextBox.Text);
                this.rvStudentInstrument.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByInstrumentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
