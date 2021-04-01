
namespace RegistryWork
{
    partial class frmRegistryWork
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
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.btnGetValueLecture1 = new System.Windows.Forms.Button();
            this.btnCreateParam = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.btnDeleteLectureKey = new System.Windows.Forms.Button();
            this.btnDeleteAdmPPOKey = new System.Windows.Forms.Button();
            this.btnSetValueLecture1 = new System.Windows.Forms.Button();
            this.txtbLecture1 = new System.Windows.Forms.TextBox();
            this.lvlParametrLecture = new System.Windows.Forms.Label();
            this.lvlParametrResult = new System.Windows.Forms.Label();
            this.nudSetResult = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateKey.Location = new System.Drawing.Point(12, 12);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(196, 39);
            this.btnCreateKey.TabIndex = 0;
            this.btnCreateKey.Text = "Создать ключи в HKCU";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // btnGetValueLecture1
            // 
            this.btnGetValueLecture1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetValueLecture1.Location = new System.Drawing.Point(164, 106);
            this.btnGetValueLecture1.Name = "btnGetValueLecture1";
            this.btnGetValueLecture1.Size = new System.Drawing.Size(128, 47);
            this.btnGetValueLecture1.TabIndex = 2;
            this.btnGetValueLecture1.Text = "Получить текущее значение";
            this.btnGetValueLecture1.UseVisualStyleBackColor = true;
            this.btnGetValueLecture1.Click += new System.EventHandler(this.btnGetValueLecture1_Click);
            // 
            // btnCreateParam
            // 
            this.btnCreateParam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateParam.Location = new System.Drawing.Point(236, 12);
            this.btnCreateParam.Name = "btnCreateParam";
            this.btnCreateParam.Size = new System.Drawing.Size(196, 39);
            this.btnCreateParam.TabIndex = 4;
            this.btnCreateParam.Text = "Создание параметров";
            this.btnCreateParam.UseVisualStyleBackColor = true;
            this.btnCreateParam.Click += new System.EventHandler(this.btnCreateParam_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteResult.Location = new System.Drawing.Point(12, 220);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(196, 39);
            this.btnDeleteResult.TabIndex = 5;
            this.btnDeleteResult.Text = "Удалить параметр Result";
            this.btnDeleteResult.UseVisualStyleBackColor = true;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // btnDeleteLectureKey
            // 
            this.btnDeleteLectureKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteLectureKey.Location = new System.Drawing.Point(12, 272);
            this.btnDeleteLectureKey.Name = "btnDeleteLectureKey";
            this.btnDeleteLectureKey.Size = new System.Drawing.Size(196, 39);
            this.btnDeleteLectureKey.TabIndex = 6;
            this.btnDeleteLectureKey.Text = "Удалить ключ Lecture";
            this.btnDeleteLectureKey.UseVisualStyleBackColor = true;
            this.btnDeleteLectureKey.Click += new System.EventHandler(this.btnDeleteLectureKey_Click);
            // 
            // btnDeleteAdmPPOKey
            // 
            this.btnDeleteAdmPPOKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteAdmPPOKey.Location = new System.Drawing.Point(236, 272);
            this.btnDeleteAdmPPOKey.Name = "btnDeleteAdmPPOKey";
            this.btnDeleteAdmPPOKey.Size = new System.Drawing.Size(196, 39);
            this.btnDeleteAdmPPOKey.TabIndex = 7;
            this.btnDeleteAdmPPOKey.Text = "Удалить корневой ключ AdmPPO";
            this.btnDeleteAdmPPOKey.UseVisualStyleBackColor = true;
            this.btnDeleteAdmPPOKey.Click += new System.EventHandler(this.btnDeleteAdmPPOKey_Click);
            // 
            // btnSetValueLecture1
            // 
            this.btnSetValueLecture1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetValueLecture1.Location = new System.Drawing.Point(304, 106);
            this.btnSetValueLecture1.Name = "btnSetValueLecture1";
            this.btnSetValueLecture1.Size = new System.Drawing.Size(128, 47);
            this.btnSetValueLecture1.TabIndex = 8;
            this.btnSetValueLecture1.Text = "Установить значение";
            this.btnSetValueLecture1.UseVisualStyleBackColor = true;
            this.btnSetValueLecture1.Click += new System.EventHandler(this.btnSetValueLecture1_Click);
            // 
            // txtbLecture1
            // 
            this.txtbLecture1.Location = new System.Drawing.Point(164, 80);
            this.txtbLecture1.Name = "txtbLecture1";
            this.txtbLecture1.Size = new System.Drawing.Size(268, 20);
            this.txtbLecture1.TabIndex = 9;
            // 
            // lvlParametrLecture
            // 
            this.lvlParametrLecture.AutoSize = true;
            this.lvlParametrLecture.Location = new System.Drawing.Point(12, 83);
            this.lvlParametrLecture.Name = "lvlParametrLecture";
            this.lvlParametrLecture.Size = new System.Drawing.Size(118, 13);
            this.lvlParametrLecture.TabIndex = 11;
            this.lvlParametrLecture.Text = "Параметр \"Лекция 1\"";
            // 
            // lvlParametrResult
            // 
            this.lvlParametrResult.AutoSize = true;
            this.lvlParametrResult.Location = new System.Drawing.Point(12, 181);
            this.lvlParametrResult.Name = "lvlParametrResult";
            this.lvlParametrResult.Size = new System.Drawing.Size(101, 13);
            this.lvlParametrResult.TabIndex = 12;
            this.lvlParametrResult.Text = "Параметр \"Result\"";
            // 
            // nudSetResult
            // 
            this.nudSetResult.Location = new System.Drawing.Point(164, 179);
            this.nudSetResult.Name = "nudSetResult";
            this.nudSetResult.Size = new System.Drawing.Size(128, 20);
            this.nudSetResult.TabIndex = 13;
            this.nudSetResult.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSetResult.ValueChanged += new System.EventHandler(this.nudSetResult_ValueChanged);
            // 
            // frmRegistryWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.nudSetResult);
            this.Controls.Add(this.lvlParametrResult);
            this.Controls.Add(this.lvlParametrLecture);
            this.Controls.Add(this.txtbLecture1);
            this.Controls.Add(this.btnSetValueLecture1);
            this.Controls.Add(this.btnDeleteAdmPPOKey);
            this.Controls.Add(this.btnDeleteLectureKey);
            this.Controls.Add(this.btnDeleteResult);
            this.Controls.Add(this.btnCreateParam);
            this.Controls.Add(this.btnGetValueLecture1);
            this.Controls.Add(this.btnCreateKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRegistryWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с реестром";
            this.Load += new System.EventHandler(this.frmRegistryWork_Load);
            this.Shown += new System.EventHandler(this.frmRegistryWork_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudSetResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.Button btnGetValueLecture1;
        private System.Windows.Forms.Button btnCreateParam;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.Button btnDeleteLectureKey;
        private System.Windows.Forms.Button btnDeleteAdmPPOKey;
        private System.Windows.Forms.Button btnSetValueLecture1;
        private System.Windows.Forms.TextBox txtbLecture1;
        private System.Windows.Forms.Label lvlParametrLecture;
        private System.Windows.Forms.Label lvlParametrResult;
        private System.Windows.Forms.NumericUpDown nudSetResult;
    }
}

