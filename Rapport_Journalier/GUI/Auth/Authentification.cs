using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Zoo.Views.Layouts;

namespace Gestion_Zoo.Views.Auth
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "katshioko")
            { this.Hide(); Form_main fg = new Form_main(); fg.Show(); }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
