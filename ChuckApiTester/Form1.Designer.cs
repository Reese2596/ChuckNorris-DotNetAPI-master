﻿namespace ChuckApiTester
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
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.RdmJokeBtn = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryCb
            // 
            this.CategoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Location = new System.Drawing.Point(325, 103);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(121, 24);
            this.CategoryCb.TabIndex = 0;
            // 
            // RdmJokeBtn
            // 
            this.RdmJokeBtn.Location = new System.Drawing.Point(314, 142);
            this.RdmJokeBtn.Name = "RdmJokeBtn";
            this.RdmJokeBtn.Size = new System.Drawing.Size(143, 74);
            this.RdmJokeBtn.TabIndex = 1;
            this.RdmJokeBtn.Text = "Random Joke";
            this.RdmJokeBtn.UseVisualStyleBackColor = true;
            this.RdmJokeBtn.Click += new System.EventHandler(this.RdmJokeBtn_Click);
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Location = new System.Drawing.Point(188, 244);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(0, 17);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 421);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.RdmJokeBtn);
            this.Controls.Add(this.CategoryCb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryCb;
        private System.Windows.Forms.Button RdmJokeBtn;
        private System.Windows.Forms.Label TextBox;
    }
}

