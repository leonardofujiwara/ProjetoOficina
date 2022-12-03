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
    public partial class frm_Produtos : Form
    {
        public frm_Produtos()
        {
            InitializeComponent();
            cmb_FiltroPesquisa.SelectedIndex = 2;
            ConfiguraDataGrid();
            preencheDataGrid();
            lbl_ValorPesquisa.Text = cmb_FiltroPesquisa.Text;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        private void ConfiguraDataGrid()
        {
            dg_Produtos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dg_Produtos.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dg_Produtos.RowHeadersVisible = false;
            col_Codigo.Width = 60;
            col_Referencia.Width = 120;
            col_Nome.Width = 300;
            col_Marca.Width = 150;
            col_Fornecedor.Width = 150;
            col_Compra.Width = 85;
            col_Venda.Width = 85;
            col_Quantidade.Width = 100;
        }

        private void preencheDataGrid()
        {
            try
            {
                dg_Produtos.Rows.Clear();
                cls_Produto.Unit produto = new cls_Produto.Unit();
                var dt = produto.SelectProdutos(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text); ;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Produtos.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][6].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][9].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         float.Parse(dt.Rows[i][3].ToString()).ToString("0.00"),
                                         float.Parse(dt.Rows[i][4].ToString()).ToString("0.00"),
                                         dt.Rows[i][7].ToString() + " " + dt.Rows[i][8].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_FiltroPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ValorPesquisa.Text = cmb_FiltroPesquisa.Text;
        }

        private void btn_FiltroPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Produtos.Rows.Clear();
                cls_Produto.Unit produto = new cls_Produto.Unit();
                var dt = produto.SelectProdutos(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text); ;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Produtos.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][6].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][9].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         float.Parse(dt.Rows[i][3].ToString()).ToString("0.00"),
                                         float.Parse(dt.Rows[i][4].ToString()).ToString("0.00"),
                                         dt.Rows[i][7].ToString() + " " + dt.Rows[i][8].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_Produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dg_Produtos.SelectedCells[0].RowIndex;
            string valor = dg_Produtos.Rows[rowindex].Cells[0].Value.ToString();
            frm_Ficha_Produto fp = new frm_Ficha_Produto(valor);
            fp.ShowDialog();
            dg_Produtos.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Produtos.SelectedCells[0].RowIndex;
            string valor = dg_Produtos.Rows[rowindex].Cells[0].Value.ToString();
            frm_Ficha_Produto fp = new frm_Ficha_Produto(valor);
            fp.ShowDialog();
            dg_Produtos.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Produtos.SelectedCells[0].RowIndex;
            string valor = dg_Produtos.Rows[rowindex].Cells[0].Value.ToString();
            frm_Excluir_Produto excluir = new frm_Excluir_Produto(valor);
            excluir.ShowDialog();
            dg_Produtos.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Novo_Produto_Click(object sender, EventArgs e)
        {
            frm_Novo_Produto novo = new frm_Novo_Produto();
            novo.ShowDialog();
            dg_Produtos.Rows.Clear();
            preencheDataGrid();
        }

        private void dg_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Excluir.Enabled = true;
            btn_Alterar.Enabled = true;
        }

        private void frm_Produtos_Click(object sender, EventArgs e)
        {
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void pct_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Produtos.Rows.Clear();
                cls_Produto.Unit produto = new cls_Produto.Unit();
                var dt = produto.SelectProdutos(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text); ;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Produtos.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][6].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][9].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         float.Parse(dt.Rows[i][3].ToString()).ToString("0.00"),
                                         float.Parse(dt.Rows[i][4].ToString()).ToString("0.00"),
                                         dt.Rows[i][7].ToString() + " " + dt.Rows[i][8].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    dg_Produtos.Rows.Clear();
                    cls_Produto.Unit produto = new cls_Produto.Unit();
                    var dt = produto.SelectProdutos(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text); ;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dg_Produtos.Rows.Add(dt.Rows[i][0].ToString(),
                                             dt.Rows[i][6].ToString(),
                                             dt.Rows[i][1].ToString(),
                                             dt.Rows[i][9].ToString(),
                                             dt.Rows[i][2].ToString(),
                                             float.Parse(dt.Rows[i][3].ToString()).ToString("0.00"),
                                             float.Parse(dt.Rows[i][4].ToString()).ToString("0.00"),
                                             dt.Rows[i][7].ToString() + " " + dt.Rows[i][8].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
