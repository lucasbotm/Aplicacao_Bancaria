using System;

namespace aplicacao_bancaria

{
    public class Conta
    {
        private TipoConta TipoConta {get; set;}

        private double Saldo {get; set;}
        
        private double Credito {get; set;}

        private string Nome {get; set;}

        /// Construtor:

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)

        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        /// Métodos:
        public bool Sacar(double valorSaque)
        {
            // Validacao do saldo

            if (this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine("O Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual de {0} é {1}",this.Nome,this.Saldo);
        }
        public void Transferir (double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }

        // Ao utilizar o writeLine ele chama o método tostring. a funcao abaixo override esse método para modificar o string escrito.
        
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito + " | ";
            return retorno;
        }
    }
}