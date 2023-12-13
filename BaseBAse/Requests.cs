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
    public partial class Requests : Form
    {
        private SQLiteConnection DB;
        public Requests()
        {
            InitializeComponent();
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
        }

        private async void buttonReq1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Подразделения";
            dataGridView1.Columns[2].HeaderText = "Отдел";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Divisions\r\nWHERE bonus_percentage1 > 25\r\nGROUP BY type_div=\"Отдел\"", DB);
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
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                    
                sqlReader?.Close();
            }

        }

        private async void buttonReq2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Должность";
            dataGridView1.Columns[2].HeaderText = "Оклад";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки2";
            dataGridView1.Columns[4].HeaderText = "Отпуск";
            dataGridView1.Columns[5].HeaderText = "Зарплата";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Staff_Units\r\nWHERE salary >50000 AND salary <70000", DB);
            List<string[]> data = new List<string[]>(); 
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["staffing_code"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["dolzhnost"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["salary"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage2"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["otpusk"]);
                    data[data.Count - 1][5] = Convert.ToString(sqlReader["ZP"]);


                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Должность";
            dataGridView1.Columns[2].HeaderText = "Оклад";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки2";
            dataGridView1.Columns[4].HeaderText = "Отпуск";
            dataGridView1.Columns[5].HeaderText = "Зарплата";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Staff_Units\r\nWHERE dolzhnost = \"Механик\" or dolzhnost = \"Сварщик\"", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["staffing_code"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["dolzhnost"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["salary"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage2"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["otpusk"]);
                    data[data.Count - 1][5] = Convert.ToString(sqlReader["ZP"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Должность";
            dataGridView1.Columns[2].HeaderText = "Оклад";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки1";
            dataGridView1.Columns[4].HeaderText = "Процент надбавки2";
            dataGridView1.Columns[5].HeaderText = "Зарплата";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT DISTINCT staffing_code, dolzhnost, salary, bonus_percentage1, bonus_percentage2, salary*(1+bonus_percentage1/100+bonus_percentage2/100) AS SL FROM Divisions, Staff_Units\r\nGROUP BY staffing_code, dolzhnost", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["staffing_code"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["dolzhnost"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["salary"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage1"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["bonus_percentage2"]);
                    data[data.Count - 1][5] = Convert.ToString(sqlReader["SL"]);




                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Должность";
            dataGridView1.Columns[2].HeaderText = "Оклад";
            dataGridView1.Columns[3].HeaderText = "Среднее значение оклада";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT staffing_code, dolzhnost, salary, AVG(salary) AS AVG FROM Staff_Units\r\nGROUP BY dolzhnost", DB);
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
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["AVG"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq8_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Подразделение";
            dataGridView1.Columns[2].HeaderText = "Отдел";
            dataGridView1.Columns[3].HeaderText = "процент надбавки 1";
            dataGridView1.Columns[4].HeaderText = "минимальный";
            dataGridView1.Columns[5].HeaderText = "максимальный";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT code_div, name_div, type_div, bonus_percentage1, min(bonus_percentage1) AS min, max(bonus_percentage1) AS max FROM Divisions\r\nGROUP BY name_div", DB);
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
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["min"]);
                    data[data.Count - 1][5] = Convert.ToString(sqlReader["max"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq9_Click(object sender, EventArgs e)
        {
         SQLiteCommand command1 = new SQLiteCommand($"DROP TABLE Div_Type", DB);
            await command1.ExecuteNonQueryAsync();

            SQLiteCommand command = new SQLiteCommand($"CREATE TABLE  Div_Type as\r\nSELECT * FROM Divisions\r\nWHERE type_div= \"Цех\"", DB);
            await command.ExecuteNonQueryAsync();



            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Подразделение";
            dataGridView1.Columns[2].HeaderText = "Отдел";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки1";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            SQLiteDataReader sqlReader = null;
            SQLiteCommand command2 = new SQLiteCommand($"SELECT code_div, name_div, type_div, bonus_percentage1, min(bonus_percentage1) AS min, max(bonus_percentage1) AS max FROM Divisions\r\nGROUP BY name_div", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command2.ExecuteReaderAsync();
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
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq10_Click(object sender, EventArgs e)
        {
            SQLiteCommand command1 = new SQLiteCommand($"DROP TABLE Cope_Staff_Units", DB);
            await command1.ExecuteNonQueryAsync();

            SQLiteCommand command = new SQLiteCommand($"CREATE TABLE Cope_Staff_Units as\r\nSELECT * FROM Staff_Units", DB);
            await command.ExecuteNonQueryAsync();


            SQLiteDataReader sqlReader = null;
            SQLiteCommand command2 = new SQLiteCommand($"SELECT * From Cope_Staff_Units", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command2.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = Convert.ToString(sqlReader["staffing_code"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["dolzhnost"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["salary"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage2"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["otpusk"]);
                    data[data.Count - 1][5] = Convert.ToString(sqlReader["ZP"]);


                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq11_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"DELETE FROM Cope_Staff_Units\r\nWHERE bonus_percentage2 >35", DB);
            await command.ExecuteNonQueryAsync();


            SQLiteDataReader sqlReader = null;
            SQLiteCommand command2 = new SQLiteCommand($"SELECT * From Cope_Staff_Units", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command2.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = Convert.ToString(sqlReader["staffing_code"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["dolzhnost"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["salary"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage2"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["otpusk"]);
                    data[data.Count - 1][5] = Convert.ToString(sqlReader["ZP"]);


                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq12_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"UPDATE Cope_Staff_Units set salary= salary*1.2", DB);
            await command.ExecuteNonQueryAsync();
        }

        private async void buttonReq4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Должность";
            dataGridView1.Columns[2].HeaderText = "Оклад";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки2";
            dataGridView1.Columns[4].HeaderText = "Отпуск";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Staff_Units Where dolzhnost = @dolzhnost and salary > 50000", DB);
            command.Parameters.AddWithValue("@dolzhnost", textBox1.Text);
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
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Подразделения";
            dataGridView1.Columns[2].HeaderText = "Отдел";
            dataGridView1.Columns[3].HeaderText = "Процент надбавки1";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Divisions Where bonus_percentage1 between @procent and @procentwo ", DB);
            command.Parameters.AddWithValue("@procent", textBox2.Text);
            command.Parameters.AddWithValue("@procentwo", textBox3.Text);

            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["code_div"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["name_div"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["type_div"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["bonus_percentage1"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
