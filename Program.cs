using System;
namespace meuPrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDaNydia = new ContaCorrente ();
            ContaDaNydia.Titular = "Nydia";
            ContaDaNydia.Agencia = 1234;
            ContaDaNydia.Conta = 789;
            ContaDaNydia.Saldo = 100;

            Console.WriteLine("a conta é do (a)" + ContaDaNydia.Titular + "a agência é " + ContaDaNydia.Agencia + " ." );
            ContaCorrente ContaDaMaria = new ContaCorrente ();
            ContaDaMaria.Titular = "Maria";
            ContaDaMaria.Agencia = 4567;
            ContaDaMaria.Conta = 790;
            ContaDaMaria.Saldo = 200;

            Console.WriteLine("a conta é do (a)" + ContaDaMaria.Titular + "a agência é " + ContaDaMaria.Agencia + " ." );
            ContaCorrente ContaDoMarcus = new ContaCorrente ();
            ContaDoMarcus.Titular = "Marcus";
            ContaDoMarcus.Agencia = 0321;
            ContaDoMarcus.Conta = 123;
            ContaDoMarcus.Saldo = 120;

            Console.WriteLine("a conta é do (a)" + ContaDoMarcus.Titular + "a agência é " + ContaDoMarcus.Agencia + " ." );
        }
    }
}