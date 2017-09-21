using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public string EstudanteNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public int NivelEnsinoId { get; set; }
        public Endereco Endereco { get; set; }

        public List<NivelEnsino> NivelEnsinos { get; set; }
        public List<Curso> Cursos { get; set; }


        }
    }