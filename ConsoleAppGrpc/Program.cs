using Grpc.Core;
using System;
using Grpctest;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleAppGrpc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var channel = new Channel("127.0.0.1:50052", ChannelCredentials.Insecure);

            var client =new helloMessage.helloMessageClient(channel);

            Hi hi1=client.GetFeature(new Hi() { Count = 100, Say = "Hello 100" });
            Console.WriteLine($"Hi count:{hi1.Count},say:{hi1.Say}.");

            Hi hi2 =client.GetFeatureAsync(new Hi() { Count = 400, Say = "Hello 400" }).ResponseAsync.Result;
            Console.WriteLine($"Hi count:{hi2.Count},say:{hi2.Say}.");

            ListPerson2(client).Wait();

            ListPerson4(client).Wait();

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            //var client = new RouteGuideClient(new Hello.RouteGuideClient(channel));

            Console.Read();
        }

        private static async Task ListPerson2(helloMessage.helloMessageClient client)
        {
            using (var call = client.ListPerson2(new Persion() { Name = "B" }))
            {
                var responseStream = call.ResponseStream;
                CancellationToken can = new CancellationToken();
                while ((await responseStream.MoveNext(can)))
                {
                    Persion model=responseStream.Current;
                    Console.WriteLine($"Name:{model.Name}");
                }
            }
        }

        private static async Task ListPerson4(helloMessage.helloMessageClient client)
        {
            using (var call = client.ListPerson4())
            {
                var tastResponse= Task.Run(async () =>
                {
                    var responseStream = call.ResponseStream;
                    CancellationToken can = new CancellationToken();
                    while ((await responseStream.MoveNext(can)))
                    {
                        Persion model = responseStream.Current;
                        Console.WriteLine($"Response Name:{model.Name}");
                    }
                });


                foreach (var i in new int[] { 1,2,3,4,5,6,7,8,9,10})
                {
                    var model = new Persion() {Name="IN"+i };
                    Console.WriteLine($"Request Name={model.Name}");

                    await call.RequestStream.WriteAsync(model);
                }
                await call.RequestStream.CompleteAsync();
                tastResponse.Wait();
            }
        }
    }
}