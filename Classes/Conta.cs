using system;
namespace Bank.Conta
{
  public class Conta
  {
    private string titular { get; set; };
    
    private double saldo {get; set; };
    
    private float numero {get; set; };
    
    public class Conta(string titular, double saldo, float numero)
    {
      this.Titular = titular;
      this.Saldo = saldo;
      this.Numero = numero;
    }
  }
}
