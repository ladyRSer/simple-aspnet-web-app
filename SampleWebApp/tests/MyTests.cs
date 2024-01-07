using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Controllers;
using Xunit;

namespace MyAspNetCoreApp.Tests
{
    public class WebAppTests
    {
        [Fact]
        public void HomeController_Index_ReturnsView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        // Add more tests for your web application components
    }
}