namespace Conta_Corrente_ConsoleApp1
{
    class CriarConta
    {
            public static int numeroId = 1000;
            public int numeroConta = numeroId++;
            public double saldo = 0;
            public int limiteDebito = 0;
            public string[] extrato = new string[10];
            public int contadorExtrato = 0;
    }
}
