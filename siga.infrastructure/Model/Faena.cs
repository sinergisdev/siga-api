using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace siga.infrastructure.Model
{
    [Table("sca_Proveedor")]
    public class Faena : EntityBase
    {
        [Key]
        [Column("idProveedor")]
        public int id { get; set; }

        [Column("Rut")]
        public string rut { get; set; }

        [Column("NombreFantasia")]
        public string name { get; set; }

        [Column("Tipo")]
        public string type { get; set; }

        [Column("EstadoRegistro")]
        public string estado { get; set; }

    }
}
