
namespace PasswordGeneratorShareware
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbPasswordGenerated = new System.Windows.Forms.TextBox();
            this.btnPasswordGenerated = new System.Windows.Forms.Button();
            this.lblPasswordLenght = new System.Windows.Forms.Label();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.cldPassword = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(151, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Ваш пароль:";
            // 
            // txtbPasswordGenerated
            // 
            this.txtbPasswordGenerated.Location = new System.Drawing.Point(84, 216);
            this.txtbPasswordGenerated.Name = "txtbPasswordGenerated";
            this.txtbPasswordGenerated.Size = new System.Drawing.Size(209, 20);
            this.txtbPasswordGenerated.TabIndex = 11;
            // 
            // btnPasswordGenerated
            // 
            this.btnPasswordGenerated.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPasswordGenerated.Location = new System.Drawing.Point(140, 257);
            this.btnPasswordGenerated.Name = "btnPasswordGenerated";
            this.btnPasswordGenerated.Size = new System.Drawing.Size(95, 30);
            this.btnPasswordGenerated.TabIndex = 10;
            this.btnPasswordGenerated.Text = "Сгенирировать";
            this.btnPasswordGenerated.UseVisualStyleBackColor = true;
            this.btnPasswordGenerated.Click += new System.EventHandler(this.btnPasswordGenerated_Click);
            // 
            // lblPasswordLenght
            // 
            this.lblPasswordLenght.AutoSize = true;
            this.lblPasswordLenght.Location = new System.Drawing.Point(102, 127);
            this.lblPasswordLenght.Name = "lblPasswordLenght";
            this.lblPasswordLenght.Size = new System.Drawing.Size(82, 13);
            this.lblPasswordLenght.TabIndex = 9;
            this.lblPasswordLenght.Text = "Длина пароля:";
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Location = new System.Drawing.Point(200, 125);
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(68, 20);
            this.nudPasswordLength.TabIndex = 8;
            // 
            // cldPassword
            // 
            this.cldPassword.BackColor = System.Drawing.SystemColors.Control;
            this.cldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cldPassword.CheckOnClick = true;
            this.cldPassword.FormattingEnabled = true;
            this.cldPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: %, *, ), ?, !, ~, #, ^, &"});
            this.cldPassword.Location = new System.Drawing.Point(94, 39);
            this.cldPassword.Name = "cldPassword";
            this.cldPassword.Size = new System.Drawing.Size(217, 60);
            this.cldPassword.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 329);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbPasswordGenerated);
            this.Controls.Add(this.btnPasswordGenerated);
            this.Controls.Add(this.lblPasswordLenght);
            this.Controls.Add(this.nudPasswordLength);
            this.Controls.Add(this.cldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbPasswordGenerated;
        private System.Windows.Forms.Button btnPasswordGenerated;
        private System.Windows.Forms.Label lblPasswordLenght;
        private System.Windows.Forms.NumericUpDown nudPasswordLength;
        private System.Windows.Forms.CheckedListBox cldPassword;
    }
}

