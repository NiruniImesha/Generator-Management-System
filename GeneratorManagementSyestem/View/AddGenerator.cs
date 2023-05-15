using CrystalDecisions.CrystalReports.Engine;
using GeneratorManagementSyestem.Controller;
using GeneratorManagementSyestem.Model;
using GeneratorManagementSyestem.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace GeneratorManagementSyestem
{
    public partial class AddGenerator : Form
    {
        GeneratorController genCon = new GeneratorController();
        ServiceController serveCon = new ServiceController();

        generatorModel genMod = new generatorModel();
        serviceModel serveMod = new serviceModel();

        public AddGenerator()
        {
            InitializeComponent();
            genCon.generatorCode(genMod);
            serveCon.serviceCode(serveMod);

            genId.Text = genMod.GenNo;
            model.Focus();            
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox2.Enabled =true;
                groupBox2.Focus();                
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox3.Focus();
                genMod.FirstServiceHours = 0;
                genMod.FirstServiceMonth1 = 0;

            }
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void model_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (model.Text != "")
                {
                    frequency.Enabled = true;
                    frequency.Focus();
                }
                else
                {
                    MessageBox.Show("Enter Model Name!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frequency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (frequency.Text != "")
                {
                    tankSize.Enabled = true;
                    tankSize.Focus();
                }
                else
                {
                    MessageBox.Show("Enter frequency!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tankSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (tankSize.Text != "")
                {
                    checkBox2.Enabled = true;
                    checkBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Enter tank size!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genMod.GenNo = genId.Text;
            genMod.Model = model.Text;
            genMod.Name = name.Text;
            genMod.Frequency = Convert.ToInt32(frequency.Text);
            genMod.TankSize = Convert.ToInt32(tankSize.Text);
            genMod.FirstServiceHours = Convert.ToInt32(fhours.Text);
            genMod.FirstServiceMonth1 = Convert.ToInt32(fmonths.Text);

            serveMod.GeneratorID = genId.Text;
            serveMod.EngineserviceDurationHours1 = Convert.ToInt32(ehours.Text);
            serveMod.EngineserviceDurationMonths1 = Convert.ToInt32(emonths.Text);
            serveMod.AirserviceDurationHours1 = Convert.ToInt32(ahours.Text);
            serveMod.AirserviceDurationMonths1 = Convert.ToInt32(amonths.Text);
            serveMod.SedimentserviceDurationHours1 = Convert.ToInt32(shours.Text);
            serveMod.SedimentserviceDurationMonths1 = Convert.ToInt32(smonths.Text);
            serveMod.ValveserviceDurationHours1 = Convert.ToInt32(vhours.Text);
            serveMod.ValveserviceDurationMonths1 = Convert.ToInt32(vmonths.Text);
            serveMod.FuelserviceDurationHours1 = Convert.ToInt32(fuhours.Text);
            serveMod.FuelserviceDurationMonths1 = Convert.ToInt32(fumonths.Text);
            serveMod.FuelSeviceDurationYears1 = Convert.ToInt32(fuyears.Text);
            serveMod.SparkserviceDurationHours1 = Convert.ToInt32(sphours.Text);
            serveMod.SparkserviceDurationMonths1 = Convert.ToInt32(spmonths.Text);

            if (genCon.addGenerator(genMod) && serveCon.addService(serveMod))
            {
                this.Dispose();
                //this.print();
                this.Hide();
                this.Close();
                ViewGenerators newChild = new ViewGenerators();
                newChild.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error..!", "Add generator", MessageBoxButtons.OK);
            }
        }

        public void print()
        {
            ReportDocument report = new ReportDocument();

            string path = Path.Combine(Environment.CurrentDirectory, @"C:\Users\G3 Developer\Desktop\Anushka\GeneratorManagementSyestem\GeneratorManagementSyestem\Report\CrystalReport1.rpt");
            report.Load(path);
            report.DataSourceConnections.Clear();

            report.SetParameterValue("Generator_name", genId.Text);
            report.SetParameterValue("Generator_model", model.Text);
            report.SetParameterValue("frequency", frequency.Text);
            report.SetParameterValue("tanksize", tankSize.Text);
            report.SetParameterValue("firstServiceHours", fhours.Text);
            report.SetParameterValue("FirstSetviceMonths", fmonths.Text);
            report.SetParameterValue("EngineHours", ehours.Text);
            report.SetParameterValue("EngineMonths", emonths.Text);
            report.SetParameterValue("AirHours", ahours.Text);
            report.SetParameterValue("AirMonths", amonths.Text);
            report.SetParameterValue("SedimentHours", shours.Text);
            report.SetParameterValue("SedimentMonths", smonths.Text);
            report.SetParameterValue("ValveHours", vhours.Text);
            report.SetParameterValue("ValveMonths", vmonths.Text);
            report.SetParameterValue("SparkHours", sphours.Text);
            report.SetParameterValue("SparkMonths", spmonths.Text);
            report.SetParameterValue("FuelHours", fuhours.Text);
            report.SetParameterValue("FuelMonths", fumonths.Text);
            report.SetParameterValue("FuelYears", fuyears.Text);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Visible = true;

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
