using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    [Table("TB_MESSAGE")]
    public class Message : Notifies
    {
        [Column("MSN_ID")]
        public int Id { get; set; }

        [Column("MSN_TITULO")]
        [MaxLength(255)]
        public string Titulo { get; set; }

        [Column("MSN_ATIVO")]
        public bool Ativo { get; set; }

        [Column("MSN_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("MSN_DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]

        public string UserI { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
