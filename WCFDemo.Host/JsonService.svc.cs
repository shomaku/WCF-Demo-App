using System.Text;

namespace WCFDemo.Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class JsonService : IJsonService
    {
        public string UploadJson(byte[] bytes)
        {
            if (null == bytes || bytes.Length < 1) return null;

            var json = Encoding.UTF8.GetString(bytes);
            return json;
        }
    }
}
