using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entity
{
    [Table("Fornecedores")]
    public class FornecedorEntity: BaseEntity
    {
        [Column("Nome")]
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(20)]
        [Column("Cnpj")]
        [Required]
        public string Cnpj { get; set; }
        [MaxLength(150)]
        [Column("Endereco")]
        [Required]
        public string Endereco { get; set; }
    }
}
