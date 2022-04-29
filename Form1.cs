using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList formaPagto = new ArrayList();
            formaPagto.Add(new FormaDePagto(1, "Selecione a opção"));
            formaPagto.Add(new FormaDePagto(2, "Dinheiro"));
            formaPagto.Add(new FormaDePagto(3, "Cartão"));
            formaPagto.Add(new FormaDePagto(4, "Boleto"));
            formaPagto.Add(new FormaDePagto(5, "Pix"));

            cb_pagamento.DataSource = formaPagto;
            cb_pagamento.DisplayMember = "Descrição";
            cb_pagamento.ValueMember = "Descricao";
        }

        public class FormaDePagto
        {
            public int ID { get; set; }
            public string Descricao { get; set; }
            public FormaDePagto(int id, string descricao)
            {
                this.ID = id;
                this.Descricao = descricao;
            }
        }

        private void cb_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolha = cb_pagamento.SelectedIndex;
            switch (escolha)
            {
                case 0:
                    lb_res.Text = "Selecione a opção";
                    break;
                case 1:
                    lb_res.Text = "Dinheiro";
                    break;
                case 2:
                    lb_res.Text = "Cartão";
                    lb_parcela.Visible = true;
                    txt_parcela.Visible = true;
                    button1.Visible = true;
                    break;
                case 3:
                    lb_res.Text = "Boleto";
                    break;
                case 4:
                    lb_res.Text = "Pix";
                    break;
            }
            if(escolha == 1 || escolha == 3 || escolha == 4)
            {
                lb_valor.Text = "R$ " + txt_valor.Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor = Decimal.Parse(txt_valor.Text);
            try
            {
                decimal qtdParcela = Decimal.Parse(txt_parcela.Text);
                decimal totalParcela = valor / qtdParcela;
                lb_valor.Text = txt_parcela.Text + " Parcelas de: R$ " + totalParcela.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Parcela ou Valor invalido!");
                txt_parcela.Focus();
            }    
        }
    }
}
