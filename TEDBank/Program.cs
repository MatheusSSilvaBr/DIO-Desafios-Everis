using System;
using System.Collections.Generic;

namespace TEDBank
{
    class Program
    {
        public static List<Conta> listaConta = new List<Conta>();

        static void Main(string[] args)
        {
             string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Sacar();
                        break;
                    case "2":
                        Depositar();
                        break;
                    case "3":
                         Transferir();
                        break;
                    case "4":
                         ListarContas();
                        break;
                    case "5":
                         InserirConta();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                 opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

         private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao TB - TEDBank!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Sacar");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Listar contas");
            Console.WriteLine("5- Inserir nova conta");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Conta");

            if (listaConta.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta cadastrada.");
                return;
            }

            for (int i = 0; i < listaConta.Count; i++)
            {
                Conta conta = listaConta[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }


         private static void InserirConta()
        {
            Console.WriteLine("Inserir uma nova Conta");
            
            foreach (int i in Enum.GetValues(typeof(TipoConta)))     
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(TipoConta), i));
            }
            Console.WriteLine("Digite o Tipo de Conta entre as opções acima: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular da conta: ");
            string entradaTitular = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial da conta: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito da conta: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta (tipoconta: (TipoConta)entradaTipoConta,
                                         titular: entradaTitular,
                                         saldo: entradaSaldo,
                                         credito: entradaCredito);  

            listaConta.Add(novaConta);            
        }

        public static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do saque");
            double valorSaque = double.Parse(Console.ReadLine());

            listaConta[indiceConta].Sacar(valorSaque);
        }

        public static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Deposito");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaConta[indiceConta].Depositar(valorDeposito);
        }

        public static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do Destinatário: ");
            int indiceContaDestinatario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da Transferencia");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaConta[indiceConta].Transferir(valorTransferencia, listaConta[indiceContaDestinatario]);
        }
    }
}
