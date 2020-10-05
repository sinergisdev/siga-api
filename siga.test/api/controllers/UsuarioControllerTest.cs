using System;
using siga.domain.Services;
using Xunit;
using Moq;
using siga.viewModel;
using siga.api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace siga.test
{
    public class UsuarioControllerTest
    {
        [Fact]
        public void GetByIdOk()
        {
            var userId = 1;
            var userServiceMock = new Mock<IUsuarioService>();
            var expectedUser = new UsuarioDTO
            {
                name = "Daniel Rubilar",
                userId = 1,
                userName = "drubilar"
            };
            userServiceMock.Setup(serv => serv.GetById(userId)).Returns(expectedUser);
            var controller = new UsuarioController(userServiceMock.Object);

            // Test
            var result = controller.GetById(userId);

            var okResult = result as OkObjectResult;

            // assert
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
        }


        [Fact]
        public void GetByIdNotFound()
        {
            var userId = 111111111;
            var userServiceMock = new Mock<IUsuarioService>();
            var expectedUser = new UsuarioDTO
            {
                name = "Daniel Rubilar",
                userId = 1,
                userName = "drubilar"
            };
            userServiceMock.Setup(serv => serv.GetById(userId)).Returns(() => null);
            var controller = new UsuarioController(userServiceMock.Object);

            // Test
            var result = controller.GetById(userId);

            var notFoundResult = result as NotFoundResult;

            // assert
            Assert.Equal(404, notFoundResult.StatusCode);
        }
    }


}
