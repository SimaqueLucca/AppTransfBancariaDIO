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
                        //ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
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

        private static void InserirConta()
        {
            System.Console.Write("Qual o tipo de conta desejado? Digite 1 para Pessoa Fisica ou 2 para Pessoa Juridica: ");
            int inTipoConta = int.Parse(Console.ReadLine());

            System.Console.Write("Insira o nome do Titular da Conta: ");
            string inNome = Console.ReadLine();

            System.Console.Write("Digite o saldo inicial: R$");
            double inSaldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o crédito: R$");
            double inCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)inTipoConta, saldo: inSaldo, credito: inCredito, nome: inNome);

            listContas.Add(novaConta);
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
