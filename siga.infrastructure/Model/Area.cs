using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace siga.infrastructure.Model
{
    [Table("sca_Area")]
    public class Area: EntityBase
    {
        [Column("idArea")]
        public int id { get; set; }
        [Column("Descripcion")]
        public string name { get; set; }
        [Column("IdEmpresa")]
        public int idEmpresa { get; set; }
        [Column("EstadoRegistro")]
        public string estado { get; set; }
        [Column("AreaRestringida")]
        public string areaRestringida { get; set; }
    }
}
