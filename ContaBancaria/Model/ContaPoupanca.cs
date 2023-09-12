using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Model
{
    public class ContaPoupanca : Conta
    {
        //atributos
        private int aniversario;

        //Construtor
        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario) 
        : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        //GETTERS AND SETTERS
        public int getAniversatio()
        {
            return this.aniversario;
        }

        public void setAniversatio(int aniversatio)
        {
            this.aniversario = aniversatio;
        }

        //MÉTODO SOBRESCRITO VISUALIZAR
        public override void Visualizar(){
            base.Visualizar();

            Console.WriteLine($"""
            Aniversario da conta: {this.aniversario}
            """);
        }

        
    }
}