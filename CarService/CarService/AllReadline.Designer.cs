﻿namespace CarService
{
    partial class AllReadline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllReadline));
            this.buttonUpDataTable = new System.Windows.Forms.Button();
            this.textBoxFiltr = new System.Windows.Forms.TextBox();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelCountR = new System.Windows.Forms.Label();
            this.numericUpDownRID = new System.Windows.Forms.NumericUpDown();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpDataTable
            // 
            this.buttonUpDataTable.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUpDataTable.Location = new System.Drawing.Point(14, 326);
            this.buttonUpDataTable.Name = "buttonUpDataTable";
            this.buttonUpDataTable.Size = new System.Drawing.Size(117, 35);
            this.buttonUpDataTable.TabIndex = 40;
            this.buttonUpDataTable.Text = "Обновить";
            this.buttonUpDataTable.UseVisualStyleBackColor = false;
            this.buttonUpDataTable.Click += new System.EventHandler(this.buttonUpDataTable_Click);
            // 
            // textBoxFiltr
            // 
            this.textBoxFiltr.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFiltr.Location = new System.Drawing.Point(212, 325);
            this.textBoxFiltr.Name = "textBoxFiltr";
            this.textBoxFiltr.Size = new System.Drawing.Size(210, 36);
            this.textBoxFiltr.TabIndex = 39;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonFiltr.Location = new System.Drawing.Point(444, 326);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(174, 35);
            this.buttonFiltr.TabIndex = 38;
            this.buttonFiltr.Text = "Отфильтровать";
            this.buttonFiltr.UseVisualStyleBackColor = false;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonMenu.Location = new System.Drawing.Point(14, 394);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(93, 33);
            this.buttonMenu.TabIndex = 37;
            this.buttonMenu.Text = "Назад";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelCountR
            // 
            this.labelCountR.AutoSize = true;
            this.labelCountR.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountR.Location = new System.Drawing.Point(457, 20);
            this.labelCountR.Name = "labelCountR";
            this.labelCountR.Size = new System.Drawing.Size(70, 28);
            this.labelCountR.TabIndex = 36;
            this.labelCountR.Text = "строк ";
            this.labelCountR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDownRID
            // 
            this.numericUpDownRID.BackColor = System.Drawing.Color.LightGray;
            this.numericUpDownRID.Location = new System.Drawing.Point(57, 13);
            this.numericUpDownRID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRID.Name = "numericUpDownRID";
            this.numericUpDownRID.Size = new System.Drawing.Size(78, 36);
            this.numericUpDownRID.TabIndex = 35;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonSearch.Location = new System.Drawing.Point(159, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(192, 35);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Поиск по номеру";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 257);
            this.dataGridView1.TabIndex = 33;
            // 
            // AllReadline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(631, 446);
            this.Controls.Add(this.buttonUpDataTable);
            this.Controls.Add(this.textBoxFiltr);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelCountR);
            this.Controls.Add(this.numericUpDownRID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllReadline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllReadline_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpDataTable;
        private System.Windows.Forms.TextBox textBoxFiltr;
        private System.Windows.Forms.Button buttonFiltr;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelCountR;
        private System.Windows.Forms.NumericUpDown numericUpDownRID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}