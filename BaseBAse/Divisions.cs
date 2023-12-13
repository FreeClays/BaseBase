using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Net.Http.Headers;

namespace BaseBAse
{
    public partial class Divisions : Form
    {
        private SQLiteConnection DB;
        public Divisions()
            
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingDoctors();
        }

        private async void LoadingDoctors()
        {
            dataGridViewDoctor.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Divisions", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["code_div"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["name_div"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["type_div"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage1"]);

                }

                foreach (string[] s in data)
                {
                    dataGridViewDoctor.Rows.Add(s);
                }
                dataGridViewDoctor.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PatientForm = new Staff_Units();
            PatientForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var RecepForm = new Distribution_staff_units();
            RecepForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var zaprosi = new Requests();
            zaprosi.Show();
        }

        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
