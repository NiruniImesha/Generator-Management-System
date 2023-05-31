using GeneratorManagementSyestem.Controller;
using GeneratorManagementSyestem.Model;
using GeneratorManagementSyestem.View;
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
    public partial class Dashboard : Form
    {
        userController uCon = new userController();
        userModel uMod = new userModel();

        GeneratorController genCon = new GeneratorController();

        generatorModel genMod = new generatorModel();
        serviceHistoryModel sMod = new serviceHistoryModel();
        Cal_Model cal = new Cal_Model();

        public Dashboard(string userName, string Password)
        {
            InitializeComponent();
            string user = userName;
            string Pass = Password;
            string user_id;

            uMod.UserName = user;
            uMod.Password = Pass;

            user_id = uCon.findUserID(uMod);
            uMod.UserID_main = user_id;

            string userType;
            userType = uCon.findUsertype(uMod);
            uMod.UserType_main = userType;


            if (uMod.UserType_main == "Employee")
            {
                add_generator.Visible = false;
                add_generator.Enabled = false;
            }

           

            Name_label2.Text = uMod.UserName;
            notification newChild = new notification();
            newChild.MdiParent = this;
            newChild.Show();
        }
        
        private void btnGenView_Click(object sender, EventArgs e)
        {
            ViewGenerators newChild = new ViewGenerators(uMod.UserID_main);
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            serviceHistory newChild = new serviceHistory();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void add_generator_Click(object sender, EventArgs e)
        {
            AddGenerator newChild = new AddGenerator();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnAddServices_Click(object sender, EventArgs e)
        {
            InsertServiceHistory newChild = new InsertServiceHistory(uMod.UserID_main);
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnAddGeneratorActions_Click(object sender, EventArgs e)
        {
            generatorOperations newChild = new generatorOperations();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnDailyUsage_Click(object sender, EventArgs e)
        {
            DailyGeneratorUsage newChild = new DailyGeneratorUsage();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUser newChild = new addUser(uMod.UserID_main);
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            


            int count = genCon.Genaratorcount();
            for (int a = 1; a <= count; ++a)
            {
                genMod.GenNo = "00" + a;
                string generator = genCon.findAllGenerators01(genMod);

                //notification_txt.Text = generator;

                string[] services = { "Engine Oil", "Air Cleaner", "Sediment cup", "Valve clearance", "Spark Arrester", "Fuel tank & filter" };

                string[] service_columns = { "EngineserviceDurationHours", "AirserviceDurationHours", "SedimentserviceDurationHours", "ValveserviceDurationHours", "SparkserviceDurationHours", "FuelserviceDurationHours" };

                string[] due = new string[6];
                string[] due_status = { "", "", "", "", "", "" };


                for (int i = 0; i < 6; ++i)
                {
                    genMod.Name = generator;
                    sMod.ServiceType = services[i];                    
                    due[i] = genCon.notification(sMod, genMod, service_columns[i]);
                   // genCon.CalcMonths(genMod, sMod, services[i]);
                    TimeSpan duration = TimeSpan.Parse(due[i].ToString());
                    string remaining = "00:00:00";
                    TimeSpan rem = TimeSpan.Parse(remaining.ToString());

                    if (duration < rem)
                    {
                        due_status[i] = "deu today";
                        //MessageBox.Show("Service " + services[i], "Notification" + " in " + genMod.Name);
                        // notification_txt.Text = "Service "+ services[i] + " in " + genMod.Name;

                    }
                    else
                    {
                        due_status[i] = "deu tomorrow";
                    }
                }
                
                                 MessageBox.Show("\t          Service \n\n" 
                                                 + services[0]+ "\t :"+ due_status[0] +  "\n"
                                                 + services[1] + "\t :" + due_status[1] + "\n"
                                                 + services[2] + "\t :" + due_status[2] + "\n"
                                                 + services[3] + "\t :" + due_status[3] + "\n"
                                                 + services[4] + "\t :" + due_status[4] + "\n"
                                                 + services[5] + "\t :" + due_status[5]  
                                    , "Notification" + " in " + genMod.Name);


                // genCon.CalcMonths(genMod, sMod);
                genCon.Cal_month(genMod, cal);

            }

        }
    }
}
