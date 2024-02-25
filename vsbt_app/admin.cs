using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vsbt_app.forms;

namespace vsbt_app
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formhijo) /// deklaracja wyświetlanie okna w oknie pod menu 
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            tiradd frm = new tiradd(); /// wyświetlanie okna w osobnym oknie 
            frm.ReloadEmployees += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit(); /// przycisk do zamykania
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ncmr frm = new ncmr(); /// wyświetlanie okna w osobnym oknie 
            frm.ReloadEmployees += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new listcmr()); ///wyświetlanie okna w oknie pod menu po naciśnieciu guzika 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new listuzytkownicy()); ///wyświetlanie okna w oknie pod menu po naciśnieciu guzika 
        }
    }
}
