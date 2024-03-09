using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    public partial class MotivoSaidum
    {
        [Key]
        [Column("mot_id")]
        public int MotId { get; set; }
        [Column("mot_descricao")]
        [StringLength(255)]
        [Unicode(false)]
        public string? MotDescricao { get; set; }
        [Column("cat_id")]
        public int? CatId { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(CatId))]
        [InverseProperty(nameof(Categoria.MotivoSaida))]
        public virtual Categoria? Cat { get; set; }
    }
}
