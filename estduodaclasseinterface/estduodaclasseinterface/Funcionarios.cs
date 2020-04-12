using System;
using System.Collections.Generic;
using System.Text;

namespace estduodaclasseinterface
{
    class Funcionarios : IPessoas
    {
        
        public void CadastrarPessoa()
        {
            Console.WriteLine("Hello World!");
        }

        /*
         toda classe que assina a interface é obrigada a dar uma implementação para essa funcionalidade, se não implementarmos o método da interface, a classe não compilará.

            public class ContaPoupanca : Conta, ITributavel
            {
              // resto da classe aqui

              // método que sou obrigado a implementar
              public double CalculaTributo()
              {
                return this.Saldo * 0.02;
              }
            }

        Repare que, para implementarmos o método da interface, não podemos 
        utilizar a palavra override, ela é reservada para a sobrescrita de métodos da Herança. 
        A mesma coisa para a

         */
    }
}
