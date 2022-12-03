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
    public partial class frm_Excluir_Produto : Form
    {
        public frm_Excluir_Produto(string codigo)
        {
            InitializeComponent();
            preencheFormulario(codigo);
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Excluir o produto selecionado ?" , "Programa Oficina",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (resultado == DialogResult.Yes)
                {
                    cls_Produto.Unit produto = new cls_Produto.Unit();
                    produto.DeleteProduto(txt_Codigo.Text);
                    MessageBox.Show("Produto excluído com sucesso.", "Programa Oficina",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pcb_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Excluir o produto selecionado ?", "Programa Oficina",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (resultado == DialogResult.Yes)
                {
                    cls_Produto.Unit produto = new cls_Produto.Unit();
                    produto.DeleteProduto(txt_Codigo.Text);
                    MessageBox.Show("Produto excluído com sucesso.", "Programa Oficina",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Close();
        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
