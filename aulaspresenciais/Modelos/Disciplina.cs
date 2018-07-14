using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Disciplina
    {
        [Key]
        public int idd { get; set; }     
        public string Disciplinad { get; set; }
        public int CargaHoraria { get; set; }
        public string ProfessorD { get; set; }
    }
}
