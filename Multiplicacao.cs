

namespace Calculadora
{
    public class Multiplicacao
    {
        public static void Multiplicar()
        {
            Console.Clear();

            System.Console.WriteLine("Multiplicacao de dois valores");

            System.Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            var resultado = v1 * v2;
            System.Console.WriteLine($"O resultado da Multiplicacao e {resultado}");
            System.Console.WriteLine("Deseja fazer mais alguma operacao? s/n");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            if (resposta == 's')
            {
                EscolhaDoOperador.Menu();
            }
            else
            {
                System.Console.WriteLine("Muito obrigado por usar nossos servicos");
                System.Environment.Exit(0);

            }

        }
    }
}