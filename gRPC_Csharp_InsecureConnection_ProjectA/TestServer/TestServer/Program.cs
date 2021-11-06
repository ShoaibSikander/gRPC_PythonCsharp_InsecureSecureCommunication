using System;
using Grpc.Core;

namespace TestServer
{
    class Program
    {
        const int Port = 50011;
        static void Main(string[] args)
        {
            Console.WriteLine("I am Server !");
            try
            {
                Server server = new Server
                {
                    Services = { Testing.BindService(new TestCode()) },
                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
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
