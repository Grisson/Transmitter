
namespace Common
{
    public interface ICommunicator<T>
    {
        void SendData(T data);
    }
}
