
namespace FinancialPlaner
{
    partial class MainForm
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
            this.listUsersListBox = new System.Windows.Forms.ListBox();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.deleteUser = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.button4 = new MaterialSkin.Controls.MaterialButton();
            this.themeButton = new MaterialSkin.Controls.MaterialButton();
            this.customizeButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listUsersListBox
            // 
            this.listUsersListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listUsersListBox.FormattingEnabled = true;
            this.listUsersListBox.ItemHeight = 20;
            this.listUsersListBox.Location = new System.Drawing.Point(550, 248);
            this.listUsersListBox.Name = "listUsersListBox";
            this.listUsersListBox.Size = new System.Drawing.Size(300, 284);
            this.listUsersListBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = false;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.DrawShadows = true;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(500, 589);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 80);
            this.button1.TabIndex = 29;
            this.button1.Text = "Создать нового пользователя";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteUser.AutoSize = false;
            this.deleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteUser.Depth = 0;
            this.deleteUser.DrawShadows = true;
            this.deleteUser.HighEmphasis = true;
            this.deleteUser.Icon = null;
            this.deleteUser.Location = new System.Drawing.Point(500, 681);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(400, 80);
            this.deleteUser.TabIndex = 30;
            this.deleteUser.Text = "Удалить пользователя";
            this.deleteUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteUser.UseAccentColor = false;
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = false;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Depth = 0;
            this.button2.DrawShadows = true;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(993, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 80);
            this.button2.TabIndex = 31;
            this.button2.Text = "Перейти на страницу трат";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.AutoSize = false;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Depth = 0;
            this.button4.DrawShadows = true;
            this.button4.HighEmphasis = true;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(7, 691);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 80);
            this.button4.TabIndex = 32;
            this.button4.Text = "Закрыть программу";
            this.button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button4.UseAccentColor = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // themeButton
            // 
            this.themeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.themeButton.AutoSize = false;
            this.themeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.themeButton.Depth = 0;
            this.themeButton.DrawShadows = true;
            this.themeButton.HighEmphasis = true;
            this.themeButton.Icon = null;
            this.themeButton.Location = new System.Drawing.Point(993, 691);
            this.themeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.themeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(400, 80);
            this.themeButton.TabIndex = 34;
            this.themeButton.Text = "Сменить тему";
            this.themeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.themeButton.UseAccentColor = false;
            this.themeButton.UseVisualStyleBackColor = true;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // customizeButton
            // 
            this.customizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customizeButton.AutoSize = false;
            this.customizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customizeButton.Depth = 0;
            this.customizeButton.DrawShadows = true;
            this.customizeButton.HighEmphasis = true;
            this.customizeButton.Icon = null;
            this.customizeButton.Location = new System.Drawing.Point(993, 599);
            this.customizeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.customizeButton.Name = "customizeButton";
            this.customizeButton.Size = new System.Drawing.Size(400, 80);
            this.customizeButton.TabIndex = 35;
            this.customizeButton.Text = "Сменить расцветку";
            this.customizeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.customizeButton.UseAccentColor = false;
            this.customizeButton.UseVisualStyleBackColor = true;
            this.customizeButton.Click += new System.EventHandler(this.customizeButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(496, 182);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(417, 24);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Список зарегистрированных пользователей";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(525, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 324);
            this.panel1.TabIndex = 37;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.customizeButton);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listUsersListBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listUsersListBox;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton deleteUser;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialButton button4;
        private MaterialSkin.Controls.MaterialButton themeButton;
        private MaterialSkin.Controls.MaterialButton customizeButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}

