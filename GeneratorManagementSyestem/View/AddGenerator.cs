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
        serviceModel01 serveMod01 = new serviceModel01();

        serviceHistoryModel shMod = new serviceHistoryModel();

        private string generatorID;
        private string generatorName;
        private string generatorModel;

        public AddGenerator()
        {
            InitializeComponent();
            genCon.generatorCode(genMod);
            serveCon.serviceCode(serveMod);

            genId.Text = genMod.GenNo;

            Total_run_duration_label.Visible = false;
            Total_run_duration.Visible = false;
            Total_run_duration.Enabled = false;

            update_btn.Visible = false;
            update_btn.Enabled = false;

            model.Focus();            
        }

        public AddGenerator(string generatorID, string generatorName, string generatorModel)
        {
            InitializeComponent();

            this.generatorID = generatorID ;
            this.generatorName = generatorName;
            this.generatorModel = generatorModel;

            genMod.GenNo = generatorID;
            serveMod01.GeneratorID = generatorID;

            genMod.Model = generatorModel;
            genMod.Name = generatorName;

            genCon.findGeneratorByID(genMod);

            genId.Text = genMod.GenNo;
            name.Text = generatorName;
            model.Text = generatorModel;
            frequency.Text = genMod.Frequency01;
            tankSize.Text = genMod.TankSize01;
            Total_run_duration.Text = genMod.TotalDuration01;
            fhours.Text = genMod.FirstServiceHours01;
            fmonths.Text = genMod.FirstServiceMonth01;
            
            serveCon.findServiceByID(serveMod01);
            ehours.Text = serveMod01.EngineserviceDurationHours01;
            emonths.Text = serveMod01.EngineserviceDurationMonths01;
            ahours.Text = serveMod01.AirserviceDurationHours01;
            amonths.Text = serveMod01.AirserviceDurationMonths01;
            shours.Text = serveMod01.SedimentserviceDurationHours01;
            smonths.Text = serveMod01.SedimentserviceDurationMonths01;
            vhours.Text = serveMod01.ValveserviceDurationHours01;
            vmonths.Text = serveMod01.ValveserviceDurationMonths01;
            sphours.Text = serveMod01.SparkserviceDurationHours01;
            spmonths.Text = serveMod01.SparkserviceDurationMonths01;
            fuhours.Text = serveMod01.FuelserviceDurationHours01;
            fumonths.Text = serveMod01.FuelserviceDurationMonths01;
            fuyears.Text = serveMod01.FuelSeviceDurationYears01;

            genId.ReadOnly = true;
            name.ReadOnly = true;

            checkBox2.Visible = false;
            checkBox2.Enabled = false;

            button1.Visible = false;
            button1.Enabled = false;        
            
            label1.Text = generatorName;
        }
        private void AddGenerator_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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
            serveMod.EngineserviceDurationHours1 = Convert.ToString(ehours.Text);
            serveMod.EngineserviceDurationMonths1 = Convert.ToString(emonths.Text);
            serveMod.AirserviceDurationHours1 = Convert.ToString(ahours.Text);
            serveMod.AirserviceDurationMonths1 = Convert.ToString(amonths.Text);
            serveMod.SedimentserviceDurationHours1 = Convert.ToString(shours.Text);
            serveMod.SedimentserviceDurationMonths1 = Convert.ToString(smonths.Text);
            serveMod.ValveserviceDurationHours1 = Convert.ToString(vhours.Text);
            serveMod.ValveserviceDurationMonths1 = Convert.ToString(vmonths.Text);
            serveMod.FuelserviceDurationHours1 = Convert.ToString(fuhours.Text);
            serveMod.FuelserviceDurationMonths1 = Convert.ToString(fumonths.Text);
            serveMod.FuelSeviceDurationYears1 = Convert.ToString(fuyears.Text);
            serveMod.SparkserviceDurationHours1 = Convert.ToString(sphours.Text);
            serveMod.SparkserviceDurationMonths1 = Convert.ToString(spmonths.Text);

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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            genMod.GenNo = genId.Text;
            genMod.Model = model.Text;
            genMod.Name = name.Text;
            genMod.Frequency = Convert.ToInt32(frequency.Text);
            genMod.TankSize = Convert.ToInt32(tankSize.Text);
            genMod.FirstServiceHours = Convert.ToInt32(fhours.Text);
            genMod.FirstServiceMonth1 = Convert.ToInt32(fmonths.Text);
            genMod.TotalDuration01 = Total_run_duration.Text;
           

            serveMod.GeneratorID = genId.Text;
            serveMod.EngineserviceDurationHours1 = Convert.ToString(ehours.Text);
            serveMod.EngineserviceDurationMonths1 = Convert.ToString(emonths.Text);
            serveMod.AirserviceDurationHours1 = Convert.ToString(ahours.Text);
            serveMod.AirserviceDurationMonths1 = Convert.ToString(amonths.Text);
            serveMod.SedimentserviceDurationHours1 = Convert.ToString(shours.Text);
            serveMod.SedimentserviceDurationMonths1 = Convert.ToString(smonths.Text);
            serveMod.ValveserviceDurationHours1 = Convert.ToString(vhours.Text);
            serveMod.ValveserviceDurationMonths1 = Convert.ToString(vmonths.Text);
            serveMod.FuelserviceDurationHours1 = Convert.ToString(fuhours.Text);
            serveMod.FuelserviceDurationMonths1 = Convert.ToString(fumonths.Text);
            serveMod.FuelSeviceDurationYears1 = Convert.ToString(fuyears.Text);
            serveMod.SparkserviceDurationHours1 = Convert.ToString(sphours.Text);
            serveMod.SparkserviceDurationMonths1 = Convert.ToString(spmonths.Text);
            genCon.updateGenarator(genMod);
            serveCon.updateService(serveMod);
            MessageBox.Show("Successfully Updated", "Update generator", MessageBoxButtons.OK);
            this.Dispose();
                //this.print();
                this.Hide();
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox2.Enabled = true;
                groupBox2.Visible = true;
                groupBox2.Focus();
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox2.Visible = false;
                groupBox3.Focus();
                genMod.FirstServiceHours = 0;
                genMod.FirstServiceMonth1 = 0;

            }
        }
    }
}
