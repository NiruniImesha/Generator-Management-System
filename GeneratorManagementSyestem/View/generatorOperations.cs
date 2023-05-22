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
    public partial class generatorOperations : Form
    {
        GeneratorController genCon = new GeneratorController();
        dailyOperationController opCon = new dailyOperationController();

        generatorModel genMod = new generatorModel();
        dailyServiceDataModel opMod = new dailyServiceDataModel();

        userController uCon = new userController();
        userModel uMod = new userModel();

        public generatorOperations()
        {
            InitializeComponent();
            addGEnerator();

            btn_Stop.Enabled = false;
            button_start.Enabled = false;
            cmbGenerator.Enabled = false;

            //txtuser.Text = Dashboard(userName);
        }

        private void addGEnerator()
        {
            cmbGenerator.Items.Add("-- Select --");
            DataSet ds = genCon.getAllGeneratorNames();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbGenerator.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            cmbGenerator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            opCon.serviceCode(opMod, genMod);
            opMod.StartDate = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));
            opMod.StartTime = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            opMod.StartUser = uMod.UserName;
            if (opCon.addDailyOperator(opMod))
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error..!", "Add generator operator", MessageBoxButtons.OK);
            }
            //if starts, generate new Id and assign values
            // if stopped, select id and update
        }

        private void cmbGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGenerator.SelectedIndex > 0)
            {
                genMod.Name = cmbGenerator.Text;
                genMod.GenNo = opCon.getGeneratorID(genMod);

                bool check = opCon.check(genMod);

                if (check == true)
                {
                    btn_Stop.Visible = true;
                    btn_Stop.Enabled = true;
                    button_start.Visible = false;
                    button_start.Enabled = false;
                }
                else
                {
                    button_start.Visible = true;
                    button_start.Enabled = true;
                    btn_Stop.Visible = false;
                    btn_Stop.Enabled = false;
                }
            }           
        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
            opMod.StopDate = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));
            opMod.StopTime = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            opMod.StopUser = uMod.UserName;

            if (opCon.updateDailyOperator(opMod, genMod))
            {
                genCon.changeTotDuration(genMod);
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error..!", "Add generator operator", MessageBoxButtons.OK);
            }
        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            //cmbGenerator.Enabled = true;

            uMod.Password = txtuser.Text;
            if (uCon.findUser(uMod))
            {
                { UserCheck(); }
               cmbGenerator.Enabled = true;
               
            }
            else
            {
               
                txtuser.Focus();
            }
        }

        public void UserCheck()//User name and password check
        {
            try
            {
                DataSet ds = uCon.PasswordbyUserName(txtuser.Text);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    uMod.UserName = ds.Tables[0].Rows[0]["userName"].ToString().Trim();
                    user_name_label.Text = uMod.UserName;
                   /* userModel.UserId = ds.Tables[0].Rows[0]["SysUserID"].ToString().Trim();
                    userModel.User_Phone_Number = ds.Tables[0].Rows[0]["SysUserPhoneNo"].ToString().Trim();
                    userModel.User_branch = ds.Tables[0].Rows[0]["SysUserBranch"].ToString().Trim();
                    userModel.User_Password = ds.Tables[0].Rows[0]["SysPassword"].ToString().Trim();
                    userModel.User_Type = ds.Tables[0].Rows[0]["SysUserType"].ToString().Trim();
                    userModel.User_status = ds.Tables[0].Rows[0]["SysUserstatus"].ToString().Trim();*/

                }
                else
                {
                    MessageBox.Show("Password is Wrong ");
                    //txtuser.Clean();
                    txtuser.Text = String.Empty;
                    txtuser.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
