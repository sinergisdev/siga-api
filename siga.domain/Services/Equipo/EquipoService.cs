using AutoMapper;
using siga.infrastructure.Repository;
using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services.Equipo
{
    public class EquipoService : IEquipoService
    {

        private readonly IGenericRepository<siga.infrastructure.Model.Equipo> _repository;
        private readonly IMapper _mapper;

        public EquipoService(IGenericRepository<siga.infrastructure.Model.Equipo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<EquipoDTO> GetEquipos(int idArea, int idTipoEquipo)
        {
            return _mapper.Map<List<EquipoDTO>>(_repository.FindAllWhere(x => x.idArea == idArea && x.idTipoEquipo == idTipoEquipo));
        }
    }
}
