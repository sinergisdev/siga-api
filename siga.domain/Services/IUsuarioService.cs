using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services
{
    public interface IUsuarioService
    {
        UsuarioDTO GetById(int id);
        UsuarioDTO GetByRut(int rut);
        void Add(UsuarioDTO usuario);
        void Update(UsuarioDTO usuario);
        UsuarioDTO GetByUserName(string userName);

        List<UsuarioDTO> GetByUsers(string userName);
    }
}
