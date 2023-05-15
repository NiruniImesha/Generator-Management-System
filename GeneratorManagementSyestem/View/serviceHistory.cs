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
    public partial class serviceHistory : Form
    {
        serviceHistoryModel hMod = new serviceHistoryModel();
        generatorModel genMod = new generatorModel();

        historyController hCon = new historyController();
        GeneratorController genCon = new GeneratorController();

        public serviceHistory()
        {
            InitializeComponent();
            addGenerator();
        }

        private void addGenerator()
        {
            DataSet dsGen = genCon.getAllGeneratorNames();
            for (int i = 0; i < dsGen.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dsGen.Tables[0].Rows[i][0]);
            }
            comboBox1.SelectedIndex = 0;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genMod.Name = comboBox1.Text;
            hCon.getServiceHistory(genMod, dgvHistory);
        }
    }
}
