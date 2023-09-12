using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Model
{
    public abstract class Conta
    {
        //criando atributos 
        private int numero;
        private int agencia;
        private int tipo;
        private string titular = "";
        private decimal saldo;

        //Criando método construtor
        public Conta(int numero, int agencia, int tipo, string titular, decimal saldo)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.tipo = tipo;
            this.titular = titular;
            this.saldo = saldo;
        }

        //Criação de métodos, para poder acessar as informações ou fazer as alterações dos dados
        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetAgencia()
        {
            return agencia;
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string titular)
        {
            this.titular = titular;
        }

        public decimal GetSaldo(){
        
            return this.saldo;
        }

        public void SetSaldo(decimal saldo)
        {
            this.saldo = saldo;
        }

        //criando método para saque
        public virtual bool Sacar(decimal valor)
        {
            if(this.saldo < valor){
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.SetSaldo(this.saldo - valor);
            return true;
        }

        //criando um método para depósito
        public void Depositar(decimal valor)
        {
            this.SetSaldo(this.saldo + valor);
        }

        //criando método para vizualizar os dados da conta
        public virtual void Visualizar(){

            string tipo = "";

            switch(this.tipo){

                case 1:
                    tipo = "Conta Corrente";
                    break;
                case 2:
                    tipo = "Conta Poupança";
                    break;

            }

            Console.WriteLine("**************************");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("**************************");
            Console.WriteLine($"Número da conta: {this.numero}");
            Console.WriteLine($"Número da agencia: {this.agencia}");
            Console.WriteLine($"Tipo da conta: {tipo}");
            Console.WriteLine($"Titular da conta: {this.titular}");
            Console.WriteLine($"Saldo da conta: {this.saldo}");
        }
        
    }
}