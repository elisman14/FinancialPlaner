
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
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.answerControlQuestion = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.restorePasswordButton = new System.Windows.Forms.Button();
            this.confirmLofinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(21, 124);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(444, 39);
            this.username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Восстановление пароля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ответ на контрольный вопрос";
            // 
            // answerControlQuestion
            // 
            this.answerControlQuestion.Location = new System.Drawing.Point(21, 349);
            this.answerControlQuestion.Name = "answerControlQuestion";
            this.answerControlQuestion.Size = new System.Drawing.Size(444, 39);
            this.answerControlQuestion.TabIndex = 16;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(15, 252);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(268, 33);
            this.questionLabel.TabIndex = 15;
            this.questionLabel.Text = "Контрольный вопрос";
            // 
            // restorePasswordButton
            // 
            this.restorePasswordButton.Location = new System.Drawing.Point(21, 394);
            this.restorePasswordButton.Name = "restorePasswordButton";
            this.restorePasswordButton.Size = new System.Drawing.Size(444, 40);
            this.restorePasswordButton.TabIndex = 18;
            this.restorePasswordButton.Text = "Восстановить пароль";
            this.restorePasswordButton.UseVisualStyleBackColor = true;
            this.restorePasswordButton.Click += new System.EventHandler(this.restorePasswordButton_Click);
            // 
            // confirmLofinButton
            // 
            this.confirmLofinButton.Location = new System.Drawing.Point(21, 169);
            this.confirmLofinButton.Name = "confirmLofinButton";
            this.confirmLofinButton.Size = new System.Drawing.Size(444, 40);
            this.confirmLofinButton.TabIndex = 19;
            this.confirmLofinButton.Text = "Подтвердить логин";
            this.confirmLofinButton.UseVisualStyleBackColor = true;
            this.confirmLofinButton.Click += new System.EventHandler(this.confirmLofinButton_Click);
            // 
            // RestorePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.confirmLofinButton);
            this.Controls.Add(this.restorePasswordButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.answerControlQuestion);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RestorePasswordForm";
            this.Text = "RstorePasswordForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox answerControlQuestion;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button restorePasswordButton;
        private System.Windows.Forms.Button confirmLofinButton;
    }
}