using AutoMapper;
using siga.infrastructure.Model;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Mapping
{
    public class AreaMapping:Profile
    {
        public AreaMapping()
        {
            CreateMap<AreaDTO, Area>();
            CreateMap<Area, AreaDTO>();

        }
    }
}
