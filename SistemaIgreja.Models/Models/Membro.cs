using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIgreja.Models.Models
{
    internal class Membro : Endereco
    {
        [Key]
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Sexo { get; set; }
        public DateTime DataAniversario { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Alteracao { get; set; }
        public bool Ativo { get; set; }

    }
}
