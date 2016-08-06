using System;
using Common;
using System.IO.Ports;

namespace CommunicationLayer
{
    public class SerialCommunicator : IDisposable //ICommunicator<byte[]>,
    {
        bool disposed = false;
        private SerialPort port;

        public SerialCommunicator(string portNumber, int baudRate)
        {
            port = new SerialPort(portNumber, baudRate);
            port.Open();
        }

        #region Disposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            this.close();

            disposed = true;
        }

        ~SerialCommunicator()
        {
            Dispose(false);
        }
        #endregion

        public void close()
        {
            if ((port != null) && (port.IsOpen))
            {
                port.Close();
            }
        }

        public void SendData(byte[] data)
        {
            if (port.IsOpen)
            {
                port.Write(data, 0, data.Length);
            }
        }

    }
}
