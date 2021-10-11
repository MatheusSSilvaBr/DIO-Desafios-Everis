using System;

namespace TEDBank

{
  public class Conta : EntidadeBase
  {
    private TipoConta TipoConta { get; set; }

    private string Titular { get; set; }
    
    private double Saldo {get; set; }
    
    public double Credito { get; set; }
    
    private float Numero {get; set; }
    
    public Conta(TipoConta TipoConta, int id, string titular, double saldo, float numero, double credito)
    {
      this.Id = id;
      this.Titular = titular;
      this.Saldo = saldo;
      this.Numero = numero;
      this.Credito = credito;
      this.TipoConta = TipoConta;
    }

    public bool Sacar(double valorSaque)
    {
        if (this.Saldo - valorSaque < (this.Credito * -1))
        {
          Console.WriteLine("Saldo Insuficiente!");
          return false;
        }
        this.saldo -= valorSaque;

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

  }
}
