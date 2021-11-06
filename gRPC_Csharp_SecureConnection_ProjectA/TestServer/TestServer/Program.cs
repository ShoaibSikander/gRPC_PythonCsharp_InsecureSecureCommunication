using System;
using System.Collections.Generic;
using System.IO;
using Grpc.Core;

namespace TestServer
{
    class Program
    {
        const int Port = 50013;
        static void Main(string[] args)
        {
            Console.WriteLine("I am Server !");
            try
            {
                var keypair = new KeyCertificatePair(
                    File.ReadAllText(@"L:\Csharp\gRPC_Csharp_SecureConnection_ProjectA\TestServer\TestServer\ssl.crt"),
                    File.ReadAllText(@"L:\Csharp\gRPC_Csharp_SecureConnection_ProjectA\TestServer\TestServer\ssl.key"));
                SslServerCredentials creds = new SslServerCredentials(new List<KeyCertificatePair>() { keypair });
                Server server = new Server
                {
                    Services = { Testing.BindService(new TestCode()) },
                    Ports = { new ServerPort("localhost", Port, creds) }
                };
                server.Start();
                Console.WriteLine("Server  started and listening on port: " + Port);
                Console.WriteLine("Press any key to stop the server...");
                Console.WriteLine("***************");
                Console.ReadKey();
                server.ShutdownAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }
    }
}
