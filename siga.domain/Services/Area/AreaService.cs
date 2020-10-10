using AutoMapper;
using siga.infrastructure.Repository;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services.Area
{
    public class AreaService : IAreaService
    {
        private readonly IGenericRepository<siga.infrastructure.Model.Area> _repository;
        private readonly IMapper _mapper;
        public AreaService(IGenericRepository<siga.infrastructure.Model.Area> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<AreaDTO> GetAreas(int idFaena)
        {
            return _mapper.Map<List<AreaDTO>>(_repository.FindAllWhere(x => x.idEmpresa == idFaena && x.estado=="V" && x.areaRestringida=="N"));
        }
    }
}
