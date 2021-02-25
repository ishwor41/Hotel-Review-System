
namespace ReviewSystem_Coursework
{
    partial class addOfCriteria
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCriteria_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.criteria_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.criteria_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Criteria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addCriteria_txt
            // 
            this.addCriteria_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addCriteria_txt.Location = new System.Drawing.Point(138, 24);
            this.addCriteria_txt.Name = "addCriteria_txt";
            this.addCriteria_txt.Size = new System.Drawing.Size(222, 30);
            this.addCriteria_txt.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_btn.Location = new System.Drawing.Point(380, 24);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(155, 34);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // import_btn
            // 
            this.import_btn.Location = new System.Drawing.Point(441, 434);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(84, 40);
            this.import_btn.TabIndex = 3;
            this.import_btn.Text = "import";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // criteria_grid
            // 
            this.criteria_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criteria_grid.Location = new System.Drawing.Point(3, 87);
            this.criteria_grid.Name = "criteria_grid";
            this.criteria_grid.RowHeadersWidth = 51;
            this.criteria_grid.RowTemplate.Height = 24;
            this.criteria_grid.Size = new System.Drawing.Size(581, 341);
            this.criteria_grid.TabIndex = 4;
            // 
            // addOfCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.criteria_grid);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.addCriteria_txt);
            this.Controls.Add(this.label1);
            this.Name = "addOfCriteria";
            this.Size = new System.Drawing.Size(603, 512);
            this.Load += new System.EventHandler(this.addOfCriteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criteria_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addCriteria_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.DataGridView criteria_grid;
    }
}
