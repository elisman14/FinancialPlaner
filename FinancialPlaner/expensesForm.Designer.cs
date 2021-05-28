
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
            this.Main_TP = new System.Windows.Forms.TabPage();
            this.toMainMenu = new System.Windows.Forms.Button();
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
            this.MonthlyStat_TP = new System.Windows.Forms.TabPage();
            this.WriteMonthlyStatToExcel_button = new System.Windows.Forms.Button();
            this.WriteMonthlyStatToWord_button = new System.Windows.Forms.Button();
            this.CurrentMonth_label = new System.Windows.Forms.Label();
            this.displayStatForAnotherMonth_button = new System.Windows.Forms.Button();
            this.MonthlyStat_DGV = new System.Windows.Forms.DataGridView();
            this.UserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyStat_TP = new System.Windows.Forms.TabPage();
            this.button1WriteYearlyStatToExcel_button = new System.Windows.Forms.Button();
            this.WriteYearlyStatToWord_button = new System.Windows.Forms.Button();
            this.CurrentYear_label = new System.Windows.Forms.Label();
            this.displayStatForAnotherYear_button = new System.Windows.Forms.Button();
            this.YearlyStat_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllTimeStat_TP = new System.Windows.Forms.TabPage();
            this.WriteAllTimeStatToExcel_button = new System.Windows.Forms.Button();
            this.WriteAllTimeStatToWord_button = new System.Windows.Forms.Button();
            this.AllTimeStat_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Main_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MonthlyStat_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyStat_DGV)).BeginInit();
            this.YearlyStat_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyStat_DGV)).BeginInit();
            this.AllTimeStat_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTimeStat_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main_TP);
            this.tabControl1.Controls.Add(this.MonthlyStat_TP);
            this.tabControl1.Controls.Add(this.YearlyStat_TP);
            this.tabControl1.Controls.Add(this.AllTimeStat_TP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1402, 731);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            // 
            // Main_TP
            // 
            this.Main_TP.Controls.Add(this.toMainMenu);
            this.Main_TP.Controls.Add(this.deleteCategoryButton);
            this.Main_TP.Controls.Add(this.addPaynment);
            this.Main_TP.Controls.Add(this.addCategoryButton);
            this.Main_TP.Controls.Add(this.remainingSumLabel);
            this.Main_TP.Controls.Add(this.label6);
            this.Main_TP.Controls.Add(this.lostSumLabel);
            this.Main_TP.Controls.Add(this.label5);
            this.Main_TP.Controls.Add(this.maxSumLabel);
            this.Main_TP.Controls.Add(this.label3);
            this.Main_TP.Controls.Add(this.dataGridView1);
            this.Main_TP.Controls.Add(this.categoryLabel);
            this.Main_TP.Controls.Add(this.label2);
            this.Main_TP.Controls.Add(this.label1);
            this.Main_TP.Controls.Add(this.categoriesListBox);
            this.Main_TP.Location = new System.Drawing.Point(4, 32);
            this.Main_TP.Name = "Main_TP";
            this.Main_TP.Padding = new System.Windows.Forms.Padding(3);
            this.Main_TP.Size = new System.Drawing.Size(1394, 695);
            this.Main_TP.TabIndex = 0;
            this.Main_TP.Text = "Главная";
            this.Main_TP.UseVisualStyleBackColor = true;
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
            this.remainingSumLabel.Size = new System.Drawing.Size(215, 25);
            this.remainingSumLabel.TabIndex = 10;
            this.remainingSumLabel.Text = "Максимальная сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(881, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Оставшаяся сумма:";
            // 
            // lostSumLabel
            // 
            this.lostSumLabel.AutoSize = true;
            this.lostSumLabel.Location = new System.Drawing.Point(881, 156);
            this.lostSumLabel.Name = "lostSumLabel";
            this.lostSumLabel.Size = new System.Drawing.Size(215, 25);
            this.lostSumLabel.TabIndex = 8;
            this.lostSumLabel.Text = "Максимальная сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Потраченная сумма:";
            // 
            // maxSumLabel
            // 
            this.maxSumLabel.AutoSize = true;
            this.maxSumLabel.Location = new System.Drawing.Point(881, 80);
            this.maxSumLabel.Name = "maxSumLabel";
            this.maxSumLabel.Size = new System.Drawing.Size(215, 25);
            this.maxSumLabel.TabIndex = 6;
            this.maxSumLabel.Text = "Максимальная сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
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
            this.user.Width = 164;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cost.HeaderText = "Сумма";
            this.cost.MinimumWidth = 10;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(620, 15);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(0, 25);
            this.categoryLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрана категория:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категории";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 23;
            this.categoriesListBox.Location = new System.Drawing.Point(0, 49);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(593, 326);
            this.categoriesListBox.TabIndex = 0;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // MonthlyStat_TP
            // 
            this.MonthlyStat_TP.Controls.Add(this.WriteMonthlyStatToExcel_button);
            this.MonthlyStat_TP.Controls.Add(this.WriteMonthlyStatToWord_button);
            this.MonthlyStat_TP.Controls.Add(this.CurrentMonth_label);
            this.MonthlyStat_TP.Controls.Add(this.displayStatForAnotherMonth_button);
            this.MonthlyStat_TP.Controls.Add(this.MonthlyStat_DGV);
            this.MonthlyStat_TP.Location = new System.Drawing.Point(4, 32);
            this.MonthlyStat_TP.Name = "MonthlyStat_TP";
            this.MonthlyStat_TP.Padding = new System.Windows.Forms.Padding(3);
            this.MonthlyStat_TP.Size = new System.Drawing.Size(1394, 695);
            this.MonthlyStat_TP.TabIndex = 1;
            this.MonthlyStat_TP.Text = "Статистика за месяц";
            this.MonthlyStat_TP.UseVisualStyleBackColor = true;
            // 
            // WriteMonthlyStatToExcel_button
            // 
            this.WriteMonthlyStatToExcel_button.AutoSize = true;
            this.WriteMonthlyStatToExcel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteMonthlyStatToExcel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WriteMonthlyStatToExcel_button.Location = new System.Drawing.Point(3, 587);
            this.WriteMonthlyStatToExcel_button.Name = "WriteMonthlyStatToExcel_button";
            this.WriteMonthlyStatToExcel_button.Size = new System.Drawing.Size(1388, 35);
            this.WriteMonthlyStatToExcel_button.TabIndex = 8;
            this.WriteMonthlyStatToExcel_button.Text = "Вывести статистику за месяц в Excel";
            this.WriteMonthlyStatToExcel_button.UseVisualStyleBackColor = true;
            // 
            // WriteMonthlyStatToWord_button
            // 
            this.WriteMonthlyStatToWord_button.AutoSize = true;
            this.WriteMonthlyStatToWord_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteMonthlyStatToWord_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WriteMonthlyStatToWord_button.Location = new System.Drawing.Point(3, 622);
            this.WriteMonthlyStatToWord_button.Name = "WriteMonthlyStatToWord_button";
            this.WriteMonthlyStatToWord_button.Size = new System.Drawing.Size(1388, 35);
            this.WriteMonthlyStatToWord_button.TabIndex = 7;
            this.WriteMonthlyStatToWord_button.Text = "Вывести статистику за месяц в Word";
            this.WriteMonthlyStatToWord_button.UseVisualStyleBackColor = true;
            // 
            // CurrentMonth_label
            // 
            this.CurrentMonth_label.AutoSize = true;
            this.CurrentMonth_label.Location = new System.Drawing.Point(3, 3);
            this.CurrentMonth_label.Name = "CurrentMonth_label";
            this.CurrentMonth_label.Size = new System.Drawing.Size(66, 25);
            this.CurrentMonth_label.TabIndex = 6;
            this.CurrentMonth_label.Text = "label4";
            // 
            // displayStatForAnotherMonth_button
            // 
            this.displayStatForAnotherMonth_button.AutoSize = true;
            this.displayStatForAnotherMonth_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayStatForAnotherMonth_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayStatForAnotherMonth_button.Location = new System.Drawing.Point(3, 657);
            this.displayStatForAnotherMonth_button.Name = "displayStatForAnotherMonth_button";
            this.displayStatForAnotherMonth_button.Size = new System.Drawing.Size(1388, 35);
            this.displayStatForAnotherMonth_button.TabIndex = 5;
            this.displayStatForAnotherMonth_button.Text = "Вывести статистику за другой месяц";
            this.displayStatForAnotherMonth_button.UseVisualStyleBackColor = true;
            this.displayStatForAnotherMonth_button.Click += new System.EventHandler(this.displayStatForAnotherMonth_button_Click);
            // 
            // MonthlyStat_DGV
            // 
            this.MonthlyStat_DGV.AllowUserToAddRows = false;
            this.MonthlyStat_DGV.AllowUserToDeleteRows = false;
            this.MonthlyStat_DGV.AllowUserToResizeColumns = false;
            this.MonthlyStat_DGV.AllowUserToResizeRows = false;
            this.MonthlyStat_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MonthlyStat_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MonthlyStat_DGV.ColumnHeadersHeight = 46;
            this.MonthlyStat_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserColumn,
            this.CategoryColumn,
            this.NameColumn,
            this.DateColumn,
            this.CostColumn});
            this.MonthlyStat_DGV.Location = new System.Drawing.Point(0, 31);
            this.MonthlyStat_DGV.Name = "MonthlyStat_DGV";
            this.MonthlyStat_DGV.RowHeadersVisible = false;
            this.MonthlyStat_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.MonthlyStat_DGV.Size = new System.Drawing.Size(1370, 474);
            this.MonthlyStat_DGV.TabIndex = 4;
            // 
            // UserColumn
            // 
            this.UserColumn.Frozen = true;
            this.UserColumn.HeaderText = "Пользователь";
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.Width = 164;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.Frozen = true;
            this.CategoryColumn.HeaderText = "Категория";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.Width = 133;
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Наименование";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 175;
            // 
            // DateColumn
            // 
            this.DateColumn.Frozen = true;
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 81;
            // 
            // CostColumn
            // 
            this.CostColumn.Frozen = true;
            this.CostColumn.HeaderText = "Стоимость";
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.Width = 141;
            // 
            // YearlyStat_TP
            // 
            this.YearlyStat_TP.Controls.Add(this.button1WriteYearlyStatToExcel_button);
            this.YearlyStat_TP.Controls.Add(this.WriteYearlyStatToWord_button);
            this.YearlyStat_TP.Controls.Add(this.CurrentYear_label);
            this.YearlyStat_TP.Controls.Add(this.displayStatForAnotherYear_button);
            this.YearlyStat_TP.Controls.Add(this.YearlyStat_DGV);
            this.YearlyStat_TP.Location = new System.Drawing.Point(4, 32);
            this.YearlyStat_TP.Name = "YearlyStat_TP";
            this.YearlyStat_TP.Size = new System.Drawing.Size(1394, 695);
            this.YearlyStat_TP.TabIndex = 2;
            this.YearlyStat_TP.Text = "Статистика за год";
            this.YearlyStat_TP.UseVisualStyleBackColor = true;
            // 
            // button1WriteYearlyStatToExcel_button
            // 
            this.button1WriteYearlyStatToExcel_button.AutoSize = true;
            this.button1WriteYearlyStatToExcel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1WriteYearlyStatToExcel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1WriteYearlyStatToExcel_button.Location = new System.Drawing.Point(0, 590);
            this.button1WriteYearlyStatToExcel_button.Name = "button1WriteYearlyStatToExcel_button";
            this.button1WriteYearlyStatToExcel_button.Size = new System.Drawing.Size(1394, 35);
            this.button1WriteYearlyStatToExcel_button.TabIndex = 10;
            this.button1WriteYearlyStatToExcel_button.Text = "Вывести статистику за месяц в Excel";
            this.button1WriteYearlyStatToExcel_button.UseVisualStyleBackColor = true;
            this.button1WriteYearlyStatToExcel_button.Click += new System.EventHandler(this.button1WriteYearlyStatToExcel_button_Click);
            // 
            // WriteYearlyStatToWord_button
            // 
            this.WriteYearlyStatToWord_button.AutoSize = true;
            this.WriteYearlyStatToWord_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteYearlyStatToWord_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WriteYearlyStatToWord_button.Location = new System.Drawing.Point(0, 625);
            this.WriteYearlyStatToWord_button.Name = "WriteYearlyStatToWord_button";
            this.WriteYearlyStatToWord_button.Size = new System.Drawing.Size(1394, 35);
            this.WriteYearlyStatToWord_button.TabIndex = 9;
            this.WriteYearlyStatToWord_button.Text = "Вывести статистику за месяц в Word";
            this.WriteYearlyStatToWord_button.UseVisualStyleBackColor = true;
            this.WriteYearlyStatToWord_button.Click += new System.EventHandler(this.WriteYearlyStatToWord_button_Click);
            // 
            // CurrentYear_label
            // 
            this.CurrentYear_label.AutoSize = true;
            this.CurrentYear_label.Location = new System.Drawing.Point(3, 0);
            this.CurrentYear_label.Name = "CurrentYear_label";
            this.CurrentYear_label.Size = new System.Drawing.Size(66, 25);
            this.CurrentYear_label.TabIndex = 7;
            this.CurrentYear_label.Text = "label4";
            // 
            // displayStatForAnotherYear_button
            // 
            this.displayStatForAnotherYear_button.AutoSize = true;
            this.displayStatForAnotherYear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayStatForAnotherYear_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayStatForAnotherYear_button.Location = new System.Drawing.Point(0, 660);
            this.displayStatForAnotherYear_button.Name = "displayStatForAnotherYear_button";
            this.displayStatForAnotherYear_button.Size = new System.Drawing.Size(1394, 35);
            this.displayStatForAnotherYear_button.TabIndex = 6;
            this.displayStatForAnotherYear_button.Text = "Вывести статистику за другой год";
            this.displayStatForAnotherYear_button.UseVisualStyleBackColor = true;
            this.displayStatForAnotherYear_button.Click += new System.EventHandler(this.displayStatForAnotherYear_button_Click);
            // 
            // YearlyStat_DGV
            // 
            this.YearlyStat_DGV.AllowUserToAddRows = false;
            this.YearlyStat_DGV.AllowUserToDeleteRows = false;
            this.YearlyStat_DGV.AllowUserToResizeColumns = false;
            this.YearlyStat_DGV.AllowUserToResizeRows = false;
            this.YearlyStat_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.YearlyStat_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.YearlyStat_DGV.ColumnHeadersHeight = 46;
            this.YearlyStat_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.YearlyStat_DGV.Location = new System.Drawing.Point(3, 28);
            this.YearlyStat_DGV.Name = "YearlyStat_DGV";
            this.YearlyStat_DGV.RowHeadersVisible = false;
            this.YearlyStat_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.YearlyStat_DGV.Size = new System.Drawing.Size(1366, 474);
            this.YearlyStat_DGV.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Пользователь";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 164;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 133;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 141;
            // 
            // AllTimeStat_TP
            // 
            this.AllTimeStat_TP.Controls.Add(this.WriteAllTimeStatToExcel_button);
            this.AllTimeStat_TP.Controls.Add(this.WriteAllTimeStatToWord_button);
            this.AllTimeStat_TP.Controls.Add(this.AllTimeStat_DGV);
            this.AllTimeStat_TP.Location = new System.Drawing.Point(4, 32);
            this.AllTimeStat_TP.Name = "AllTimeStat_TP";
            this.AllTimeStat_TP.Size = new System.Drawing.Size(1394, 695);
            this.AllTimeStat_TP.TabIndex = 3;
            this.AllTimeStat_TP.Text = "Статистика за все время";
            this.AllTimeStat_TP.UseVisualStyleBackColor = true;
            // 
            // WriteAllTimeStatToExcel_button
            // 
            this.WriteAllTimeStatToExcel_button.AutoSize = true;
            this.WriteAllTimeStatToExcel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteAllTimeStatToExcel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WriteAllTimeStatToExcel_button.Location = new System.Drawing.Point(0, 625);
            this.WriteAllTimeStatToExcel_button.Name = "WriteAllTimeStatToExcel_button";
            this.WriteAllTimeStatToExcel_button.Size = new System.Drawing.Size(1394, 35);
            this.WriteAllTimeStatToExcel_button.TabIndex = 10;
            this.WriteAllTimeStatToExcel_button.Text = "Вывести статистику за месяц в Excel";
            this.WriteAllTimeStatToExcel_button.UseVisualStyleBackColor = true;
            this.WriteAllTimeStatToExcel_button.Click += new System.EventHandler(this.WriteAllTimeStatToExcel_button_Click);
            // 
            // WriteAllTimeStatToWord_button
            // 
            this.WriteAllTimeStatToWord_button.AutoSize = true;
            this.WriteAllTimeStatToWord_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteAllTimeStatToWord_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WriteAllTimeStatToWord_button.Location = new System.Drawing.Point(0, 660);
            this.WriteAllTimeStatToWord_button.Name = "WriteAllTimeStatToWord_button";
            this.WriteAllTimeStatToWord_button.Size = new System.Drawing.Size(1394, 35);
            this.WriteAllTimeStatToWord_button.TabIndex = 9;
            this.WriteAllTimeStatToWord_button.Text = "Вывести статистику за месяц в Word";
            this.WriteAllTimeStatToWord_button.UseVisualStyleBackColor = true;
            this.WriteAllTimeStatToWord_button.Click += new System.EventHandler(this.WriteAllTimeStatToWord_button_Click);
            // 
            // AllTimeStat_DGV
            // 
            this.AllTimeStat_DGV.AllowUserToAddRows = false;
            this.AllTimeStat_DGV.AllowUserToDeleteRows = false;
            this.AllTimeStat_DGV.AllowUserToResizeColumns = false;
            this.AllTimeStat_DGV.AllowUserToResizeRows = false;
            this.AllTimeStat_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllTimeStat_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllTimeStat_DGV.ColumnHeadersHeight = 46;
            this.AllTimeStat_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.AllTimeStat_DGV.Location = new System.Drawing.Point(0, 0);
            this.AllTimeStat_DGV.Name = "AllTimeStat_DGV";
            this.AllTimeStat_DGV.RowHeadersVisible = false;
            this.AllTimeStat_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.AllTimeStat_DGV.Size = new System.Drawing.Size(1366, 474);
            this.AllTimeStat_DGV.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Пользователь";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 164;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 133;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 175;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 81;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 141;
            // 
            // expensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 731);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "expensesForm";
            this.Text = "expensesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Main_TP.ResumeLayout(false);
            this.Main_TP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MonthlyStat_TP.ResumeLayout(false);
            this.MonthlyStat_TP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyStat_DGV)).EndInit();
            this.YearlyStat_TP.ResumeLayout(false);
            this.YearlyStat_TP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearlyStat_DGV)).EndInit();
            this.AllTimeStat_TP.ResumeLayout(false);
            this.AllTimeStat_TP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTimeStat_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main_TP;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TabPage MonthlyStat_TP;
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
        private System.Windows.Forms.DataGridView MonthlyStat_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
        private System.Windows.Forms.TabPage YearlyStat_TP;
        private System.Windows.Forms.DataGridView YearlyStat_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage AllTimeStat_TP;
        private System.Windows.Forms.DataGridView AllTimeStat_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button displayStatForAnotherMonth_button;
        private System.Windows.Forms.Button displayStatForAnotherYear_button;
        private System.Windows.Forms.Label CurrentMonth_label;
        private System.Windows.Forms.Label CurrentYear_label;
        private System.Windows.Forms.Button WriteMonthlyStatToExcel_button;
        private System.Windows.Forms.Button WriteMonthlyStatToWord_button;
        private System.Windows.Forms.Button button1WriteYearlyStatToExcel_button;
        private System.Windows.Forms.Button WriteYearlyStatToWord_button;
        private System.Windows.Forms.Button WriteAllTimeStatToExcel_button;
        private System.Windows.Forms.Button WriteAllTimeStatToWord_button;
    }
}