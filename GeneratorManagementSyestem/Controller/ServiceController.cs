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
    class ServiceController
    {
        DbController DbCon = new DbController();
        SqlConnection sqlconn;

        public ServiceController()
        {
            sqlconn = DbCon.getDbConnection();
        }

        public void serviceCode(serviceModel serveMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            string url = "select max(serviceID) as id from service_duration_data;";

            SqlCommand cmd = new SqlCommand(url, sqlconn);
            SqlDataReader result = cmd.ExecuteReader();

            try
            {
                if (result.Read())
                {
                    if (result["id"].ToString() == "")
                    {
                        serveMod.ServiceID = "001";
                    }
                    else
                    {
                        string currentID = result["id"].ToString();
                        int newid = Convert.ToInt32(currentID) + 1;

                        serveMod.ServiceID = serveMod.GeneratorID + newid.ToString("000");
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

        public bool addService(serviceModel serveMod)
        {
            bool stat = false;
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "insert into service_duration_data (serviceID, generatorID, EngineserviceDurationMonths, EngineserviceDurationHours,AirserviceDurationMonths, AirserviceDurationHours, SedimentserviceDurationMonths, SedimentserviceDurationHours, ValveserviceDurationMonths,ValveserviceDurationHours, SparkserviceDurationMonths, SparkserviceDurationHours,FuelserviceDurationMonths, FuelserviceDurationHours, FuelSeviceDurationYears) values ('" + serveMod.ServiceID + "','" + serveMod.GeneratorID + "','" + serveMod.EngineserviceDurationMonths1 + "','" + serveMod.EngineserviceDurationHours1 + "','" + serveMod.AirserviceDurationMonths1 + "','" + serveMod.AirserviceDurationHours1 + "','" + serveMod.SedimentserviceDurationMonths1 + "','" + serveMod.SedimentserviceDurationHours1 + "','" + serveMod.ValveserviceDurationMonths1 + "','" + serveMod.ValveserviceDurationHours1 + "','" + serveMod.SparkserviceDurationMonths1 + "','" + serveMod.SparkserviceDurationHours1 + "','" + serveMod.FuelserviceDurationMonths1 + "','" + serveMod.FuelserviceDurationHours1 + "','" + serveMod.FuelSeviceDurationYears1 + "')";


                SqlCommand cmd = new SqlCommand(url, sqlconn);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("service data didn't stored!");
                }
                else
                {
                    MessageBox.Show("service details successfully added!");
                    stat = true;
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

        public void findServiceByID(serviceModel01 serMod)
        {
            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            try
            {
                string url = "select serviceID, generatorID, EngineserviceDurationMonths, EngineserviceDurationHours, AirserviceDurationMonths,AirserviceDurationHours,SedimentserviceDurationMonths,SedimentserviceDurationHours,ValveserviceDurationMonths,ValveserviceDurationHours,SparkserviceDurationMonths,SparkserviceDurationHours,FuelserviceDurationMonths,FuelserviceDurationHours,FuelSeviceDurationYears from service_duration_data where generatorID = '" + serMod.GeneratorID + "'";

                SqlCommand cmd = new SqlCommand(url, sqlconn);
                SqlDataReader result = cmd.ExecuteReader();


             /*   string url = " Update service_duration_data SET EngineserviceDurationMonths = '" + serMod.EngineserviceDurationMonths + "', EngineserviceDurationHours = '" + serMod.EngineserviceDurationHours + "', AirserviceDurationMonths = '" + serMod.AirserviceDurationMonths + "', AirserviceDurationHours = '" + serMod.AirserviceDurationHours + "', SedimentserviceDurationMonths = '" + serMod.SedimentserviceDurationMonths + "', SedimentserviceDurationHours = '" + serMod.SedimentserviceDurationHours + "', ValveserviceDurationMonths = '" + serMod.ValveserviceDurationMonths + "', ValveserviceDurationHours = '" + serMod.ValveserviceDurationHours + "', SparkserviceDurationMonths = '" + serMod.SparkserviceDurationMonths + "', SparkserviceDurationHours = '" + serMod.SparkserviceDurationHours + "', FuelserviceDurationMonths = '" + serMod.FuelserviceDurationMonths + "', FuelserviceDurationHours = '" + serMod.FuelserviceDurationHours + "', FuelSeviceDurationYears = '" + serMod.FuelSeviceDurationYears + "' where generatorID = '" + serMod.GeneratorID + "'";*/

                while (result.Read())
                {
                    serMod.ServiceID = result["serviceID"].ToString();
                    serMod.GeneratorID = result["generatorID"].ToString();
                    serMod.EngineserviceDurationMonths01 = result["EngineserviceDurationMonths"].ToString();
                    serMod.EngineserviceDurationHours01 = result["EngineserviceDurationHours"].ToString();
                    serMod.AirserviceDurationMonths01 = result["AirserviceDurationMonths"].ToString();
                    serMod.AirserviceDurationHours01 = result["AirserviceDurationHours"].ToString();
                    serMod.SedimentserviceDurationMonths01 = result["SedimentserviceDurationMonths"].ToString();
                    serMod.SedimentserviceDurationHours01 = result["SedimentserviceDurationHours"].ToString();

                    serMod.ValveserviceDurationMonths01 = result["ValveserviceDurationMonths"].ToString();
                    serMod.ValveserviceDurationHours01 = result["ValveserviceDurationHours"].ToString();
                    serMod.SparkserviceDurationMonths01 = result["SparkserviceDurationMonths"].ToString();
                    serMod.SparkserviceDurationHours01 = result["SparkserviceDurationHours"].ToString();
                    serMod.FuelserviceDurationMonths01 = result["FuelserviceDurationMonths"].ToString();
                    serMod.FuelserviceDurationHours01 = result["FuelserviceDurationHours"].ToString();
                    serMod.FuelSeviceDurationYears01 = result["FuelSeviceDurationYears"].ToString();
                }
                result.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            sqlconn.Close();
        }

        public void updateService(serviceModel serMod)
        {
            string query = " Update service_duration_data SET EngineserviceDurationMonths = '" + serMod.EngineserviceDurationMonths1 + "', EngineserviceDurationHours = '" + serMod.EngineserviceDurationHours1 + "', AirserviceDurationMonths = '" + serMod.AirserviceDurationMonths1 + "', AirserviceDurationHours = '" + serMod.AirserviceDurationHours1 + "', SedimentserviceDurationMonths = '" + serMod.SedimentserviceDurationMonths1 + "', SedimentserviceDurationHours = '" + serMod.SedimentserviceDurationHours1 + "', ValveserviceDurationMonths = '" + serMod.ValveserviceDurationMonths1 + "', ValveserviceDurationHours = '" + serMod.ValveserviceDurationHours1 + "', SparkserviceDurationMonths = '" + serMod.SparkserviceDurationMonths1 + "', SparkserviceDurationHours = '" + serMod.SparkserviceDurationHours1 + "', FuelserviceDurationMonths = '" + serMod.FuelserviceDurationMonths1 + "', FuelserviceDurationHours = '" + serMod.FuelserviceDurationHours1 + "', FuelSeviceDurationYears = '" + serMod.FuelSeviceDurationYears1 + "' where generatorID = '" + serMod.GeneratorID + "'";

            if (sqlconn.State.ToString() != "Open")
            {
                sqlconn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                //MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Error Occured (updateService)");
            }
            sqlconn.Close();
        }
    }
}
