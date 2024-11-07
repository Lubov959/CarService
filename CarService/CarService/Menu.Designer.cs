namespace CarService
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonRequest = new System.Windows.Forms.Button();
            this.buttonAuthoriz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.labelQR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRequest
            // 
            this.buttonRequest.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonRequest.Location = new System.Drawing.Point(25, 83);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(100, 38);
            this.buttonRequest.TabIndex = 12;
            this.buttonRequest.Text = "Заявки";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonAuthoriz
            // 
            this.buttonAuthoriz.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAuthoriz.Location = new System.Drawing.Point(120, 201);
            this.buttonAuthoriz.Name = "buttonAuthoriz";
            this.buttonAuthoriz.Size = new System.Drawing.Size(225, 40);
            this.buttonAuthoriz.TabIndex = 25;
            this.buttonAuthoriz.Text = "Сменить пользователя";
            this.buttonAuthoriz.UseVisualStyleBackColor = false;
            this.buttonAuthoriz.Click += new System.EventHandler(this.buttonAuthoriz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выберите действие";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUsers.Location = new System.Drawing.Point(339, 83);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(142, 38);
            this.buttonUsers.TabIndex = 15;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonHistory.Location = new System.Drawing.Point(186, 83);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(100, 69);
            this.buttonHistory.TabIndex = 13;
            this.buttonHistory.Text = "История входа";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(371, 66);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(120, 109);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQR.TabIndex = 26;
            this.pictureBoxQR.TabStop = false;
            this.pictureBoxQR.Visible = false;
            // 
            // labelQR
            // 
            this.labelQR.AutoSize = true;
            this.labelQR.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQR.Location = new System.Drawing.Point(205, 88);
            this.labelQR.Name = "labelQR";
            this.labelQR.Size = new System.Drawing.Size(160, 56);
            this.labelQR.TabIndex = 27;
            this.labelQR.Text = "Оцените работу \r\nсервисной службы";
            this.labelQR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelQR.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(503, 270);
            this.Controls.Add(this.labelQR);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonAuthoriz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRequest);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonAuthoriz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Label labelQR;
    }
}