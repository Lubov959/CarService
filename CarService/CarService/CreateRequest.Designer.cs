namespace CarService
{
    partial class CreateRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRequest));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxProdlem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonL = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Проблема";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Модель машины";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCreate.Location = new System.Drawing.Point(237, 249);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(155, 42);
            this.buttonCreate.TabIndex = 9;
            this.buttonCreate.Text = "Создать заявку";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(181, 91);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxModel.Size = new System.Drawing.Size(211, 36);
            this.comboBoxModel.TabIndex = 10;
            this.comboBoxModel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxModel_SelectionChangeCommitted);
            // 
            // comboBoxProdlem
            // 
            this.comboBoxProdlem.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxProdlem.FormattingEnabled = true;
            this.comboBoxProdlem.Location = new System.Drawing.Point(181, 161);
            this.comboBoxProdlem.Name = "comboBoxProdlem";
            this.comboBoxProdlem.Size = new System.Drawing.Size(211, 36);
            this.comboBoxProdlem.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип машины";
            // 
            // radioButtonL
            // 
            this.radioButtonL.AutoSize = true;
            this.radioButtonL.Checked = true;
            this.radioButtonL.Location = new System.Drawing.Point(181, 27);
            this.radioButtonL.Name = "radioButtonL";
            this.radioButtonL.Size = new System.Drawing.Size(104, 32);
            this.radioButtonL.TabIndex = 13;
            this.radioButtonL.TabStop = true;
            this.radioButtonL.Text = "Легковая";
            this.radioButtonL.UseVisualStyleBackColor = true;
            this.radioButtonL.CheckedChanged += new System.EventHandler(this.radioButtonL_CheckedChanged);
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(308, 27);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(103, 32);
            this.radioButtonG.TabIndex = 14;
            this.radioButtonG.Text = "Грузовая";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCancel.Location = new System.Drawing.Point(26, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 42);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(422, 306);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.radioButtonL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProdlem);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateRequest_FormClosed);
            this.Load += new System.EventHandler(this.CreateRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxProdlem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonL;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.Button buttonCancel;
    }
}