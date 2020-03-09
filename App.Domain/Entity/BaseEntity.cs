using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entity
{
    public class BaseEntity
    {
        [Key]
        [Column("Id")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        private DateTime? _createdAt;

        [Column("CreatedAt")]
        [Required]
        public DateTime? CreatedAt {
            get { return _createdAt; }
            set { _createdAt = (value == null ? DateTime.UtcNow : value); } 
        }

        [Column("UpdateAt")]
        public DateTime? UpdateAt { get; set; }

        private bool _ativo = true;

        [Column("Ativo")]
        [Required]
        public bool Ativo { get { return _ativo; } set { _ativo = value; } }
    }
}
