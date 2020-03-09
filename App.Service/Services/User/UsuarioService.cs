using App.Data.Repository;
using App.Domain.Entity;
using App.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.User
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<UsuarioEntity> _repository;
        public UsuarioService()
        {
            _repository = new BaseRepository<UsuarioEntity>();
        }

        public bool Autenticar(UsuarioEntity usuario)
        {
            return _repository.Select().Where(u => u.Login == usuario.Login && u.Senha == usuario.Senha).FirstOrDefault() != null;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public UsuarioEntity Get(int id)
        {
            return _repository.Select(id);
        }

        public IEnumerable<UsuarioEntity> GetAll()
        {
            return _repository.Select();
        }

        public UsuarioEntity Post(UsuarioEntity usuario)
        {
            return _repository.Insert(usuario);
        }

        public UsuarioEntity Put(UsuarioEntity usuario)
        {
            return _repository.Update(usuario);
        }
    }
}
