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
        public ViewGenerators()
        {
            InitializeComponent();
            genCon.findAllGenerators(genMod, dgvGenerator);
            //dgvGenerator
        }

        private void dgvGenerator_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            genCon.findGeneratorByID(genMod);
        }
    }
}
