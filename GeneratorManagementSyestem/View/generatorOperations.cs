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
    public partial class generatorOperations : Form
    {
        GeneratorController genCon = new GeneratorController();
        dailyOperationController opCon = new dailyOperationController();

        generatorModel genMod = new generatorModel();
        dailyServiceDataModel opMod = new dailyServiceDataModel();

        public generatorOperations()
        {
            InitializeComponent();
            addGEnerator();
            //txtuser.Text = Dashboard(userName);
        }

        private void addGEnerator()
        {
            DataSet ds = genCon.getAllGeneratorNames();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbGenerator.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            cmbGenerator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            opCon.serviceCode(opMod, genMod);
            opMod.StartDate = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));
            opMod.StartTime = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            opMod.StartUser = txtuser.Text;
            if (opCon.addDailyOperator(opMod))
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error..!", "Add generator operator", MessageBoxButtons.OK);
            }
            //if starts, generate new Id and assign values
            // if stopped, select id and update
        }

        private void cmbGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            genMod.Name = cmbGenerator.Text;
            genMod.GenNo = opCon.getGeneratorID(genMod);

            bool check = opCon.check(genMod);

            if (check == true)
            {
                btn_Stop.Visible = true;
                btn_Stop.Enabled = true;
                button_start.Visible = false;
                button_start.Enabled = false;
            }
            else
            {
                button_start.Visible = true;
                button_start.Enabled = true;
                btn_Stop.Visible = false;
                btn_Stop.Enabled = false;
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if (txtuser.Text.Length == 4)
            {
                cmbGenerator.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            opMod.StopDate = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));
            opMod.StopTime = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            opMod.StopUser = txtuser.Text;
            
            if (opCon.updateDailyOperator(opMod, genMod))                
            {
                genCon.changeTotDuration(genMod);
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error..!", "Add generator operator", MessageBoxButtons.OK);
            }
        }
    }
}
