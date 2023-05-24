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
    class GeneratorController
    {
        DbController DbCon = new DbController();
        SqlConnection sqlconn;

        public GeneratorController()
        {
            sqlconn = DbCon.getDbConnection();
        }

        // generate primary key
        public void generatorCode(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "select max(genNo) as id from generator";

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
                            genMod.GenNo = "001";
                        }
                        else
                        {
                            genMod.GenNo = (Convert.ToInt32(result["id"].ToString()) + 1).ToString("000");
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

        // insert new generator
        public bool addGenerator(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "insert into generator (genNo, name, model,frequency,tankSize,totalDuration,firstServiceMonth,firstServiceHours) values ('" + genMod.GenNo + "','" + genMod.Name + "','" + genMod.Model + "','" + genMod.Frequency + "','" + genMod.TankSize + "','0','" + genMod.FirstServiceMonth1 + "','" + genMod.FirstServiceHours + "')";

                SqlCommand cmd = new SqlCommand(url, sqlconn);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Generator data didn't stored!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Generator details successfullyadded!");
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

        // get the dataset of generator details by name
        public DataSet getAllGeneratorNames()
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            DataSet ds = new DataSet();
            try
            {
                string url = "SELECT name FROM generator order by name";
                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet getAllGenerators()
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            DataSet ds = new DataSet();
            try
            {
                string url = "SELECT * FROM generator";
                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                sqlconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        // get generator by name
        public string getGeneratorByName(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string genNo = "";
            try
            {
                string url = "select genNo as id from generator where name='" + genMod.Name + "'";

                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    genNo = result["id"].ToString();
                }
                result.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return genNo;
        }

        public DataSet getGeneratorById(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            DataSet ds = new DataSet();
            try
            {
                string url = "SELECT * FROM generator where id = '" + genMod.GenNo + "'";
                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                sqlconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        //View all generators
        public void findAllGenerators(generatorModel genMod, DataGridView dgvName)
        {
            string query = "select genNo as genNo, model as model, frequency as frequency, tankSize as tank_size, totalDuration as total_duration, firstServiceMonth as first_service_month, firstServiceHours as first_service_hours, name as name from generator";

            AddGeneratorDetails(dgvName, query);
        }

        // pass the generator details to the data grid view
        public void AddGeneratorDetails(DataGridView dgvName, string query)
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
                dgvName.Rows[n].Cells[0].Value = result["genNo"].ToString();
                dgvName.Rows[n].Cells[1].Value = result["name"].ToString();
                dgvName.Rows[n].Cells[2].Value = result["model"].ToString();
                //dgvName.Rows[n].Cells[3].Value = result["frequency"].ToString();
                //dgvName.Rows[n].Cells[4].Value = result["tank_size"].ToString();
                //dgvName.Rows[n].Cells[5].Value = result["total_duration"].ToString();
                //dgvName.Rows[n].Cells[6].Value = result["first_service_month"].ToString();
                //dgvName.Rows[n].Cells[7].Value = result["first_service_hours"].ToString();
            }
            sqlconn.Close();
        }

        // get generator by id
        public void findGeneratorByID(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "select genNo, model, frequency, tankSize, totalDuration, name ,firstServiceMonth ,firstServiceHours from generator where genNo = '" + genMod.GenNo + "'";

                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    genMod.GenNo = result["genNo"].ToString();
                    genMod.Name = result["name"].ToString();
                    genMod.Model = result["model"].ToString();
                    genMod.Frequency01 = result["frequency"].ToString();
                    genMod.TankSize01 = result["tankSize"].ToString();
                    genMod.TotalDuration01 = result["totalDuration"].ToString();
                    genMod.FirstServiceMonth01 = result["firstServiceMonth"].ToString();
                    genMod.FirstServiceHours01 = result["firstServiceHours"].ToString();
                    // genMod.TankSize = Convert.ToInt32(result["tankSize"].ToString());
                    //genMod.Frequency = Convert.ToInt32(result["frequency"].ToString());
                    // genMod.TotalDuration = Convert.ToInt32(result["totalDuration"].ToString());
                }
                result.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            sqlconn.Close();
        }

        // update all generator details
        public void updateGenarator(generatorModel genMod)
        {
            string query = " Update generator SET model = '" + genMod.Model + "', frequency = '" + genMod.Frequency + "', tankSize = '" + genMod.TankSize + "', totalDuration = '" + genMod.TotalDuration01 + "', firstServiceMonth = '" + genMod.FirstServiceMonth1 + "', firstServiceHours = '" + genMod.FirstServiceHours + "' where genNo = '" + genMod.GenNo + "'";

            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                // MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Error Occured (updateGenarator)");
            }
            sqlconn.Close();
        }

        // update the total duration
        public void changeTotDuration(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "update generator set totalDuration = '" + genMod.TotalDuration + "' where name= '" + genMod.Name + "'";
                SqlCommand cmd = new SqlCommand(url, sqlconn); if (cmd.ExecuteNonQuery() == 0)

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Total duration didn't update!");
                    }
                    else
                    {
                        MessageBox.Show("Total duration successfully updated!");
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

        // calculate the duration for the notifications
        public string notification(serviceHistoryModel sMod, generatorModel genMod, string columnName)
        {
            string hours = "";
            TimeSpan toHours = new TimeSpan();
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                sMod.GeneratorID = genMod.Name;
                string totalDuration = "";
                string currentDuration = "";
                string serviceDuration = "";

                //string url_lifetime = "select TOP 1 s.currentTotDuration, g.totalDuration from service_history s,generator g where g.name = s.generatorID and s.generatorID = '" + sMod.GeneratorID + "' and s.serviceType = '" + sMod.ServiceType + "' order by s.serviceTurn desc;";

                #region LIFE TIME
                string url_lifetime = "select TOP 1 g.totalDuration from service_history s,generator g where g.name = s.generatorID and s.generatorID = '" + sMod.GeneratorID + "' order by s.serviceTurn desc;";

                SqlCommand cmd_lifetime = new SqlCommand(url_lifetime, sqlconn);
                SqlDataReader result_lifetime = cmd_lifetime.ExecuteReader();

                if (result_lifetime.Read())
                {
                    totalDuration = result_lifetime["totalDuration"].ToString();
                }
                result_lifetime.Close();
                #endregion

                #region CURRENT TIME
                //string url_currentTime = "select TOP 1 s.currentTotDuration, d." + columnName + "  from service_history s, generator g, service_duration_data d where g.name = s.generatorID and s.generatorID = '" + sMod.GeneratorID + "' and s.serviceType = '" + sMod.ServiceType + "' AND g.genNo = d.generatorID order by s.serviceTurn desc;";

                string url_currentTime = "select TOP 1 currentTotDuration from service_history where generatorID = '" + sMod.GeneratorID + "' and serviceType = '" + sMod.ServiceType + "' order by serviceTurn desc;";

                SqlCommand cmd_currentTime = new SqlCommand(url_currentTime, sqlconn);
                SqlDataReader result_currentTime = cmd_currentTime.ExecuteReader();

                if (result_currentTime.Read())
                {
                    if (result_currentTime.HasRows)
                    {
                        currentDuration = result_currentTime["currentTotDuration"].ToString();
                    }
                }
                else
                {
                    currentDuration = "00:00:00";
                }
                result_currentTime.Close();
                #endregion

                #region SERVICE HOURS

                //sMod.GeneratorID = "002";
                //string url_serviceHours = "select " + columnName + " from service_duration_data where generatorID = '" + sMod.GeneratorID+"';";
                string url_serviceHours = "select " + columnName + " from service_duration_data d, generator g where d.generatorID = g.genNo and g.name = '"+ sMod.GeneratorID + "';";

                SqlCommand cmd_serviceHourse = new SqlCommand(url_serviceHours, sqlconn);
                SqlDataReader result_serviceHours = cmd_serviceHourse.ExecuteReader();

                if (result_serviceHours.Read())
                {
                    if (result_serviceHours.HasRows)
                    {
                        serviceDuration = result_serviceHours[columnName].ToString();
                    }           
                }
                else
                {
                    serviceDuration = "00:00:00";
                }
                result_serviceHours.Close();
                #endregion

                TimeSpan total_run_hours = DateTime.Parse(totalDuration).Subtract(DateTime.Parse(currentDuration));
                string Hours = Convert.ToString(total_run_hours);
                toHours = DateTime.Parse(serviceDuration).Subtract(DateTime.Parse(Hours));
                //hours = Convert.ToString(toHours.Hours);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlconn.Close();
            }
            return toHours.ToString();
        }

    }
}
