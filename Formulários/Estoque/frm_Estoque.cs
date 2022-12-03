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

namespace Programa_Oficina.Formulários.Estoque
{
    public partial class frm_Estoque : Form
    {
        public frm_Estoque()
        {
            InitializeComponent();
            configuraDataGrid();
            chb_Validade.Checked = false;
            dt_Inicial.Enabled = false;
            dt_Final.Enabled = false;
            cmb_Periodo.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Adicionar_Produto.Enabled = false;
            cmb_FiltroPesquisa.SelectedIndex = 2;
            preencheDataGridSemTempo();
        }

        public void configuraDataGrid()
        {
            col_Codigo.Width = 80;
            col_Referencia.Width = 150;
            col_Nome.Width = 200;
            col_Marca.Width = 150;
            col_Compra.Width = 100;
            col_Venda.Width = 100;
            col_Quantidade.Width = 150;
            col_Validade.Width = 80;
        }

        private void preencheDataGridSemTempo()
        {
            try
            {
                dg_Estoque.Rows.Clear();
                cls_Estoque.Unit estoque = new cls_Estoque.Unit();
                var dt = estoque.SelectEstoqueSemTempo(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text); ;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Estoque.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][4].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         float.Parse(dt.Rows[i][6].ToString()).ToString("0.00"),
                                         float.Parse(dt.Rows[i][7].ToString()).ToString("0.00"),
                                         dt.Rows[i][3].ToString().Replace(".",",") + " " + dt.Rows[i][8].ToString(),
                                         dt.Rows[i][5].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void preencheDataGridComTempo()
        {
            try
            {
                dg_Estoque.Rows.Clear();
                cls_Estoque.Unit estoque = new cls_Estoque.Unit();
                var dt = estoque.SelectEstoqueComTempo(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text,dt_Inicial.Text,dt_Final.Text); ;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Estoque.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][4].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         float.Parse(dt.Rows[i][6].ToString()).ToString("0.00"),
                                         float.Parse(dt.Rows[i][7].ToString()).ToString("0.00"),
                                         dt.Rows[i][3].ToString().Replace(".", ",") + " " + dt.Rows[i][8].ToString(),
                                         dt.Rows[i][5].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpaFormulario()
        {
            cmb_Codigo.Text = "";
            cmb_Nome.Text = "";
            txt_Marca.Text = "";
            txt_Embalagem.Text = "";
            cmb_Referencia.Text = "";
            msk_Validade.Text = "";
            txt_Compra.Text = "";
            txt_Venda.Text = "";
            lbl_Unidade.Text = "Unidade";
        }

        private void chb_Validade_CheckedChanged(object sender, EventArgs e)
        {
            if (!(chb_Validade.Checked))
            {
                dt_Inicial.Enabled = false;
                dt_Final.Enabled = false;
                cmb_Periodo.Enabled = false;
            }
            else
            {
                dt_Inicial.Enabled = true;
                dt_Final.Enabled = true;
                cmb_Periodo.Enabled = true;
            }
        }

        private void cmb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Nome.SelectedItem == null)
                {
                    cmb_Nome.Items.Clear();
                    SQLServerClass db = new SQLServerClass();
                    string sql = "Select top(100) [Nome] From tabela_Produtos where [Nome] like '%" + cmb_Nome.Text + "%'";
                    var dt = db.SqlQuery(sql);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmb_Nome.Items.Add(dt.Rows[i][0]);
                    }
                }
                else
                {
                    SQLServerClass db = new SQLServerClass();
                    string sql = "select [codigo produto], [nome], [marca], [referencia], [fornecedor], [quantidade], [unidade]" +
                                 ",[valor compra], [valor venda] from tabela_produtos where [nome] = '" + cmb_Nome.Text + "'";

                    var dt = db.SqlQuery(sql);
                    if (dt.Rows.Count > 0)
                    {
                        cmb_Codigo.Text = dt.Rows[0][0].ToString();
                        cmb_Nome.Text = dt.Rows[0][1].ToString();
                        txt_Marca.Text = dt.Rows[0][2].ToString();
                        cmb_Referencia.Text = dt.Rows[0][3].ToString();
                        txt_Fornecedor.Text = dt.Rows[0][4].ToString();
                        txt_Embalagem.Text = dt.Rows[0][5].ToString();
                        lbl_Unidade.Text = dt.Rows[0][6].ToString(); ;
                        txt_Compra.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
                        txt_Venda.Text = float.Parse(dt.Rows[0][8].ToString()).ToString("0.00");
                    }
                }
            }
        }

        private void cmb_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Codigo.SelectedItem == null)
                {
                    cmb_Codigo.Items.Clear();
                    cmb_Codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                    cmb_Codigo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cmb_Codigo.AutoCompleteSource = AutoCompleteSource.ListItems;
                    SQLServerClass db = new SQLServerClass();
                    string sql = "Select top(100) [codigo produto] From tabela_Produtos where [codigo produto] like '%" + cmb_Codigo.Text + "%'";
                    var dt = db.SqlQuery(sql);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmb_Codigo.Items.Add(dt.Rows[i][0]);
                    }
                }
                else
                {
                    SQLServerClass db = new SQLServerClass();
                    string sql = "select [codigo produto], [nome], [marca], [referencia], [fornecedor], [quantidade], [unidade]" +
                                    ",[valor compra], [valor venda] from tabela_produtos where [codigo produto] = '" + cmb_Codigo.Text + "'";

                    var dt = db.SqlQuery(sql);
                    if (dt.Rows.Count > 0)
                    {
                        cmb_Codigo.Text = dt.Rows[0][0].ToString();
                        cmb_Nome.Text = dt.Rows[0][1].ToString();
                        txt_Marca.Text = dt.Rows[0][2].ToString();
                        cmb_Referencia.Text = dt.Rows[0][3].ToString();
                        txt_Fornecedor.Text = dt.Rows[0][4].ToString();
                        txt_Embalagem.Text = dt.Rows[0][5].ToString();
                        lbl_Unidade.Text = dt.Rows[0][6].ToString(); ;
                        txt_Compra.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
                        txt_Venda.Text = float.Parse(dt.Rows[0][8].ToString()).ToString("0.00");
                    }
                }
            }
        }

        private void cmb_Referencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Referencia.SelectedItem == null)
                {
                    cmb_Referencia.Items.Clear();
                    SQLServerClass db = new SQLServerClass();
                    string sql = "Select top(100) [referencia] From tabela_Produtos where [referencia] like '%" + cmb_Referencia.Text + "%'";
                    var dt = db.SqlQuery(sql);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmb_Referencia.Items.Add(dt.Rows[i][0]);
                    }
                }
                else
                {
                    SQLServerClass db = new SQLServerClass();
                    string sql = "select [codigo produto], [nome], [marca], [referencia], [fornecedor], [quantidade], [unidade]" +
                                    ",[valor compra], [valor venda] from tabela_produtos where [Referencia] = '" + cmb_Referencia.Text + "'";

                    var dt = db.SqlQuery(sql);
                    if (dt.Rows.Count > 0)
                    {
                        cmb_Codigo.Text = dt.Rows[0][0].ToString();
                        cmb_Nome.Text = dt.Rows[0][1].ToString();
                        txt_Marca.Text = dt.Rows[0][2].ToString();
                        cmb_Referencia.Text = dt.Rows[0][3].ToString();
                        txt_Fornecedor.Text = dt.Rows[0][4].ToString();
                        txt_Embalagem.Text = dt.Rows[0][5].ToString();
                        lbl_Unidade.Text = dt.Rows[0][6].ToString(); ;
                        txt_Compra.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
                        txt_Venda.Text = float.Parse(dt.Rows[0][8].ToString()).ToString("0.00");
                    }
                }
            }
        }

        private void cmb_Codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Codigo.SelectedIndex == -1)
                {
                    cmb_Codigo.DroppedDown = true;
                }
            }          
        }

        private void cmb_Nome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Nome.SelectedIndex == -1)
                {
                    cmb_Nome.DroppedDown = true;
                }  
            }
        }

        private void cmb_Referencia_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Referencia.SelectedIndex == -1)
                {
                    cmb_Referencia.DroppedDown = true;
                }
            }
        }

        private void cmb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLServerClass db = new SQLServerClass();
            string sql = "select [codigo produto], [nome], [marca], [referencia], [fornecedor], [quantidade], [unidade]" +
                         ",[valor compra], [valor venda] from tabela_produtos where [nome] = '" + cmb_Nome.Text + "'";

            var dt = db.SqlQuery(sql);
            if (dt.Rows.Count > 0)
            {
                cmb_Codigo.Text = dt.Rows[0][0].ToString();
                cmb_Nome.Text = dt.Rows[0][1].ToString();
                txt_Marca.Text = dt.Rows[0][2].ToString();
                cmb_Referencia.Text = dt.Rows[0][3].ToString();
                txt_Fornecedor.Text = dt.Rows[0][4].ToString();
                txt_Embalagem.Text = dt.Rows[0][5].ToString();
                lbl_Unidade.Text = dt.Rows[0][6].ToString(); ;
                txt_Compra.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
                txt_Venda.Text = float.Parse(dt.Rows[0][8].ToString()).ToString("0.00");
            }
        }

        private void cmb_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLServerClass db = new SQLServerClass();
            string sql = "select [codigo produto], [nome], [marca], [referencia], [fornecedor], [quantidade], [unidade]" +
                         ",[valor compra], [valor venda] from tabela_produtos where [codigo produto] = '" + cmb_Codigo.Text + "'";

            var dt = db.SqlQuery(sql);
            if (dt.Rows.Count > 0)
            {
                cmb_Codigo.Text = dt.Rows[0][0].ToString();
                cmb_Nome.Text = dt.Rows[0][1].ToString();
                txt_Marca.Text = dt.Rows[0][2].ToString();
                cmb_Referencia.Text = dt.Rows[0][3].ToString();
                txt_Fornecedor.Text = dt.Rows[0][4].ToString();
                txt_Embalagem.Text = dt.Rows[0][5].ToString();
                lbl_Unidade.Text = dt.Rows[0][6].ToString(); ;
                txt_Compra.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
                txt_Venda.Text = float.Parse(dt.Rows[0][8].ToString()).ToString("0.00");
            }
        }

        private void cmb_Referencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLServerClass db = new SQLServerClass();
            string sql = "select [codigo produto], [nome], [marca], [referencia], [fornecedor], [quantidade], [unidade]" +
                            ",[valor compra], [valor venda] from tabela_produtos where [Referencia] = '" + cmb_Referencia.Text + "'";

            var dt = db.SqlQuery(sql);
            if (dt.Rows.Count > 0)
            {
                cmb_Codigo.Text = dt.Rows[0][0].ToString();
                cmb_Nome.Text = dt.Rows[0][1].ToString();
                txt_Marca.Text = dt.Rows[0][2].ToString();
                cmb_Referencia.Text = dt.Rows[0][3].ToString();
                txt_Fornecedor.Text = dt.Rows[0][4].ToString();
                txt_Embalagem.Text = dt.Rows[0][5].ToString();
                lbl_Unidade.Text = dt.Rows[0][6].ToString(); ;
                txt_Compra.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
                txt_Venda.Text = float.Parse(dt.Rows[0][8].ToString()).ToString("0.00");
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {  
                cls_Estoque.Unit estoque = new cls_Estoque.Unit();
                estoque.Codigo = cmb_Codigo.Text;
                estoque.Nome = cmb_Nome.Text;
                estoque.Referencia = cmb_Referencia.Text;
                estoque.Marca = txt_Marca.Text;
                if (msk_Validade.Text.Length == 6)
                {
                    estoque.Validade = "01/01/2100";
                }
                else
                {
                    estoque.Validade = msk_Validade.Text;
                }
                estoque.Venda = txt_Venda.Text.Replace(",",".");
                estoque.Compra = txt_Compra.Text.Replace(",", ".");
                float f = float.Parse(txt_Embalagem.Text.Replace(".",","));
                float x = float.Parse(txt_Quantidade.Text);
                float quantidade = f * x; 
                estoque.Quantidade = quantidade.ToString("0.00");
                estoque.Unidade = lbl_Unidade.Text;
                estoque.ValidaClasse();
                if (btn_Adicionar.Text == "Adicionar")
                {
                    if (estoque.ValidaClasse())
                    {
                        if (produtoInEstoque())
                        {
                            float soma = (float.Parse(estoque.Quantidade)) + (float.Parse(estoque.GetQuantidadeEstoque(cmb_Codigo.Text, estoque.Validade)));
                            estoque.Quantidade = soma.ToString().Replace(",", ".");
                            estoque.UpdateEstoque(cmb_Codigo.Text);
                        }
                        else
                        {
                            estoque.InsertEstoque();
                        }
                        MessageBox.Show("Produto inserido no estoque com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (btn_Adicionar.Text == "Alterar")
                {
                    if (produtoInEstoque())
                    { 
                        estoque.Quantidade = quantidade.ToString().Replace(",", ".");
                        estoque.UpdateEstoque(cmb_Codigo.Text);
                        MessageBox.Show("Produto alterado no estoque com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (chb_Validade.Checked)
                {
                    preencheDataGridComTempo();
                }
                else
                {
                    preencheDataGridSemTempo();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_FiltroPesquisa_Click(object sender, EventArgs e)
        {
            if (chb_Validade.Checked)
            {
                preencheDataGridComTempo();
            }
            else
            {
                preencheDataGridSemTempo();
            }
        }

        private void dg_Estoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            preencheFormulario();
        }

        public void preencheFormulario()
        {
            int rowindex = dg_Estoque.SelectedCells[0].RowIndex;
            string valor = dg_Estoque.Rows[rowindex].Cells[0].Value.ToString();
            string validade = Convert.ToDateTime(dg_Estoque.Rows[rowindex].Cells[7].Value.ToString()).ToString("yyyy-MM-dd");
            cls_Estoque.Unit estoque = new cls_Estoque.Unit();
            var dt = estoque.SelectEstoqueFormulario ("Codigo Produto", valor,validade);
            cmb_Codigo.Text = dt.Rows[0][0].ToString();
            cmb_Nome.Text = dt.Rows[0][1].ToString();
            txt_Marca.Text = dt.Rows[0][2].ToString();
            txt_Quantidade.Text = dt.Rows[0][3].ToString();
            cmb_Referencia.Text = dt.Rows[0][4].ToString();
            msk_Validade.Text = dt.Rows[0][5].ToString();
            txt_Compra.Text = float.Parse(dt.Rows[0][6].ToString()).ToString("0.00");
            txt_Venda.Text = float.Parse(dt.Rows[0][7].ToString()).ToString("0.00");
            lbl_Unidade.Text = dt.Rows[0][8].ToString();
            cls_Produto.Unit produto = new cls_Produto.Unit();
            var ds = produto.SelectProdutoUnico("Codigo Produto", cmb_Codigo.Text);
            txt_Embalagem.Text = ds.Rows[0][7].ToString();
        }

        public bool produtoInEstoque()
        {
            SQLServerClass db = new SQLServerClass();
            string validade = msk_Validade.Text.Replace("/","");
            if (validade.Length < 8)
            {
                msk_Validade.Text = "01/01/2100";
            }
            string sql = "select * from tabela_estoque where " +
                         "[codigo produto] =  '" + cmb_Codigo.Text + "'" +
                         "and [nome produto] =  '" + cmb_Nome.Text + "'" +
                         "and [marca] =  '" + txt_Marca.Text + "'" +
                         "and [referencia] =  '" + cmb_Referencia.Text + "'" +
                         "and [data validade] =  '" + msk_Validade.Text + "'" +
                         "and [compra] =  '" + txt_Compra.Text.Replace(",",".") + "'" +
                         "and [venda] =  '" + txt_Venda.Text.Replace(",", ".") + "'";
            var dt = db.SqlQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dg_Estoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_Estoque.SelectedCells.Count > 0)
            {
                btn_Alterar.Enabled = true;
                btn_Excluir.Enabled = true;
                btn_Adicionar_Produto.Enabled = true;
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            preencheFormulario();
            btn_Adicionar.Text = "Alterar";
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                SQLServerClass db = new SQLServerClass();
                cls_Estoque.Unit estoque = new cls_Estoque.Unit();
                int rowindex = dg_Estoque.SelectedCells[0].RowIndex;
                string valor = dg_Estoque.Rows[rowindex].Cells[0].Value.ToString();
                preencheFormulario();
                var dt = estoque.SelectEstoqueSemTempo("codigo produto", valor);
                DialogResult resultado = MessageBox.Show("Deseja excluir o produto " + dt.Rows[0][1].ToString() + " do estoque ?",
                                "Programa Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    estoque.Codigo = cmb_Codigo.Text;
                    estoque.Nome = cmb_Nome.Text;
                    estoque.Referencia = cmb_Referencia.Text;
                    estoque.Marca = txt_Marca.Text;
                    if (msk_Validade.Text.Length == 6)
                    {
                        estoque.Validade = "01/01/2100";
                    }
                    else
                    {
                        estoque.Validade = msk_Validade.Text;
                    }
                    estoque.Venda = txt_Venda.Text.Replace(",", ".");
                    estoque.Compra = txt_Compra.Text.Replace(",", ".");
                    estoque.Unidade = lbl_Unidade.Text;
                    estoque.DeleteEstoque();
                    limpaFormulario();
                    preencheDataGridSemTempo();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Adicionar_Produto_Click(object sender, EventArgs e)
        {
            preencheFormulario();
            btn_Adicionar.Text = "Adicionar";
        }
    }
}
