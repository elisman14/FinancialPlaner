
namespace FinancialPlaner
{
    partial class RegisterUser
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
            this.username = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.controlQuestion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.answerControlQuestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(21, 188);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(436, 38);
            this.username.TabIndex = 0;
            // 
            // confirm
            // 
            this.confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm.Location = new System.Drawing.Point(589, 519);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(436, 71);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "Подтвердить";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // toMainMenu
            // 
            this.toMainMenu.Location = new System.Drawing.Point(12, 774);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(436, 96);
            this.toMainMenu.TabIndex = 4;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click_1);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(21, 300);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(436, 38);
            this.password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1576, 87);
            this.label3.TabIndex = 7;
            this.label3.Text = "Форма регистрации";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Контрольный вопрос";
            // 
            // controlQuestion
            // 
            this.controlQuestion.Location = new System.Drawing.Point(576, 188);
            this.controlQuestion.Name = "controlQuestion";
            this.controlQuestion.Size = new System.Drawing.Size(999, 38);
            this.controlQuestion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ответ на контрольный вопрос";
            // 
            // answerControlQuestion
            // 
            this.answerControlQuestion.Location = new System.Drawing.Point(576, 300);
            this.answerControlQuestion.Name = "answerControlQuestion";
            this.answerControlQuestion.Size = new System.Drawing.Size(999, 38);
            this.answerControlQuestion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(21, 423);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(436, 38);
            this.name.TabIndex = 14;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 882);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.answerControlQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.controlQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegisterUser";
            this.Text = "м";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toMainMenu;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox controlQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox answerControlQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
    }
}