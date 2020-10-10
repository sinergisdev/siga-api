using AutoMapper;
using siga.infrastructure.Model;
using siga.infrastructure.Repository;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services.Faena
{
    public class FaenaService : IFaenaService
    {

        private readonly IGenericRepository<siga.infrastructure.Model.Faena> _repository;
        private readonly IMapper _mapper;

        public FaenaService(IGenericRepository<siga.infrastructure.Model.Faena> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<FaenaDTO> GetFaenas()
        {
            return _mapper.Map<List<FaenaDTO>>(_repository.FindAllWhere(x => x.type == "M" && x.estado == "V"));
        }
    }
}
