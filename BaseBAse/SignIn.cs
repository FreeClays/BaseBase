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
using System.Xml;

namespace BaseBAse
{
    public partial class SignIn : Form
    {
        private SQLiteConnection DB;
        public SignIn()
        {
            InitializeComponent();
        }

     
        private async void SignIn_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataReader reader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Account WHERE login = @Login AND pass = @PASS", DB);

            command.Parameters.AddWithValue("@Login", textBox1.Text);
            command.Parameters.AddWithValue("@PASS", textBox2.Text);

            

            try {
                reader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                if (await reader.ReadAsync()) {
                    
                    var Main = new Divisions();
                    Main.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Неправильный логин или пароль");                
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Reg = new RegSign();
            Reg.Show();
        }
    }
}
