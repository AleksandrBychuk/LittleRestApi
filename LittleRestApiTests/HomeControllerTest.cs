using LittleRestApi.Controllers;
using LittleRestApi.Services;
using LittleRestApiTests.FakeServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace LittleRestApiTests
{
    public class HomeControllerTest
    {
        private readonly ISomeDataService _service;
        private readonly ILogger<HomeController> _logger;
        private readonly HomeController _controller;
        
        public HomeControllerTest()
        {
            _logger = new NullLogger<HomeController>();
            _service = new FakeSomeDataService();
            _controller = new HomeController(_service, _logger);
        }

        [Fact]
        public async Task GetSomeDatasRange_WhenCalled_ReturnsNotFoundObjectResult()
        {
            // Arrange
            // Act
            var notFoundResult = await _controller.GetSomeDatasRange();
            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult as NotFoundResult);
        }

        [Fact]
        public async Task GetSomeDatasRange_WhenCalled_ReturnsOkResult()
        {
            // Arrange
            // Act
            var okObjectResult = await _controller.GetSomeDatasRange(0, 12);
            // Assert
            Assert.IsType<OkObjectResult>(okObjectResult as OkObjectResult);
        }

        [Fact]
        public async Task GetSomeDatasRange_WhenCalledWithExtraNums_ReturnsOkResult()
        {
            // Arrange
            // Act
            var okObjectResult = await _controller.GetSomeDatasRange(0, 99999);
            // Assert
            Assert.IsType<OkObjectResult>(okObjectResult as OkObjectResult);
        }
    }
}