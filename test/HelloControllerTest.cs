using System;
using src.Controllers;
using Xunit;

namespace test
{
    public class HelloControllerTest
    {
        private readonly HomeController _homeController;

        public HelloControllerTest()
        {
            _homeController = new HomeController();   
        }
        
        [Fact]
        public void VerifyHelloWorldGet()
        {
            var result = _homeController.Get();
            Assert.Contains("hello world", result);
        }
    }
}