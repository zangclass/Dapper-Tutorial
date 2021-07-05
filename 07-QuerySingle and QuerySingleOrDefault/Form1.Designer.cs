namespace _07_QuerySingle_and_QuerySingleOrDefault
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
            this.btnQuerySingleOrDefault = new System.Windows.Forms.Button();
            this.btnQuerySingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuerySingleOrDefault
            // 
            this.btnQuerySingleOrDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuerySingleOrDefault.Location = new System.Drawing.Point(12, 100);
            this.btnQuerySingleOrDefault.Name = "btnQuerySingleOrDefault";
            this.btnQuerySingleOrDefault.Size = new System.Drawing.Size(380, 82);
            this.btnQuerySingleOrDefault.TabIndex = 3;
            this.btnQuerySingleOrDefault.Text = "QuerySingleOrDefault";
            this.btnQuerySingleOrDefault.UseVisualStyleBackColor = true;
            this.btnQuerySingleOrDefault.Click += new System.EventHandler(this.btnQuerySingleOrDefault_Click);
            // 
            // btnQuerySingle
            // 
            this.btnQuerySingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuerySingle.Location = new System.Drawing.Point(12, 12);
            this.btnQuerySingle.Name = "btnQuerySingle";
            this.btnQuerySingle.Size = new System.Drawing.Size(380, 82);
            this.btnQuerySingle.TabIndex = 2;
            this.btnQuerySingle.Text = "QuerySingle";
            this.btnQuerySingle.UseVisualStyleBackColor = true;
            this.btnQuerySingle.Click += new System.EventHandler(this.btnQuerySingle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 196);
            this.Controls.Add(this.btnQuerySingleOrDefault);
            this.Controls.Add(this.btnQuerySingle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuerySingleOrDefault;
        private System.Windows.Forms.Button btnQuerySingle;
    }
}

