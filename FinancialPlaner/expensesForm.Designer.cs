
namespace FinancialPlaner
{
    partial class expensesForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.addPaynment = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.remainingSumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lostSumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxSumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1378, 885);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toMainMenu);
            this.tabPage1.Controls.Add(this.deleteCategoryButton);
            this.tabPage1.Controls.Add(this.addPaynment);
            this.tabPage1.Controls.Add(this.addCategoryButton);
            this.tabPage1.Controls.Add(this.remainingSumLabel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lostSumLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.maxSumLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.categoryLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.categoriesListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1370, 841);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(0, 466);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(379, 42);
            this.deleteCategoryButton.TabIndex = 13;
            this.deleteCategoryButton.Text = "Удалить категорию";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // addPaynment
            // 
            this.addPaynment.Location = new System.Drawing.Point(385, 418);
            this.addPaynment.Name = "addPaynment";
            this.addPaynment.Size = new System.Drawing.Size(398, 42);
            this.addPaynment.TabIndex = 12;
            this.addPaynment.Text = "Добавить покупку";
            this.addPaynment.UseVisualStyleBackColor = true;
            this.addPaynment.Click += new System.EventHandler(this.addPaynment_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(0, 418);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(379, 42);
            this.addCategoryButton.TabIndex = 11;
            this.addCategoryButton.Text = "Добавить категорию";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // remainingSumLabel
            // 
            this.remainingSumLabel.AutoSize = true;
            this.remainingSumLabel.Location = new System.Drawing.Point(881, 235);
            this.remainingSumLabel.Name = "remainingSumLabel";
            this.remainingSumLabel.Size = new System.Drawing.Size(258, 31);
            this.remainingSumLabel.TabIndex = 10;
            this.remainingSumLabel.Text = "Максимальная сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(881, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Оставшаяся сумма:";
            // 
            // lostSumLabel
            // 
            this.lostSumLabel.AutoSize = true;
            this.lostSumLabel.Location = new System.Drawing.Point(881, 156);
            this.lostSumLabel.Name = "lostSumLabel";
            this.lostSumLabel.Size = new System.Drawing.Size(258, 31);
            this.lostSumLabel.TabIndex = 8;
            this.lostSumLabel.Text = "Максимальная сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Потраченная сумма:";
            // 
            // maxSumLabel
            // 
            this.maxSumLabel.AutoSize = true;
            this.maxSumLabel.Location = new System.Drawing.Point(881, 80);
            this.maxSumLabel.Name = "maxSumLabel";
            this.maxSumLabel.Size = new System.Drawing.Size(258, 31);
            this.maxSumLabel.TabIndex = 6;
            this.maxSumLabel.Text = "Максимальная сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Максимальная сумма:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.name,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(385, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(398, 345);
            this.dataGridView1.TabIndex = 4;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user.HeaderText = "Пользователь";
            this.user.MinimumWidth = 10;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 198;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 149;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cost.HeaderText = "Сумма";
            this.cost.MinimumWidth = 10;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 119;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(620, 15);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(0, 31);
            this.categoryLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрана категория:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категории";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 31;
            this.categoriesListBox.Location = new System.Drawing.Point(0, 49);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(593, 345);
            this.categoriesListBox.TabIndex = 0;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1715, 844);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toMainMenu
            // 
            this.toMainMenu.Location = new System.Drawing.Point(6, 627);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(161, 40);
            this.toMainMenu.TabIndex = 5;
            this.toMainMenu.Text = "В меню";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // expensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 731);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "expensesForm";
            this.Text = "expensesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label remainingSumLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lostSumLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxSumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPaynment;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button toMainMenu;
    }
}