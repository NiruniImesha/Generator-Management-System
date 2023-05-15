using GeneratorManagementSyestem.View;
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
    public partial class Dashboard : Form
    {
        public Dashboard(string userName)
        {
            InitializeComponent();
            string user = userName;
        }
        
        private void btnGenView_Click(object sender, EventArgs e)
        {
            ViewGenerators newChild = new ViewGenerators();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            serviceHistory newChild = new serviceHistory();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void add_generator_Click(object sender, EventArgs e)
        {
            AddGenerator newChild = new AddGenerator();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnAddServices_Click(object sender, EventArgs e)
        {
            InsertServiceHistory newChild = new InsertServiceHistory();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnAddGeneratorActions_Click(object sender, EventArgs e)
        {
            generatorOperations newChild = new generatorOperations();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnDailyUsage_Click(object sender, EventArgs e)
        {
            DailyGeneratorUsage newChild = new DailyGeneratorUsage();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUser newChild = new addUser();
            newChild.MdiParent = this;
            newChild.Show();
        }
    }
}
