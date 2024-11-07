namespace CarService
{
    partial class UpDateRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpDateRequest));
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.radioButtonL = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProdlem = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(308, 27);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(103, 32);
            this.radioButtonG.TabIndex = 22;
            this.radioButtonG.Text = "Грузовая";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // radioButtonL
            // 
            this.radioButtonL.AutoSize = true;
            this.radioButtonL.Checked = true;
            this.radioButtonL.Location = new System.Drawing.Point(181, 27);
            this.radioButtonL.Name = "radioButtonL";
            this.radioButtonL.Size = new System.Drawing.Size(104, 32);
            this.radioButtonL.TabIndex = 21;
            this.radioButtonL.TabStop = true;
            this.radioButtonL.Text = "Легковая";
            this.radioButtonL.UseVisualStyleBackColor = true;
            this.radioButtonL.CheckedChanged += new System.EventHandler(this.radioButtonL_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тип машины";
            // 
            // comboBoxProdlem
            // 
            this.comboBoxProdlem.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxProdlem.FormattingEnabled = true;
            this.comboBoxProdlem.Location = new System.Drawing.Point(181, 161);
            this.comboBoxProdlem.Name = "comboBoxProdlem";
            this.comboBoxProdlem.Size = new System.Drawing.Size(211, 36);
            this.comboBoxProdlem.TabIndex = 19;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(181, 91);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(211, 36);
            this.comboBoxModel.TabIndex = 18;
            this.comboBoxModel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxModel_SelectionChangeCommitted);
            this.comboBoxModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxModel_KeyPress);
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUpDate.Location = new System.Drawing.Point(244, 260);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(167, 42);
            this.buttonUpDate.TabIndex = 17;
            this.buttonUpDate.Text = "Изменить заявку";
            this.buttonUpDate.UseVisualStyleBackColor = false;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Проблема";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Модель машины";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCancel.Location = new System.Drawing.Point(26, 260);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 42);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // UpDateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(436, 314);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.radioButtonL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProdlem);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.buttonUpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpDateRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpDateRequest_FormClosed);
            this.Load += new System.EventHandler(this.UpDateRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.RadioButton radioButtonL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProdlem;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
    }
}