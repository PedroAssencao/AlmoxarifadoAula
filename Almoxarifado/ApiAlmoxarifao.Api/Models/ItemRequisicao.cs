using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    [Table("ItemRequisicao")]
    public partial class ItemRequisicao
    {
        [Key]
        [Column("item_id")]
        public int ItemId { get; set; }
        [Column("item_preco", TypeName = "decimal(10, 2)")]
        public decimal? ItemPreco { get; set; }
        [Column("item_quantidade")]
        public int? ItemQuantidade { get; set; }
        [Column("req_id")]
        public int? ReqId { get; set; }
        [Column("pro_id")]
        public int? ProId { get; set; }

        [ForeignKey(nameof(ProId))]
        [InverseProperty(nameof(Produto.ItemRequisicaos))]
        public virtual Produto? Pro { get; set; }
        [ForeignKey(nameof(ReqId))]
        [InverseProperty(nameof(Requisicao.ItemRequisicaos))]
        public virtual Requisicao? Req { get; set; }
    }
}
