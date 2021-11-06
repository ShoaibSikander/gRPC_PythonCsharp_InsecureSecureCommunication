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

def serve():
    port = '50051'

    # read in key and certificate
    with open('ssl.key', 'rb') as f:
        private_key = f.read()
    with open('ssl.crt', 'rb') as f:
        certificate_chain = f.read()
    
    # create server credentials
    server_credentials = grpc.ssl_server_credentials(((private_key, certificate_chain,),))
    
    # create server
    server = grpc.server(futures.ThreadPoolExecutor(max_workers=10), options = [('grpc.max_send_message_length', -1),('grpc.max_receive_message_length', -1)])
    TestServiceProtoFile_pb2_grpc.add_TestingServicer_to_server(TestingServicer(), server) 
    
    # add secure port using crendentials
    server.add_secure_port('[::]:'+port, server_credentials)
    
    server.start()
    print('API server started. Listening at localhost:'+port)
    
    try:
        while True:
            time.sleep(86400)
    except KeyboardInterrupt:
        server.stop(0)

if __name__ == '__main__':
    serve()