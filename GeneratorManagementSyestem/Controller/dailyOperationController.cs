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
    class dailyOperationController
    {
        DbController DbCon = new DbController();
        GeneratorController genCon = new GeneratorController();
        SqlConnection sqlconn;

        public dailyOperationController()
        {
            sqlconn = DbCon.getDbConnection();
        }


        // generate primary key
        public void serviceCode(dailyServiceDataModel dailyMod, generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }

            string url = "select max(serviceNo) as id from daily_generator_usage where serviceNo like '" + genMod.GenNo + "%'";

            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            try
            {
                if (result.Read())
                {
                    if (result.HasRows)
                    {
                        string id = result["id"].ToString();
                        if (id != "")
                        {
                            string part2 = id.Substring(4, 3);
                            dailyMod.ServiceNo = genMod.GenNo + "-" + (Convert.ToInt32(part2) + 1).ToString("000");
                        }
                        else
                        {
                            dailyMod.ServiceNo = genMod.GenNo + "-001";
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

        // insert daily generator operation data
        public bool addDailyOperator(dailyServiceDataModel serceMod)
        {
            bool stat = false;
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "insert into daily_generator_usage (serviceNo, startTime, startUser, startDate, state) values ('" + serceMod.ServiceNo + "','" + serceMod.StartTime + "','" + serceMod.StartUser + "','" + serceMod.StartDate + "','1')";

                SqlCommand cmd = new SqlCommand(url, sqlconn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Generator started");
                    stat = true;
                }
                else
                {
                    MessageBox.Show("Generator didn't start!!");
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
            return stat;
        }

        // get generator details by genNo.
        public string getGeneratorID(generatorModel genMod)
        {
            string rs = "";
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "select genNo as id from generator where name ='" + genMod.Name + "'";
            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            if (result.Read())
            {
                rs = result["id"].ToString();
            }
            result.Close();
            sqlconn.Close();
            return rs;
        }

        // check whether the generator started or stopped
        public bool check(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            bool isRunning = false;

            string url = "select state from daily_generator_usage where serviceNo = (select max(serviceNo) as id from daily_generator_usage where serviceNo like '" + genMod.GenNo + "%')";

            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                if (result.HasRows)
                {
                    if (Convert.ToBoolean(result["state"]) == true)
                    {
                        isRunning = true;
                    }
                }
            }

            result.Close();
            sqlconn.Close();
            return isRunning;

        }

        // calculate duration
        public string calDuration(dailyServiceDataModel dMod)
        {
            string due = "";
            TimeSpan duration = new TimeSpan();
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "select startTime, startDate from daily_generator_usage where serviceNo LIKE '" + dMod.ServiceNo + "%' and state='1';";

            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            if (result.Read())
            {
                string start_date = result["startDate"].ToString();
                string start_time = result["startTime"].ToString();

                string start_full = start_date + " " + start_time;

                string stop_date = DateTime.Now.ToString("yyyy-MM-dd");
                string stop_time = DateTime.Now.ToString("HH:mm:ss");

                string stop_full = stop_date + " " + stop_time;

                duration = DateTime.Parse(stop_full).Subtract(DateTime.Parse(start_full));
                due = Convert.ToString(duration);
            }

            result.Close();
            return due;

        }

        // update the table to insert stop data
        public bool updateDailyOperator(dailyServiceDataModel dmod, generatorModel genMod)
        {
            bool status = false;
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }

            try
            {
                dmod.ServiceNo = genMod.GenNo;
                dmod.Duration1 = calDuration(dmod);
                string url = "update daily_generator_usage set stopTime='" + dmod.StopTime + "', stopDate='" + dmod.StopDate + "', stopUser='" + dmod.StopUser + "', state='0',Duration='" + dmod.Duration1 + "' where serviceNo like '" + genMod.GenNo + "%' and state='1'";

                SqlCommand cmd = new SqlCommand(url, sqlconn);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Generator stopped");

                    status = true;
                }
                else
                {
                    MessageBox.Show("Generator didn't stop!!");
                }

                #region
                string total_dration = genCon.get_TotDuration(genMod);
                TimeSpan total_duration_old = TimeSpan.Parse(total_dration);
                TimeSpan current_duration = TimeSpan.Parse(dmod.Duration1);

                TimeSpan total_duration_new = (total_duration_old).Add(current_duration);

                string url_update = "update generator set totalDuration = '" + total_duration_new.ToString() + "' where name= '" + genMod.Name + "'";
                SqlCommand cmd_update = new SqlCommand(url_update, sqlconn);

                if (cmd_update.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Total duration didn't update!");
                }
                else
                {
                    MessageBox.Show("Total duration successfully updated!");
                }
                #endregion

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            return status;

        }

        // get all daily operations data by generator name
        public void getDailyOperationsHistory(generatorModel genMod, DataGridView dgvName)
        {
            string query = "select * from daily_generator_usage where serviceNo like '" + genMod.GenNo + "%'";

            AddHistoryDetails(dgvName, query);
        }

        // add data to the data grid view
        public void AddHistoryDetails(DataGridView dgvName, string query)
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
                dgvName.Rows[n].Cells[0].Value = result["starttime"].ToString();
                dgvName.Rows[n].Cells[1].Value = result["startdate"].ToString();
                dgvName.Rows[n].Cells[2].Value = result["startuser"].ToString();
                dgvName.Rows[n].Cells[3].Value = result["stoptime"].ToString();
                dgvName.Rows[n].Cells[4].Value = result["stopdate"].ToString();
                dgvName.Rows[n].Cells[5].Value = result["stopuser"].ToString();
                dgvName.Rows[n].Cells[6].Value = result["duration"].ToString();
            }
            result.Close();
            sqlconn.Close();
        }

        /*************************************************************************************************************************/
        public void getDailyOperationsHistory01(generatorModel genMod, DataGridView dgvName)
        {
            // string query01 = "select * from daily_generator_usage where serviceNo like '" + genMod.GenNo + "%'";

            string query = "select * from daily_generator_usage where serviceNo like '" + genMod.GenNo + "%' And startDate >= '" + genMod.Start_date_range + "' and stopDate <= '" + genMod.End_date_range + "'";

            AddHistoryDetails01(dgvName, query);
        }

        // add data to the data grid view
        public void AddHistoryDetails01(DataGridView dgvName, string query)
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
                dgvName.Rows[n].Cells[0].Value = result["starttime"].ToString();
                dgvName.Rows[n].Cells[1].Value = result["startdate"].ToString();
                dgvName.Rows[n].Cells[2].Value = result["startuser"].ToString();
                dgvName.Rows[n].Cells[3].Value = result["stoptime"].ToString();
                dgvName.Rows[n].Cells[4].Value = result["stopdate"].ToString();
                dgvName.Rows[n].Cells[5].Value = result["stopuser"].ToString();
                dgvName.Rows[n].Cells[6].Value = result["duration"].ToString();
            }
            result.Close();
            sqlconn.Close();
        }
        /*************************************************************************************************************************/
    }
}
