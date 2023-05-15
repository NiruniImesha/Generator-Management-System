using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorManagementSyestem.Model
{
    class serviceHistoryModel
    {
        private int serviceTurn;
        private string currentTotDuration;
        private string generatorID;
        private string serviceDate;
        private string serviceType;

        public int ServiceTurn
        {
            get
            {
                return serviceTurn;
            }

            set
            {
                serviceTurn = value;
            }
        }

        public string CurrentTotDuration
        {
            get
            {
                return currentTotDuration;
            }

            set
            {
                currentTotDuration = value;
            }
        }

        public string GeneratorID
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

        public string ServiceDate
        {
            get
            {
                return serviceDate;
            }

            set
            {
                serviceDate = value;
            }
        }

        public string ServiceType
        {
            get
            {
                return serviceType;
            }

            set
            {
                serviceType = value;
            }
        }
    }
}
