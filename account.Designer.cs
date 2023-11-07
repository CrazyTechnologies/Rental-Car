namespace Ayubo_Drive
{
    partial class account
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
            this.Titel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbstaffid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.CheckBox();
            this.Titel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.BackColor = System.Drawing.Color.Teal;
            this.Titel.Controls.Add(this.label23);
            this.Titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titel.Location = new System.Drawing.Point(0, 0);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(491, 85);
            this.Titel.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Location = new System.Drawing.Point(149, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(221, 38);
            this.label23.TabIndex = 3;
            this.label23.Text = "Ayubo Drive";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 14);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(409, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ayubo PVT(Ltd)";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(111, 236);
            this.tbpassword.MaxLength = 10;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(157, 20);
            this.tbpassword.TabIndex = 12;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username  :";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(110, 195);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(157, 20);
            this.tbusername.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Staff ID    :";
            // 
            // tbstaffid
            // 
            this.tbstaffid.Location = new System.Drawing.Point(110, 155);
            this.tbstaffid.Name = "tbstaffid";
            this.tbstaffid.Size = new System.Drawing.Size(157, 20);
            this.tbstaffid.TabIndex = 14;
            this.tbstaffid.TextChanged += new System.EventHandler(this.tbstaffid_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 22);
            this.panel2.TabIndex = 16;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(248, 275);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(104, 23);
            this.btncreate.TabIndex = 23;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.Location = new System.Drawing.Point(409, 309);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 24);
            this.btnback.TabIndex = 24;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Check.Location = new System.Drawing.Point(274, 158);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(38, 13);
            this.Check.TabIndex = 25;
            this.Check.Text = "Check";
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(107, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Maximum 10 characters can be use";
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(274, 240);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(50, 15);
            this.Show.TabIndex = 27;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.CheckedChanged += new System.EventHandler(this.Show_CheckedChanged);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 353);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbstaffid);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.panel1);
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.Titel.ResumeLayout(false);
            this.Titel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbstaffid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label Check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Show;
    }
}