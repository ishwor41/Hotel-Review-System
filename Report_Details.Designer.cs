
namespace ReviewSystem_Coursework
{
    partial class Report_Details
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
        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid_report = new System.Windows.Forms.DataGridView();
            this.sort_cmd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_report
            // 
            this.dataGrid_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_report.Location = new System.Drawing.Point(0, 152);
            this.dataGrid_report.Name = "dataGrid_report";
            this.dataGrid_report.RowHeadersWidth = 51;
            this.dataGrid_report.RowTemplate.Height = 24;
            this.dataGrid_report.Size = new System.Drawing.Size(637, 274);
            this.dataGrid_report.TabIndex = 0;
            this.dataGrid_report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_report_CellContentClick);
            // 
            // sort_cmd
            // 
            this.sort_cmd.FormattingEnabled = true;
            this.sort_cmd.Items.AddRange(new object[] {
            " Sort by Name"});
            this.sort_cmd.Location = new System.Drawing.Point(13, 111);
            this.sort_cmd.Name = "sort_cmd";
            this.sort_cmd.Size = new System.Drawing.Size(177, 24);
            this.sort_cmd.TabIndex = 1;
            this.sort_cmd.SelectedIndexChanged += new System.EventHandler(this.sort_cmd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details";
            // 
            // Report_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort_cmd);
            this.Controls.Add(this.dataGrid_report);
            this.Name = "Report_Details";
            this.Size = new System.Drawing.Size(640, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox sort_cmd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGrid_report;
    }
}
