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

        private string frequency01;
        private string tankSize01;
        private string totalDuration01;
        private string firstServiceMonth01;
        private string firstServiceHours01;


        private string start_date_range;
        private string end_date_range;

        public string End_date_range
        {
            get
            {
                return end_date_range;
            }

            set
            {
                end_date_range = value;
            }
        }
        public string Start_date_range
        {
            get
            {
                return start_date_range;
            }

            set
            {
                start_date_range = value;
            }
        }
        public string FirstServiceHours01
        {
            get
            {
                return firstServiceHours01;
            }

            set
            {
                firstServiceHours01 = value;
            }
        }
        public string FirstServiceMonth01
        {
            get
            {
                return firstServiceMonth01;
            }

            set
            {
                firstServiceMonth01 = value;
            }
        }
        public string TotalDuration01
        {
            get
            {
                return totalDuration01;
            }

            set
            {
                totalDuration01 = value;
            }
        }
        public string TankSize01
        {
            get
            {
                return tankSize01;
            }

            set
            {
                tankSize01 = value;
            }
        }
        public string Frequency01
        {
            get
            {
                return frequency01;
            }

            set
            {
                frequency01 = value;
            }
        }
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
