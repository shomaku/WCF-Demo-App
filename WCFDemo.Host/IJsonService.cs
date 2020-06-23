using System.ServiceModel;

namespace WCFDemo.Host
{
    [ServiceContract]
    public interface IJsonService
    {
        [OperationContract]
        string UploadJson(byte[] bytes);
    }
}
