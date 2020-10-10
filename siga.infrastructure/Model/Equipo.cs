using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace siga.infrastructure.Model
{
    [Table("sca_Equipo")]
    public class Equipo:EntityBase
    {
       

        
        [Key]
        [Column("IdEquipo")]
        public int id { get; set; }

        [Column("idArea")]
        public int idArea { get; set; }

        [Column("Nombre")]
        public string name { get; set; }

        [Column("Ip")]
        public string ip { get; set; }

        [Column("EstadoRegistro")]
        public string estado { get; set; }

        [Column("idTipoEquipo")]
        public int idTipoEquipo { get; set; }

    }
}
