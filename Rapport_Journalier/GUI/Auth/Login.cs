using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Rapport_Journalier.GUI;
using Rapport_Journalier.Controller;

namespace Rapport_Journalier.GUI.Auth
{
    public partial class Login : Form
    {
        private String[] bwaka;
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int c;
            //Thread tr = new Thread(seConn);
            //tr.Name = "Proc_Admin";
            //tr.Start();
           bwaka= AuthController.Login(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text);
           if ( bwaka!=null && bwaka.Length > 0)
           {
               c = Convert.ToInt16(bwaka[1]);
               UserController.Mat_Users = bwaka[0];
               UserController.Nom = bwaka[2];
               seConn(c);
           }
           else
           {
               MessageBox.Show("Mot de passe ou nom d'utilisateur incorrect");
           }
           //seConn();


        }

        private void seConn(int role)
        {
            if (role == 1)
            {
                AdminForm adm = new AdminForm();
                adm.Visible = true;
                this.Hide();
            }
            else
            {
                UsersForm us = new UsersForm();
                us.Visible = true;
                this.Hide();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new Register();
            rg.Visible = true;
        }

        private void c(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
