﻿using CrystalDecisions.CrystalReports.Engine;
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
            model.Select();
        }

        public AddGenerator(string generatorID, string generatorName, string generatorModel)
        {
            InitializeComponent();

            this.generatorID = generatorID;
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

            string timeString01 = serveMod01.EngineserviceDurationHours01;
            string timeString02 = serveMod01.AirserviceDurationHours01;
            string timeString03 = serveMod01.SedimentserviceDurationHours01;
            string timeString04 = serveMod01.ValveserviceDurationHours01;
            string timeString05 = serveMod01.SparkserviceDurationHours01;
            string timeString06 = serveMod01.FuelserviceDurationHours01;

            TimeSpan timeSpan01 = TimeSpan.Parse(timeString01);
            TimeSpan timeSpan02 = TimeSpan.Parse(timeString02);
            TimeSpan timeSpan03 = TimeSpan.Parse(timeString03);
            TimeSpan timeSpan04 = TimeSpan.Parse(timeString04);
            TimeSpan timeSpan05 = TimeSpan.Parse(timeString05);
            TimeSpan timeSpan06 = TimeSpan.Parse(timeString06);

            int ehoursHours = (int)timeSpan01.TotalHours;
            int ahoursHours = (int)timeSpan02.TotalHours;
            int shoursHours = (int)timeSpan03.TotalHours;
            int vhoursHours = (int)timeSpan04.TotalHours;
            int sphoursHours = (int)timeSpan05.TotalHours;
            int fuhoursHours = (int)timeSpan06.TotalHours;

            ehours.Text = Convert.ToString(ehoursHours);
            ahours.Text = Convert.ToString(ahoursHours);
            shours.Text = Convert.ToString(shoursHours);
            vhours.Text = Convert.ToString(vhoursHours);
            sphours.Text = Convert.ToString(sphoursHours);
            fuhours.Text = Convert.ToString(fuhoursHours);

            emonths.Text = serveMod01.EngineserviceDurationMonths01;
            amonths.Text = serveMod01.AirserviceDurationMonths01;
            smonths.Text = serveMod01.SedimentserviceDurationMonths01;
            vmonths.Text = serveMod01.ValveserviceDurationMonths01;
            spmonths.Text = serveMod01.SparkserviceDurationMonths01;
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

        private void button1_Click(object sender, EventArgs e)
        {
            genMod.GenNo = genId.Text;
            genMod.Model = model.Text;
            genMod.Name = name.Text;
            genMod.Frequency = Convert.ToInt32(frequency.Text);
            genMod.TankSize = Convert.ToInt32(tankSize.Text);
            genMod.FirstServiceHours = Convert.ToInt32(fhours.Text);
            genMod.FirstServiceMonth1 = Convert.ToInt32(fmonths.Text);

            serveMod.EngineserviceDurationHours02 = Convert.ToInt32(ehours.Text);
            serveMod.AirserviceDurationHours02 = Convert.ToInt32(ahours.Text);
            serveMod.SedimentserviceDurationHours02 = Convert.ToInt32(shours.Text);
            serveMod.ValveserviceDurationHours02 = Convert.ToInt32(vhours.Text);
            serveMod.FuelserviceDurationHours02 = Convert.ToInt32(fuhours.Text);
            serveMod.SparkserviceDurationHours02 = Convert.ToInt32(sphours.Text);

            int val01 = serveMod.EngineserviceDurationHours02;
            int val02 = serveMod.AirserviceDurationHours02;
            int val03 = serveMod.SedimentserviceDurationHours02;
            int val04 = serveMod.ValveserviceDurationHours02;
            int val05 = serveMod.FuelserviceDurationHours02;
            int val06 = serveMod.SparkserviceDurationHours02;

            TimeSpan result01 = TimeSpan.FromHours(val01);
            TimeSpan result02 = TimeSpan.FromHours(val02);
            TimeSpan result03 = TimeSpan.FromHours(val03);
            TimeSpan result04 = TimeSpan.FromHours(val04);
            TimeSpan result05 = TimeSpan.FromHours(val05);
            TimeSpan result06 = TimeSpan.FromHours(val06);

            string fromTimeString01 = result01.ToString("hh':'mm':'ss");
            string fromTimeString02 = result02.ToString("hh':'mm':'ss");
            string fromTimeString03 = result03.ToString("hh':'mm':'ss");
            string fromTimeString04 = result04.ToString("hh':'mm':'ss");
            string fromTimeString05 = result05.ToString("hh':'mm':'ss");
            string fromTimeString06 = result06.ToString("hh':'mm':'ss");

            serveMod.GeneratorID = genId.Text;
            serveMod.EngineserviceDurationHours1 = Convert.ToString(fromTimeString01);
            serveMod.EngineserviceDurationMonths1 = Convert.ToString(emonths.Text);
            serveMod.AirserviceDurationHours1 = Convert.ToString(fromTimeString02);
            serveMod.AirserviceDurationMonths1 = Convert.ToString(amonths.Text);
            serveMod.SedimentserviceDurationHours1 = Convert.ToString(fromTimeString03);
            serveMod.SedimentserviceDurationMonths1 = Convert.ToString(smonths.Text);
            serveMod.ValveserviceDurationHours1 = Convert.ToString(fromTimeString04);
            serveMod.ValveserviceDurationMonths1 = Convert.ToString(vmonths.Text);
            serveMod.FuelserviceDurationHours1 = Convert.ToString(fromTimeString05);
            serveMod.FuelserviceDurationMonths1 = Convert.ToString(fumonths.Text);
            serveMod.FuelSeviceDurationYears1 = Convert.ToString(fuyears.Text);
            serveMod.SparkserviceDurationHours1 = Convert.ToString(fromTimeString06);
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

            serveMod.EngineserviceDurationHours02 = Convert.ToInt32(ehours.Text);
            serveMod.AirserviceDurationHours02 = Convert.ToInt32(ahours.Text);
            serveMod.SedimentserviceDurationHours02 = Convert.ToInt32(shours.Text);
            serveMod.ValveserviceDurationHours02 = Convert.ToInt32(vhours.Text);
            serveMod.FuelserviceDurationHours02 = Convert.ToInt32(fuhours.Text);
            serveMod.SparkserviceDurationHours02 = Convert.ToInt32(sphours.Text);

            int val01 = serveMod.EngineserviceDurationHours02;
            int val02 = serveMod.AirserviceDurationHours02;
            int val03 = serveMod.SedimentserviceDurationHours02;
            int val04 = serveMod.ValveserviceDurationHours02;
            int val05 = serveMod.FuelserviceDurationHours02;
            int val06 = serveMod.SparkserviceDurationHours02;

            TimeSpan result01 = TimeSpan.FromHours(val01);
            TimeSpan result02 = TimeSpan.FromHours(val02);
            TimeSpan result03 = TimeSpan.FromHours(val03);
            TimeSpan result04 = TimeSpan.FromHours(val04);
            TimeSpan result05 = TimeSpan.FromHours(val05);
            TimeSpan result06 = TimeSpan.FromHours(val06);

            string fromTimeString01 = result01.ToString("hh':'mm':'ss");
            string fromTimeString02 = result02.ToString("hh':'mm':'ss");
            string fromTimeString03 = result03.ToString("hh':'mm':'ss");
            string fromTimeString04 = result04.ToString("hh':'mm':'ss");
            string fromTimeString05 = result05.ToString("hh':'mm':'ss");
            string fromTimeString06 = result06.ToString("hh':'mm':'ss");

            serveMod.GeneratorID = genId.Text;
            serveMod.EngineserviceDurationHours1 = Convert.ToString(fromTimeString01);
            serveMod.EngineserviceDurationMonths1 = Convert.ToString(emonths.Text);
            serveMod.AirserviceDurationHours1 = Convert.ToString(fromTimeString02);
            serveMod.AirserviceDurationMonths1 = Convert.ToString(amonths.Text);
            serveMod.SedimentserviceDurationHours1 = Convert.ToString(fromTimeString03);
            serveMod.SedimentserviceDurationMonths1 = Convert.ToString(smonths.Text);
            serveMod.ValveserviceDurationHours1 = Convert.ToString(fromTimeString04);
            serveMod.ValveserviceDurationMonths1 = Convert.ToString(vmonths.Text);
            serveMod.FuelserviceDurationHours1 = Convert.ToString(fromTimeString05);
            serveMod.FuelserviceDurationMonths1 = Convert.ToString(fumonths.Text);
            serveMod.FuelSeviceDurationYears1 = Convert.ToString(fuyears.Text);
            serveMod.SparkserviceDurationHours1 = Convert.ToString(fromTimeString06);
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
                fhours.Enabled = true;
                fhours.Focus();
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox2.Visible = false;
                groupBox3.Focus();
                ehours.Enabled = true;
                ehours.Focus();
                genMod.FirstServiceHours = 0;
                genMod.FirstServiceMonth1 = 0;

            }
        }

        private void frequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tankSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frequency_KeyDown_1(object sender, KeyEventArgs e)
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
                    MessageBox.Show("Enter Frequency value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void model_KeyDown_1(object sender, KeyEventArgs e)
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

        private void tankSize_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (tankSize.Text != "")
                {
                    name.Enabled = true;
                    name.Focus();
                }
                else
                {
                    MessageBox.Show("Enter Tank Size!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fhours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void fhours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (fhours.Text != "")
                {
                    fmonths.Enabled = true;
                    fmonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter First service hours value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (name.Text != "")
                {
                    if (genCon.checkName(name.Text))
                    {
                        ehours.Enabled = true;
                        ehours.Focus();
                    }
                    //fhours.Enabled = true;
                    //fhours.Focus();                    
                }
                else
                {
                    MessageBox.Show("Enter generator name!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fmonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (fhours.Text != "")
                {
                    ehours.Enabled = true;
                    ehours.Focus();
                }
                else
                {
                    MessageBox.Show("Enter First service months value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ehours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (ehours.Text != "")
                {
                    emonths.Enabled = true;
                    emonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter First service months value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void emonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (emonths.Text != "")
                {
                    ahours.Enabled = true;
                    ahours.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ahours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (ahours.Text != "")
                {
                    amonths.Enabled = true;
                    amonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void amonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (amonths.Text != "")
                {
                    shours.Enabled = true;
                    shours.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void shours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (shours.Text != "")
                {
                    smonths.Enabled = true;
                    smonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void smonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (smonths.Text != "")
                {
                    vhours.Enabled = true;
                    vhours.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void vhours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (vhours.Text != "")
                {
                    vmonths.Enabled = true;
                    vmonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void vmonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (vmonths.Text != "")
                {
                    sphours.Enabled = true;
                    sphours.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void sphours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (sphours.Text != "")
                {
                    spmonths.Enabled = true;
                    spmonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void spmonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (spmonths.Text != "")
                {
                    fuhours.Enabled = true;
                    fuhours.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fuhours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (fuhours.Text != "")
                {
                    fumonths.Enabled = true;
                    fumonths.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fumonths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (fumonths.Text != "")
                {
                    fuyears.Enabled = true;
                    fuyears.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fuyears_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (fuyears.Text != "")
                {
                    button1.Enabled = true;
                    button1.Focus();
                }
                else
                {
                    MessageBox.Show("Enter value!", "Required Field.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
