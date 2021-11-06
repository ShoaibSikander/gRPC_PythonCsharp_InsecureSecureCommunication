# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
"""Client and server classes corresponding to protobuf-defined services."""
import grpc

import TestServiceProtoFile_pb2 as TestServiceProtoFile__pb2


class TestingStub(object):
    """Missing associated documentation comment in .proto file."""

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.TestService = channel.unary_unary(
                '/Testing/TestService',
                request_serializer=TestServiceProtoFile__pb2.TestReq.SerializeToString,
                response_deserializer=TestServiceProtoFile__pb2.TestResp.FromString,
                )


class TestingServicer(object):
    """Missing associated documentation comment in .proto file."""

    def TestService(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_TestingServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'TestService': grpc.unary_unary_rpc_method_handler(
                    servicer.TestService,
                    request_deserializer=TestServiceProtoFile__pb2.TestReq.FromString,
                    response_serializer=TestServiceProtoFile__pb2.TestResp.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'Testing', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class Testing(object):
    """Missing associated documentation comment in .proto file."""

    @staticmethod
    def TestService(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/Testing/TestService',
            TestServiceProtoFile__pb2.TestReq.SerializeToString,
            TestServiceProtoFile__pb2.TestResp.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)
