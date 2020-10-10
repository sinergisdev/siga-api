using System;
using System.Collections.Generic;
using System.Text;

namespace siga.viewModel
{
    public class AreaDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idEmpresa { get; set; }
        public string estado { get; set; }
        public string areaRestringida { get; set; }
    }
}
