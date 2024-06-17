using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rapport_Journalier.Controller;

namespace Rapport_Journalier.GUI.Auth
{
    public partial class Register : Form
    {
        public static String Mat,Nom;
        public int ins;
        public Register()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String[] Data = { bnfTxbNom.Text, bnfTxbPostnom.Text, bnfTxbprenom.Text, cbxSexe.SelectedItem.ToString(), bnfTxbTEL.Text, bnfTxbAdresse.Text, cbxProv.SelectedItem.ToString(), bnfTxbTerri.Text, bnfTxbPWD.Text, bnfTxbMail.Text, cbxPoste.SelectedItem.ToString() };
            this.ins=Controller.UserController.Create(Data);
            Mat= Controller.UserController.Mat_Users;
            Nom = Controller.UserController.Nom;
            AdminForm ad=new AdminForm();
            UsersForm form = new UsersForm();
            if (ins > 0)
            {
                if (Controller.UserController.Roles != 1)
                {
                    MessageBox.Show("Inscription reussi " + Mat);
                    form.Show();
                    this.Hide();
                }
            }
            else 
            {
                MessageBox.Show("Inscription  a échoué " + Mat);
            }
        }
    }
}
