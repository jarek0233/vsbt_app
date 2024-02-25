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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formhijo) /// wyświetlania okien w oknie w aplikacji 
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

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ncmr frm = new ncmr(); /// wyświetlanie okna plaikacji z innego formsa w osobnym oknie
            frm.ReloadEmployees += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new listcmr()); /// wyświetlania okien w oknie w aplikacji 
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
