﻿using GeneratorManagementSyestem.Model;
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
    }
}
