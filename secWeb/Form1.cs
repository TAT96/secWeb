using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncDec;
using System.IO;

namespace secWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (textUtil.Text.Length < 3 || texMdp.Text.Length < 3)
            {
                MessageBox.Show("pseudo ou mdp invalide");
            }
            else
            {
                string dir = textUtil.Text;
                if (!Directory.Exists("data\\" + dir)) MessageBox.Show(" erreur 404",dir) ;
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string utilisateur = sr.ReadLine();
                    string mdp = sr.ReadLine();
                    sr.Close();

                    string verifUti = AesCryp.Decrypt(utilisateur);
                    string verifPass = AesCryp.Decrypt(mdp);

                    if(verifUti == textUtil.Text && verifPass == texMdp.Text)
                    {
                        MessageBox.Show("Bienvenue ! ", verifUti);
                    }
                    else
                    {
                        MessageBox.Show("Pass ou non d'utilisateur incorrecte ! ");
                    }

                }
            }
        }

        private void btnRegistre_Click(object sender, EventArgs e)
        {
            Regform rf = new Regform();
            rf.Show();

        }

        private void texMdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
