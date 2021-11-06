import grpc
import TestServiceProtoFile_pb2
import TestServiceProtoFile_pb2_grpc

channel = grpc.insecure_channel('localhost:50050')
stub = TestServiceProtoFile_pb2_grpc.TestingStub(channel)

print("*** test service ***")
print("Client is requesting for test service ...")

TestUserName = "Shoaib Sikander"
TestUserId = 786

req = TestServiceProtoFile_pb2.TestReq(user_name=TestUserName, user_id=TestUserId)
resp = stub.TestService(req)

print("Client received response from server ...")
print("Received information about User's Company Name: ", resp.company_name)
print("Received information about User's Designation: ", resp.designation)
print("Received information about User's Salary: ", resp.salary_eur)
