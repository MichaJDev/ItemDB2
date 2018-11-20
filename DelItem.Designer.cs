namespace ItemDB2
{
    partial class DelItem
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btDel = new System.Windows.Forms.Button();
            this.dbgrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(22, 111);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(69, 20);
            this.tbID.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(22, 57);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(136, 21);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(22, 156);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dbgrid
            // 
            this.dbgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrid.Location = new System.Drawing.Point(174, 38);
            this.dbgrid.Name = "dbgrid";
            this.dbgrid.Size = new System.Drawing.Size(614, 362);
            this.dbgrid.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(18, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 20);
            label1.TabIndex = 18;
            label1.Text = "DELETE ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Choose Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Delete ID";
            // 
            // DelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dbgrid);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(350, 50);
            this.Name = "DelItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DelItem";
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGridView dbgrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}