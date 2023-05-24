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
        private string userID_main;

        public addUser()
        {
            InitializeComponent();
            uCon.userID(uMod);
            txt_uid.Text = uMod.UserID;
            uCon.findAllUsers(uMod, dgvUser);
        }

        public addUser(string userID_main)
        {
            InitializeComponent();
            this.userID_main = userID_main;
            uMod.UserID_main = userID_main;

            string userType;
            uCon.userID(uMod);
            userType = uCon.findUsertype(uMod);
            uMod.UserType_main = userType;

            txt_uid.Text = uMod.UserID;
            uCon.findAllUsers(uMod, dgvUser);

            updatebtn.Visible = false;
            updatebtn.Enabled = false;

            if(userType== "Admin")
            {
                btnSave.Visible = true;
                btnSave.Enabled = true;
                add_btn.Visible = true;
                add_btn.Enabled = true;
            }
            else
            {
                btnSave.Visible = false;
                btnSave.Enabled = false;
                add_btn.Visible = false;
                add_btn.Enabled = false;
            }
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

        private void dgvUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            SingleclickGridView(rowIndex);
            
        }
        public void SingleclickGridView(int rowIndex)
        {
            string userID = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            uMod.UserID = userID;

            if (uMod.UserType_main == "Admin")
            {
                if (uMod.UserID_main == uMod.UserID)
                {
                    groupBox1.Text = uMod.UserID;
                    uCon.finduserByID01(uMod);

                    txt_user_name.Text = uMod.UserName;
                    txt_password.Text = uMod.Password;
                    cmb_user_type.Text = uMod.UserType;


                    label20.Visible = false;
                    txt_uid.Visible = false;
                    txt_uid.Enabled = false;

                    txt_password.Visible = true;
                    txt_password.Enabled = true;

                    label22.Visible = true;
                    label22.Enabled = true;

                    updatebtn.Visible = true;
                    updatebtn.Enabled = true;

                    add_btn.Visible = true;
                    add_btn.Enabled = true;
                    
                }
                else
                {

                   /* txt_user_name.Text = String.Empty;
                    txt_password.Text = String.Empty;
                    cmb_user_type.Text = String.Empty;*/

                    groupBox1.Text = uMod.UserID;
                    uCon.finduserByID01(uMod);

                    txt_user_name.Text = uMod.UserName;
                    txt_password.Text = uMod.Password;
                    cmb_user_type.Text = uMod.UserType;


                    label20.Visible = false;
                    txt_uid.Visible = false;
                    txt_uid.Enabled = false;

                    txt_password.Visible = false;
                    txt_password.Enabled = false;

                    label22.Visible = false;
                    label22.Enabled = false;


                    updatebtn.Visible = true;
                    updatebtn.Enabled = true;

                    add_btn.Visible = true;
                    add_btn.Enabled = true;
                }
            }

            else if(uMod.UserType_main == "Employee")
            {
                if (uMod.UserID_main == userID)
                {
                    groupBox1.Text = userID;
                    uCon.finduserByID01(uMod);

                    txt_user_name.Text = uMod.UserName;
                    txt_password.Text = uMod.Password;
                    cmb_user_type.Text = uMod.UserType;


                    label20.Visible = false;
                    txt_uid.Visible = false;
                    txt_uid.Enabled = false;
                    cmb_user_type.Visible = false;
                    cmb_user_type.Enabled = false;
                    label21.Visible = false;
                    label21.Enabled = false;


                    updatebtn.Visible = true;
                    updatebtn.Enabled = true;

                    add_btn.Visible = false;
                    add_btn.Enabled = false;

                    btnSave.Visible = false;
                    btnSave.Enabled = false;
                    
                }
                else
                {

                    txt_user_name.Text = String.Empty;
                    txt_password.Text = String.Empty;
                    cmb_user_type.Text = String.Empty;

                    groupBox1.Text = "New User";
                    label20.Visible = true;
                    txt_uid.Visible = true;
                    txt_uid.Enabled = true;

                    updatebtn.Visible = false;
                    updatebtn.Enabled = false;

                    txt_uid.Visible = true;
                    txt_uid.Enabled = true;
                    cmb_user_type.Visible = true;
                    cmb_user_type.Enabled = true;
                    label21.Visible = true;
                    label21.Enabled = true;

                    add_btn.Visible = false;
                    add_btn.Enabled = false;

                    btnSave.Visible = false;
                    btnSave.Enabled = false;
                }
            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            uMod.UserID = groupBox1.Text;
            uMod.UserName = txt_user_name.Text;
            uMod.Password = txt_password.Text;
            uMod.UserType = cmb_user_type.Text;

            uCon.updateuser(uMod);
            uCon.findAllUsers(uMod, dgvUser);

            groupBox1.Text = String.Empty;
            txt_user_name.Text = String.Empty;
            txt_password.Text = String.Empty;
            cmb_user_type.Text = String.Empty;
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            txt_user_name.Text = String.Empty;
            txt_password.Text = String.Empty;
            cmb_user_type.Text = String.Empty;

            groupBox1.Text = "New User";
            updatebtn.Visible = false;
            updatebtn.Enabled = false;

            label20.Visible = true;
            label22.Visible = true;
            txt_uid.Visible = true;
            txt_uid.Enabled = true;

            txt_uid.Visible = true;
            txt_uid.Enabled = true;
            cmb_user_type.Visible = true;
            cmb_user_type.Enabled = true;
            label21.Visible = true;
            label21.Enabled = true;

            txt_password.Visible = true;
            txt_password.Enabled = true;

            btnSave.Visible = true;
            btnSave.Enabled = true;


        }
    }
}
