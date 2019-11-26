namespace Mitchell_School_of_Music
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateTuitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialistWeekendSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialistSummerSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnBrowseStudents = new System.Windows.Forms.Button();
            this.gpbxStudentDirectory = new System.Windows.Forms.GroupBox();
            this.btnBrowseRepairs = new System.Windows.Forms.Button();
            this.gpbxRepairs = new System.Windows.Forms.GroupBox();
            this.gpbxRental = new System.Windows.Forms.GroupBox();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnBrowseRentals = new System.Windows.Forms.Button();
            this.gpbxInstruments = new System.Windows.Forms.GroupBox();
            this.btnAddInstrument = new System.Windows.Forms.Button();
            this.btnBrowseInstruments = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gpbxStudentDirectory.SuspendLayout();
            this.gpbxRepairs.SuspendLayout();
            this.gpbxRental.SuspendLayout();
            this.gpbxInstruments.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAddNewUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspAddNewUser
            // 
            this.tspAddNewUser.Name = "tspAddNewUser";
            this.tspAddNewUser.Size = new System.Drawing.Size(94, 20);
            this.tspAddNewUser.Text = "Add New User";
            this.tspAddNewUser.Click += new System.EventHandler(this.tspAddNewUser_Click);
            // 
            // rentalToolStripMenuItem
            // 
            this.rentalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.rentalToolStripMenuItem.Text = "Instrument Rental";
            this.rentalToolStripMenuItem.Click += new System.EventHandler(this.rentalToolStripMenuItem_Click);
            // 
            // eventManagementToolStripMenuItem
            // 
            this.eventManagementToolStripMenuItem.Name = "eventManagementToolStripMenuItem";
            this.eventManagementToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.eventManagementToolStripMenuItem.Text = "Event Management";
            // 
            // tuitionToolStripMenuItem
            // 
            this.tuitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateTuitionToolStripMenuItem,
            this.specialistWeekendSchoolToolStripMenuItem,
            this.specialistSummerSchoolToolStripMenuItem});
            this.tuitionToolStripMenuItem.Name = "tuitionToolStripMenuItem";
            this.tuitionToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tuitionToolStripMenuItem.Text = "Tuition";
            // 
            // privateTuitionToolStripMenuItem
            // 
            this.privateTuitionToolStripMenuItem.Name = "privateTuitionToolStripMenuItem";
            this.privateTuitionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.privateTuitionToolStripMenuItem.Text = "Private Tuition";
            // 
            // specialistWeekendSchoolToolStripMenuItem
            // 
            this.specialistWeekendSchoolToolStripMenuItem.Name = "specialistWeekendSchoolToolStripMenuItem";
            this.specialistWeekendSchoolToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.specialistWeekendSchoolToolStripMenuItem.Text = "Specialist Weekend School";
            // 
            // specialistSummerSchoolToolStripMenuItem
            // 
            this.specialistSummerSchoolToolStripMenuItem.Name = "specialistSummerSchoolToolStripMenuItem";
            this.specialistSummerSchoolToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.specialistSummerSchoolToolStripMenuItem.Text = "Specialist Summer School";
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.BackColor = System.Drawing.Color.Gray;
            this.btnAddRepair.Location = new System.Drawing.Point(1, 36);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(99, 58);
            this.btnAddRepair.TabIndex = 2;
            this.btnAddRepair.Text = "Add Tuition Details";
            this.btnAddRepair.UseVisualStyleBackColor = false;
            this.btnAddRepair.Click += new System.EventHandler(this.btnAddRepair_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Gray;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 30);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 58);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add New Event";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Gray;
            this.btnSignOut.Location = new System.Drawing.Point(263, 408);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(78, 33);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // btnBrowseStudents
            // 
            this.btnBrowseStudents.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseStudents.Location = new System.Drawing.Point(106, 30);
            this.btnBrowseStudents.Name = "btnBrowseStudents";
            this.btnBrowseStudents.Size = new System.Drawing.Size(99, 58);
            this.btnBrowseStudents.TabIndex = 6;
            this.btnBrowseStudents.Text = "Manage Events";
            this.btnBrowseStudents.UseVisualStyleBackColor = false;
            this.btnBrowseStudents.Click += new System.EventHandler(this.btnBrowseStudents_Click);
            // 
            // gpbxStudentDirectory
            // 
            this.gpbxStudentDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbxStudentDirectory.Controls.Add(this.btnAddStudent);
            this.gpbxStudentDirectory.Controls.Add(this.btnBrowseStudents);
            this.gpbxStudentDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbxStudentDirectory.Location = new System.Drawing.Point(359, 260);
            this.gpbxStudentDirectory.Name = "gpbxStudentDirectory";
            this.gpbxStudentDirectory.Size = new System.Drawing.Size(205, 122);
            this.gpbxStudentDirectory.TabIndex = 7;
            this.gpbxStudentDirectory.TabStop = false;
            this.gpbxStudentDirectory.Text = "              Event Management                     ";
            this.gpbxStudentDirectory.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBrowseRepairs
            // 
            this.btnBrowseRepairs.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseRepairs.Location = new System.Drawing.Point(106, 36);
            this.btnBrowseRepairs.Name = "btnBrowseRepairs";
            this.btnBrowseRepairs.Size = new System.Drawing.Size(99, 58);
            this.btnBrowseRepairs.TabIndex = 8;
            this.btnBrowseRepairs.Text = "Browse Tuition Records";
            this.btnBrowseRepairs.UseVisualStyleBackColor = false;
            this.btnBrowseRepairs.Click += new System.EventHandler(this.btnBrowseRepairs_Click);
            // 
            // gpbxRepairs
            // 
            this.gpbxRepairs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbxRepairs.Controls.Add(this.btnAddRepair);
            this.gpbxRepairs.Controls.Add(this.btnBrowseRepairs);
            this.gpbxRepairs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbxRepairs.Location = new System.Drawing.Point(358, 103);
            this.gpbxRepairs.Name = "gpbxRepairs";
            this.gpbxRepairs.Size = new System.Drawing.Size(205, 122);
            this.gpbxRepairs.TabIndex = 9;
            this.gpbxRepairs.TabStop = false;
            this.gpbxRepairs.Text = "                   Private Tuition                     ";
            // 
            // gpbxRental
            // 
            this.gpbxRental.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbxRental.Controls.Add(this.btnAddForm);
            this.gpbxRental.Controls.Add(this.btnBrowseRentals);
            this.gpbxRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbxRental.Location = new System.Drawing.Point(47, 103);
            this.gpbxRental.Name = "gpbxRental";
            this.gpbxRental.Size = new System.Drawing.Size(205, 122);
            this.gpbxRental.TabIndex = 10;
            this.gpbxRental.TabStop = false;
            this.gpbxRental.Text = "        Instrument Rental Service                     ";
            // 
            // btnAddForm
            // 
            this.btnAddForm.BackColor = System.Drawing.Color.Gray;
            this.btnAddForm.Location = new System.Drawing.Point(1, 36);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(99, 58);
            this.btnAddForm.TabIndex = 2;
            this.btnAddForm.Text = "Add students, rentals and Repairs";
            this.btnAddForm.UseVisualStyleBackColor = false;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnBrowseRentals
            // 
            this.btnBrowseRentals.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseRentals.Location = new System.Drawing.Point(106, 36);
            this.btnBrowseRentals.Name = "btnBrowseRentals";
            this.btnBrowseRentals.Size = new System.Drawing.Size(99, 58);
            this.btnBrowseRentals.TabIndex = 8;
            this.btnBrowseRentals.Text = "Browse All Rental Tables";
            this.btnBrowseRentals.UseVisualStyleBackColor = false;
            this.btnBrowseRentals.Click += new System.EventHandler(this.btnBrowseRentals_Click);
            // 
            // gpbxInstruments
            // 
            this.gpbxInstruments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbxInstruments.Controls.Add(this.btnAddInstrument);
            this.gpbxInstruments.Controls.Add(this.btnBrowseInstruments);
            this.gpbxInstruments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbxInstruments.Location = new System.Drawing.Point(46, 260);
            this.gpbxInstruments.Name = "gpbxInstruments";
            this.gpbxInstruments.Size = new System.Drawing.Size(205, 122);
            this.gpbxInstruments.TabIndex = 11;
            this.gpbxInstruments.TabStop = false;
            this.gpbxInstruments.Text = "      Weekend and Summer School                     ";
            // 
            // btnAddInstrument
            // 
            this.btnAddInstrument.BackColor = System.Drawing.Color.Gray;
            this.btnAddInstrument.Location = new System.Drawing.Point(1, 36);
            this.btnAddInstrument.Name = "btnAddInstrument";
            this.btnAddInstrument.Size = new System.Drawing.Size(99, 58);
            this.btnAddInstrument.TabIndex = 2;
            this.btnAddInstrument.Text = "Add New Class";
            this.btnAddInstrument.UseVisualStyleBackColor = false;
            this.btnAddInstrument.Click += new System.EventHandler(this.btnAddInstrument_Click);
            // 
            // btnBrowseInstruments
            // 
            this.btnBrowseInstruments.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseInstruments.Location = new System.Drawing.Point(106, 36);
            this.btnBrowseInstruments.Name = "btnBrowseInstruments";
            this.btnBrowseInstruments.Size = new System.Drawing.Size(99, 58);
            this.btnBrowseInstruments.TabIndex = 8;
            this.btnBrowseInstruments.Text = "View and Edit Class Details";
            this.btnBrowseInstruments.UseVisualStyleBackColor = false;
            this.btnBrowseInstruments.Click += new System.EventHandler(this.btnBrowseInstruments_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(248, 45);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(120, 29);
            this.lblMainMenu.TabIndex = 12;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.gpbxInstruments);
            this.Controls.Add(this.gpbxRental);
            this.Controls.Add(this.gpbxRepairs);
            this.Controls.Add(this.gpbxStudentDirectory);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbxStudentDirectory.ResumeLayout(false);
            this.gpbxRepairs.ResumeLayout(false);
            this.gpbxRental.ResumeLayout(false);
            this.gpbxInstruments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateTuitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialistWeekendSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialistSummerSchoolToolStripMenuItem;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnBrowseStudents;
        private System.Windows.Forms.GroupBox gpbxStudentDirectory;
        private System.Windows.Forms.Button btnBrowseRepairs;
        private System.Windows.Forms.GroupBox gpbxRepairs;
        private System.Windows.Forms.GroupBox gpbxRental;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnBrowseRentals;
        private System.Windows.Forms.GroupBox gpbxInstruments;
        private System.Windows.Forms.Button btnAddInstrument;
        private System.Windows.Forms.Button btnBrowseInstruments;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tspAddNewUser;
    }
}