﻿
namespace FinancialPlaner
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.qurrentPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dontChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменение пароля";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущий пароль:";
            // 
            // qurrentPassword
            // 
            this.qurrentPassword.AutoSize = true;
            this.qurrentPassword.Location = new System.Drawing.Point(247, 104);
            this.qurrentPassword.Name = "qurrentPassword";
            this.qurrentPassword.Size = new System.Drawing.Size(201, 33);
            this.qurrentPassword.TabIndex = 4;
            this.qurrentPassword.Text = "qurrentPassword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Новый пароль:";
            // 
            // dontChange
            // 
            this.dontChange.Location = new System.Drawing.Point(34, 362);
            this.dontChange.Name = "dontChange";
            this.dontChange.Size = new System.Drawing.Size(414, 38);
            this.dontChange.TabIndex = 6;
            this.dontChange.Text = "Не изменять пароль";
            this.dontChange.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 674);
            this.Controls.Add(this.dontChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qurrentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label qurrentPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dontChange;
    }
}