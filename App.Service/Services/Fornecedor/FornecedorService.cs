using App.Data.Repository;
using App.Domain.Entity;
using App.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.Fornecedor
{
    public class FornecedorService : IFornecedorService
    {
        private IRepository<FornecedorEntity> _repository;
        public FornecedorService()
        {
            _repository = new BaseRepository<FornecedorEntity>();
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public FornecedorEntity Get(int id)
        {
            if (id == 0)
                return new FornecedorEntity();

            return _repository.Select(id);
        }

        public IEnumerable<FornecedorEntity> GetAll()
        {
            return _repository.Select();
        }

        public FornecedorEntity Post(FornecedorEntity usuario)
        {
            return _repository.Insert(usuario);
        }

        public FornecedorEntity Put(FornecedorEntity usuario)
        {
            return _repository.Update(usuario);
        }
    }
}
