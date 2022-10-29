namespace Calculadora
{

    public class Menu
    {
        public static void Men1()
        {
            Console.Clear();

            Console.WriteLine("o que deseja calcula? Selecione abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Somar.Soma(); break;
                case 2: Subtrair.Subtracao(); break;
                case 3: Dividir.Divisao(); break;
                case 4: Multiplicar.Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Men1(); break;
            }


        }
    }
}