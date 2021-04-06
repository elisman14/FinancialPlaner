
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
            this.label1 = new System.Windows.Forms.Label();
            this.listUsersListBox = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(911, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите пользователя: которого хотите удалить";
            // 
            // listUsersListBox
            // 
            this.listUsersListBox.FormattingEnabled = true;
            this.listUsersListBox.ItemHeight = 49;
            this.listUsersListBox.Location = new System.Drawing.Point(9, 52);
            this.listUsersListBox.Name = "listUsersListBox";
            this.listUsersListBox.Size = new System.Drawing.Size(422, 592);
            this.listUsersListBox.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(9, 650);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(422, 96);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // toMainMenu
            // 
            this.toMainMenu.Location = new System.Drawing.Point(12, 752);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(422, 96);
            this.toMainMenu.TabIndex = 3;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 882);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.listUsersListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUsersListBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button toMainMenu;
    }
}