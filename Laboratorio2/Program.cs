using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Considerando true para Conta-Corrente e false para Conta-Poupança.

            Clientes Bob = new Clientes();
            Bob.nomeUsuario = "Bob Nelson";
            Bob.numeroIdentificacao = "12345-6";
            Bob.tipoConta = true;


            Clientes Testolfo = new Clientes();
            Testolfo.nomeUsuario = "Testolfo Rocha";
            Testolfo.numeroIdentificacao = "71717-1";
            Testolfo.tipoConta = false;

            Clientes Lisa = new Clientes();
            Lisa.nomeUsuario = "Lisa Leite";
            Lisa.numeroIdentificacao = "65432-1";
            Lisa.tipoConta = true;

            //Depositos
            Bob.depositar(Bob, 5000);
            Testolfo.depositar(Testolfo, 1500);
            Lisa.depositar(Lisa, 2000);
            //Transferência de Bob para Testolfo
            Bob.transferir(600,Testolfo);
            //Saque Lisa
            Lisa.sacar(Lisa, 250);
            //Transferência de Lisa para Testolfo
            Lisa.transferir(400, Testolfo);
            //Transferência Testolfo para Bob
            Testolfo.transferir(1000, Bob);
            //Saque Bob
            Bob.sacar(Bob, 900);
            //Transferência de Bob para Lisa
            Bob.transferir(1500,Lisa);
            //Transferência de Testolfo para Lisa
            Testolfo.transferir(1200, Lisa);
            //Saque Bob
            Bob.sacar(Bob, 2000);
            //Deposito Lisa
            Lisa.depositar(Lisa, 100);
            //Transferência Testolfo para Bob
            Testolfo.transferir(700, Bob);


            Console.WriteLine("SALDOS FINAIS:");
            Bob.consultarSaldo(Bob);
            Testolfo.consultarSaldo(Testolfo);
            Lisa.consultarSaldo(Lisa);

            Console.ReadLine();
        }
    }
}
