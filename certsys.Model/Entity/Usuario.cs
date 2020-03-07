using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certsys.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        [Required]
        string Login { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
