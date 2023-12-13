using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseBAse
{
    public partial class Staff_Units : Form
    {
        private SQLiteConnection DB;
        public Staff_Units()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingPatient();
        }

        private async void LoadingPatient()
        {
            dataGridViewPatient.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Staff_Units", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["staffing_code"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["dolzhnost"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["salary"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage2"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["otpusk"]);

                }

                foreach (string[] s in data)
                {
                    dataGridViewPatient.Rows.Add(s);
                }
                dataGridViewPatient.ClearSelection();

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

        private void button2_Click(object sender, EventArgs e)
        {
            var DoctorsForm = new Divisions();
            DoctorsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RecepForm = new Distribution_staff_units();
            RecepForm.Show();
            this.Hide();
        }

        private void dataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
