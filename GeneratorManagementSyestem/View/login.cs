using GeneratorManagementSyestem.Controller;
using GeneratorManagementSyestem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorManagementSyestem
{
    public partial class login : Form
    {
        userController uCon = new userController();
        userModel uMod = new userModel();

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uMod.UserName = textBox1.Text;
            uMod.Password = textBox2.Text;
            if (uCon.login(uMod))
            {
                this.Hide();
                Dashboard d = new Dashboard(textBox1.Text);
                d.Show();
            }
            else
            {
                textBox2.Clear();
                textBox1.Clear();
            }
        }
    }
}
