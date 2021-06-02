using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace Others
{
    class Program
    {
        private static void Main(string[] args)
        {
            var client = new RestClient("http://172.16.48.111:8291/SelfscanEnginePlugin/TripStart")
            {
                Timeout = -1
            };

            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "text/plain");
            
            request.AddParameter(
                "text/plain",
                "{\r\n    \"Origin\":\"Android\",\r\n    \"TicketMetaData\":\r\n    {\r\n        \"Started\":\"20210515135900\",\r\n        \"CustomerId\":\"9210170700000004\",\r\n        \"StoreId\":\"257\",\r\n        \"Language\":\"EN\",\r\n        \"Attributes\":\r\n        [\r\n            {\r\n                \"Name\":\"\",\r\n                \"Value\":\"\"\r\n            }\r\n        ],\r\n        \"ItemCapacity\":0\r\n    }\r\n}",
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            var objects = JObject.Parse(response.Content);

            if (!objects["Result"].ToString().Equals("Success")) { 
            
            Console.Write("Operation failed! - ");

            switch(objects["CustomerCardValidationResult"].ToString()) { 
                    case "1":
                        Console.Write("InvalidFormat");
                        break;
                    case "2":
                        Console.Write("TooManyShoppingTrips");
                        break;
                    case "3":
                        Console.Write("ProfileNotFound");
                        break;
                    case "4":
                        Console.Write("CardBlocked");
                        break;
                    case "5":
                        Console.Write("CardInactive");
                        break;
                    case "6":
                        Console.Write("Error");
                        break;
                    default:
                        // Success = 0
                        Console.Write("Success");
                        break;
                }
            }
            else {
                Console.WriteLine("TicketResult\n");
                foreach (var j in objects["TicketResult"])
                    Console.WriteLine(j);
                
                Console.WriteLine("\nShoppingTripResult\n");
                foreach (var j in objects["ShoppingTripResult"])
                    Console.WriteLine(j);
            }

        }
    }
}
