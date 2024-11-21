using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
    {
        [Key]
        public int LivroReservaID { get; set; }

        [ForeignKey ("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey ("Livro")]
        public int LivroID { get; set; }
        public Livro Livro { get; set; }

        public DateOnly DtReserva { get; set; }
    }
}