using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Model
{
    public class ContaCorrente : Conta
    {
        //atributo especifico da conta corrente
        private decimal limite;

        // contrutor
        public ContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo, decimal limite) 
        : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        //GETTER AND SETTERS
        public decimal GetLimite()
        {
            return this.limite;
        }

        public void SetLimite(decimal limite)
        {
            this.limite = limite;
        }

        // POLIMORFIRMO DE SOBRESCRITA do método sacar da classe conta para conta corrente
         public override bool Sacar(decimal valor)
        {
            if(this.GetSaldo()+ this.limite < valor){
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }

        //criando método de sobrescrita do método visualizar acrescentando o atributo "limite"
        public override void Visualizar(){
            base.Visualizar();

            Console.WriteLine($"""
            Limite da conta: {this.limite}
            """);
        }

    
    }
}