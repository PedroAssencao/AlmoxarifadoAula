using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    [Table("categorias")]
    public partial class Categoria
    {
        public Categoria()
        {
            MotivoSaida = new HashSet<MotivoSaidum>();
            Produtos = new HashSet<Produto>();
        }

        [Key]
        [Column("cat_id")]
        public int CatId { get; set; }
        [Column("cat_descricao")]
        [StringLength(255)]
        [Unicode(false)]
        public string? CatDescricao { get; set; }

        [JsonIgnore]
        [InverseProperty(nameof(MotivoSaidum.Cat))]
        public virtual ICollection<MotivoSaidum> MotivoSaida { get; set; }
        [JsonIgnore]
        [InverseProperty(nameof(Produto.Cat))]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
