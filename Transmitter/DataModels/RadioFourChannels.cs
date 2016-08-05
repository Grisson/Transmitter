using Common;

namespace SerialLib
{
    class RadioFourChannels : BaseDataPackage
    {
        private byte throttle;
        private byte yaw;
        private byte pitch;
        private byte roll;

        public byte Throttle
        {
            get
            {
                return throttle;
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    throttle = value;
                }
            }
        }

        public byte Yaw
        {
            get
            {
                return yaw;
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    yaw = value;
                }
            }
        }


        public byte Pitch
        {
            get
            {
                return pitch;
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    pitch = value;
                }
            }
        }

        public byte Roll
        {
            get
            {
                return roll;
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    roll = value;
                }
            }
        }
    }
}
