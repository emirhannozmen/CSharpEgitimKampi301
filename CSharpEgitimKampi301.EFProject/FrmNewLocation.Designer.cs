namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmNewLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDayNight = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lokasyon Id  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ülke :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rehber :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kapasite :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gün Gece :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 22);
            this.txtId.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(119, 128);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(154, 22);
            this.txtCountry.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(119, 198);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(154, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // txtDayNight
            // 
            this.txtDayNight.Location = new System.Drawing.Point(119, 268);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(154, 22);
            this.txtDayNight.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(119, 93);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 22);
            this.txtCity.TabIndex = 13;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkBlue;
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(15, 343);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(258, 34);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(258, 34);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(15, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(258, 34);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(15, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(258, 34);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 479);
            this.dataGridView1.TabIndex = 19;
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(119, 163);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(154, 22);
            this.nudCapacity.TabIndex = 20;
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(119, 233);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(154, 24);
            this.cmbGuide.TabIndex = 21;
            // 
            // FrmNewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 549);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewLocation";
            this.Text = "FrmNewLocation";
            this.Load += new System.EventHandler(this.FrmNewLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDayNight;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cmbGuide;
    }
}