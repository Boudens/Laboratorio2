using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class Clientes
    {
        public string nomeUsuario { get; set; }
        public string numeroIdentificacao { get;set; }
        public float saldo { get; protected set; }
        public bool tipoConta { get; set; }
 
        //Considerando true para Conta-Corrente e false para Conta-Poupança.

        public void depositar(Clientes cliente, float quantidadeDeposito)
        {
            this.saldo += quantidadeDeposito;
            Console.WriteLine("O deposito de R$ {0} na conta {1} foi realizado com sucesso.", quantidadeDeposito, cliente.numeroIdentificacao);
        }

        public void consultarSaldo(Clientes cliente)
        {
            Console.WriteLine("O saldo da conta {0} é de R$ {1}.", cliente.numeroIdentificacao, cliente.saldo);
        }

        public void sacar(Clientes cliente, float valorSaque)
        {
            if (valorSaque > saldo)
            {
                saldo = saldo;
                Console.WriteLine("Não foi possível realizar o saque, não há saldo suficiente");
            }
            else if (saldo > 0)
            {
                if (cliente.tipoConta == true)
                {

                    this.saldo -= (valorSaque + (valorSaque * 0.0037f));
                }
                else
                {
                    this.saldo -= (valorSaque + (valorSaque * 0.0020f));
                }
                Console.WriteLine("Foi sacado R$ {0} da conta {1}.", valorSaque, cliente.numeroIdentificacao);
            }

        }

        public void transferir(float valor , Clientes destinatario)
        {
            if (valor > this.saldo)
            {
                saldo = saldo;
                Console.WriteLine("Não foi possível realizar a transferência, não há saldo suficiente");
            }
            else if (this.saldo > 0)
            {
                if (this.tipoConta == true)
                {

                    this.saldo -= (valor + (valor * 0.0010f));
                }
                else
                {
                    this.saldo -= (valor + (valor * 0.0015f));
                }
                Console.WriteLine("Foi transferido R$ {0} da conta {1} para a conta {2}.", valor, this.numeroIdentificacao,destinatario.numeroIdentificacao);
                destinatario.saldo += valor;
            }

        }
    }
}
