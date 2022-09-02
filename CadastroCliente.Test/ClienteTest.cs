using CadastroClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CadastroCliente.Test
{
    public class ClienteTest
    {
        [Fact]
        public void Idade_VinteAnosDepois__RetornaVinte()
        {
            //Arramge
            Cliente cliente = new Cliente("Jose da Silva", DateTime.Now.AddYears(-20), "joaozinho@gmail.com");

            //Act
            var idade = cliente.Idade();

            //Assert
            Assert.Equal(20, idade);
        }

        [Fact]
        public void Idade_VinteAnosDepoisEumDia__RetornaVinteAnos()
        {
            //Arramge
            Cliente cliente = new Cliente("Jose da Silva", DateTime.Now.AddYears(-20).AddDays(-1), "joaozinho@gmail.com");

            //Act
            var idade = cliente.Idade();

            //Assert
            Assert.Equal(20, idade);
        }
        [Fact]
        public void Idade_VinteAnosDepoisMenosUmDia_RetornaDezenove()
        {
            //Arramge
            Cliente cliente = new Cliente("Jose da Silva", DateTime.Now.AddYears(-20).AddDays(+1), "joaozinho@gmail.com");

            //Act
            var idade = cliente.Idade();

            //Assert
            Assert.Equal(19, idade);
        }

        [Theory]
        [InlineData("Joao", "2010-05-14", "Joao@gmail.com")]
        [InlineData("", "2010-05-14", "Joao@gmail.com")]
        [InlineData("Joao", null, "Joao@gmail.com")]
        [InlineData("Joao", "2010-05-14", "")]
        public void AtualizaDados_AlteraNomeEmailNascimento_RetornaAlterada(string nome,DateTime nascimento, string email)
        {
            //Arrange
            Cliente cliente = new Cliente("Jose da Silva",new DateTime(2000,06,15), "joaozinho@gmail.com");

            //Act
            cliente.AtualizaDados(nome,nascimento,email);

            //Assert
            Assert.Equal(cliente.Nome, nome);
            Assert.Equal(cliente.Nascimento, nascimento);
            Assert.Equal(cliente.Email, email);
        }
    }
}
