using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TddMeetup
{
    public class ConversorRomanoTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        public void Deve_Entender_Um_Numero_De_Um_Algarismo(string romano, int esperado)
        {
            var conversorRomano = new ConversorRomano();

            var resultado = conversorRomano.Converte(romano);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData("II", 2)]
        [InlineData("VI", 6)]
        [InlineData("XI", 11)]
        [InlineData("XII", 12)]
        [InlineData("VIII", 8)]
        [InlineData("XVI", 16)]
        public void Deve_Entender_Um_Numero_De_Dois_Ou_Mais_Algarismos(string romano, int esperado)
        {
            var conversorRomano = new ConversorRomano();

            var resultado = conversorRomano.Converte(romano);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XIV", 14)]
        public void Deve_Subtrair_Algarismos_Menores_A_Direita(string romano, int esperado)
        {
            var conversorRomano = new ConversorRomano();

            var resultado = conversorRomano.Converte(romano);

            Assert.Equal(esperado, resultado);
        }
    }
}
