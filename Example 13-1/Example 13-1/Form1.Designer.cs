namespace Example_13_1
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
            this.cmbCursors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCursors
            // 
            this.cmbCursors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursors.FormattingEnabled = true;
            this.cmbCursors.Location = new System.Drawing.Point(48, 88);
            this.cmbCursors.Name = "cmbCursors";
            this.cmbCursors.Size = new System.Drawing.Size(195, 21);
            this.cmbCursors.TabIndex = 0;
            this.cmbCursors.SelectedIndexChanged += new System.EventHandler(this.cmbCursors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Cursors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCursors);
            this.Name = "Form1";
            this.Text = "Example 13-1 (Cursors)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCursors;
        private System.Windows.Forms.Label label1;
    }
}

