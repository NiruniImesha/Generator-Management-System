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
    public partial class DailyGeneratorUsage : Form
    {
        dailyServiceDataModel dMod = new dailyServiceDataModel();
        generatorModel genMod = new generatorModel();


        dailyOperationController dCon = new dailyOperationController();
        GeneratorController genCon = new GeneratorController();
        dailyOperationController genOp = new dailyOperationController();

        public DailyGeneratorUsage()
        {
            InitializeComponent();            
            addGenerator();
        }

        private void addGenerator()
        {
            DataSet dsGen = genCon.getAllGeneratorNames();
            for (int i = 0; i < dsGen.Tables[0].Rows.Count; i++)
            {
                cmbGenerator.Items.Add(dsGen.Tables[0].Rows[i][0]);
            }
            cmbGenerator.SelectedIndex = 0;
        }

        private void cmbGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            genMod.Name = cmbGenerator.Text;
            genMod.GenNo = genCon.getGeneratorByName(genMod);
            dCon.getDailyOperationsHistory(genMod, dgvDailyOperations);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            genMod.Name = cmbGenerator.Text;
            genMod.GenNo = genCon.getGeneratorByName(genMod);
            genMod.Start_date_range = dateTimePicker1.Text;
            genMod.End_date_range = dateTimePicker2.Text;
            label3.Text = genMod.Start_date_range;
            dCon.getDailyOperationsHistory01(genMod, dgvDailyOperations);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            genMod.Name = cmbGenerator.Text;
            genMod.GenNo = genCon.getGeneratorByName(genMod);
            genMod.Start_date_range = dateTimePicker1.Text;
            genMod.End_date_range = dateTimePicker2.Text;
            dCon.getDailyOperationsHistory01(genMod, dgvDailyOperations);
        }
    }
}
