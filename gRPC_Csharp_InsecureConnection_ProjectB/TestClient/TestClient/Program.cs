using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("I am client !");
            Console.WriteLine("***********************************");

            // insecure channel communication with C# server (working fine)
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress("http://localhost:50012");
            // insecure channel communication with Python server (working fine)
            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            //var channel = GrpcChannel.ForAddress("http://localhost:50050");
            var client = new Testing.TestingClient(channel);

            Console.WriteLine("*** test service ***");
            Console.WriteLine("Client is requesting for test service ...");
            String TestUserName = "Shoaib Sikander";
            Int32 TestUserId = 786;
            TestReq req = new TestReq { UserName = TestUserName, UserId = TestUserId };
            TestResp resp = await client.TestServiceAsync(req);

            if (resp == null)
            {
                Console.WriteLine("Initiliazation failed ..");
                Console.WriteLine("***********************************");
            }
            else
            {
                Console.WriteLine("Client received response from server ...");
                String TestUserCompanyName = resp.CompanyName;
                String TestUserDesignation = resp.Designation;
                Int32 TestUserSalary = resp.SalaryEur;
                Console.WriteLine($"Received information about User's Company Name: {TestUserCompanyName}");
                Console.WriteLine($"Received information about User's Designation: {TestUserDesignation}");
                Console.WriteLine($"Received information about User's Salary: {TestUserSalary}");
                Console.WriteLine("***********************************");
            }
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
