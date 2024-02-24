namespace Calculadora
{
    public class EscolhaDoOperador
    {
        public static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("Qual operador deseja utilizar?");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtracao");
            System.Console.WriteLine("3 - Multiplicacao");
            System.Console.WriteLine("4 - Divisao");

            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("Seleciona sua opcao: ");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma.Somar(); break;
                case 2: Subtracao.Subtrair(); break;
                case 3: Multiplicacao.Multiplicar(); break;
                case 4: Divisao.Dividir(); break;
                default: Menu(); break;

            }

        }
    }
}