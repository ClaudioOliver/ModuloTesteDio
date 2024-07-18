using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERotornar3()
        {
            //Arrenge
            string texto = "Ola";

            //Act
            int resuldado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resuldado);
        }
    }
}