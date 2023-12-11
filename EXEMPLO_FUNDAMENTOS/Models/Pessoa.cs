using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Classes, propiedades e métodos seguem a PascalCase >
// 1° palavra > começa com maiúscula,
// 2° palavra e adiante > começa com maiúscula também.
//Classes = Objetos e Métodos = Funções.

//Outra convenção para a escrita de variáveis, propiedades e classes,
//é nunca usar abreviações.

//Outra convenção para o nome de classes é de que
//o nome do arquivo que armazena a classe, ser igual ao da classe.

//Uma outra convenção sobre o nome de Classes propiedades e váriaveis,
//é de não por nenhum caractere especial, com excessão ao _.


namespace EXEMPLO_FUNDAMENTOS.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public int Idade { get; set; }
        public required string Email { get; set; }
        public DateTime DataDeNascimento {get; set; }

        public void Apresentar()
        {
          Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
          //Console.WriteLine($"Olá, meu nome é {Nome}," + 
          //$"\n e tenho {Idade} anos.");  
        }

        public void InformarEmail()
        {
          Console.WriteLine($"Meu e-mail é {Email}.");
        }
        
    }
}