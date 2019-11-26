using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_of_Music
{
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void pgrLoadingBar_Click(object sender, EventArgs e)
        {

        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            pgrLoadingBar.Increment(5);
            lblLoading.Text = "loading  " + pgrLoadingBar.Value + "%"; //Changes the text on lblLoading to include the value of pgrLoadingBar
            if (pgrLoadingBar.Value >= pgrLoadingBar.Maximum) //an if statement that checks if pgrLoadingBar's value exceeds its maximum, which causes
            // The timer to stop and frmSplashScreen to open.
            {
                LoadTimer.Stop();
                Hide(); 
                new frmSignIn().Show();
            }
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            
        }

    }
}
