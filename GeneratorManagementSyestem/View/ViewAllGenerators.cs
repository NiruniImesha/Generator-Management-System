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
    public partial class ViewAllGenerators : Form
    {
        GeneratorController genCon = new GeneratorController();
        generatorModel genMod = new generatorModel();

        

        public ViewAllGenerators()
        {
            InitializeComponent();
            genCon.findAllGenerators(genMod, dgvGenerator);
               
        }

        //private void loadGeneratorGrid()
        //{
        //    genMod.GenNo = txtBxCode.Text;
        //    genMod.Name = txtBxName.Text;
        //    genMod.Model = txtBxCategory.Text;
        //    genMod.Frequency = txtBxBrand.Text;
        //    genMod.TankSize = txtBxType.Text;
        //    genMod.TotalDuration= txtBxSize.Text;
        //    genMod.FirstServiceHours = txtBxSize.Text;
        //    genMod.FirstServiceMonth1 = txtBxSize.Text;

        //    genCon.findItmDetailsForAll(genMod, dgvItems);
        //}
    }
}
