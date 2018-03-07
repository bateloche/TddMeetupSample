using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddMeetup
{
    public class ConversorRomano
    {
        private Dictionary<char, int> _algarismos =
            new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 }
            };

        public int Converte(string romano)
        {
            var tamanho = romano.Length;

            var anterior = _algarismos[romano.Last()];
            var valor = anterior;

            for (var i = tamanho - 2; i >= 0; i--)
            {
                var caractereAtual = romano[i];
                var valorAtual = _algarismos[caractereAtual];
                var multiplicador = valorAtual >= anterior ? 1 : -1;
                valor += valorAtual * multiplicador;
                anterior = valorAtual;
            }

            return valor;
        }
    }
}
