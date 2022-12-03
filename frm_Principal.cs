using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa_Oficina.Formulários.Carros;
using Programa_Oficina.Formulários.Clientes;
using Programa_Oficina.Formulários.Funcionario;
using Programa_Oficina.Formulários.Produtos;
using Programa_Oficina.Formulários.Estoque;
using Programa_Oficina.Formulários.Serviços;
using Programa_Oficina.Formulários.Ordem_de_Serviço;

namespace Programa_Oficina
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Novo_Carro novo_Carro = new frm_Novo_Carro();
            novo_Carro.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Novo_Cliente novo_Cliente = new frm_Novo_Cliente();
            novo_Cliente.ShowDialog(); 
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Nova_OS os = new frm_Nova_OS();
            os.ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes clientes = new frm_Clientes();
            clientes.ShowDialog();
        }

        private void btn_Carro_Click(object sender, EventArgs e)
        {
            frm_Carros carros = new frm_Carros();   
            carros.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Novo_Funcionario funcionario = new frm_Novo_Funcionario();
            funcionario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Funcionarios func = new frm_Funcionarios();
            func.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Novo_Produto produto = new frm_Novo_Produto();
            produto.ShowDialog();
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            frm_Produtos produtos = new frm_Produtos();
            produtos.ShowDialog();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            frm_Estoque estoque = new frm_Estoque();
            estoque.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Novo_Servico novo = new frm_Novo_Servico();
            novo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Servicos servicos = new frm_Servicos();
            servicos.ShowDialog();
        }
    }
}
