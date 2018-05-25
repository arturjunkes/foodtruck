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
    public partial class TelaListaPedidos : Form
    {
        public TelaListaPedidos()
        {
            InitializeComponent();
        }
        private void AbreTelaInclusaoAlteracao(Pedido pedidoSelecionado)
        {
            TelaManterPedido tela = new TelaManterPedido();
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }
        private bool VerificarSelecao()
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.TodosOsClientes();
            dgPedidos.DataSource = clientes;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPedido(pedidoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Pedido removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o pedido");
                    }
                    CarregarPedidos();
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(pedidoSelecionado);
            }
        }
    }
}
