
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.restorePasswordButton = new MaterialSkin.Controls.MaterialButton();
            this.confirm = new MaterialSkin.Controls.MaterialButton();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.username = new MaterialSkin.Controls.MaterialTextBox();
            this.toMainMenu = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(702, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "логин";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(698, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "пароль";
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
            this.restorePasswordButton.Location = new System.Drawing.Point(526, 630);
            this.restorePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.restorePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.restorePasswordButton.Name = "restorePasswordButton";
            this.restorePasswordButton.Size = new System.Drawing.Size(414, 38);
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
            this.confirm.Location = new System.Drawing.Point(526, 561);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(414, 38);
            this.confirm.TabIndex = 28;
            this.confirm.Text = "Войти";
            this.confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirm.UseAccentColor = false;
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 12F);
            this.password.Location = new System.Drawing.Point(400, 488);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(666, 36);
            this.password.TabIndex = 27;
            this.password.Text = "";
            this.password.UseTallSize = false;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Depth = 0;
            this.username.Font = new System.Drawing.Font("Roboto", 12F);
            this.username.Location = new System.Drawing.Point(400, 412);
            this.username.MaxLength = 50;
            this.username.MouseState = MaterialSkin.MouseState.OUT;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(666, 36);
            this.username.TabIndex = 26;
            this.username.Text = "";
            this.username.UseTallSize = false;
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
            this.toMainMenu.Location = new System.Drawing.Point(13, 729);
            this.toMainMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(186, 38);
            this.toMainMenu.TabIndex = 30;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.toMainMenu.UseAccentColor = false;
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // ChooseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1467, 782);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.restorePasswordButton);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton restorePasswordButton;
        private MaterialSkin.Controls.MaterialButton confirm;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialTextBox username;
        private MaterialSkin.Controls.MaterialButton toMainMenu;
    }
}