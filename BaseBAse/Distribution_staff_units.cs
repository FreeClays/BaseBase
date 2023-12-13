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
    public partial class Distribution_staff_units : Form
    {
        private SQLiteConnection DB;
        public Distribution_staff_units()
        {
            InitializeComponent();
        }

        private async  void Form3_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingReception();
        }

        private async void LoadingReception()
        {
            dataGridViewRecep.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Distribution_staff_units JOIN Staff_Units ON Staff_Units.staffing_code = Distribution_staff_units.staffing_code2 JOIN Divisions ON Divisions.code_div = Distribution_staff_units.code_div1", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["distribution_code_pcs"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["name_div"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["dolzhnost"]);

                }

                foreach (string[] s in data)
                {
                    dataGridViewRecep.Rows.Add(s);
                }
                dataGridViewRecep.ClearSelection();

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
            var DoctorsForm = new Divisions();
            DoctorsForm.Show();
            this.Hide();
        }

        private void dataGridViewRecep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
