using Common;
using CommunicationLayer;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new RadioEightChannelsData();
            data.Throttle = 0;
            data.Yaw = 32;
            data.Pitch = 64;
            data.Roll = 128;
            data.Aux1 = 32;
            data.Aux2 = 64;
            data.Aux3 = 128;
            data.Aux4 = 255;

            using (var port = new SerialCommunicator("com7", 9600))
            {
                for(int i = 0; i< 10000000; ++i)
                {
                    data.Throttle = Convert.ToByte((data.Throttle + 1) % 255);
                    data.Yaw = Convert.ToByte((data.Yaw + 1) % 255);
                    data.Pitch = Convert.ToByte((data.Pitch + 1) % 255);
                    data.Roll = Convert.ToByte((data.Roll + 1) % 255);

                    port.SendData(data.toBytes());
                }
            }
        }
    }
}
