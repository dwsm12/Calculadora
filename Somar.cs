namespace Calculadora
{

    public class Somar
    {

        public static void Soma()
        {
            float v1 = 0;
            float v2 = 0;
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);

            Console.ReadKey();
            Menu.Men1();


        }
    }


}