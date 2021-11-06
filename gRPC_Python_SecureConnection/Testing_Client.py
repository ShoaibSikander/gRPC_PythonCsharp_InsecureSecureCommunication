import grpc
import TestServiceProtoFile_pb2
import TestServiceProtoFile_pb2_grpc

def main():
    host = 'localhost'
    port = 50051

    # read in certificate
    with open('ssl.crt', 'rb') as f:
        trusted_certs = f.read()

    # create credentials
    credentials = grpc.ssl_channel_credentials(root_certificates=trusted_certs)

    # create channel using ssl credentials
    channel = grpc.secure_channel('{}:{}'.format(host, port), credentials, options=[('grpc.max_receive_message_length', -1), ('grpc.max_send_message_length', -1), ('grpc.ssl_target_name_override',host), ('grpc.default_authority',host )])
    stub = TestServiceProtoFile_pb2_grpc.TestingStub(channel)
    
    print("*** test service ***")
    print("Client is requesting for test service ...")
    TestUserName = "Shoaib Sikander"
    TestUserId = 786

    req = TestServiceProtoFile_pb2.TestReq(user_name = TestUserName, user_id=TestUserId)
    resp = stub.TestService(req)

    print("Client received response from server ...")
    print("Received information about User's Company Name: ", resp.company_name)
    print("Received information about User's Designation: ", resp.designation)
    print("Received information about User's Salary: ", resp.salary_eur)

if __name__ == '__main__':
    main()