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
    public partial class addUser : Form
    {
        userModel uMod = new userModel();
        userController uCon = new userController();

        public addUser()
        {
            InitializeComponent();
            uCon.userID(uMod);
            txt_uid.Text = uMod.UserID;
            uCon.findAllUsers(uMod, dgvUser);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            uMod.UserID = txt_uid.Text;
            uMod.UserName = txt_user_name.Text;
            uMod.Password = txt_password.Text;
            //uCon.checkPassword(uMod);
            uMod.UserType = cmb_user_type.Text;

            if (uCon.checkPassword(uMod))
            {
                if (uCon.addUser(uMod))
                {
                    //this.Dispose();
                    //this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error..!", "Add new user", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtBxName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                uMod.Password = txt_password.Text;
                uCon.checkPassword(uMod);
            }
        }
    }
}
