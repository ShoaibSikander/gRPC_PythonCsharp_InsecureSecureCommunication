using System;
using System.IO;
using Grpc.Core;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am client !");
            Console.WriteLine("***********************************");
            try
            {
                // secure channel communication with C# server (working fine)
                var channelCredentials = new SslCredentials(File.ReadAllText("L:\\Csharp\\gRPC_Csharp_SecureConnection_ProjectA\\TestClient\\TestClient\\ssl.crt"));
                Channel channel = new Channel("localhost:50013", channelCredentials);
                // secure channel communication with Python server (working fine)
                //var channelCredentials = new SslCredentials(File.ReadAllText("L:\\Csharp\\gRPC_Csharp_SecureConnection_ProjectA\\TestClient\\TestClient\\ssl.crt"));
                //Channel channel = new Channel("localhost:50051", channelCredentials);
                var client = new Testing.TestingClient(channel);

                Console.WriteLine("*** test service ***");
                Console.WriteLine("Client is requesting for test service ...");
                String TestUserName = "Shoaib Sikander";
                Int32 TestUserId = 786;
                TestReq req = new TestReq { UserName = TestUserName, UserId = TestUserId };
                TestResp resp = client.TestService(req);

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
            catch (Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }
}
