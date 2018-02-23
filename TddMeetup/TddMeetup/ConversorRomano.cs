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
            var valor = 0;

            var anterior = romano[0];

            for (var i = 1; i < romano.Length; i++)
            {
                var atual = romano[i];

            }

            foreach (var algarismo in romano)
            {
                valor += _algarismos[algarismo];
            }

            return valor;
        }
    }
}
