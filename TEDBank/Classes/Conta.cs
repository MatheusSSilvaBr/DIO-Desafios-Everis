using System;

namespace TEDBank

{
  public class Conta
  {
    private TipoConta TipoConta { get; set; }

    private string Titular { get; set; }
    
    private double Saldo {get; set; }
    
    public double Credito { get; set; }   
    
    public Conta(TipoConta tipoconta, string titular, double saldo, double credito)
    {
      this.Titular = titular;
      this.Saldo = saldo;
      this.Credito = credito;
      this.TipoConta = tipoconta;
    }

    public bool Sacar(double valorSaque)
    {
        if (this.Saldo - valorSaque < (this.Credito * -1))
        {
          Console.WriteLine("Saldo Insuficiente!");
          return false;
        }
        this.Saldo -= valorSaque;

        Console.WriteLine("O saldo atual de sua conta {0} é {1}.", this.Titular, this.Saldo);
        return true;

    }

    public void Depositar(double valorDeposito)
    {
      this.Saldo += valorDeposito;
      
      Console.WriteLine("O saldo atual de sua conta {0} é {1}.", this.Titular, this.Saldo);
    }

    public void Transferir(double valorTransferencia, Conta contaDestino)
    {
      if(this.Sacar(valorTransferencia))
      {
        contaDestino.Depositar(valorTransferencia);
      }
      Console.WriteLine("Seu saldo é insuficiente");
    }

    public override string ToString()
        {
            string retorno = "";
            retorno += "Titular: " + this.Titular + " | "; 
            retorno += "TipoConta: " + this.TipoConta + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito;
            return retorno;
        }
  }
}
