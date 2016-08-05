using System;
using Common;


namespace SerialLib
{
    class SerialCommunicator : ICommunicator
    {
        public bool SendData<T>(T data) where T : BaseDataPackage
        {
            throw new NotImplementedException();
        }
    }
}
