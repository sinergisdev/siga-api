using siga.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.domain.Services.Faena
{
    public interface IFaenaService
    {
        List<FaenaDTO> GetFaenas();
    }
}
