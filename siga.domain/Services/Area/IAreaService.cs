using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services.Area
{
    public interface IAreaService
    {

        List<AreaDTO> GetAreas(int idFaena);
    }
}
