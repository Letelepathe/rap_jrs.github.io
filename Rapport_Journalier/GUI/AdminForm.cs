using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rapport_Journalier.GUI.Auth;
using Rapport_Journalier.Controller;

namespace Rapport_Journalier.GUI
{
    public partial class AdminForm : Form
    {
        public String mat;
        public String Names;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            mat = UserController.Mat_Users;
            Names = UserController.Nom;
            //MessageBox.Show("matricule egale=" + mat);
            bunifuCustomLblAdmin.Text = "Bienvenu cher Admin "+ Names;
            bunifuCustomDgTaches.Rows.Clear();
            TachesController.index(bunifuCustomDgTaches, bunifuCustomLblComptable, bunifuCustomLblAutres);
            AgentsController.index(bunifuCustomDgEmploye);
            lblMat.Text ="Matricule :"+ mat;
            bunifuCustomLblTous.Text = TachesController.getNumberAll().ToString() ;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bunifuCustomDgTaches.Rows.Clear();
            TachesController.index(bunifuCustomDgTaches, bunifuCustomLblComptable, bunifuCustomLblAutres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("voulez vous vous deconnectez?", "Deconnexion", MessageBoxButtons.YesNo);
            if (rd == DialogResult.Yes)
            {
                this.Close();
                Login lg = new Login();
                lg.Visible = true;
            }
            else
            { }
        }
    }
}
