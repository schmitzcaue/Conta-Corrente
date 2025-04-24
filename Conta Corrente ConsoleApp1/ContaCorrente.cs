
namespace Conta_Corrente_ConsoleApp1
{
    public class ContaCorrente
    {
        //atributos
        public int numero;
        public decimal saldo;
        public decimal limite;

        //metodos

        public void Sacar(decimal quantia)
        {
            if (quantia <= saldo + limite)
            {
                saldo -= quantia;
            }
        }
        public void Depositar(decimal quantia)
        {
            saldo += quantia;
        }

        public void TransferirPara(ContaCorrente destinatario, decimal quantia)
        {
            destinatario.Depositar(quantia);

            this.Sacar(quantia);
        }
    }
    }
    
    

