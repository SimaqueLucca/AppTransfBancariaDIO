using System;
using System.Collections.Generic;

namespace TransfBancarias
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ListarContas()
        {
            int i = 0;
            foreach (var item in listContas)
            {

                if (listContas.Count != 0)
                {
                    System.Console.WriteLine($"#{i} - " + item);
                }
                else
                {
                    System.Console.WriteLine("Nenhuma conta cadastrada");
                }
                i++;
            }
        }

        private static void InserirConta()
        {
            System.Console.Write("Qual o tipo de conta desejado? Digite 1 para Pessoa Fisica ou 2 para Pessoa Juridica: ");
            int inTipoConta = int.Parse(Console.ReadLine());

            System.Console.Write("Insira o nome do Titular da Conta: ");
            string inNome = Console.ReadLine();

            System.Console.Write("Digite o saldo inicial: R$");
            double inSaldo = double.Parse(Console.ReadLine());

            System.Console.Write("Digite o crédito: R$");
            double inCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)inTipoConta, saldo: inSaldo, credito: inCredito, nome: inNome);

            listContas.Add(novaConta);
        }

        private static void Transferir()
        {
            System.Console.Write("Informe a conta de origem: ");
            int contaOrigem = int.Parse(Console.ReadLine());

            System.Console.Write("Informe a conta destino: ");
            int contaDestino = int.Parse(Console.ReadLine());

            System.Console.Write("Valor a ser transferido:");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[contaOrigem].Transferir(valorTransferencia, listContas[contaDestino]);
        }

        private static void Sacar()
        {
            System.Console.Write("Informe o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            System.Console.Write("Informe o valor que deseja sacar: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[numeroConta].Sacar(valorSaque: valorSaque);
        }

        private static void Depositar()
        {
            System.Console.Write("Informe o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            System.Console.Write("Insira o valor do deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[numeroConta].Depositar(valorDeposito: valorDeposito);
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.Write("Informe a opção desejada: ");

            System.Console.WriteLine();
            System.Console.WriteLine("1- Listar contas");
            System.Console.WriteLine("2- Inserir nova conta");
            System.Console.WriteLine("3- Transferir");
            System.Console.WriteLine("4- Sacar");
            System.Console.WriteLine("5- Depositar");
            System.Console.WriteLine("C- Limpar tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();

            return opcaoUsuario;
        }



    }
}
