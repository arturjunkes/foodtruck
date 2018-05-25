﻿using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaManterCliente : Form
    {
        public Cliente ClienteSelecionado { get; set; }

        public TelaManterCliente()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if(Int64.TryParse(tbId.Text, out long value))
            {
                cliente.Id = value;
            }
            else
            {
                cliente.Id = -1;
                //passa indentificador com valor negativo se não conseguir converter
            }
            cliente.CPF = tbCpf.Text;
            cliente.Nome = tbNome.Text;
            cliente.Email = tbEmail.Text;

            Validacao validacao;
            if (ClienteSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarCliente(cliente);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarCliente(cliente);
            }
            

            
            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Cliente salvo com sucesso");
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterCliente_Shown(object sender, EventArgs e)
        {
            if(ClienteSelecionado != null)
            {
                this.tbId.Text = ClienteSelecionado.Id.ToString();
                this.tbNome.Text = ClienteSelecionado.Nome;
                this.tbCpf.Text = ClienteSelecionado.CPF;
                this.tbEmail.Text = ClienteSelecionado.Email;
            }
        }

        private void TelaManterCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
