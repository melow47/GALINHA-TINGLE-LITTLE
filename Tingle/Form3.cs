using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tingle
{
    public partial class Histórico : Form
    {

        string pastaimg = "";
        Image img_Voltar;
        Image img_EVoltar;

        public Histórico()
        {
            InitializeComponent();


            pastaimg = Application.StartupPath + @"\";

            //Imagens
            img_Voltar = Image.FromFile(pastaimg + "branco.png");
            img_EVoltar = Image.FromFile(pastaimg + "azul.png");



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = img_EVoltar;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = img_Voltar;
        }

    }

}
