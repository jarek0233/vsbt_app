using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; /// systemowe definicja polaczenia sql
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vsbt_app.forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vsbt_app
{
    public partial class logowanie : Form
    {
        public logowanie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) /// buton do logowania dla kierowców
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "server=192.168.88.211;" + "database=login;" + "user id=sa;" + "password=Qlbnfa2020##;"; /// dane połączeniowe do SQL serwer
            string query = "Select * from login where login = '" + textBox2.Text.Trim() + "' and haslo = '" + textBox1.Text.Trim() + "'"; /// wybranie bazy i tabeli
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            _ = sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                menu objFrmMain = new menu(); /// otwiera po poprawnym zalogowaniu formsa menu
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("niepoprawne dane do logowania");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            textBox1.PasswordChar = '*'; /// maskowanie hasła
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*'; /// maskowanie hasła
        }

        private void button2_Click(object sender, EventArgs e) /// buton do logowania dla adminów
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "server=192.168.88.211;" + "database=login;" + "user id=sa;" + "password=Qlbnfa2020##;"; /// dane połączeniowe do SQL serwer
            string query = "Select * from logina where login = '" + textBox3.Text.Trim() + "' and haslo = '" + textBox4.Text.Trim() + "'"; /// wybranie bazy i tabeli
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            _ = sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                admin objFrmMain = new admin(); /// otwiera po poprawnym zalogowaniu formsa menu
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("niepoprawne dane do logowania");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            prawo frm = new prawo(); /// wyświetlanie osobnego okna forms
            frm.ReloadEmployees += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            apkinfo frm = new apkinfo(); /// wyświetlanie osobnego okna forms
            frm.ReloadEmployees += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }
    }
}
