﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numeroDaConta = 1;
            double saldo = 250;
            double valorDoSaque = 300;
            double valorAposSaque = saldo - valorDoSaque;
            bool podeSacar = (valorDoSaque <= saldo) && (valorDoSaque > 0);

            if (podeSacar)
            {
                saldo = saldo - valorDoSaque;
                MessageBox.Show("Saque realizado com sucesso! Seu saldo é: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade1 = 13;
            int idade2 = 56;
            int idade3 = 47;
            double media = (idade1 + idade2 + idade3) / 3;

            MessageBox.Show("Média de idades: " + media);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 240;
            int c = 9;

            double a1;
            double a2;
            double delta;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("A1 = " + a1, "A2 = " + a2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000.0;
            int i = 1;

            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }

            //utilizando o "for"
            /* 
            for (int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            */
            MessageBox.Show("Valor investido agora é: " + valorInvestido);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i ++)
            {
               
                soma += i;
                
            }
            MessageBox.Show("A soma dos números de 1 até 1000 é: " + soma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show(" Múltiplo de 3: " + i);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fibonaci = "";
            int anterior = 0;
            int atual = 1;
            

            while (atual <= 100)
            {
                fibonaci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
     
            }

            MessageBox.Show("Valores: " + fibonaci);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Pablo";
            umaConta.saldo = 2000.0;

            MessageBox.Show("Titular conta 1 :" + umaConta.titular);

            Conta outraConta = new Conta();
            outraConta.cpf = "01904359175";
            outraConta.agencia = 123;

            MessageBox.Show("Agencia Conta 2 :" + outraConta.agencia);
        }
    }
}
