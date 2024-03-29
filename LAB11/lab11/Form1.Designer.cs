namespace lab11
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
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.listBoxFonts = new System.Windows.Forms.ListBox();
            this.labelFontPreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Location = new System.Drawing.Point(500, 63);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 24);
            this.comboBoxShape.TabIndex = 0;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // listBoxFonts
            // 
            this.listBoxFonts.FormattingEnabled = true;
            this.listBoxFonts.ItemHeight = 16;
            this.listBoxFonts.Location = new System.Drawing.Point(500, 145);
            this.listBoxFonts.Name = "listBoxFonts";
            this.listBoxFonts.Size = new System.Drawing.Size(120, 84);
            this.listBoxFonts.TabIndex = 1;
            this.listBoxFonts.SelectedIndexChanged += new System.EventHandler(this.listBoxFonts_SelectedIndexChanged);
            // 
            // labelFontPreview
            // 
            this.labelFontPreview.AutoSize = true;
            this.labelFontPreview.Location = new System.Drawing.Point(564, 236);
            this.labelFontPreview.Name = "labelFontPreview";
            this.labelFontPreview.Size = new System.Drawing.Size(44, 16);
            this.labelFontPreview.TabIndex = 2;
            this.labelFontPreview.Text = "label1";
            this.labelFontPreview.Click += new System.EventHandler(this.labelFontPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFontPreview);
            this.Controls.Add(this.listBoxFonts);
            this.Controls.Add(this.comboBoxShape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.ListBox listBoxFonts;
        private System.Windows.Forms.Label labelFontPreview;
    }
}

