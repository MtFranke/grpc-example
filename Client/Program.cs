using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeter;

namespace Client
{
    class Program
    {

        static  async  Task Main(string[] args)
        {
            string serverAddress = "https://localhost:5001";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                // The following statement allows you to call insecure services. To be used only in development environments.
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                serverAddress = "http://localhost:5000";
            }

            using var channel = GrpcChannel.ForAddress(serverAddress);
            var client =  new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}