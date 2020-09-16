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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox1.BackgroundImage = Properties.Resources.User2;
            panel1.BackColor = Color.FromArgb(0, 134, 251);
            textBox1.ForeColor = Color.FromArgb(0, 134, 251);

            pictureBox2.BackgroundImage = Properties.Resources.Lock1;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            pictureBox3.BackgroundImage = Properties.Resources.Email1;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();          
            textBox2.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.Lock2;
            panel2.BackColor = Color.FromArgb(0, 134, 251);
            textBox2.ForeColor = Color.FromArgb(0, 134, 251);

            pictureBox1.BackgroundImage = Properties.Resources.User1;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            pictureBox3.BackgroundImage = Properties.Resources.Email1;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.Email2;
            panel3.BackColor = Color.FromArgb(0, 134, 251);
            textBox3.ForeColor = Color.FromArgb(0, 134, 251);

            pictureBox1.BackgroundImage = Properties.Resources.User1;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            pictureBox2.BackgroundImage = Properties.Resources.Lock1;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }
    }
}
