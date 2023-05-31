using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorManagementSyestem.Model
{
    class Cal_Model
    {
        private string serviceID;
        private string generatorID;
        private string engineserviceDurationMonths;
        private string airserviceDurationMonths;
        private string sedimentserviceDurationMonths;
        private string valveserviceDurationMonths;
        private string sparkserviceDurationMonths;
        private string fuelserviceDurationMonths;
        private string fuelSeviceDurationYears;


        public string ServiceID
        {
            get
            {
                return serviceID;
            }

            set
            {
                serviceID = value;
            }
        }
        public string EeneratorID
        {
            get
            {
                return generatorID;
            }

            set
            {
                generatorID = value;
            }
        }
        public string EngineserviceDurationMonths
        {
            get
            {
                return engineserviceDurationMonths;
            }

            set
            {
                engineserviceDurationMonths = value;
            }
        }
        public string AirserviceDurationMonths
        {
            get
            {
                return airserviceDurationMonths;
            }

            set
            {
                airserviceDurationMonths = value;
            }
        }
        public string SedimentserviceDurationMonths
        {
            get
            {
                return sedimentserviceDurationMonths;
            }

            set
            {
                sedimentserviceDurationMonths = value;
            }
        }
        public string ValveserviceDurationMonths
        {
            get
            {
                return valveserviceDurationMonths;
            }

            set
            {
                valveserviceDurationMonths = value;
            }
        }
        public string SparkserviceDurationMonths
        {
            get
            {
                return sparkserviceDurationMonths;
            }

            set
            {
                sparkserviceDurationMonths = value;
            }
        }
        public string FuelserviceDurationMonths
        {
            get
            {
                return fuelserviceDurationMonths;
            }

            set
            {
                fuelserviceDurationMonths = value;
            }
        }
        public string FuelSeviceDurationYears
        {
            get
            {
                return fuelSeviceDurationYears;
            }

            set
            {
                fuelSeviceDurationYears = value;
            }
        }
    }
}
