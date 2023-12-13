namespace BaseBAse
{
    partial class Distribution_staff_units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Distribution_staff_units));
            this.dataGridViewRecep = new System.Windows.Forms.DataGridView();
            this.idRecep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecep
            // 
            this.dataGridViewRecep.AllowUserToAddRows = false;
            this.dataGridViewRecep.AllowUserToDeleteRows = false;
            this.dataGridViewRecep.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridViewRecep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecep,
            this.idDoc,
            this.idPatient});
            this.dataGridViewRecep.Location = new System.Drawing.Point(126, 33);
            this.dataGridViewRecep.Name = "dataGridViewRecep";
            this.dataGridViewRecep.ReadOnly = true;
            this.dataGridViewRecep.RowHeadersVisible = false;
            this.dataGridViewRecep.Size = new System.Drawing.Size(511, 366);
            this.dataGridViewRecep.TabIndex = 0;
            this.dataGridViewRecep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecep_CellContentClick);
            // 
            // idRecep
            // 
            this.idRecep.HeaderText = "Код распределения шт.ед.";
            this.idRecep.Name = "idRecep";
            this.idRecep.ReadOnly = true;
            this.idRecep.Width = 170;
            // 
            // idDoc
            // 
            this.idDoc.HeaderText = "Код подразделения";
            this.idDoc.Name = "idDoc";
            this.idDoc.ReadOnly = true;
            this.idDoc.Width = 170;
            // 
            // idPatient
            // 
            this.idPatient.HeaderText = "Код штатной единицы";
            this.idPatient.Name = "idPatient";
            this.idPatient.ReadOnly = true;
            this.idPatient.Width = 170;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 452);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Distribution_staff_units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRecep);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Distribution_staff_units";
            this.Text = "Распределение штатных едениц";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
    }
}