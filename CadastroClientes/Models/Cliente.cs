using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
    public class Cliente
    {   //no caso essa parte, é aonde definimos o mínimo para instanciar um objeto
        //no caso o construtor
        public Cliente(string nome, DateTime nascimento, string email)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

        public int Id { get; private set; }
        [Required(ErrorMessage ="Nome é obrigatório !!!")]
        public string Nome { get; private set; }
        [Required(ErrorMessage ="Nascimento é obrigatório")]
        public DateTime Nascimento { get; private set; }
        public string Email { get; private set; }


        //método para fazer o calculo da idade do usuário e retornar essa data
        //e fazendo a conta para validar os dias com base na mudança dos anos
        public int Idade()
        {
            int idade = DateTime.Now.Year - Nascimento.Year;

            if (DateTime.Now.DayOfYear < Nascimento.DayOfYear)
            {
                idade--;
            }

            return (idade);

        }

        //nesse método é para atualizar os dados do objeto
        //mantendo o padrão do construtor
        public void AtualizaDados(string nome, DateTime nascimento, string email)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

    }

}
