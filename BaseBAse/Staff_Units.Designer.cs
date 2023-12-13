namespace BaseBAse
{
    partial class Staff_Units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Units));
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.Staffing_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolznost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpusk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AllowUserToAddRows = false;
            this.dataGridViewPatient.AllowUserToDeleteRows = false;
            this.dataGridViewPatient.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staffing_code,
            this.Dolznost,
            this.Salary,
            this.bonus2,
            this.otpusk,
            this.ZP});
            this.dataGridViewPatient.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.ReadOnly = true;
            this.dataGridViewPatient.RowHeadersVisible = false;
            this.dataGridViewPatient.Size = new System.Drawing.Size(644, 309);
            this.dataGridViewPatient.TabIndex = 0;
            this.dataGridViewPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatient_CellContentClick);
            // 
            // Staffing_code
            // 
            this.Staffing_code.HeaderText = "Код";
            this.Staffing_code.Name = "Staffing_code";
            this.Staffing_code.ReadOnly = true;
            this.Staffing_code.Width = 40;
            // 
            // Dolznost
            // 
            this.Dolznost.HeaderText = "Должность";
            this.Dolznost.Name = "Dolznost";
            this.Dolznost.ReadOnly = true;
            this.Dolznost.Width = 150;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Оклад";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // bonus2
            // 
            this.bonus2.HeaderText = "Процент надбавки 2";
            this.bonus2.Name = "bonus2";
            this.bonus2.ReadOnly = true;
            this.bonus2.Width = 150;
            // 
            // otpusk
            // 
            this.otpusk.HeaderText = "Отпуск";
            this.otpusk.Name = "otpusk";
            this.otpusk.ReadOnly = true;
            // 
            // ZP
            // 
            this.ZP.HeaderText = "Зарплата";
            this.ZP.Name = "ZP";
            this.ZP.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 524);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Staff_Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 519);
            this.Controls.Add(this.dataGridViewPatient);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Staff_Units";
            this.Text = "Штатные единицы";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staffing_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolznost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus2;
        private System.Windows.Forms.DataGridViewTextBoxColumn otpusk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZP;
    }
}