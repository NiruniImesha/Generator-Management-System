using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorManagementSyestem.Model
{
    class dailyServiceDataModel
    {
        private string serviceNo;
        private string startTime;
        private string startDate;
        private string startUser;
        private string stopTime;
        private string stopUser;
        private string stopDate;
        private string Duration;
        private string state;

        public string ServiceNo
        {
            get
            {
                return serviceNo;
            }

            set
            {
                serviceNo = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public string StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public string StartUser
        {
            get
            {
                return startUser;
            }

            set
            {
                startUser = value;
            }
        }

        public string StopTime
        {
            get
            {
                return stopTime;
            }

            set
            {
                stopTime = value;
            }
        }

        public string StopUser
        {
            get
            {
                return stopUser;
            }

            set
            {
                stopUser = value;
            }
        }

        public string StopDate
        {
            get
            {
                return stopDate;
            }

            set
            {
                stopDate = value;
            }
        }

        public string Duration1
        {
            get
            {
                return Duration;
            }

            set
            {
                Duration = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}
