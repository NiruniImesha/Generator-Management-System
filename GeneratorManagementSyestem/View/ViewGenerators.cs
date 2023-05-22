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
    public partial class ViewGenerators : Form
    {
        generatorModel genMod = new generatorModel();
        GeneratorController genCon = new GeneratorController();

        ServiceController serveCon = new ServiceController();
        serviceModel01 serveMod01 = new serviceModel01();
        serviceHistoryModel sMod = new serviceHistoryModel();


        public ViewGenerators()
        {
            InitializeComponent();
            genCon.findAllGenerators(genMod, dgvGenerator);
            //dgvGenerator
        }
        private void dgvGenerator_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            doubleclickGridView(rowIndex);
            this.Dispose();
        }
        public void doubleclickGridView(int rowIndex)
        {
            string GeneratorID = dgvGenerator.Rows[rowIndex].Cells[0].Value.ToString();
            string GeneratorName = dgvGenerator.Rows[rowIndex].Cells[1].Value.ToString();
            string GeneratorModel = dgvGenerator.Rows[rowIndex].Cells[2].Value.ToString();

            AddGenerator newChild = new AddGenerator(GeneratorID, GeneratorName, GeneratorModel);
            newChild.MdiParent = Dashboard.ActiveForm;
            newChild.Show();
            this.Dispose();

        }

        private void dgvGenerator_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            SingleclickGridView(rowIndex);
        }

        public void SingleclickGridView(int rowIndex)
        {
            string GeneratorID = dgvGenerator.Rows[rowIndex].Cells[0].Value.ToString();
            string GeneratorName = dgvGenerator.Rows[rowIndex].Cells[1].Value.ToString();
            string GeneratorModel = dgvGenerator.Rows[rowIndex].Cells[2].Value.ToString();

            serveMod01.GeneratorID = GeneratorID;

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

            ehours.ReadOnly = true;
            emonths.ReadOnly = true;
            ahours.ReadOnly = true;
            amonths.ReadOnly = true;
            shours.ReadOnly = true;
            smonths.ReadOnly = true;
            vhours.ReadOnly = true;
            vmonths.ReadOnly = true;
            sphours.ReadOnly = true;
            spmonths.ReadOnly = true;
            fuhours.ReadOnly = true;
            fumonths.ReadOnly = true;
            fuyears.ReadOnly = true;

            genMod.Name = GeneratorName;
            string[] services = { "Engine Oil", "Air Cleaner", "Sediment cup", "Valve clearance", "Spark Arrester", "Fuel tank & filter" };
            string[] due = new string[6];

                for (int i = 0; i < 6; ++i)
                {
                    sMod.ServiceType = services[i];
                    due[i] = genCon.notification(sMod, genMod);
                }

            textBox1.Text = due[0];
            textBox2.Text = due[1];
            textBox3.Text = due[2];
            textBox4.Text = due[3];
            textBox5.Text = due[4];
            textBox6.Text = due[5];
        }
    }
}
