using App.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString)
        {

        }

        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<ProdutoEntity> Produtos { get; set; }
        public DbSet<FornecedorEntity> Fonecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
