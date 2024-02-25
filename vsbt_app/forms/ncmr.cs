using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsbt_app.forms
{
    public partial class ncmr : Form
    {
        public EventHandler ReloadEmployees; /// wyświetlanie okna w osobnym oknie 
        public ncmr()
        {
            InitializeComponent();
        }

        private void ncmr_Load(object sender, EventArgs e)
        {

        }
    }
}
