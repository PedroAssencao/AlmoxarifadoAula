using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    [Table("departamento")]
    public partial class Departamento
    {
        [Key]
        [Column("dep_id")]
        public int DepId { get; set; }
        [Column("dep_descricao")]
        [StringLength(255)]
        [Unicode(false)]
        public string? DepDescricao { get; set; }
        [Column("dep_situacao")]
        public bool? DepSituacao { get; set; }
    }
}
