using AutoMapper;
using siga.infrastructure.Model;
using siga.infrastructure.Repository;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IGenericRepository<Usuario> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public UsuarioService(IGenericRepository<Usuario> @object, Mapper mapper)
        {
        }

        public void Add(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO GetById(int id)
        {
            return _mapper.Map<UsuarioDTO>(_repository.Get(id));
        }

        public UsuarioDTO GetByRut(int rut)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> GetByUsers(string userName)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }
    }
}
