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
    public partial class frm_Ficha_Produto : Form
    {
        public frm_Ficha_Produto(string codigo)
        {
            InitializeComponent();
            preencheFormulario(codigo);
            btn_Salvar.Enabled = false;
        }

        public void preencheFormulario(string codigo)
        {
            SQLServerClass db = new SQLServerClass();
            string sql = "Select * from tabela_produtos where [codigo produto] = '" + codigo + "'";
            var dt = db.SqlQuery(sql);
            txt_Codigo.Text = dt.Rows[0][0].ToString();
            txt_Nome.Text = dt.Rows[0][1].ToString();
            cmb_Fornecedor.Text = dt.Rows[0][2].ToString();
            txt_Compra.Text = float.Parse(dt.Rows[0][3].ToString()).ToString("0.00");
            txt_Venda.Text = float.Parse(dt.Rows[0][4].ToString()).ToString("0.00");
            txt_Descrição.Text = dt.Rows[0][5].ToString();
            txt_Referencia.Text = dt.Rows[0][6].ToString();
            txt_Contem.Text = dt.Rows[0][7].ToString();
            cmb_Unidade.Text = dt.Rows[0][8].ToString();
            cmb_Marca.Text = dt.Rows[0][9].ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
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
                    btn_Salvar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                    btn_Salvar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    produto.UpdateProduto(produto.Codigo);
                    MessageBox.Show("Produto alterado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    produto.UpdateProduto(produto.Codigo);
                    MessageBox.Show("Produto alterado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            if (btn_Salvar.Enabled)
            {
                DialogResult resultado = MessageBox.Show("Sair sem salvar? (As alterações serão descartadas)", "Programa Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            if (btn_Salvar.Enabled)
            {
                DialogResult resultado = MessageBox.Show("Sair sem salvar? (As alterações serão descartadas)", "Programa Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
