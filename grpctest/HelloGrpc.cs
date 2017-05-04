// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: hello.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Grpctest {
  /// <summary>
  /// Interface exported by the server.
  /// </summary>
  public static partial class helloMessage
  {
    static readonly string __ServiceName = "grpctest.helloMessage";

    static readonly grpc::Marshaller<global::Grpctest.Hi> __Marshaller_Hi = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpctest.Hi.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Grpctest.Persions> __Marshaller_Persions = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpctest.Persions.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Grpctest.Persion> __Marshaller_Persion = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpctest.Persion.Parser.ParseFrom);

    static readonly grpc::Method<global::Grpctest.Hi, global::Grpctest.Hi> __Method_GetFeature = new grpc::Method<global::Grpctest.Hi, global::Grpctest.Hi>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFeature",
        __Marshaller_Hi,
        __Marshaller_Hi);

    static readonly grpc::Method<global::Grpctest.Persions, global::Grpctest.Persions> __Method_ListPersons = new grpc::Method<global::Grpctest.Persions, global::Grpctest.Persions>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ListPersons",
        __Marshaller_Persions,
        __Marshaller_Persions);

    static readonly grpc::Method<global::Grpctest.Persion, global::Grpctest.Persion> __Method_ListPerson2 = new grpc::Method<global::Grpctest.Persion, global::Grpctest.Persion>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListPerson2",
        __Marshaller_Persion,
        __Marshaller_Persion);

    static readonly grpc::Method<global::Grpctest.Persion, global::Grpctest.Persion> __Method_ListPerson3 = new grpc::Method<global::Grpctest.Persion, global::Grpctest.Persion>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ListPerson3",
        __Marshaller_Persion,
        __Marshaller_Persion);

    static readonly grpc::Method<global::Grpctest.Persion, global::Grpctest.Persion> __Method_ListPerson4 = new grpc::Method<global::Grpctest.Persion, global::Grpctest.Persion>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ListPerson4",
        __Marshaller_Persion,
        __Marshaller_Persion);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpctest.HelloReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of helloMessage</summary>
    public abstract partial class helloMessageBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Grpctest.Hi> GetFeature(global::Grpctest.Hi request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Grpctest.Persions> ListPersons(grpc::IAsyncStreamReader<global::Grpctest.Persions> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ListPerson2(global::Grpctest.Persion request, grpc::IServerStreamWriter<global::Grpctest.Persion> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Grpctest.Persion> ListPerson3(grpc::IAsyncStreamReader<global::Grpctest.Persion> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ListPerson4(grpc::IAsyncStreamReader<global::Grpctest.Persion> requestStream, grpc::IServerStreamWriter<global::Grpctest.Persion> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for helloMessage</summary>
    public partial class helloMessageClient : grpc::ClientBase<helloMessageClient>
    {
      /// <summary>Creates a new client for helloMessage</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public helloMessageClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for helloMessage that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public helloMessageClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected helloMessageClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected helloMessageClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Grpctest.Hi GetFeature(global::Grpctest.Hi request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFeature(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Grpctest.Hi GetFeature(global::Grpctest.Hi request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFeature, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Grpctest.Hi> GetFeatureAsync(global::Grpctest.Hi request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFeatureAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Grpctest.Hi> GetFeatureAsync(global::Grpctest.Hi request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFeature, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Grpctest.Persions, global::Grpctest.Persions> ListPersons(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListPersons(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Grpctest.Persions, global::Grpctest.Persions> ListPersons(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ListPersons, null, options);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Grpctest.Persion> ListPerson2(global::Grpctest.Persion request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListPerson2(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Grpctest.Persion> ListPerson2(global::Grpctest.Persion request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListPerson2, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Grpctest.Persion, global::Grpctest.Persion> ListPerson3(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListPerson3(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Grpctest.Persion, global::Grpctest.Persion> ListPerson3(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_ListPerson3, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Grpctest.Persion, global::Grpctest.Persion> ListPerson4(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListPerson4(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Grpctest.Persion, global::Grpctest.Persion> ListPerson4(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ListPerson4, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override helloMessageClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new helloMessageClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(helloMessageBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFeature, serviceImpl.GetFeature)
          .AddMethod(__Method_ListPersons, serviceImpl.ListPersons)
          .AddMethod(__Method_ListPerson2, serviceImpl.ListPerson2)
          .AddMethod(__Method_ListPerson3, serviceImpl.ListPerson3)
          .AddMethod(__Method_ListPerson4, serviceImpl.ListPerson4).Build();
    }

  }
}
#endregion