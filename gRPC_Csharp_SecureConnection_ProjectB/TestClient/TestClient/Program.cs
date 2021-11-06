using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
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

            // secure channel communication with C# server (not implemented yet, it should work with ssl.crt)
            var channel = GrpcChannel.ForAddress("https://localhost:50014");
            // secure channel communication with Python server (not working)
            //var channelCredentials = new SslCredentials(File.ReadAllText("L:\\Csharp\\gRPC_Csharp_SecureConnection_ProjectA\\TestClient\\TestClient\\ssl.crt"));
            //var channel = GrpcChannel.ForAddress("https://localhost:50051");
            /*
            string certificatePem = File.ReadAllText(@"L:\Csharp\gRPC_Csharp_SecureConnection_ProjectB\TestClient\TestClient\ssl.crt");
            string privateKeyPem = File.ReadAllText(@"L:\Csharp\gRPC_Csharp_SecureConnection_ProjectB\TestClient\TestClient\ssl.key");
            var cert = X509Certificate2.CreateFromPem(certificatePem, privateKeyPem);
            var handler = new HttpClientHandler();
            handler.ClientCertificates.Add(cert);
            using HttpClient httpClient = new(handler);
            var channel = GrpcChannel.ForAddress("https://localhost:50051/", new GrpcChannelOptions
            {
                HttpClient = httpClient
            });
            */
            /*
            String Certificate = @"L:\Csharp\gRPC_Csharp_SecureConnection_ProjectB\TestClient\TestClient\ssl.crt";
            X509Certificate cert = X509Certificate.CreateFromCertFile(Certificate);
            */
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
