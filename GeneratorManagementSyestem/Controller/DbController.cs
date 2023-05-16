using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorManagementSyestem.Controller
{
    class DbController
    {
        public SqlConnection getDbConnection()
        {
            SqlConnection conn =null;
            try
            {
                string conString = @"Data Source=.;Initial Catalog=generatorManagement;Integrated security=true";
                // string conString = @"Data Source=.;Initial Catalog=generatorManagement;User Id=niruni; Password=12345678";
                //string conString = @"Data Source=LAPTOP-R6N6PA0H;Initial Catalog=generatorManagement;User Id=Niruni; Password=12345678";
               // string conString = "Data Source=DESKTOP-9P855LF\\SQLEXPRESS;Initial Catalog=generatorManagement; User Id=Lasitha; Password=Lasitha0;";
                //string conString = "Data Source=DESKTOP-METLJUD\\SQLEXPRESS;Initial Catalog=generatorManagement; User Id=Chamara; Password=aA@3065326;";

                conn = new SqlConnection(conString);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return conn;

        }
    }
}
