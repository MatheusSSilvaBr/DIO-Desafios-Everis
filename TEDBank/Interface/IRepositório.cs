using System;

namespace TEDBank.Interface
{
  public interface IRepositorio<T>
  {
    void Insere(T entidade);
    
    void Exclui(int id);
    
    void Atualiza(int id, T entidade);

    void Sacar(double valorSaque);
  }
}
