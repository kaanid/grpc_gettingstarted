using Grpc.Core;
using Grpctest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppGrpcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Port = 50052;
            Server server = new Server
            {
                Services = { helloMessage.BindService(new RouteGuideImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("RouteGuide server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }

    public class RouteGuideImpl : helloMessage.helloMessageBase
    {
        public override Task<Hi> GetFeature(Hi request, ServerCallContext context)
        {
            //return base.GetFeature(request, context);
            Hi hi1 = request;

            Console.WriteLine($"Hi count:{hi1.Count},say:{hi1.Say}.");
            return Task.FromResult<Hi>(new Hi() { Count= hi1.Count+1, Say="World!"+hi1.Count});
        }

        public override async Task ListPerson2(Persion request, IServerStreamWriter<Persion> responseStream, ServerCallContext context)
        {
            //return base.ListPerson2(request, responseStream, context);
            Console.WriteLine($"Person:{request.Name}.");
            foreach (var i in Enumerable.Range(0, 10))
            {
                await responseStream.WriteAsync(new Persion() { Name = "A" + DateTime.Now.Second.ToString() });
                Thread.Sleep(1000);
            }
        }

        public override async Task ListPerson4(IAsyncStreamReader<Persion> requestStream, IServerStreamWriter<Persion> responseStream, ServerCallContext context)
        {
            //return base.ListPerson4(requestStream, responseStream, context);
            while (await requestStream.MoveNext())
            {
                var req = requestStream.Current;
                Console.WriteLine($"4:Name:{req.Name}");
                foreach(var i in Enumerable.Range(100, 110))
                {
                    await responseStream.WriteAsync(new Persion { Name = req.Name + "   " + i.ToString() });
                }


            }
        }
    }
}