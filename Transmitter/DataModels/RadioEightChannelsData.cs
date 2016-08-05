using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class RadioEightChannelsData : RadioFourChannelsData
    {
        public RadioEightChannelsData() : this(8)
        { }

        protected RadioEightChannelsData(byte channelNumber) : base(channelNumber)
        { }

        public byte Aux1
        {
            get
            {
                return this[4];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[4] = value;
                }
            }
        }

        public byte Aux2
        {
            get
            {
                return this[5];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[5] = value;
                }
            }
        }

        public byte Aux3
        {
            get
            {
                return this[6];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[6] = value;
                }
            }
        }

        public byte Aux4
        {
            get
            {
                return this[7];
            }

            set
            {
                if (CheckValueRangeIncludeEdge(value, 0, 255))
                {
                    this[7] = value;
                }
            }
        }

    }
}
