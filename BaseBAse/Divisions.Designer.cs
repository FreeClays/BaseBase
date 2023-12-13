namespace BaseBAse
{
    partial class Divisions
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Divisions));
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.Code_div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.AllowUserToAddRows = false;
            this.dataGridViewDoctor.AllowUserToDeleteRows = false;
            this.dataGridViewDoctor.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_div,
            this.name_div,
            this.type_div,
            this.bonus1});
            this.dataGridViewDoctor.Location = new System.Drawing.Point(22, 68);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.ReadOnly = true;
            this.dataGridViewDoctor.RowHeadersVisible = false;
            this.dataGridViewDoctor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDoctor.ShowEditingIcon = false;
            this.dataGridViewDoctor.Size = new System.Drawing.Size(445, 199);
            this.dataGridViewDoctor.TabIndex = 0;
            this.dataGridViewDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctor_CellContentClick);
            // 
            // Code_div
            // 
            this.Code_div.HeaderText = "Код";
            this.Code_div.Name = "Code_div";
            this.Code_div.ReadOnly = true;
            this.Code_div.Width = 40;
            // 
            // name_div
            // 
            this.name_div.HeaderText = "Подразделение";
            this.name_div.Name = "name_div";
            this.name_div.ReadOnly = true;
            this.name_div.Width = 150;
            // 
            // type_div
            // 
            this.type_div.HeaderText = "Тип подразделения";
            this.type_div.Name = "type_div";
            this.type_div.ReadOnly = true;
            // 
            // bonus1
            // 
            this.bonus1.HeaderText = "Процент надбавки 1";
            this.bonus1.Name = "bonus1";
            this.bonus1.ReadOnly = true;
            this.bonus1.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 478);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Divisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 478);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Divisions";
            this.Text = "Подразделения";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_div;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_div;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_div;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus1;
    }
}

