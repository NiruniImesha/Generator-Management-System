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

            Genarator_Name.Text = GeneratorName;
            Genarator_Model.Text = GeneratorModel;
            gb_generator.Text = GeneratorID;


            AddGenerator newChild = new AddGenerator(GeneratorID, GeneratorName, GeneratorModel);
            newChild.MdiParent = Dashboard.ActiveForm;
            newChild.Show();
            this.Dispose();

        }
    }
}
