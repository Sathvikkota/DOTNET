namespace lab11
{
    partial class Form2
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
            this.buttonAddEmployees = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddEmployees
            // 
            this.buttonAddEmployees.Location = new System.Drawing.Point(348, 90);
            this.buttonAddEmployees.Name = "buttonAddEmployees";
            this.buttonAddEmployees.Size = new System.Drawing.Size(140, 23);
            this.buttonAddEmployees.TabIndex = 0;
            this.buttonAddEmployees.Text = "Add Employee";
            this.buttonAddEmployees.UseVisualStyleBackColor = true;
            this.buttonAddEmployees.Click += new System.EventHandler(this.buttonAddEmployees_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(345, 188);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 16);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "display";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonAddEmployees);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddEmployees;
        private System.Windows.Forms.Label labelResult;
    }
}