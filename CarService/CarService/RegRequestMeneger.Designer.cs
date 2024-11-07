namespace CarService
{
    partial class RegRequestMeneger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegRequestMeneger));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.buttonUpData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Дата окончания";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCancel.Location = new System.Drawing.Point(16, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 37);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(198, 83);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(191, 36);
            this.comboBoxMaster.TabIndex = 29;
            // 
            // buttonUpData
            // 
            this.buttonUpData.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUpData.Location = new System.Drawing.Point(219, 167);
            this.buttonUpData.Name = "buttonUpData";
            this.buttonUpData.Size = new System.Drawing.Size(170, 37);
            this.buttonUpData.TabIndex = 28;
            this.buttonUpData.Text = "Изменить заявку";
            this.buttonUpData.UseVisualStyleBackColor = false;
            this.buttonUpData.Click += new System.EventHandler(this.buttonUpData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Мастер";
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.BackColor = System.Drawing.Color.LightGray;
            this.maskedTextBoxDate.Location = new System.Drawing.Point(198, 25);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(191, 36);
            this.maskedTextBoxDate.TabIndex = 33;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // RegRequestMeneger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(416, 230);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.buttonUpData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegRequestMeneger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegRequestMeneger_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.Button buttonUpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
    }
}