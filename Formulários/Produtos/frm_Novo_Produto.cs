using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa_Oficina.Classes;

namespace Programa_Oficina.Formulários.Produtos
{
    public partial class frm_Novo_Produto : Form
    {
        public frm_Novo_Produto()
        {
            InitializeComponent();
            cls_Produto.Unit produto = new cls_Produto.Unit();
            txt_Codigo.Text = produto.GeraCodigo().ToString(); ;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Produto.Unit produto = new cls_Produto.Unit();
                produto.Codigo = txt_Codigo.Text;
                produto.Nome = txt_Nome.Text;
                produto.Referencia = txt_Referencia.Text;
                produto.Marca = cmb_Marca.Text;
                produto.Fornecedor = cmb_Fornecedor.Text;
                string Unidade = cmb_Unidade.Text;
                string Quantidade = txt_Contem.Text.Replace(".", ",");
                if (Unidade == "gramas")
                {
                    float f = float.Parse(Quantidade) / 1000;
                    Quantidade = f.ToString();
                    produto.Quantidade = Quantidade.Replace(",", ".");
                    produto.Unidade = "Kg";
                }
                else if (Unidade == "ml")
                {
                    float f = float.Parse(Quantidade) / 1000;
                    Quantidade = f.ToString();
                    produto.Quantidade = Quantidade.Replace(",", ".");
                    produto.Unidade = "Litro(s)";
                }
                else if (Unidade == "cm")
                {
                    float f = float.Parse(Quantidade) / 100;
                    Quantidade = f.ToString();
                    produto.Quantidade = Quantidade.Replace(",", ".");
                    produto.Unidade = "Metro(s)";
                }
                else
                {
                    produto.Quantidade = Quantidade.Replace(",", ".");
                    produto.Unidade = cmb_Unidade.Text;
                }
                produto.Compra = txt_Compra.Text.Replace(",", ".");
                produto.Venda = txt_Venda.Text.Replace(",", ".");
                produto.Descricao = txt_Descrição.Text;
                produto.ValidaClasse();
                if (produto.ValidaClasse())
                {
                    produto.InsertProduto();
                    MessageBox.Show("Produto Cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Produto.Unit produto = new cls_Produto.Unit();
                produto.Codigo = txt_Codigo.Text;
                produto.Nome = txt_Nome.Text;
                produto.Referencia = txt_Referencia.Text;
                produto.Marca = cmb_Marca.Text;
                produto.Fornecedor = cmb_Fornecedor.Text;
                produto.Unidade = cmb_Unidade.Text;
                produto.Quantidade = txt_Contem.Text.Replace(",", ".");
                produto.Compra = txt_Compra.Text.Replace(",", ".");
                produto.Venda = txt_Venda.Text.Replace(",", ".");
                produto.Descricao = txt_Descrição.Text;
                produto.ValidaClasse();
                if (produto.ValidaClasse())
                {
                    produto.InsertProduto();
                    MessageBox.Show("Produto Cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
