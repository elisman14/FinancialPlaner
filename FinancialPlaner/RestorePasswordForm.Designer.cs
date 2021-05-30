
namespace FinancialPlaner
{
    partial class RestorePasswordForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.confirmLofinButton = new MaterialSkin.Controls.MaterialButton();
            this.restorePasswordButton = new MaterialSkin.Controls.MaterialButton();
            this.username = new System.Windows.Forms.TextBox();
            this.answerControlQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите логин";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ответ на контрольный вопрос";
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(594, 582);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(213, 25);
            this.questionLabel.TabIndex = 15;
            this.questionLabel.Text = "Контрольный вопрос";
            // 
            // confirmLofinButton
            // 
            this.confirmLofinButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmLofinButton.AutoSize = false;
            this.confirmLofinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmLofinButton.Depth = 0;
            this.confirmLofinButton.DrawShadows = true;
            this.confirmLofinButton.HighEmphasis = true;
            this.confirmLofinButton.Icon = null;
            this.confirmLofinButton.Location = new System.Drawing.Point(500, 485);
            this.confirmLofinButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmLofinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmLofinButton.Name = "confirmLofinButton";
            this.confirmLofinButton.Size = new System.Drawing.Size(400, 80);
            this.confirmLofinButton.TabIndex = 22;
            this.confirmLofinButton.Text = "Подтвердить логин";
            this.confirmLofinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirmLofinButton.UseAccentColor = false;
            this.confirmLofinButton.UseVisualStyleBackColor = true;
            this.confirmLofinButton.Click += new System.EventHandler(this.confirmLofinButton_Click);
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
            this.restorePasswordButton.Location = new System.Drawing.Point(500, 691);
            this.restorePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.restorePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.restorePasswordButton.Name = "restorePasswordButton";
            this.restorePasswordButton.Size = new System.Drawing.Size(400, 80);
            this.restorePasswordButton.TabIndex = 23;
            this.restorePasswordButton.Text = "Восстановить пароль";
            this.restorePasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.restorePasswordButton.UseAccentColor = false;
            this.restorePasswordButton.UseVisualStyleBackColor = true;
            this.restorePasswordButton.Click += new System.EventHandler(this.restorePasswordButton_Click);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.Location = new System.Drawing.Point(367, 444);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(666, 32);
            this.username.TabIndex = 24;
            // 
            // answerControlQuestion
            // 
            this.answerControlQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answerControlQuestion.Location = new System.Drawing.Point(367, 650);
            this.answerControlQuestion.Name = "answerControlQuestion";
            this.answerControlQuestion.Size = new System.Drawing.Size(666, 32);
            this.answerControlQuestion.TabIndex = 25;
            // 
            // RestorePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.answerControlQuestion);
            this.Controls.Add(this.username);
            this.Controls.Add(this.restorePasswordButton);
            this.Controls.Add(this.confirmLofinButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RestorePasswordForm";
            this.Text = "Восстановление пароля";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label questionLabel;
        private MaterialSkin.Controls.MaterialButton confirmLofinButton;
        private MaterialSkin.Controls.MaterialButton restorePasswordButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox answerControlQuestion;
    }
}