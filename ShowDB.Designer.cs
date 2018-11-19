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
            this.btnClose = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dbgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 415);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // dbgrid
            // 
            this.dbgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrid.Location = new System.Drawing.Point(12, 12);
            this.dbgrid.Name = "dbgrid";
            this.dbgrid.Size = new System.Drawing.Size(776, 397);
            this.dbgrid.TabIndex = 2;
            // 
            // ShowDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbgrid);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDB";
            this.Text = "ShowDB";
            this.Load += new System.EventHandler(this.ShowDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.DataGridView dbgrid;
    }
}