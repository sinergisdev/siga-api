using AutoMapper;
using siga.infrastructure.Model;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Mapping
{
    public class FaenaMapping : Profile
    {

        public FaenaMapping()
        {
            CreateMap<FaenaDTO, Faena>();
            CreateMap<Faena, FaenaDTO>();

        }
    }
}
