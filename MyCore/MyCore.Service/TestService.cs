using MyCore.Contract;
using System;

namespace MyCore.Service
{
    public class TestService : ITestService
    {
        public string HelloChuck()
        {
            return "hello chuck you are great boy";
        }
    }
}
