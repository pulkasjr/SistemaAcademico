using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string  CursoNome { get; set; }
        public int ProfessorId { get; set; }

        public Professor Professores { get; set; }

    }
}