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
    public partial class Regform : Form
    {
        public Regform()
        {
            InitializeComponent();
        }

        private void btnRegistre_Click(object sender, EventArgs e)
        {
            if (textUtil.Text.Length<3||texMdp.Text.Length<3)
            {
                MessageBox.Show("Passe ou non d'utilisateur invalide !");
            }else
            {
                string dir = textUtil.Text;
                Directory.CreateDirectory("data\\" + dir);

                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string verifUti = AesCryp.Encrypt(textUtil.Text)  ;
                string verifPass = AesCryp.Encrypt(texMdp.Text);
                sw.WriteLine(verifUti);
                sw.WriteLine(verifPass);
                sw.Close();

                MessageBox.Show("vous etes inscrit avec succes .", textUtil.Text);
                this.Close();

            }
        }

        private void labMdp_Click(object sender, EventArgs e)
        {

        }
    }
}
