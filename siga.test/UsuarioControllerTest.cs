using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using siga.api.Controllers;
using siga.domain.Services;
using siga.viewModel;

namespace siga.test
{
    [TestClass]
    public class UsuarioControllerTest
    {
        [TestMethod]
        public void GetUserNotFound()
        {
            //preparación
            var idUsuario = 1;
            var mock = new Mock<IUsuarioService>();
            mock.Setup(x => x.GetById(idUsuario)).Returns(default(UsuarioDTO));
            
            var usuarioController = new UsuarioController(mock.Object);

            //prueba
            var resultado = usuarioController.GetById(idUsuario);
            
            //verificación
            Assert.IsInstanceOfType(resultado, typeof(NotFoundResult));

           

        }

        [TestMethod]
        public void GetUserFound()
        {
            //preparación
            var usuarioMock = new UsuarioDTO()
            {
                userId = 2,
                name = "DANIEL RUBILAR PEREZ",
                userName = "drubilar"
            };

            var mock = new Mock<IUsuarioService>();
            mock.Setup(x => x.GetById(usuarioMock.userId)).Returns(usuarioMock);
            var usuarioController = new UsuarioController(mock.Object);

            //prueba
            var result = usuarioController.GetById(usuarioMock.userId) as OkObjectResult;

            //verificación
            Assert.IsNotNull(result.Value);

            var model = result.Value as UsuarioDTO;
            Assert.AreEqual(model.userId, usuarioMock.userId);
            Assert.AreEqual(model.userName, usuarioMock.userName);

        }
    }
}
