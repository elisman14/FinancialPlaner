
namespace FinancialPlaner
{
    partial class DeleteUser
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
            this.delete = new MaterialSkin.Controls.MaterialButton();
            this.toMainMenu = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listUsersListBox
            // 
            this.listUsersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listUsersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsersListBox.FormattingEnabled = true;
            this.listUsersListBox.ItemHeight = 23;
            this.listUsersListBox.Location = new System.Drawing.Point(550, 248);
            this.listUsersListBox.Name = "listUsersListBox";
            this.listUsersListBox.Size = new System.Drawing.Size(300, 276);
            this.listUsersListBox.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete.AutoSize = false;
            this.delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete.Depth = 0;
            this.delete.DrawShadows = true;
            this.delete.HighEmphasis = true;
            this.delete.Icon = null;
            this.delete.Location = new System.Drawing.Point(500, 589);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(400, 80);
            this.delete.TabIndex = 4;
            this.delete.Text = "Удалить";
            this.delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete.UseAccentColor = false;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // toMainMenu
            // 
            this.toMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toMainMenu.AutoSize = false;
            this.toMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toMainMenu.Depth = 0;
            this.toMainMenu.DrawShadows = true;
            this.toMainMenu.HighEmphasis = true;
            this.toMainMenu.Icon = null;
            this.toMainMenu.Location = new System.Drawing.Point(500, 681);
            this.toMainMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(400, 80);
            this.toMainMenu.TabIndex = 5;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.toMainMenu.UseAccentColor = false;
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Location = new System.Drawing.Point(525, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 324);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите пользователя: которого хотите удалить";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listUsersListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.delete);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DeleteUser";
            this.Text = "Удаление пользователя";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listUsersListBox;
        private MaterialSkin.Controls.MaterialButton delete;
        private MaterialSkin.Controls.MaterialButton toMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}