// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/TestServiceProtoFile.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TestServer {
  public static partial class Testing
  {
    static readonly string __ServiceName = "Testing";

    static readonly grpc::Marshaller<global::TestServer.TestReq> __Marshaller_TestReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TestServer.TestReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TestServer.TestResp> __Marshaller_TestResp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TestServer.TestResp.Parser.ParseFrom);

    static readonly grpc::Method<global::TestServer.TestReq, global::TestServer.TestResp> __Method_TestService = new grpc::Method<global::TestServer.TestReq, global::TestServer.TestResp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestService",
        __Marshaller_TestReq,
        __Marshaller_TestResp);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TestServer.TestServiceProtoFileReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Testing</summary>
    [grpc::BindServiceMethod(typeof(Testing), "BindService")]
    public abstract partial class TestingBase
    {
      public virtual global::System.Threading.Tasks.Task<global::TestServer.TestResp> TestService(global::TestServer.TestReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TestingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_TestService, serviceImpl.TestService).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TestingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_TestService, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestServer.TestReq, global::TestServer.TestResp>(serviceImpl.TestService));
    }

  }
}
#endregion
