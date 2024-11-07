namespace CarService
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonCreateR = new System.Windows.Forms.Button();
            this.buttonUpDateR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numericUpDownRID = new System.Windows.Forms.NumericUpDown();
            this.labelCountR = new System.Windows.Forms.Label();
            this.buttonUpDataTable = new System.Windows.Forms.Button();
            this.textBoxFiltr = new System.Windows.Forms.TextBox();
            this.buttonFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRID)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonMenu.Location = new System.Drawing.Point(12, 496);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(93, 33);
            this.buttonMenu.TabIndex = 19;
            this.buttonMenu.Text = "Назад";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonCreateR
            // 
            this.buttonCreateR.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCreateR.Location = new System.Drawing.Point(12, 28);
            this.buttonCreateR.Name = "buttonCreateR";
            this.buttonCreateR.Size = new System.Drawing.Size(169, 35);
            this.buttonCreateR.TabIndex = 20;
            this.buttonCreateR.Text = "Добавить заявку";
            this.buttonCreateR.UseVisualStyleBackColor = false;
            this.buttonCreateR.Click += new System.EventHandler(this.buttonCreateR_Click);
            // 
            // buttonUpDateR
            // 
            this.buttonUpDateR.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUpDateR.Location = new System.Drawing.Point(201, 28);
            this.buttonUpDateR.Name = "buttonUpDateR";
            this.buttonUpDateR.Size = new System.Drawing.Size(215, 35);
            this.buttonUpDateR.TabIndex = 21;
            this.buttonUpDateR.Text = "Изменить заявку";
            this.buttonUpDateR.UseVisualStyleBackColor = false;
            this.buttonUpDateR.Click += new System.EventHandler(this.buttonUpDateR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 257);
            this.dataGridView1.TabIndex = 22;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonSearch.Location = new System.Drawing.Point(580, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(223, 35);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Поиск по номеру заявки";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // numericUpDownRID
            // 
            this.numericUpDownRID.BackColor = System.Drawing.Color.LightGray;
            this.numericUpDownRID.Location = new System.Drawing.Point(473, 27);
            this.numericUpDownRID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRID.Name = "numericUpDownRID";
            this.numericUpDownRID.Size = new System.Drawing.Size(78, 36);
            this.numericUpDownRID.TabIndex = 24;
            // 
            // labelCountR
            // 
            this.labelCountR.AutoSize = true;
            this.labelCountR.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountR.Location = new System.Drawing.Point(1032, 38);
            this.labelCountR.Name = "labelCountR";
            this.labelCountR.Size = new System.Drawing.Size(70, 28);
            this.labelCountR.TabIndex = 27;
            this.labelCountR.Text = "строк ";
            this.labelCountR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUpDataTable
            // 
            this.buttonUpDataTable.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUpDataTable.Location = new System.Drawing.Point(12, 332);
            this.buttonUpDataTable.Name = "buttonUpDataTable";
            this.buttonUpDataTable.Size = new System.Drawing.Size(117, 35);
            this.buttonUpDataTable.TabIndex = 28;
            this.buttonUpDataTable.Text = "Обновить";
            this.buttonUpDataTable.UseVisualStyleBackColor = false;
            this.buttonUpDataTable.Click += new System.EventHandler(this.buttonUpDataTable_Click);
            // 
            // textBoxFiltr
            // 
            this.textBoxFiltr.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFiltr.Location = new System.Drawing.Point(776, 360);
            this.textBoxFiltr.Name = "textBoxFiltr";
            this.textBoxFiltr.Size = new System.Drawing.Size(210, 36);
            this.textBoxFiltr.TabIndex = 41;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonFiltr.Location = new System.Drawing.Point(1018, 360);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(174, 35);
            this.buttonFiltr.TabIndex = 40;
            this.buttonFiltr.Text = "Отфильтровать";
            this.buttonFiltr.UseVisualStyleBackColor = false;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 541);
            this.Controls.Add(this.textBoxFiltr);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.buttonUpDataTable);
            this.Controls.Add(this.labelCountR);
            this.Controls.Add(this.numericUpDownRID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpDateR);
            this.Controls.Add(this.buttonCreateR);
            this.Controls.Add(this.buttonMenu);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Request_FormClosed);
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonCreateR;
        private System.Windows.Forms.Button buttonUpDateR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownRID;
        private System.Windows.Forms.Label labelCountR;
        private System.Windows.Forms.Button buttonUpDataTable;
        private System.Windows.Forms.TextBox textBoxFiltr;
        private System.Windows.Forms.Button buttonFiltr;
    }
}