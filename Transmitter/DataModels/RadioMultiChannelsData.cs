using Common;
using System;
using System.Linq;

namespace DataModels
{
    public class RadioMultiChannelsData : BaseDataPackage
    {
        private byte channelNumber;
        private byte[] channels;
        private const byte channelMinValue = 0;
        private const byte channelMaxValue = 255;

        protected byte this[byte i]
        {
            get
            {
                if ((0 <= i) && (i < channelNumber))
                {
                    return this.channels[i];
                }
                else
                {
                    throw new IndexOutOfRangeException($"Accessing channel {i}. Total channel number is {channelNumber}");
                }
            }
            
            set
            {
                if ((0 <= i) && (i < channelNumber))
                {
                    this.channels[i] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Accessing channel {i}. Total channel number is {channelNumber}");
                }
            }
        }

        public byte[] toBytes()
        {
            var result = new byte[channelNumber];

            channels.CopyTo(result, 0);

            return result;
        }

        protected RadioMultiChannelsData(byte totalChannelNumber)
        {
            channelNumber = totalChannelNumber;
            channels = Enumerable.Repeat(Convert.ToByte(0), totalChannelNumber).ToArray(); ;
        }
    }
}
