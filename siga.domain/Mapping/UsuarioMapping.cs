using AutoMapper;
using siga.infrastructure.Model;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Mapping
{
    public class UsuarioMapping: Profile
    {
        public UsuarioMapping()
        {
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();

        }
    }
}
