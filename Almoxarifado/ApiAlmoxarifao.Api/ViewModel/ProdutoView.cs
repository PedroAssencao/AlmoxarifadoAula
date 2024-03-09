using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    public partial class ProdutoView
    {
        public int ProId { get; set; }
        public string? ProNome { get; set; }
        public IFormFile? ProImg { get; set; }
        public int? ProEstoque { get; set; }
        public int? CatId { get; set; }
        [JsonIgnore]
        public virtual Categoria? Cat { get; set; } 

    }
}
