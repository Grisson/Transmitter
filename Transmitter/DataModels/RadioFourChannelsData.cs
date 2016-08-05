using Common;

namespace DataModels
{
    public class RadioFourChannelsData : RadioMultiChannelsData
    {
        public RadioFourChannelsData() : this(4)
        {
        }

        protected RadioFourChannelsData(byte chanelNumber) : base(chanelNumber)
        {

        }

        public byte Throttle
        {
            get
            {
                return this[0];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[0] = value;
                }
            }
        }

        public byte Yaw
        {
            get
            {
                return this[1];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[1] = value;
                }
            }
        }

        public byte Pitch
        {
            get
            {
                return this[2];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[2] = value;
                }
            }
        }

        public byte Roll
        {
            get
            {
                return this[3];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[3] = value;
                }
            }
        }
    }
}
