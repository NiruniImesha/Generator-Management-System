using GeneratorManagementSyestem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorManagementSyestem.Controller
{
    class userController
    {
        DbController DbCon = new DbController();
        SqlConnection sqlconn;

        public userController()
        {
            sqlconn = DbCon.getDbConnection();
        }


        // user login
        public Boolean login(userModel uMod)
        {
            Boolean status = false;
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string query = "SELECT * FROM employee WHERE userName ='" + uMod.UserName + "' AND  password ='" + uMod.Password + "'";

                SqlCommand queryCommand = new SqlCommand(query, sqlconn);
                SqlDataReader dr = queryCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    status = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            sqlconn.Close();
            return status;
        }

        // generate user id
        public void userID(userModel uMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "select max(userID) as id from employee";

            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            try
            {
                if (result.Read())
                {
                    if (result.HasRows)
                    {
                        if (result["id"].ToString() == "")
                        {
                            uMod.UserID = "0001";
                        }
                        else
                        {
                            uMod.UserID = (Convert.ToInt32(result["id"].ToString()) + 1).ToString("0000");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlconn.Close();
            }
        }

        // insert new user
        public bool addUser(userModel uMod)
        {
            bool isadded = false;   
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "insert into employee (userID, userName, password, userType) values ('" + uMod.UserID + "','" + uMod.UserName + "','" + uMod.Password + "','" + uMod.UserType + "')";

                SqlCommand cmd = new SqlCommand(url, sqlconn);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("User data didn't stored!");;
                }
                else
                {
                    MessageBox.Show("User added successfully!");
                    isadded = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlconn.Close();
            }
            return isadded;
        }

        // check the password is unique or not
        public bool checkPassword(userModel uMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            bool isUnique = false;

            try
            {
                string query = "SELECT * FROM employee WHERE password ='" + uMod.Password + "'";

                SqlCommand queryCommand = new SqlCommand(query, sqlconn);
                SqlDataReader dr = queryCommand.ExecuteReader();
                if (!dr.HasRows)
                {
                    isUnique = true;
                }
                else
                {
                    MessageBox.Show("Password is already exist");
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
            sqlconn.Close();
            }
            return isUnique;                          
        }

        // view all users
        public void findAllUsers(userModel uMod, DataGridView dgvName)
        {
            string query = "select userID, userName, password, userType from employee";

            AddUserDetails(dgvName, query);
        }

        public void AddUserDetails(DataGridView dgvName, string query)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }

            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();
            dgvName.Rows.Clear();

            while (result.Read())
            {
                int n = dgvName.Rows.Add();
                dgvName.Rows[n].Cells[0].Value = result["userID"].ToString();
                dgvName.Rows[n].Cells[1].Value = result["userName"].ToString();
                dgvName.Rows[n].Cells[2].Value = result["userType"].ToString();
                //dgvName.Rows[n].Cells[2].Value = result["model"].ToString();
                //dgvName.Rows[n].Cells[3].Value = result["frequency"].ToString();
                //dgvName.Rows[n].Cells[4].Value = result["tank_size"].ToString();
                //dgvName.Rows[n].Cells[5].Value = result["total_duration"].ToString();
                //dgvName.Rows[n].Cells[6].Value = result["first_service_month"].ToString();
                //dgvName.Rows[n].Cells[7].Value = result["first_service_hours"].ToString();
            }
            sqlconn.Close();
        }

        /******************************************************************************************************************/
        public DataSet PasswordbyUserName( string password)
        {
            if (sqlconn.State.ToString() == "Closed")
            {
                sqlconn.Open();
            }

            SqlCommand newCmd = sqlconn.CreateCommand();
            newCmd.Connection = sqlconn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Select * from employee where password='" + password + "';";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");

            sqlconn.Close();

            return ds;
        }

        public Boolean findUser(userModel uMod)
        {
            Boolean status = false;
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string query = "Select * from employee where password='" + uMod.Password + "';";

                SqlCommand queryCommand = new SqlCommand(query, sqlconn);
                SqlDataReader dr = queryCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    status = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlconn.Close();
            return status;
        }
        /******************************************************************************************************************/
        
        /*************************************************************************************************************************/

        public string findUserID(userModel uMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string Userid = "00";
            try
            {
                string url = "Select * from employee where password='" + uMod.Password + "';";
                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read()) ;
                Userid = Convert.ToString(r[0]);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
            return Userid;
        }

        /****************************************************************************************************************/
        public void finduserByID(userModel uMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "Select userName,password,userType from employee where userID='" + uMod.UserID_main + "';";

                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    uMod.UserName = result["userName"].ToString();
                    uMod.Password = result["password"].ToString();
                    uMod.UserType = result["userType"].ToString();
                   
                }
                result.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            sqlconn.Close();
        }
    }
}
