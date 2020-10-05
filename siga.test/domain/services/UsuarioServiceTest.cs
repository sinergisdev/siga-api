using System;
using AutoMapper;
using Moq;
using siga.domain.Services;
using siga.infrastructure.Model;
using siga.infrastructure.Repository;
using siga.viewModel;
using Xunit;

namespace siga.test.domain.services
{
    public class UsuarioServiceTest
    {
        [Fact]
        public void GetByIdOk()
        {
            var userId = 1;
            var userRepository = new Mock<IGenericRepository<Usuario>>();
            var user = new Usuario
            {
                userID = 1,
                name = "Daniel RUbilar",
                userName = "drubilar"
            };
            userRepository.Setup(repo => repo.Get(userId)).Returns(user);
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UsuarioDTO, Usuario>();
                cfg.CreateMap<Usuario, UsuarioDTO>();
            });
            var mapper = mockMapper.CreateMapper();

            var userService = new UsuarioService(userRepository.Object, mapper);

            // Test
            var result = userService.GetById(userId);

            Assert.NotNull(result);
            Assert.Equal(result.userName, user.userName);
        }

        [Fact]
        public void GetByIdNotFound()
        {
            var userId = 1;
            var userRepository = new Mock<IGenericRepository<Usuario>>();
          
            userRepository.Setup(repo => repo.Get(userId)).Returns(() => null);
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UsuarioDTO, Usuario>();
                cfg.CreateMap<Usuario, UsuarioDTO>();
            });
            var mapper = mockMapper.CreateMapper();

            var userService = new UsuarioService(userRepository.Object, mapper);

            // Test
            var result = userService.GetById(userId);

            Assert.Null(result);
           
        }
    }
}
