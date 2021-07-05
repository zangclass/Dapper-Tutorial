namespace _06_QueryFirst_and_QueryFirstOrDefult
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
            this.btnQueryFirst = new System.Windows.Forms.Button();
            this.btnQueryFirstOrDefult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQueryFirst
            // 
            this.btnQueryFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryFirst.Location = new System.Drawing.Point(25, 22);
            this.btnQueryFirst.Name = "btnQueryFirst";
            this.btnQueryFirst.Size = new System.Drawing.Size(380, 82);
            this.btnQueryFirst.TabIndex = 0;
            this.btnQueryFirst.Text = "QueryFirst";
            this.btnQueryFirst.UseVisualStyleBackColor = true;
            this.btnQueryFirst.Click += new System.EventHandler(this.btnQueryFirst_Click);
            // 
            // btnQueryFirstOrDefult
            // 
            this.btnQueryFirstOrDefult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryFirstOrDefult.Location = new System.Drawing.Point(25, 110);
            this.btnQueryFirstOrDefult.Name = "btnQueryFirstOrDefult";
            this.btnQueryFirstOrDefult.Size = new System.Drawing.Size(380, 82);
            this.btnQueryFirstOrDefult.TabIndex = 1;
            this.btnQueryFirstOrDefult.Text = "QueryFirstOrDefult";
            this.btnQueryFirstOrDefult.UseVisualStyleBackColor = true;
            this.btnQueryFirstOrDefult.Click += new System.EventHandler(this.btnQueryFirstOrDefult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 213);
            this.Controls.Add(this.btnQueryFirstOrDefult);
            this.Controls.Add(this.btnQueryFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueryFirst;
        private System.Windows.Forms.Button btnQueryFirstOrDefult;
    }
}

