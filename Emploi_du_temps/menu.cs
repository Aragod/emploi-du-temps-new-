using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emploi_du_temps
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gestion_des_formateurs formateur = new Gestion_des_formateurs();
            formateur.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gestion_des_groupes group = new Gestion_des_groupes();
            group.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gestion_des_modules module = new Gestion_des_modules();
            module.Show();
        }
    }
}
