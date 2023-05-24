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

namespace GeneratorManagementSyestem.View
{
    public partial class InsertServiceHistory : Form
    {
        serviceHistoryModel hMod = new serviceHistoryModel();
        generatorModel gMod = new generatorModel();

        historyController hCon = new historyController();
        GeneratorController genCon = new GeneratorController();

        userController uCon = new userController();
        userModel uMod = new userModel();

        private string userID_main;

        public InsertServiceHistory()
        {
            InitializeComponent();
            addGenerator();
            cbGenerator.SelectedIndex = 0;
            cbService.SelectedIndex = 0;
            
        }

        public InsertServiceHistory(string userID_main)
        {
            InitializeComponent();

            this.userID_main = userID_main;
            uMod.UserID_main = userID_main;

            addGenerator();
            cbGenerator.SelectedIndex = 0;
            cbService.SelectedIndex = 0;

            Usre_ID.Text = uMod.UserID_main;
            Usre_ID.ReadOnly = true;
        }

        private void addGenerator()
        {
            DataSet dsGen = genCon.getAllGeneratorNames();
            for (int i = 0; i < dsGen.Tables[0].Rows.Count; i++)
            {
                cbGenerator.Items.Add(dsGen.Tables[0].Rows[i][0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hMod.GeneratorID = cbGenerator.Text;
            hMod.ServiceDate =dtpHistory.Text;
            hMod.CurrentTotDuration = hCon.getCurrentDuration(hMod);
            hMod.ServiceType = cbService.Text;
            hMod.User_ID = Usre_ID.Text;

            if (hCon.addGeneratorHistory(hMod))
            {
                this.Dispose();
                this.Hide();
                serviceHistory newChild = new serviceHistory();
                newChild.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error..!", "Add service", MessageBoxButtons.OK);
            }
        }
        
    }
}
