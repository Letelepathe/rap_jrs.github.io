using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Rapport_Journalier.GUI.Auth;
using Rapport_Journalier.Controller;

namespace Rapport_Journalier.GUI
{
    public partial class UsersForm : Form
    {
        private String[] bwaka;
        public String mat;
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            mat = UserController.Mat_Users;
            TachesController.Show(mat,bunifuCustomDataGrid1);
            bnfMcLBL.Text = "Copyright by McMpisangu " + DateTime.Now.Year.ToString()+" All reserved by MCGALAXIE TECH";
           //bunifuCustomDataGrid1.Rows.Add(bwaka[0].ToString());
            MessageBox.Show("m  atricule egale=" + mat);
            bunifuCustomLabel1.Text = "Bienvenue Monsieur(maDame) " + UserController.Nom;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int agnum = AgentsController.NUM_AG(mat);
            String[] bwaka = { agnum.ToString(), bunifuMaterialTextbox1.Text, bunifuDatepicker1.Value.ToString("dd-MM-yyyy"), bunifuDatepicker2.Value.ToString("dd-MM-yyyy"), richTextBox1.Text, dateTimePicker1.Value.ToString("H:m:s"), dateTimePicker2.Value.ToString("H:m:s") };
            int ins = TachesController.Create(bwaka);
            if (ins > 0)
            {
                if (dateTimePicker2.Value.Hour <= 16 && dateTimePicker1.Value.Hour == 8 && bunifuDatepicker1.Value.Day < bunifuDatepicker2.Value.Day)
                {
                    MessageBox.Show("Nouvelle taches enregistrer monsieur (dame) " + UserController.Nom);
                    bunifuCustomDataGrid1.Rows.Clear();
                    TachesController.Show(mat, bunifuCustomDataGrid1);
                    BunifuMaterialTextbox []txt = { bunifuMaterialTextbox1 };
                    Config.ValidateData.ResetData(txt);
                    RichTextBox[] Rtxt = { richTextBox1 };
                    Config.ValidateData.ResetData(Rtxt);
                }
                else
                {
                    MessageBox.Show("L'heure et date indiquer ne pas ceux du travail veuiller reajuster les horaires svp monsieur (dame) " + UserController.Nom);
                }
            }
            else
            {
                MessageBox.Show("Nouvelle taches ne pas enregistrer monsieur (dame) " + UserController.Nom);
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            TachesController.Show(mat, bunifuCustomDataGrid1, bunifuTextbox1.text);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            TachesController.Show(mat, bunifuCustomDataGrid1);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            BunifuMaterialTextbox[] txt = { bunifuMaterialTextbox1 };
            Config.ValidateData.ResetData(txt);
            RichTextBox[] Rtxt = { richTextBox1 };
            Config.ValidateData.ResetData(Rtxt);
        }
    }
}
