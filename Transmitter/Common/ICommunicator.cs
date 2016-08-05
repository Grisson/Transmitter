
namespace Common
{
    public interface ICommunicator
    {
        bool SendData<T>(T data) where T: BaseDataPackage;
    }
}
