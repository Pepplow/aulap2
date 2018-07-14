using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Modelos
{
    public class Professor
    {
        [Key]
        public int IDProfessor { get; set; }
        public string nomep { get; set; }
        public string cpf { get; set; }
        public int matriculap { get; set; }

    }
}
