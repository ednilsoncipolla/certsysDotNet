using App.Domain.Dto;
using App.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.Produto
{
    public interface IProdutoService
    {
        ProdutoEntity Get(int id);
        IEnumerable<ProdutoEntity> GetAll();
        ProdutoEntity Post(ProdutoEntity usuario);
        ProdutoEntity Put(ProdutoEntity usuario);
        bool Delete(int id);
        ProdutoDto GetDto(int id);
        IEnumerable<ProdutoDto> GetAllDto();

    }
}
