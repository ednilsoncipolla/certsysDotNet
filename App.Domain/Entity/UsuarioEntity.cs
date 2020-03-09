using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entity
{
    [Table("Usuarios")]
    public class UsuarioEntity : BaseEntity
    {
        [Column("Login")]
        [MaxLength(50)]
        [Required]
        public string Login { get; set; }
        [Column("Senha")]
        [MaxLength(20)]
        [Required]
        public string Senha { get; set; }
    }
}
