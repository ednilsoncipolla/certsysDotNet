using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certisys.Dados
{
    class Conexao : DbContext
    {
        public Conexao() : base(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString)
        {
                
        }
    }
}
