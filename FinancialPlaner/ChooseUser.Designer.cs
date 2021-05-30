
namespace FinancialPlaner
{
    partial class ChooseUser
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
            this.restorePasswordButton = new MaterialSkin.Controls.MaterialButton();
            this.confirm = new MaterialSkin.Controls.MaterialButton();
            this.toMainMenu = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // restorePasswordButton
            // 
            this.restorePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restorePasswordButton.AutoSize = false;
            this.restorePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restorePasswordButton.Depth = 0;
            this.restorePasswordButton.DrawShadows = true;
            this.restorePasswordButton.HighEmphasis = true;
            this.restorePasswordButton.Icon = null;
            this.restorePasswordButton.Location = new System.Drawing.Point(533, 693);
            this.restorePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.restorePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.restorePasswordButton.Name = "restorePasswordButton";
            this.restorePasswordButton.Size = new System.Drawing.Size(400, 80);
            this.restorePasswordButton.TabIndex = 29;
            this.restorePasswordButton.Text = "Восстановить пароль";
            this.restorePasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.restorePasswordButton.UseAccentColor = false;
            this.restorePasswordButton.UseVisualStyleBackColor = true;
            this.restorePasswordButton.Click += new System.EventHandler(this.restorePasswordButton_Click);
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
            this.confirm.Location = new System.Drawing.Point(533, 601);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(400, 80);
            this.confirm.TabIndex = 28;
            this.confirm.Text = "Войти";
            this.confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirm.UseAccentColor = false;
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
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
            this.toMainMenu.Location = new System.Drawing.Point(7, 693);
            this.toMainMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(400, 80);
            this.toMainMenu.TabIndex = 30;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.toMainMenu.UseAccentColor = false;
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(702, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "пароль";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(702, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "логин";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(533, 499);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(400, 32);
            this.username.TabIndex = 31;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(533, 560);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(400, 32);
            this.password.TabIndex = 32;
            // 
            // ChooseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1467, 782);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.restorePasswordButton);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChooseUser";
            this.Text = "Вход в профиль";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton restorePasswordButton;
        private MaterialSkin.Controls.MaterialButton confirm;
        private MaterialSkin.Controls.MaterialButton toMainMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}