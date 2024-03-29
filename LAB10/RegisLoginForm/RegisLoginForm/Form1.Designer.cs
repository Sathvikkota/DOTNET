namespace RegisLoginForm
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
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.loginbutton = new System.Windows.Forms.Button();
            this.regbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regreset = new System.Windows.Forms.Button();
            this.regsubmit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.regbranch = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.regname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regno = new System.Windows.Forms.Label();
            this.ButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonPanel.Controls.Add(this.loginbutton);
            this.ButtonPanel.Controls.Add(this.regbutton);
            this.ButtonPanel.Location = new System.Drawing.Point(-1, 1);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(286, 527);
            this.ButtonPanel.TabIndex = 0;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(28, 130);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(223, 35);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // regbutton
            // 
            this.regbutton.Location = new System.Drawing.Point(28, 77);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(223, 34);
            this.regbutton.TabIndex = 0;
            this.regbutton.Text = "Register";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 301);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "password/SID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(180, 173);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(231, 22);
            this.textBox8.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(180, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(231, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(280, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 539);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.regreset);
            this.panel1.Controls.Add(this.regsubmit);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.regbranch);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.regname);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.regno);
            this.panel1.Location = new System.Drawing.Point(106, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 480);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // regreset
            // 
            this.regreset.Location = new System.Drawing.Point(181, 328);
            this.regreset.Name = "regreset";
            this.regreset.Size = new System.Drawing.Size(157, 34);
            this.regreset.TabIndex = 11;
            this.regreset.Text = "Reset";
            this.regreset.UseVisualStyleBackColor = true;
            this.regreset.Click += new System.EventHandler(this.regreset_Click);
            // 
            // regsubmit
            // 
            this.regsubmit.Location = new System.Drawing.Point(18, 328);
            this.regsubmit.Name = "regsubmit";
            this.regsubmit.Size = new System.Drawing.Size(157, 34);
            this.regsubmit.TabIndex = 2;
            this.regsubmit.Text = "Submit";
            this.regsubmit.UseVisualStyleBackColor = true;
            this.regsubmit.Click += new System.EventHandler(this.regsubmit_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 22);
            this.textBox3.TabIndex = 5;
            // 
            // regbranch
            // 
            this.regbranch.AutoSize = true;
            this.regbranch.Location = new System.Drawing.Point(30, 138);
            this.regbranch.Name = "regbranch";
            this.regbranch.Size = new System.Drawing.Size(41, 16);
            this.regbranch.TabIndex = 4;
            this.regbranch.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 3;
            // 
            // regname
            // 
            this.regname.AutoSize = true;
            this.regname.Location = new System.Drawing.Point(30, 75);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(44, 16);
            this.regname.TabIndex = 2;
            this.regname.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 1;
            // 
            // regno
            // 
            this.regno.AutoSize = true;
            this.regno.Location = new System.Drawing.Point(30, 21);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(68, 16);
            this.regno.TabIndex = 0;
            this.regno.Text = "Student ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 527);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ButtonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regreset;
        private System.Windows.Forms.Button regsubmit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label regbranch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label regname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label regno;
    }
}

