using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace siga.infrastructure.Model
{
    [Table("TB_MAE_Usuario")]
    public class Usuario : EntityBase
    {
        [Key]
        [Column("USUA_ENTI_CODIGO")]
        public int userID { get; set; }

        [Column("USUA_NOMBRECOMPLETO")]
        public string name { get; set; }

        [Column("USUA_NOMBREUSUARIO")]
        public string userName { get; set; }
    }
}
