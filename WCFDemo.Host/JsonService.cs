using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace WCFDemo.Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JsonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JsonService.svc or JsonService.svc.cs at the Solution Explorer and start debugging.
    public class JsonService : IJsonService
    {
        private readonly DataContractJsonSerializer _serializer;

        public JsonService()
        {
            _serializer = new DataContractJsonSerializer(typeof(JsonData));
        }

        public string UploadJson(byte[] bytes)
        {
            if (null == bytes || bytes.Length < 1) return null;

            //var data = ParseJson1(bytes);
            var data = ParseJson2(bytes);

            return data.User.Name;
        }

        /// <summary>
        /// Parses data with DataContractJsonSerializer.
        /// </summary>
        /// <param name="bytes">The byte array.</param>
        /// <returns>Json data</returns>
        private JsonData ParseJson1(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                return _serializer.ReadObject(stream) as JsonData;
            }
        }

        /// <summary>
        /// Parses data with JSON.NET.
        /// </summary>
        /// <param name="bytes">The byte array.</param>
        /// <returns>Json data</returns>
        private JsonData ParseJson2(byte[] bytes)
        {
            var json = Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<JsonData>(json);
        }
    }
}
