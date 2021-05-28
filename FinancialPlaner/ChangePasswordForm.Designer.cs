
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.dontChange = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Новый пароль:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox1.Location = new System.Drawing.Point(354, 241);
            this.textBox1.MaxLength = 50;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Password = true;
            this.textBox1.Size = new System.Drawing.Size(414, 36);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "";
            this.textBox1.UseTallSize = false;
            // 
            // TextBox2
            // 
            this.TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox2.Depth = 0;
            this.TextBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.TextBox2.Location = new System.Drawing.Point(354, 357);
            this.TextBox2.MaxLength = 50;
            this.TextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBox2.Multiline = false;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Password = true;
            this.TextBox2.Size = new System.Drawing.Size(414, 36);
            this.TextBox2.TabIndex = 8;
            this.TextBox2.Text = "";
            this.TextBox2.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите новый пароль еще раз";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = false;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.DrawShadows = true;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(354, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Подтвердить";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dontChange
            // 
            this.dontChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dontChange.AutoSize = false;
            this.dontChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dontChange.Depth = 0;
            this.dontChange.DrawShadows = true;
            this.dontChange.HighEmphasis = true;
            this.dontChange.Icon = null;
            this.dontChange.Location = new System.Drawing.Point(354, 508);
            this.dontChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dontChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.dontChange.Name = "dontChange";
            this.dontChange.Size = new System.Drawing.Size(414, 38);
            this.dontChange.TabIndex = 11;
            this.dontChange.Text = "Не изменять пароль";
            this.dontChange.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dontChange.UseAccentColor = false;
            this.dontChange.UseVisualStyleBackColor = true;
            this.dontChange.Click += new System.EventHandler(this.dontChange_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 674);
            this.Controls.Add(this.dontChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangePasswordForm";
            this.Text = "Изменение пароля";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox TextBox2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton dontChange;
    }
}