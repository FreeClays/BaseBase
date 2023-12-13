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
    public partial class RegSign : Form
    {
        private SQLiteConnection DB;
        public RegSign()
        {
            InitializeComponent();
        }

        private async void Form5_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();

        }

        private void errorBox(string message)
        {
            MessageBox.Show(
                message,
                "Регистрация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            SQLiteCommand account = new SQLiteCommand("SELECT * FROM Account WHERE login = @login ", DB);

            account.Parameters.AddWithValue("@login", textBoxLogin.Text);


            SQLiteDataReader reader = null;

            reader = (SQLiteDataReader)await account.ExecuteReaderAsync();

            if (textBoxLogin.Text == "" || this.textBoxFam.Text == "" || this.textBoxName.Text == "" || this.textBoxOtch.Text == "" || this.textBoxSpec.Text == "" || this.textBoxPass.Text == "")
            {
                errorBox("Все поля должны быть заполнены");
            }
            else if (await reader.ReadAsync())
            {
                errorBox("Учетная запись с таким телефоном или E-Mail существует");
            }

            else
            {
                SQLiteCommand command1 = new SQLiteCommand("INSERT INTO Account (login, pass) VALUES(@login, @pass); ", DB);

                command1.Parameters.AddWithValue("@login", this.textBoxLogin.Text);
                command1.Parameters.AddWithValue("@pass", this.textBoxPass.Text);



                await command1.ExecuteNonQueryAsync();

                SQLiteCommand command2 = new SQLiteCommand("INSERT INTO doctor (docFam, docName, docOtch, docSpec) VALUES(@Fam, @Name, @Otch, @Spec); ", DB);

                command2.Parameters.AddWithValue("@Fam", this.textBoxFam.Text);
                command2.Parameters.AddWithValue("@Name", this.textBoxName.Text);
                command2.Parameters.AddWithValue("@Otch", this.textBoxOtch.Text);
                command2.Parameters.AddWithValue("@Spec", this.textBoxSpec.Text);



                await command2.ExecuteNonQueryAsync();



                this.Hide();
                var signinForm = new SignIn();
                signinForm.Show();
                signinForm.FormClosed += (s, args) => this.Show();
            }


        }
    }
}
