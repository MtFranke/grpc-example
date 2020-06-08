using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeter;

namespace Service1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            // var client =  new GreeterService();
            // var reply = await client.SayHello(
            //     new HelloRequest { Name = "GreeterClient" }
            //     );
            // Console.WriteLine("Greeting: " + reply.Message);
            // Console.WriteLine("Press any key to exit...");
            // Console.ReadKey();
        }
    }
}