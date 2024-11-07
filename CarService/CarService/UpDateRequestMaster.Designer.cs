namespace CarService
{
    partial class UpDateRequestMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpDateRequestMaster));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxComment = new System.Windows.Forms.ComboBox();
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.buttonUpDataRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxFinish = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Статус";
            // 
            // comboBoxComment
            // 
            this.comboBoxComment.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxComment.FormattingEnabled = true;
            this.comboBoxComment.Location = new System.Drawing.Point(198, 153);
            this.comboBoxComment.Name = "comboBoxComment";
            this.comboBoxComment.Size = new System.Drawing.Size(211, 36);
            this.comboBoxComment.TabIndex = 27;
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.Location = new System.Drawing.Point(198, 83);
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(211, 36);
            this.comboBoxPart.TabIndex = 26;
            // 
            // buttonUpDataRequest
            // 
            this.buttonUpDataRequest.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUpDataRequest.Location = new System.Drawing.Point(242, 251);
            this.buttonUpDataRequest.Name = "buttonUpDataRequest";
            this.buttonUpDataRequest.Size = new System.Drawing.Size(167, 42);
            this.buttonUpDataRequest.TabIndex = 25;
            this.buttonUpDataRequest.Text = "Изменить заявку";
            this.buttonUpDataRequest.UseVisualStyleBackColor = false;
            this.buttonUpDataRequest.Click += new System.EventHandler(this.buttonUpDataRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Комментарий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Запчасти";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCancel.Location = new System.Drawing.Point(24, 251);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 42);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // checkBoxFinish
            // 
            this.checkBoxFinish.AutoSize = true;
            this.checkBoxFinish.Location = new System.Drawing.Point(198, 23);
            this.checkBoxFinish.Name = "checkBoxFinish";
            this.checkBoxFinish.Size = new System.Drawing.Size(168, 32);
            this.checkBoxFinish.TabIndex = 30;
            this.checkBoxFinish.Text = "Готова к выдаче";
            this.checkBoxFinish.UseVisualStyleBackColor = true;
            // 
            // UpDateRequestMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(439, 305);
            this.Controls.Add(this.checkBoxFinish);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxComment);
            this.Controls.Add(this.comboBoxPart);
            this.Controls.Add(this.buttonUpDataRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpDateRequestMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpDateRequestMaster_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxComment;
        private System.Windows.Forms.ComboBox comboBoxPart;
        private System.Windows.Forms.Button buttonUpDataRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxFinish;
    }
}