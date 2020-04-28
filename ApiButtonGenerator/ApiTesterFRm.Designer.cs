namespace ApiButtonGenerator
{
    partial class ApiTesterFrm
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
            this.JokeCategoriesCb = new System.Windows.Forms.ComboBox();
            this.RdmJokeBtn = new System.Windows.Forms.Button();
            this.Txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // JokeCategoriesCb
            // 
            this.JokeCategoriesCb.FormattingEnabled = true;
            this.JokeCategoriesCb.Location = new System.Drawing.Point(316, 132);
            this.JokeCategoriesCb.Name = "JokeCategoriesCb";
            this.JokeCategoriesCb.Size = new System.Drawing.Size(121, 24);
            this.JokeCategoriesCb.TabIndex = 0;
            // 
            // RdmJokeBtn
            // 
            this.RdmJokeBtn.Location = new System.Drawing.Point(292, 173);
            this.RdmJokeBtn.Name = "RdmJokeBtn";
            this.RdmJokeBtn.Size = new System.Drawing.Size(164, 80);
            this.RdmJokeBtn.TabIndex = 1;
            this.RdmJokeBtn.Text = "Good Luck";
            this.RdmJokeBtn.UseVisualStyleBackColor = true;
            this.RdmJokeBtn.Click += new System.EventHandler(this.RdmJokeBtn_Click);
            // 
            // Txtbox
            // 
            this.Txtbox.Location = new System.Drawing.Point(316, 300);
            this.Txtbox.Name = "Txtbox";
            this.Txtbox.Size = new System.Drawing.Size(121, 22);
            this.Txtbox.TabIndex = 2;
            this.Txtbox.Visible = false;
            // 
            // ApiTesterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txtbox);
            this.Controls.Add(this.RdmJokeBtn);
            this.Controls.Add(this.JokeCategoriesCb);
            this.Name = "ApiTesterFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox JokeCategoriesCb;
        private System.Windows.Forms.Button RdmJokeBtn;
        private System.Windows.Forms.TextBox Txtbox;
    }
}

