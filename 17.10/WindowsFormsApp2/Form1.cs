using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Auth_Form : Form
    {
        public Auth_Form()
        {
            InitializeComponent();
        }
        private void AuthButton_Click_1(object sender, EventArgs e)
        {
            string ServerName = textBox3.Text;
            string DataBaseName = textBox4.Text;
            string TableName = textBox5.Text;
            string name = textBox1.Text;
            string second_name = textBox2.Text;
            string loginQuery = "";
            DataBase db = new DataBase("","");
            db = new DataBase($"{ServerName}", $"{DataBaseName}");
            db.openConnection();


            loginQuery = $"SELECT * FROM {TableName} WHERE first_name='{name}' AND second_name='{second_name}'";
            MessageBox.Show($"Неверные данные авторизации", "Что-то не так",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(String.Format(loginQuery, name, second_name),
            db.GetConnection());

            adapter.SelectCommand = command;

            if (adapter.Fill(table) == 1)
            {
                MessageBox.Show($"Вы вошли как: {name} {second_name}", "Успешный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Авторизация не прошла : {name} {second_name}", "Ошибка данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }

        private void Auth_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
