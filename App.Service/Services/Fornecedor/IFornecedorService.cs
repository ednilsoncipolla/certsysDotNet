using App.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.Fornecedor
{
    public interface IFornecedorService
    {
        FornecedorEntity Get(int id);
        IEnumerable<FornecedorEntity> GetAll();
        FornecedorEntity Post(FornecedorEntity usuario);
        FornecedorEntity Put(FornecedorEntity usuario);
        bool Delete(int id);
    }
}
