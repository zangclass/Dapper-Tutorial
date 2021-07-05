namespace _08_QueryMultiple
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
            this.btnQueryMultiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQueryMultiple
            // 
            this.btnQueryMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryMultiple.Location = new System.Drawing.Point(12, 12);
            this.btnQueryMultiple.Name = "btnQueryMultiple";
            this.btnQueryMultiple.Size = new System.Drawing.Size(380, 82);
            this.btnQueryMultiple.TabIndex = 3;
            this.btnQueryMultiple.Text = "QueryMultiple";
            this.btnQueryMultiple.UseVisualStyleBackColor = true;
            this.btnQueryMultiple.Click += new System.EventHandler(this.btnQueryMultiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 111);
            this.Controls.Add(this.btnQueryMultiple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueryMultiple;
    }
}

