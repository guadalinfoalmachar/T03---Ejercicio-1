namespace T03_Eje1
{
    class T03_Eje1
    {
        static void Main()
        {
            int Valor1 = 580;
            int Valor2 = 7;

            Console.WriteLine("{0} + {1} = {2}", Valor1, Valor2, Valor1 + Valor2);
            Console.WriteLine("{0} - {1} = {2}", Valor1, Valor2, Valor1 - Valor2);
            Console.WriteLine("{0} * {1} = {2}", Valor1, Valor2, Valor1 * Valor2);
            Console.WriteLine("{0} / {1} = {2}", Valor1, Valor2, Valor1 / Valor2);
            Console.WriteLine("Resto de {0} / {1} = {2}", Valor1, Valor2, Valor1 % Valor2);

            Console.WriteLine("Presiene cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}