namespace ItemDB2
{
    partial class AddItem
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.cbWorth = new System.Windows.Forms.ComboBox();
            this.tbStam = new System.Windows.Forms.TextBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.tbAgi = new System.Windows.Forms.TextBox();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.tbHas = new System.Windows.Forms.TextBox();
            this.tbMas = new System.Windows.Forms.TextBox();
            this.cbStam = new System.Windows.Forms.CheckBox();
            this.cbStr = new System.Windows.Forms.CheckBox();
            this.cbAgi = new System.Windows.Forms.CheckBox();
            this.cbInt = new System.Windows.Forms.CheckBox();
            this.cbHas = new System.Windows.Forms.CheckBox();
            this.cbMas = new System.Windows.Forms.CheckBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblWorth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 20);
            label1.TabIndex = 17;
            label1.Text = "ADD ITEM";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 57);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(127, 21);
            this.cbType.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(267, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(16, 137);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(267, 20);
            this.tbDesc.TabIndex = 3;
            // 
            // cbWorth
            // 
            this.cbWorth.FormattingEnabled = true;
            this.cbWorth.Location = new System.Drawing.Point(161, 57);
            this.cbWorth.Name = "cbWorth";
            this.cbWorth.Size = new System.Drawing.Size(122, 21);
            this.cbWorth.TabIndex = 4;
            // 
            // tbStam
            // 
            this.tbStam.BackColor = System.Drawing.Color.Gray;
            this.tbStam.Location = new System.Drawing.Point(125, 174);
            this.tbStam.Name = "tbStam";
            this.tbStam.ReadOnly = true;
            this.tbStam.Size = new System.Drawing.Size(158, 20);
            this.tbStam.TabIndex = 5;
            this.tbStam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbStr
            // 
            this.tbStr.BackColor = System.Drawing.Color.Gray;
            this.tbStr.Location = new System.Drawing.Point(125, 212);
            this.tbStr.Name = "tbStr";
            this.tbStr.ReadOnly = true;
            this.tbStr.Size = new System.Drawing.Size(158, 20);
            this.tbStr.TabIndex = 6;
            this.tbStr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbAgi
            // 
            this.tbAgi.BackColor = System.Drawing.Color.Gray;
            this.tbAgi.Location = new System.Drawing.Point(126, 250);
            this.tbAgi.Name = "tbAgi";
            this.tbAgi.ReadOnly = true;
            this.tbAgi.Size = new System.Drawing.Size(158, 20);
            this.tbAgi.TabIndex = 7;
            this.tbAgi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbInt
            // 
            this.tbInt.BackColor = System.Drawing.Color.Gray;
            this.tbInt.Location = new System.Drawing.Point(125, 289);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(158, 20);
            this.tbInt.TabIndex = 8;
            this.tbInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbHas
            // 
            this.tbHas.BackColor = System.Drawing.Color.Gray;
            this.tbHas.Location = new System.Drawing.Point(125, 330);
            this.tbHas.Name = "tbHas";
            this.tbHas.ReadOnly = true;
            this.tbHas.Size = new System.Drawing.Size(158, 20);
            this.tbHas.TabIndex = 9;
            this.tbHas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbMas
            // 
            this.tbMas.BackColor = System.Drawing.Color.Gray;
            this.tbMas.Location = new System.Drawing.Point(125, 371);
            this.tbMas.Name = "tbMas";
            this.tbMas.ReadOnly = true;
            this.tbMas.Size = new System.Drawing.Size(158, 20);
            this.tbMas.TabIndex = 10;
            this.tbMas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // cbStam
            // 
            this.cbStam.AutoSize = true;
            this.cbStam.Location = new System.Drawing.Point(16, 177);
            this.cbStam.Name = "cbStam";
            this.cbStam.Size = new System.Drawing.Size(80, 17);
            this.cbStam.TabIndex = 11;
            this.cbStam.Text = "checkBox1";
            this.cbStam.UseVisualStyleBackColor = true;
            // 
            // cbStr
            // 
            this.cbStr.AutoSize = true;
            this.cbStr.Location = new System.Drawing.Point(16, 215);
            this.cbStr.Name = "cbStr";
            this.cbStr.Size = new System.Drawing.Size(80, 17);
            this.cbStr.TabIndex = 12;
            this.cbStr.Text = "checkBox2";
            this.cbStr.UseVisualStyleBackColor = true;
            // 
            // cbAgi
            // 
            this.cbAgi.AutoSize = true;
            this.cbAgi.Location = new System.Drawing.Point(16, 254);
            this.cbAgi.Name = "cbAgi";
            this.cbAgi.Size = new System.Drawing.Size(80, 17);
            this.cbAgi.TabIndex = 13;
            this.cbAgi.Text = "checkBox3";
            this.cbAgi.UseVisualStyleBackColor = true;
            // 
            // cbInt
            // 
            this.cbInt.AutoSize = true;
            this.cbInt.Location = new System.Drawing.Point(16, 292);
            this.cbInt.Name = "cbInt";
            this.cbInt.Size = new System.Drawing.Size(80, 17);
            this.cbInt.TabIndex = 14;
            this.cbInt.Text = "checkBox4";
            this.cbInt.UseVisualStyleBackColor = true;
            // 
            // cbHas
            // 
            this.cbHas.AutoSize = true;
            this.cbHas.Location = new System.Drawing.Point(16, 333);
            this.cbHas.Name = "cbHas";
            this.cbHas.Size = new System.Drawing.Size(80, 17);
            this.cbHas.TabIndex = 15;
            this.cbHas.Text = "checkBox5";
            this.cbHas.UseVisualStyleBackColor = true;
            // 
            // cbMas
            // 
            this.cbMas.AutoSize = true;
            this.cbMas.Location = new System.Drawing.Point(16, 374);
            this.cbMas.Name = "cbMas";
            this.cbMas.Size = new System.Drawing.Size(80, 17);
            this.cbMas.TabIndex = 16;
            this.cbMas.Text = "checkBox6";
            this.cbMas.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 41);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "label2";
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Location = new System.Drawing.Point(158, 41);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(35, 13);
            this.lblWorth.TabIndex = 19;
            this.lblWorth.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "label4";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(14, 121);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "label5";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 22);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(234, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 22);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWorth);
            this.Controls.Add(this.lblType);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbMas);
            this.Controls.Add(this.cbHas);
            this.Controls.Add(this.cbInt);
            this.Controls.Add(this.cbAgi);
            this.Controls.Add(this.cbStr);
            this.Controls.Add(this.cbStam);
            this.Controls.Add(this.tbMas);
            this.Controls.Add(this.tbHas);
            this.Controls.Add(this.tbInt);
            this.Controls.Add(this.tbAgi);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.tbStam);
            this.Controls.Add(this.cbWorth);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbWorth;
        private System.Windows.Forms.TextBox tbStam;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.TextBox tbAgi;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.TextBox tbHas;
        private System.Windows.Forms.TextBox tbMas;
        private System.Windows.Forms.CheckBox cbStam;
        private System.Windows.Forms.CheckBox cbStr;
        private System.Windows.Forms.CheckBox cbAgi;
        private System.Windows.Forms.CheckBox cbInt;
        private System.Windows.Forms.CheckBox cbHas;
        private System.Windows.Forms.CheckBox cbMas;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblWorth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}