using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entity
{
    [Table("Produtos")]
    public class ProdutoEntity : BaseEntity
    {
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Quantidade")]
        public decimal Quantidade { get; set; }
        [Column("FornecedorId")]
        public int FornecedorId { get; set; }
    }
}

