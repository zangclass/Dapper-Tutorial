namespace _02_Execute_Many
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
            this.btnSaveAddHoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveAddHoc
            // 
            this.btnSaveAddHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSaveAddHoc.Location = new System.Drawing.Point(45, 48);
            this.btnSaveAddHoc.Name = "btnSaveAddHoc";
            this.btnSaveAddHoc.Size = new System.Drawing.Size(204, 45);
            this.btnSaveAddHoc.TabIndex = 7;
            this.btnSaveAddHoc.Text = "Save Excute Many";
            this.btnSaveAddHoc.UseVisualStyleBackColor = true;
            this.btnSaveAddHoc.Click += new System.EventHandler(this.btnSaveAddHoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 123);
            this.Controls.Add(this.btnSaveAddHoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveAddHoc;
    }
}

