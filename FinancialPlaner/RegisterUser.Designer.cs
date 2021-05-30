
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toMainMenu = new MaterialSkin.Controls.MaterialButton();
            this.confirm = new MaterialSkin.Controls.MaterialButton();
            this.username = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.controlQuestion = new System.Windows.Forms.TextBox();
            this.answerControlQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Контрольный вопрос";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ответ на контрольный вопрос";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Имя";
            // 
            // toMainMenu
            // 
            this.toMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toMainMenu.AutoSize = false;
            this.toMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toMainMenu.Depth = 0;
            this.toMainMenu.DrawShadows = true;
            this.toMainMenu.HighEmphasis = true;
            this.toMainMenu.Icon = null;
            this.toMainMenu.Location = new System.Drawing.Point(7, 691);
            this.toMainMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(400, 80);
            this.toMainMenu.TabIndex = 31;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.toMainMenu.UseAccentColor = false;
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click_1);
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirm.AutoSize = false;
            this.confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirm.Depth = 0;
            this.confirm.DrawShadows = true;
            this.confirm.HighEmphasis = true;
            this.confirm.Icon = null;
            this.confirm.Location = new System.Drawing.Point(500, 691);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(400, 80);
            this.confirm.TabIndex = 32;
            this.confirm.Text = "Подтвердить";
            this.confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirm.UseAccentColor = false;
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.Location = new System.Drawing.Point(500, 326);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(400, 32);
            this.username.TabIndex = 1;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.Location = new System.Drawing.Point(500, 461);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(400, 32);
            this.name.TabIndex = 3;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.Location = new System.Drawing.Point(500, 389);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(400, 32);
            this.password.TabIndex = 2;
            // 
            // controlQuestion
            // 
            this.controlQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.controlQuestion.Location = new System.Drawing.Point(500, 533);
            this.controlQuestion.Name = "controlQuestion";
            this.controlQuestion.Size = new System.Drawing.Size(400, 32);
            this.controlQuestion.TabIndex = 4;
            // 
            // answerControlQuestion
            // 
            this.answerControlQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answerControlQuestion.Location = new System.Drawing.Point(500, 611);
            this.answerControlQuestion.Name = "answerControlQuestion";
            this.answerControlQuestion.Size = new System.Drawing.Size(400, 32);
            this.answerControlQuestion.TabIndex = 5;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.answerControlQuestion);
            this.Controls.Add(this.controlQuestion);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.username);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegisterUser";
            this.Text = "Регистрация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialButton toMainMenu;
        private MaterialSkin.Controls.MaterialButton confirm;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox controlQuestion;
        private System.Windows.Forms.TextBox answerControlQuestion;
    }
}