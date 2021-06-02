using RestSharp;
using System;

namespace Others
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://172.16.48.111:8291/SelfscanEnginePlugin/TripStart");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "text/plain");
            request.AddHeader("Cookie", "BusinessServerSessionId=de971aef-2911-4db7-bdfd-a3e0ae0c182c");
            request.AddParameter("text/plain", "{\r\n    \"Origin\":\"Android\",\r\n    \"TicketMetaData\":\r\n    {\r\n        \"Started\":\"20210515135900\",\r\n        \"CustomerId\":\"9210170700000004\",\r\n        \"StoreId\":\"257\",\r\n        \"Language\":\"EN\",\r\n        \"Attributes\":\r\n        [\r\n            {\r\n                \"Name\":\"\",\r\n                \"Value\":\"\"\r\n            }\r\n        ],\r\n        \"ItemCapacity\":0\r\n    }\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
