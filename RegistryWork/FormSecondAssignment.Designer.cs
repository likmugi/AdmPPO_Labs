
namespace RegistryWork
{
    partial class frmShareware
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
            this.lblBeforeTrialEnd = new System.Windows.Forms.Label();
            this.btnRunCountFamiliarized = new System.Windows.Forms.Button();
            this.lblRunCount = new System.Windows.Forms.Label();
            this.lblTrialInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBeforeTrialEnd
            // 
            this.lblBeforeTrialEnd.AutoSize = true;
            this.lblBeforeTrialEnd.Location = new System.Drawing.Point(35, 27);
            this.lblBeforeTrialEnd.Name = "lblBeforeTrialEnd";
            this.lblBeforeTrialEnd.Size = new System.Drawing.Size(198, 13);
            this.lblBeforeTrialEnd.TabIndex = 0;
            this.lblBeforeTrialEnd.Text = "Запусков до конца пробного периода";
            // 
            // btnRunCountFamiliarized
            // 
            this.btnRunCountFamiliarized.Location = new System.Drawing.Point(141, 112);
            this.btnRunCountFamiliarized.Name = "btnRunCountFamiliarized";
            this.btnRunCountFamiliarized.Size = new System.Drawing.Size(92, 34);
            this.btnRunCountFamiliarized.TabIndex = 1;
            this.btnRunCountFamiliarized.Text = "Ознакомлен";
            this.btnRunCountFamiliarized.UseVisualStyleBackColor = true;
            this.btnRunCountFamiliarized.Click += new System.EventHandler(this.btnRunCountFamiliarized_Click);
            // 
            // lblRunCount
            // 
            this.lblRunCount.Location = new System.Drawing.Point(239, 13);
            this.lblRunCount.Name = "lblRunCount";
            this.lblRunCount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRunCount.Size = new System.Drawing.Size(107, 45);
            this.lblRunCount.TabIndex = 2;
            this.lblRunCount.Text = "N запусков";
            this.lblRunCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrialInformation
            // 
            this.lblTrialInformation.Location = new System.Drawing.Point(20, 56);
            this.lblTrialInformation.Name = "lblTrialInformation";
            this.lblTrialInformation.Size = new System.Drawing.Size(341, 48);
            this.lblTrialInformation.TabIndex = 3;
            this.lblTrialInformation.Text = "Для того чтобы пользоваться функионалом программы по истичении пробного периода, " +
    "вам необходимо приобрести лицензию.";
            this.lblTrialInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShareware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 158);
            this.Controls.Add(this.lblTrialInformation);
            this.Controls.Add(this.lblRunCount);
            this.Controls.Add(this.btnRunCountFamiliarized);
            this.Controls.Add(this.lblBeforeTrialEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmShareware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Условно-бесплатное использование программы";
            this.Load += new System.EventHandler(this.frmShareware_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeforeTrialEnd;
        private System.Windows.Forms.Button btnRunCountFamiliarized;
        private System.Windows.Forms.Label lblRunCount;
        private System.Windows.Forms.Label lblTrialInformation;
    }
}