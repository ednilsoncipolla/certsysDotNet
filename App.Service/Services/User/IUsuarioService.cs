using App.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.User
{
    interface IUsuarioService
    {
        UsuarioEntity Get(int id);
        IEnumerable<UsuarioEntity> GetAll();
        UsuarioEntity Post(UsuarioEntity usuario);
        UsuarioEntity Put(UsuarioEntity usuario);
        bool Delete(int id);
        bool Autenticar(UsuarioEntity usuario);
    }
}
