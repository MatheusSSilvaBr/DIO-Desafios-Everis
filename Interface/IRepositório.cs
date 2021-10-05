using System;

namespace Bank.Conta.Interface
{
  public interface IRepositorio<T>
  {
    void Insere(T entidade);
    
    void Exclui(int id);
    
    void Atualiza(int id, T entidade);
    
    
  }
}
