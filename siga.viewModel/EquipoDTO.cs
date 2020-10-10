using System;
using System.Collections.Generic;
using System.Text;

namespace siga.viewModel
{
    public class EquipoDTO
    {
        public int id { get; set; }
        public int idArea { get; set; }
        public string name { get; set; }
        public string ip { get; set; }
        public string estado { get; set; }
        public int idTipoEquipo { get; set; }
    }
}
