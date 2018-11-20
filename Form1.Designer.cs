namespace ItemDB2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAddItem = new System.Windows.Forms.Button();
            this.btDelItem = new System.Windows.Forms.Button();
            this.btnShowDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAddItem
            // 
            this.btAddItem.Location = new System.Drawing.Point(23, 12);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(188, 75);
            this.btAddItem.TabIndex = 0;
            this.btAddItem.Text = "Add Item";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // btDelItem
            // 
            this.btDelItem.Location = new System.Drawing.Point(235, 12);
            this.btDelItem.Name = "btDelItem";
            this.btDelItem.Size = new System.Drawing.Size(188, 75);
            this.btDelItem.TabIndex = 1;
            this.btDelItem.Text = "Delete Item";
            this.btDelItem.UseVisualStyleBackColor = true;
            this.btDelItem.Click += new System.EventHandler(this.btDelItem_Click);
            // 
            // btnShowDB
            // 
            this.btnShowDB.Location = new System.Drawing.Point(447, 12);
            this.btnShowDB.Name = "btnShowDB";
            this.btnShowDB.Size = new System.Drawing.Size(188, 75);
            this.btnShowDB.TabIndex = 2;
            this.btnShowDB.Text = "Database";
            this.btnShowDB.UseVisualStyleBackColor = true;
            this.btnShowDB.Click += new System.EventHandler(this.btShowDB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 140);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowDB);
            this.Controls.Add(this.btDelItem);
            this.Controls.Add(this.btAddItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Button btDelItem;
        private System.Windows.Forms.Button btnShowDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

