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
                string currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                string url = "insert into generator (genNo, name, model,frequency,tankSize,totalDuration,firstServiceMonth,firstServiceHours,date) values ('" + genMod.GenNo + "','" + genMod.Name + "','" + genMod.Model + "','" + genMod.Frequency + "','" + genMod.TankSize + "','00:00:00','" + genMod.FirstServiceMonth1 + "','" + genMod.FirstServiceHours + "','"+ currentDate + "')";

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
        public string findAllGenerators(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string generator = "";
            string query = "select name from generator";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                generator = result["name"].ToString();
            }
            sqlconn.Close();

            return generator;
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
        public string get_TotDuration(generatorModel genMod)
        {
            string duration = "00:00:00";
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "SELECT totalDuration FROM generator where name= '" + genMod.Name + "';";
                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    duration = rd[0].ToString();
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
            return duration;
        }

        // calculate the duration for the notifications
        public string notification_months(serviceHistoryModel sMod, generatorModel genMod, string columnName)
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
                else
                {
                    totalDuration = "00:00:00";
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
                string url_serviceHours = "select " + columnName + " from service_duration_data d, generator g where d.generatorID = g.genNo and g.name = '" + sMod.GeneratorID + "';";

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
                else
                {
                    totalDuration = "00:00:00";
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
                string url_serviceHours = "select " + columnName + " from service_duration_data d, generator g where d.generatorID = g.genNo and g.name = '" + sMod.GeneratorID + "';";

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

        // Calculate time for months
        public string[] CalcMonths(generatorModel genMod, serviceHistoryModel sMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string[] message = new string[7];
                #region calculation
                int due_month = 0;
                DateTime today = DateTime.Now;

                string[] services = { "Engine Oil", "Air Cleaner", "Sediment cup", "Valve clearance", "Spark Arrester", "Fuel tank & filter" };

                for (int i = 0; i < 6; ++i)
                {
                    string url_service_date = "select TOP 1 serviceDate from service_history s,generator g where g.name = s.generatorID and g.name = '" + genMod.Name + "' and serviceType = '" + services[i] + "' order by s.serviceTurn desc;";

                    SqlCommand cmd_service_date = new SqlCommand(url_service_date, sqlconn);
                    SqlDataReader result_service_date = cmd_service_date.ExecuteReader();

                    SqlDataReader result_reg_date = null;

                    if (result_service_date.Read())
                    {
                        string service_date = result_service_date["serviceDate"].ToString();
                        DateTime service = DateTime.Parse(service_date);

                        if (result_service_date.HasRows)
                        {
                            due_month = Convert.ToInt32(today.Subtract(service).TotalDays);
                        }
                    }
                    else
                    {
                        result_service_date.Close();
                        string url_reg_date = "select date from generator  where name='" + genMod.Name + "';";
                        SqlCommand cmd_reg_date = new SqlCommand(url_reg_date, sqlconn);
                        result_reg_date = cmd_reg_date.ExecuteReader();

                        if (result_reg_date.Read())
                        {
                            if (result_reg_date["date"].ToString() != "")
                            {
                                string reg_date = result_reg_date["date"].ToString();
                                DateTime register = DateTime.Parse(reg_date);
                                due_month = Convert.ToInt32(today.Subtract(register).TotalDays);
                            }
                        }
                        result_reg_date.Close();
                    }
                    result_service_date.Close();



                    #endregion

                    #region comparison

                    string[] service_columns = { "EngineserviceDurationMonths", "AirserviceDurationMonths", "SedimentserviceDurationMonths", "ValveserviceDurationMonths", "SparkserviceDurationMonths", "FuelserviceDurationMonths", "FuelSeviceDurationYears" };

                    for (i = 0; i < 7; ++i)
                    {
                        string url_service = "select " + service_columns[i] + " from service_duration_data d, generator g where d.generatorID = g.genNo and g.name = '" + sMod.GeneratorID + "';";

                        SqlCommand cmd_service = new SqlCommand(url_service, sqlconn);
                        SqlDataReader result_service = cmd_service.ExecuteReader();
                        if (result_service.Read())
                        {
                            string months = result_service[service_columns[i]].ToString();
                            int days = Convert.ToInt32(months) * 30;
                            if (days <= due_month)
                            {
                                MessageBox.Show(sMod.GeneratorID + " Has to service " + services[i] + " over due days : " + (due_month - days));
                                // message[i] = sMod.GeneratorID + " Has to service " + services[i];
                            }
                            else
                            {
                                //MessageBox.Show(sMod.GeneratorID + " Has to service " + services[i] + " in days : " + ( days - due_month)+" days.");
                            }
                        }
                        result_service.Close();
                    }
                    #endregion
                }
                return message;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            sqlconn.Close();
            return null;
        }

        public int Genaratorcount()
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "SELECT count(genNo) From generator";
            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read()) ;
            int count = Convert.ToInt32(r[0]);
            // int clientid =0;
            sqlconn.Close();
            return count;
        }

        public string findAllGenerators01(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string generator = "";
            string query = "select name from generator where genNo = '" + genMod.GenNo + "'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                generator = result["name"].ToString();
            }
            sqlconn.Close();

            return generator;
        }


        //************************************************************************************************************************

        public void Cal_month(generatorModel genMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string Date = "";
            string query = "select date from generator where genNo = '" + genMod.GenNo + "'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                Date = result["date"].ToString();

            }
            result.Close();

            string url = "select EngineserviceDurationMonths, AirserviceDurationMonths, SedimentserviceDurationMonths, ValveserviceDurationMonths, SparkserviceDurationMonths, FuelserviceDurationMonths ,FuelSeviceDurationYears from service_duration_data where generatorID = '" + genMod.GenNo + "'";

            SqlCommand cmd01 = new SqlCommand(url, sqlconn);
            SqlDataReader result01 = cmd01.ExecuteReader();
            string[] service_da = { "", "", "", "", "", "", "" };

            while (result01.Read())
            {
                service_da[0] = result01["EngineserviceDurationMonths"].ToString();
                service_da[1] = result01["AirserviceDurationMonths"].ToString();
                service_da[2] = result01["SedimentserviceDurationMonths"].ToString();
                service_da[3] = result01["ValveserviceDurationMonths"].ToString();
                service_da[4] = result01["SparkserviceDurationMonths"].ToString();
                service_da[5] = result01["FuelserviceDurationMonths"].ToString();
                service_da[6] = result01["FuelSeviceDurationYears"].ToString();

            }
            result01.Close();

            int da01 = Convert.ToInt32(service_da[0]);
            int da02 = Convert.ToInt32(service_da[1]);
            int da03 = Convert.ToInt32(service_da[2]);
            int da04 = Convert.ToInt32(service_da[3]);
            int da05 = Convert.ToInt32(service_da[4]);
            int da06 = Convert.ToInt32(service_da[5]);

            int day01 = da01 * 30;
            int day02 = da02 * 30;
            int day03 = da03 * 30;
            int day04 = da04 * 30;
            int day05 = da05 * 30;
            int day06 = da06 * 30;



            string[] service_date = { "", "", "", "", "", "", "", "" };
            string[] services = { "Engine Oil", "Air Cleaner", "Sediment cup", "Valve clearance", "Spark Arrester", "Fuel tank & filter", "Fuel line" };

            for (int i = 0; i < 6; ++i)
            {
                string url_service_date = "select TOP 1 serviceDate from service_history s,generator g where g.name = s.generatorID and g.name = '"+ genMod.Name + "' and serviceType = '" + services[i] + "' order by s.serviceTurn desc;";

                SqlCommand cmd_service_date = new SqlCommand(url_service_date, sqlconn);
                SqlDataReader result_service_date = cmd_service_date.ExecuteReader();

                // SqlDataReader result_reg_date = null;

                if (result_service_date.Read())
                {
                    service_date[i] = result_service_date["serviceDate"].ToString();
                }
                else
                {
                    service_date[i] = Date;
                }
                result_service_date.Close();

            }

            DateTime today = DateTime.Now;

            DateTime enteredDate01 = DateTime.Parse(service_date[0]);
            DateTime enteredDate02 = DateTime.Parse(service_date[1]);
            DateTime enteredDate03 = DateTime.Parse(service_date[2]);
            DateTime enteredDate04 = DateTime.Parse(service_date[3]);
            DateTime enteredDate05 = DateTime.Parse(service_date[4]);
            DateTime enteredDate06 = DateTime.Parse(service_date[5]);

            TimeSpan d01 = today - enteredDate01;
            TimeSpan d02 = today - enteredDate02;
            TimeSpan d03 = today - enteredDate03;
            TimeSpan d04 = today - enteredDate04;
            TimeSpan d05 = today - enteredDate05;
            TimeSpan d06 = today - enteredDate06;

            double NrOfDays01 = d01.TotalDays;
            double NrOfDays02 = d02.TotalDays;
            double NrOfDays03 = d03.TotalDays;
            double NrOfDays04 = d04.TotalDays;
            double NrOfDays05 = d05.TotalDays;
            double NrOfDays06 = d06.TotalDays;

            int a01 = Convert.ToInt32(NrOfDays01);
            int a02 = Convert.ToInt32(NrOfDays02);
            int a03 = Convert.ToInt32(NrOfDays03);
            int a04 = Convert.ToInt32(NrOfDays04);
            int a05 = Convert.ToInt32(NrOfDays05);
            int a06 = Convert.ToInt32(NrOfDays06);

            int[] s = new int[7];
            int s1;
            int c;
            int y;
            string c5 = "";
            string y5 = "";
            string c6 = "";
            string y6 = "";

            string[] servicedate = { "", "", "", "", "", "", "" };

            s[1] = day01 - a01;
            s[2] = day02 - a02;
            s[3] = day03 - a03;
            s[4] = day04 - a04;
            s[5] = day05 - a05;
            s[6] = day06 - a06;

            for (int i = 0; i <= 6; ++i)
            {


                if (s[i] < 0)
                {
                    s1 = Math.Abs(s[i]);

                    c = s1 / 30;
                    y = s1 % 30;

                    if (c < 10)
                    {
                        c5 = Convert.ToString(c);
                        c6 = "0" + c5;
                    }
                    else
                    {
                        c5 = Convert.ToString(c);
                    }
                    if (y < 10)
                    {
                        y5 = Convert.ToString(y);
                        y6 = "0" + y5;
                    }
                    else
                    {
                        y5 = Convert.ToString(y);
                    }
                    servicedate[i] = "-" + c6 + "/" + y6;

                }
                else
                {
                    s1 = s[i];

                    c = s1 / 30;
                    y = s1 % 30;

                    if (c < 10)
                    {
                        c5 = Convert.ToString(c);
                        c6 = "0" + c5;
                    }
                    else
                    {
                        c5 = Convert.ToString(c);
                    }
                    if (y < 10)
                    {
                        y5 = Convert.ToString(y);
                        y6 = "0" + y5;
                    }
                    else
                    {
                        y5 = Convert.ToString(y);
                    }
                    servicedate[i] = " " + c6 + "/" + y6;
                }
            }



            MessageBox.Show(" Has to service \n"
                                                               + servicedate[1] + "\n"
                                                               + servicedate[2] + "\n"
                                                               + servicedate[3] + "\n"
                                                               + servicedate[4] + "\n"
                                                               + servicedate[5] + "\n"
                                                               + servicedate[6] + "\n"
                                                               );


            //cal.EngineserviceDurationMonths = result01["EngineserviceDurationMonths"].ToString();
            //cal.AirserviceDurationMonths = result01["AirserviceDurationMonths"].ToString();
            //cal.SedimentserviceDurationMonths = result01["SedimentserviceDurationMonths"].ToString();
            //cal.ValveserviceDurationMonths = result01["ValveserviceDurationMonths"].ToString();
            //cal.SparkserviceDurationMonths = result01["SparkserviceDurationMonths"].ToString();
            //cal.FuelserviceDurationMonths = result01["FuelserviceDurationMonths"].ToString();
            //cal.FuelSeviceDurationYears = result01["FuelSeviceDurationYears"].ToString();

            sqlconn.Close();
        }


        // check generator name
        public bool checkName(string name)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            bool isUnique = false;

            try
            {
                string query = "SELECT * FROM generator WHERE name ='" + name + "'";

                SqlCommand queryCommand = new SqlCommand(query, sqlconn);
                SqlDataReader dr = queryCommand.ExecuteReader();
                if (!dr.HasRows)
                {
                    isUnique = true;
                }
                else
                {
                    MessageBox.Show("Generator name is already exist");
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


    }
}
