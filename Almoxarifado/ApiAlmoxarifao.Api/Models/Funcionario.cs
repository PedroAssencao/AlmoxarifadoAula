using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    public partial class Funcionario
    {
        [Key]
        [Column("fun_id")]
        public int FunId { get; set; }
        [Column("fun_nome")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunNome { get; set; }
        [Column("fun_cargo")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunCargo { get; set; }
        [Column("fun_dataNacimento")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunDataNacimento { get; set; }
        [Column("fun_salario")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunSalario { get; set; }
        [Column("fun_endereco")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunEndereco { get; set; }
        [Column("fun_cidade")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunCidade { get; set; }
        [Column("fun_uf")]
        [StringLength(255)]
        [Unicode(false)]
        public string? FunUf { get; set; }
    }
}
