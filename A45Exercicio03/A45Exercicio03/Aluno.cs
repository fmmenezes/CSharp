using System;
using System.Collections.Generic;
using System.Text;

namespace A45Exercicio03
{
    class Aluno
    {
        public string Nome;
        public double NotaT1, NotaT2, NotaT3;

        public double SomaNota()
        {
            return NotaT1 + NotaT2 + NotaT3;
        }

        public double PontosFaltantes()
        {
            return 60 - SomaNota();
        }

    }
}
