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
    public partial class notification : Form
    {
        GeneratorController genCon = new GeneratorController();

        generatorModel genMod = new generatorModel();
        serviceHistoryModel sMod = new serviceHistoryModel();
        serviceModel servMOd = new serviceModel();

        public notification()
        {
            InitializeComponent();
            string[] message = genCon.CalcMonths(genMod, sMod);
            for(int i=0;i<7; ++i)
            {
                //this.Show(message[i]);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
