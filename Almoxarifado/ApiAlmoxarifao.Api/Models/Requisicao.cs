using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    [Table("requisicao")]
    public partial class Requisicao
    {
        public Requisicao()
        {
            ItemRequisicaos = new HashSet<ItemRequisicao>();
        }

        [Key]
        [Column("req_id")]
        public int ReqId { get; set; }
        [Column("req_date", TypeName = "datetime")]
        public DateTime? ReqDate { get; set; }

        [InverseProperty(nameof(ItemRequisicao.Req))]
        public virtual ICollection<ItemRequisicao> ItemRequisicaos { get; set; }
    }
}
