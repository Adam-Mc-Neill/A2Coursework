namespace Mitchell_School_of_Music.GUI
{
    partial class frmInstrumentsByStudentsReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvStudentInstrument = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByInstrumentToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentInstrumentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentInstrumentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByInstrumentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mitchellMusicDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDataSet2 = new Mitchell_School_of_Music.MitchellMusicDataSet2();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Mitchell_School_of_Music.MitchellMusicDataSet2TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.fillByInstrumentToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvStudentInstrument
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.studentBindingSource1;
            this.rvStudentInstrument.LocalReport.DataSources.Add(reportDataSource1);
            this.rvStudentInstrument.LocalReport.ReportEmbeddedResource = "Mitchell_School_of_Music.GUI.InstrumentsByStudent.rdlc";
            this.rvStudentInstrument.Location = new System.Drawing.Point(0, 28);
            this.rvStudentInstrument.Name = "rvStudentInstrument";
            this.rvStudentInstrument.Size = new System.Drawing.Size(632, 425);
            this.rvStudentInstrument.TabIndex = 0;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.mitchellMusicDataSet2BindingSource;
            // 
            // fillByInstrumentToolStrip
            // 
            this.fillByInstrumentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInstrumentToolStripLabel,
            this.studentInstrumentToolStripTextBox,
            this.fillByInstrumentToolStripButton});
            this.fillByInstrumentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByInstrumentToolStrip.Name = "fillByInstrumentToolStrip";
            this.fillByInstrumentToolStrip.Size = new System.Drawing.Size(632, 25);
            this.fillByInstrumentToolStrip.TabIndex = 1;
            this.fillByInstrumentToolStrip.Text = "fillByInstrumentToolStrip";
            this.fillByInstrumentToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByInstrumentToolStrip_ItemClicked);
            // 
            // studentInstrumentToolStripLabel
            // 
            this.studentInstrumentToolStripLabel.Name = "studentInstrumentToolStripLabel";
            this.studentInstrumentToolStripLabel.Size = new System.Drawing.Size(102, 22);
            this.studentInstrumentToolStripLabel.Text = "StudentInstrument:";
            // 
            // studentInstrumentToolStripTextBox
            // 
            this.studentInstrumentToolStripTextBox.Name = "studentInstrumentToolStripTextBox";
            this.studentInstrumentToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByInstrumentToolStripButton
            // 
            this.fillByInstrumentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByInstrumentToolStripButton.Name = "fillByInstrumentToolStripButton";
            this.fillByInstrumentToolStripButton.Size = new System.Drawing.Size(88, 22);
            this.fillByInstrumentToolStripButton.Text = "FillByInstrument";
            this.fillByInstrumentToolStripButton.Click += new System.EventHandler(this.fillByInstrumentToolStripButton_Click);
            // 
            // mitchellMusicDataSet2BindingSource
            // 
            this.mitchellMusicDataSet2BindingSource.DataSource = this.mitchellMusicDataSet2;
            this.mitchellMusicDataSet2BindingSource.Position = 0;
            this.mitchellMusicDataSet2BindingSource.CurrentChanged += new System.EventHandler(this.mitchellMusicDataSet2BindingSource_CurrentChanged);
            // 
            // mitchellMusicDataSet2
            // 
            this.mitchellMusicDataSet2.DataSetName = "MitchellMusicDataSet2";
            this.mitchellMusicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataMember = "Student";
            this.StudentBindingSource.DataSource = this.mitchellMusicDataSet2;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frmInstrumentsByStudentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.fillByInstrumentToolStrip);
            this.Controls.Add(this.rvStudentInstrument);
            this.Name = "frmInstrumentsByStudentsReport";
            this.Text = "InstrumentsByStudentsReport";
            this.Load += new System.EventHandler(this.InstrumentsByStudentsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.fillByInstrumentToolStrip.ResumeLayout(false);
            this.fillByInstrumentToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mitchellMusicDataSet2BindingSource;
        private MitchellMusicDataSet2 mitchellMusicDataSet2;
        private System.Windows.Forms.BindingSource StudentBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvStudentInstrument;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private MitchellMusicDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ToolStrip fillByInstrumentToolStrip;
        private System.Windows.Forms.ToolStripLabel studentInstrumentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentInstrumentToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByInstrumentToolStripButton;


    }
}