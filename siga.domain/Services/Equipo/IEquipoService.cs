using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services.Equipo
{
    public interface IEquipoService
    {
        List<EquipoDTO> GetEquipos(int idArea, int idTipoEquipo);
    }
}
