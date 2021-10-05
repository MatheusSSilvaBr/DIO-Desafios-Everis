using system;
namespace Bank.Conta
{
  public class Conta : EntidadeBase
  {
    private string titular { get; set; };
    
    private double saldo {get; set; };
    
    private float numero {get; set; };
    
    public class Conta(int id, string titular, double saldo, float numero)
    {
      this.Id = id;
      this.Titular = titular;
      this.Saldo = saldo;
      this.Numero = numero;
    }
  }
}
