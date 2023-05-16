using GeneratorManagementSyestem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorManagementSyestem.Controller
{
    class historyController
    {
        DbController DbCon = new DbController();
        SqlConnection sqlconn;

        public historyController()
        {
            sqlconn = DbCon.getDbConnection();
        }

        // insert
        public bool addHistory(serviceHistoryModel hMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "insert into service_history (serviceTurn, currentTotDuration, generatorID, serviceDate, serviceType) values ('" + hMod.ServiceTurn + "','" + hMod.CurrentTotDuration + "','" + hMod.GeneratorID + "','" + hMod.ServiceDate + "','" + hMod.ServiceType + "')";

                SqlCommand cmd = new SqlCommand(url, sqlconn);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Generator data didn't stored!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Generator details successfully added!");
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        //get all service history
        public void getServiceHistory(generatorModel genMod, DataGridView dgvName)
        {
            string query = "select serviceTurn as service_turn, currentTotDuration as duration, generatorID as generator, serviceDate as date, serviceType as service from service_history where generatorID ='" + genMod.Name + "';";

            AddHistoryDetails(dgvName, query);
        }

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
                dgvName.Rows[n].Cells[0].Value = result["service_turn"].ToString();
                dgvName.Rows[n].Cells[1].Value = result["duration"].ToString();
                dgvName.Rows[n].Cells[2].Value = result["generator"].ToString();
                dgvName.Rows[n].Cells[3].Value = result["date"].ToString();
                dgvName.Rows[n].Cells[4].Value = result["service"].ToString();
            }
            sqlconn.Close();
        }

        // Get the current total duration of generator

        public string getCurrentDuration(serviceHistoryModel hMod)
        {
            string rs = "";
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "select totalDuration as duration from generator where name ='" + hMod.GeneratorID + "'";
            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            if (result.Read())
            {
                rs = result["duration"].ToString();
            }
            result.Close();
            sqlconn.Close();
            return rs;
        }

        public bool addGeneratorHistory(serviceHistoryModel hMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                //hMod.CurrentTotDuration = getCurrentDuration(hMod);
                string url = "insert into service_history (currentTotDuration, generatorID,serviceDate,serviceType) values ('" + hMod.CurrentTotDuration + "','" + hMod.GeneratorID + "','" + hMod.ServiceDate + "','" + hMod.ServiceType + "')";

                SqlCommand cmd = new SqlCommand(url, sqlconn);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Generator service data didn't stored!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Generator service details successfully added!");
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        /***********************************************************************************************************************/
        public void getServiceHistory01(generatorModel genMod, DataGridView dgvName)
        {
            string query = "select serviceTurn as service_turn, currentTotDuration as duration, generatorID as generator, serviceDate as date, serviceType as service from service_history where generatorID ='" + genMod.Name + "' And serviceDate between '" + genMod.Start_date_range + "' and '" + genMod.End_date_range + "';";

            AddHistoryDetails01(dgvName, query);
        }

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
                dgvName.Rows[n].Cells[0].Value = result["service_turn"].ToString();
                dgvName.Rows[n].Cells[1].Value = result["duration"].ToString();
                dgvName.Rows[n].Cells[2].Value = result["generator"].ToString();
                dgvName.Rows[n].Cells[3].Value = result["date"].ToString();
                dgvName.Rows[n].Cells[4].Value = result["service"].ToString();
            }
            sqlconn.Close();
        }
        /*****************************************************************************************************************************/
    }
}
