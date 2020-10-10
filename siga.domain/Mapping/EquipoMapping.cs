using AutoMapper;
using siga.infrastructure.Model;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Mapping
{
    public class EquipoMapping:Profile
    {
        public EquipoMapping()
        {
            CreateMap<EquipoDTO, Equipo>();
            CreateMap<Equipo, EquipoDTO>();

        }
    }
}
