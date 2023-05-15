using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorManagementSyestem.Model
{
    class generatorModel
    {
        private string genNo;
        private string model;
        private string name;
        private int frequency;
        private int tankSize;
        private int FirstServiceMonth;
        private int firstServiceHours;
        private string totalDuration;

        public string GenNo
        {
            get
            {
                return genNo;
            }

            set
            {
                genNo = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                frequency = value;
            }
        }

        public int TankSize
        {
            get
            {
                return tankSize;
            }

            set
            {
                tankSize = value;
            }
        }

        public int FirstServiceMonth1
        {
            get
            {
                return FirstServiceMonth;
            }

            set
            {
                FirstServiceMonth = value;
            }
        }

        public int FirstServiceHours
        {
            get
            {
                return firstServiceHours;
            }

            set
            {
                firstServiceHours = value;
            }
        }

        public string TotalDuration
        {
            get
            {
                return totalDuration;
            }

            set
            {
                totalDuration = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
