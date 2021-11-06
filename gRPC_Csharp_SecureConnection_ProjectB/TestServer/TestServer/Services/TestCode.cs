using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace TestServer
{
    public class TestCode : Testing.TestingBase
    {
        private readonly ILogger<TestCode> _logger;
        public TestCode(ILogger<TestCode> logger)
        {
            _logger = logger;
        }

        public override Task<TestResp> TestService(TestReq request, ServerCallContext context)
        {

            Console.WriteLine("Server received test request ...");

            String TestUserName = request.UserName;
            Int32 TestUderId = request.UserId;
            Console.WriteLine($"Received information about User's Name: {TestUserName}");
            Console.WriteLine($"Received information about User's Id: {TestUderId}");

            Console.WriteLine("Server is preparing data to respond test request ...");

            String TestUserCompanyName = "LS telcom AG";
            String TestUserDesignation = "Software Developer";
            Int32 TestUserSalary = 12345;

            TestResp resp = new TestResp { CompanyName = TestUserCompanyName, Designation = TestUserDesignation, SalaryEur = TestUserSalary };

            Console.WriteLine("Server sent the test response successfully ...");
            Console.WriteLine("***************");
            return Task.FromResult(resp);
        }
    }
}
