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

namespace vsbt_app.forms
{
    public partial class tiradd : Form
    {
        public EventHandler ReloadEmployees;
        public tiradd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "server=192.168.88.211;" + "database=tir;" + "user id=sa;" + "password=Qlbnfa2020##;";/// sql connection string podłączenia do bazy
            cn.Open(); /// otworzenie połączenia 
            SqlCommand cmd = new SqlCommand("Insert  into tirlist (model,marka,cena,konfiguracja) Values (@model,@marka,@cena,@konfiguracja)", cn); /// dodawanie danych
            cmd.Parameters.AddWithValue("@model", textBox1.Text);
            cmd.Parameters.AddWithValue("@marka", textBox2.Text);
            cmd.Parameters.AddWithValue("@cena", textBox3.Text);
            cmd.Parameters.AddWithValue("@konfiguracja", textBox4.Text);
            cmd.ExecuteReader();
            MessageBox.Show("Ciężarówka dodana poprawnie");
            cn.Close();
        }
    }
}
