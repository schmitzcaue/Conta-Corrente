namespace Conta_Corrente_ConsoleApp1
{
    public class Operacoes
    {
        public static string Depositar(CriarConta conta, double valor)
        {
            if (valor < conta.limiteDebito)
            {
                Console.WriteLine();
            }
        }
    }
}
