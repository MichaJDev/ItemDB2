namespace ItemDB2
{
    partial class ShowDB
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
            System.Windows.Forms.Label label1;
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dbgrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(88, 418);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // dbgrid
            // 
            this.dbgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrid.Location = new System.Drawing.Point(12, 32);
            this.dbgrid.Name = "dbgrid";
            this.dbgrid.Size = new System.Drawing.Size(1219, 374);
            this.dbgrid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(8, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 20);
            label1.TabIndex = 18;
            label1.Text = "DATABASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Choose Type";
            // 
            // ShowDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dbgrid);
            this.Controls.Add(this.cbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 500);
            this.Name = "ShowDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowDB";
            this.Load += new System.EventHandler(this.ShowDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.DataGridView dbgrid;
        private System.Windows.Forms.Label label2;
    }
}