﻿using GeneratorManagementSyestem.Controller;
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
    public partial class notification : Form
    {
        GeneratorController genCon = new GeneratorController();

        generatorModel genMod = new generatorModel();
        serviceHistoryModel sMod = new serviceHistoryModel();

        public notification()
        {
            InitializeComponent();

            string generator = genCon.findAllGenerators(genMod);

            string[] services = { "Engine Oil", "Air Cleaner", "Sediment cup", "Valve clearance", "Spark Arrester", "Fuel tank & filter" };

            string[] service_columns = { "EngineserviceDurationHours", "AirserviceDurationHours", "SedimentserviceDurationHours", "ValveserviceDurationHours", "SparkserviceDurationHours", "FuelserviceDurationHours" };

            string[] due = new string[6];

            for (int i = 0; i < 6; ++i)
            {
                sMod.ServiceType = services[i];
                due[i] = genCon.notification(sMod, genMod, service_columns[i]);
                TimeSpan duration = TimeSpan.Parse(due[i].ToString());
                string remaining = "00:00:00";
                TimeSpan rem = TimeSpan.Parse(remaining.ToString());

                if (duration<=rem)
                {
                    notification_txt.Text = "Service "+ services[i] + "in" + generator; 
                    this.Show();
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
