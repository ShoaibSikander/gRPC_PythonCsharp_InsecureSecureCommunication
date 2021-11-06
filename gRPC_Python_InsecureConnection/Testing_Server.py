import grpc
from concurrent import futures
import time

import TestServiceMethods
import TestServiceProtoFile_pb2
import TestServiceProtoFile_pb2_grpc

class TestingServicer(TestServiceProtoFile_pb2_grpc.TestingServicer):
    def TestService(self, request, context):
        comp, desig, sal = TestServiceMethods.provide_details(request.user_name, request.user_id)
        result = TestServiceProtoFile_pb2.TestResp(company_name=comp, designation=desig, salary_eur=sal)
        return result

if __name__ == '__main__':
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=1))
    TestServiceProtoFile_pb2_grpc.add_TestingServicer_to_server(TestingServicer(), server)
    server.add_insecure_port('0.0.0.0:50050')
    server.start()
    print('API server started. Listening at localhost:50050')
    try:
        while True:
            time.sleep(86400)
    except KeyboardInterrupt:
        server.stop(0)