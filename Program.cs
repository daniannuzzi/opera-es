using System;

namespace QuatroOperacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            /*
            Vamos declarar as sete variáveis, sendo duas para os usuários inserir dados e as outras serão para armazenar os resultados
             */
            
             int numero1, numero2;
             int soma, subtrair, multiplicar, dividir,resto;
            
            //  Pedir ao usuários que entre com o primeiro número
            Console.WriteLine("Digite um número:");

            // Vamos pegar o valor que o usuário digitou e alocar na variável número1

            // Utilizamos o comando int.Parse para passar a captura de texto do console.readline
            // em número mesmo sabendo que o usuário irá digitar um número, o readline sempre lê como texto
    
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");

            numero2 = int.Parse(Console.ReadLine());

            // Abaixo iremos realizar as 5 operações aritméticas

            soma = numero1+numero2; 
            subtrair = numero1-numero2;
            dividir = numero1/numero2;
            multiplicar = numero1*numero2;
            resto = numero1%numero2;
            
             

        }
    }
}
