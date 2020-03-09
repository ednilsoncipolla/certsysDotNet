using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Dto
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Quantidade { get; set; }
        public int FornecedorId { get; set; }
        public string FornecedorNome { get; set; }
    }
}
