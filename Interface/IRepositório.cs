using System;

namespace Bank.Conta.Interface
{
  public interface IRepositorio<T>
  {
    void insere(T entidade);
    
    
  }
}
