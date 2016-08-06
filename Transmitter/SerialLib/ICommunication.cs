
namespace SerialLib
{
    public interface ICommunication
    {
        bool SendData<T>(T data) where T: BaseDataPackage;
    }
}
