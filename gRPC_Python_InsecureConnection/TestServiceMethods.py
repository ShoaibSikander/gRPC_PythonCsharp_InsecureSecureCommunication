def provide_details(name, id):
    print("Server received test request ...")
    print("Received information about User's Name: ", name)
    print("Received information about User's Id: ", id)

    print("Server is preparing data to respond test request ...")

    TestUserCompanyName = "LS telcom AG"
    TestUserDesignation = "Software Developer"
    TestUserSalary = 12345
    company = TestUserCompanyName
    designation = TestUserDesignation
    salary = TestUserSalary

    print("Server sent the test response successfully ...")
    print("***************")

    return company, designation, salary
