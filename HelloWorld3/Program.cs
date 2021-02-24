using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMensagem();
            ExibirMensagem();

            GerarPrecoTest(60, "teste");
            GerarPrecoTest(20, "teste2");


            Console.WriteLine("digite o valor e o nome do produto: ");
            GerarPreco(int.Parse(Console.ReadLine()), Console.ReadLine());


            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(10, 20, 30);
            int soma3 = Somar(100, 200, 300);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);


            Console.ReadLine();
        }

        // função: Funciona como uma variável, mas armazena um código podendo tbm conter parametros
        // o parametro não fuciona fora da função colocada
        //void antes do nome - a função nao retorna informação
        static void ExibirMensagem(/*parametro*/)
        {
            Console.WriteLine("top");
            Console.WriteLine("testando função");
            Console.WriteLine("bem-vindo");
            Console.WriteLine(" ");
        }

        static void GerarPrecoTest(int preco, string teste)
        {
            Console.WriteLine("teste");
            Console.WriteLine(preco + " " + teste);
            Console.WriteLine(" ");
        }

        //função para calcular preço
        static void GerarPreco(int preco, string nome)
        {
            int precoAbs = Math.Abs(preco); //Abs converte o numero para modulo (sem sinal, sempre positivo)
            float valorFinal = precoAbs * 2;
            Console.WriteLine("Produto: " + nome);
            Console.WriteLine("O preço final é: " + valorFinal);
            
        }

        // função com retorno - É indicado o tipo antes do nome da função e sempre tem que retorna algo
        static /*tipo de retorno >> */int Somar (int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal; // return = retorna no tipo da função

            //tudo escrito abaixo do retorno é ignorado vvv
        }

    }
}
