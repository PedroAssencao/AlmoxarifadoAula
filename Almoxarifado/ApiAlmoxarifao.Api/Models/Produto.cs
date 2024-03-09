using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    [Table("produtos")]
    public partial class Produto
    {
        public Produto()
        {
            ItemRequisicaos = new HashSet<ItemRequisicao>();
        }

        [Key]
        [Column("pro_id")]
        public int ProId { get; set; }
        [Column("pro_nome")]
        [StringLength(255)]
        [Unicode(false)]
        public string? ProNome { get; set; }
        [Column("pro_img")]
        [Unicode(false)]
        public string? ProImg { get; set; }
        [Column("pro_estoque")]
        public int? ProEstoque { get; set; }
        [Column("cat_id")]
        public int? CatId { get; set; }

        [ForeignKey(nameof(CatId))]
        [InverseProperty(nameof(Categoria.Produtos))]
        public virtual Categoria? Cat { get; set; }
        [JsonIgnore]
        [InverseProperty(nameof(ItemRequisicao.Pro))]
        public virtual ICollection<ItemRequisicao> ItemRequisicaos { get; set; }
    }
}
