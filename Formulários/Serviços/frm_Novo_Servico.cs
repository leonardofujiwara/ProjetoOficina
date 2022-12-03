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

namespace Programa_Oficina.Formulários.Serviços
{
    public partial class frm_Novo_Servico : Form
    {
        public frm_Novo_Servico()
        {
            InitializeComponent();
            cls_Servico.Unit serv = new cls_Servico.Unit();
            txt_Codigo.Text = serv.GeraCodigo().ToString();
            cmb_Codigo_Produto.MaxDropDownItems = 8;
            configuraDataGrid();
            
        }

        private void configuraDataGrid()
        {
            col_Codigo.Width = 109;
            col_Nome.Width = 222;
            col_Referência.Width = 174;
            col_Quantidade.Width = 105;
        }

        private void cmb_Codigo_Produto_DropDown(object sender, EventArgs e)
        {
            cmb_Codigo_Produto.Items.Clear();
            cls_Produto.Unit produto = new cls_Produto.Unit();
            var dt = produto.SelectProdutos("codigo produto", cmb_Codigo_Produto.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_Codigo_Produto.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cmb_Codigo_Produto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (cmb_Codigo_Produto.SelectedIndex == -1)
                    {
                        cmb_Codigo_Produto.Items.Clear();
                        cls_Produto.Unit produto = new cls_Produto.Unit();
                        var dt = produto.SelectProdutos("codigo produto", cmb_Codigo_Produto.Text);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cmb_Codigo_Produto.Items.Add(dt.Rows[i][0].ToString());
                        }
                    }
                    else
                    {
                        cls_Produto.Unit produto = new cls_Produto.Unit();
                        var dt = produto.SelectProdutoUnico("codigo produto", cmb_Codigo_Produto.Text);
                        cmb_Nome_Produto.Text = dt.Rows[0][1].ToString();
                        cmb_Referencia.Text = dt.Rows[0][6].ToString();
                        lbl_Unidade.Text = dt.Rows[0][8].ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Produto inválido.", "Programa Oficina",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void cmb_Nome_Produto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (cmb_Nome_Produto.SelectedIndex == -1)
                    {
                        cmb_Nome_Produto.Items.Clear();
                        cls_Produto.Unit produto = new cls_Produto.Unit();
                        var dt = produto.SelectProdutos("nome", cmb_Nome_Produto.Text);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cmb_Nome_Produto.Items.Add(dt.Rows[i][1].ToString());
                        }
                    }
                    else
                    {
                        cls_Produto.Unit produto = new cls_Produto.Unit();
                        var dt = produto.SelectProdutos("nome", cmb_Nome_Produto.Text);
                        cmb_Codigo_Produto.Text = dt.Rows[0][0].ToString();
                        cmb_Referencia.Text = dt.Rows[0][6].ToString();
                        lbl_Unidade.Text = dt.Rows[0][8].ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Produto inválido.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void cmb_Nome_Produto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Nome_Produto.SelectedIndex == -1)
                {
                    cmb_Nome_Produto.DroppedDown = true;
                }
            }
        }

        private void cmb_Nome_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cls_Produto.Unit produto = new cls_Produto.Unit();
                var dt = produto.SelectProdutos("nome", cmb_Nome_Produto.Text);
                cmb_Codigo_Produto.Text = dt.Rows[0][0].ToString();
                cmb_Referencia.Text = dt.Rows[0][6].ToString();
                lbl_Unidade.Text = dt.Rows[0][8].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto inválido.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Codigo_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_Produto.Unit produto = new cls_Produto.Unit();
            var dt = produto.SelectProdutoUnico("codigo produto", cmb_Codigo_Produto.Text);
            cmb_Nome_Produto.Text = dt.Rows[0][1].ToString();
            cmb_Referencia.Text = dt.Rows[0][6].ToString();
            lbl_Unidade.Text = dt.Rows[0][8].ToString();
        }

        private void cmb_Codigo_Produto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Codigo_Produto.SelectedIndex == -1)
                {
                    cmb_Codigo_Produto.DroppedDown = true;
                }
            }
        }

        private void cmb_Referencia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmb_Referencia.SelectedIndex == -1)
                    {
                        cmb_Referencia.Items.Clear();
                        cls_Produto.Unit produto = new cls_Produto.Unit();
                        var dt = produto.SelectProdutos("Referencia", cmb_Referencia.Text);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cmb_Referencia.Items.Add(dt.Rows[i][6].ToString());
                        }
                    }
                    else
                    {
                        cls_Produto.Unit produto = new cls_Produto.Unit();
                        var dt = produto.SelectProdutoUnico("Referencia", cmb_Referencia.Text);
                        cmb_Nome_Produto.Text = dt.Rows[0][1].ToString();
                        cmb_Codigo_Produto.Text = dt.Rows[0][0].ToString();
                        lbl_Unidade.Text = dt.Rows[0][8].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void cmb_Referencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cls_Produto.Unit produto = new cls_Produto.Unit();
                var dt = produto.SelectProdutoUnico("Referencia", cmb_Referencia.Text);
                cmb_Nome_Produto.Text = dt.Rows[0][1].ToString();
                cmb_Codigo_Produto.Text = dt.Rows[0][0].ToString();
                lbl_Unidade.Text = dt.Rows[0][8].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string unidade = lbl_Unidade.Text;
            string quantidade = float.Parse(txt_Quantidade.Text.Replace(".", ",")).ToString("0.00");
            if (lbl_Unidade.Text == "Quilos")
            {
                unidade = "Kg";
            }
            if (lbl_Unidade.Text == "Litro(s)")
            {
                unidade = "L";
            }
            if (lbl_Unidade.Text == "Litros")
            {
                unidade = "L";
            }

            dg_Produtos.Rows.Add(cmb_Codigo_Produto.Text,
                                    cmb_Nome_Produto.Text,
                                    cmb_Referencia.Text,
                                    quantidade.Replace(",", ".") + " " + unidade);

            cmb_Codigo_Produto.Text = "";
            cmb_Nome_Produto.Text = "";
            cmb_Referencia.Text = "";
            txt_Quantidade.Text = "";
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Produtos.SelectedCells[0].RowIndex;
            dg_Produtos.Rows.Remove(dg_Produtos.Rows[rowindex]);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Servico.Unit servico = new cls_Servico.Unit();
                if (dg_Produtos.Rows.Count > 0)
                {
                    for (int i = 0; i < dg_Produtos.Rows.Count; i++)
                    {
                        servico.Nome = txt_Nome.Text;
                        servico.Codigo = txt_Codigo.Text;
                        servico.Referencia = txt_Referencia.Text;
                        servico.Venda = txt_Venda.Text.Replace(",", ".");
                        servico.Codigo_Produto = dg_Produtos.Rows[i].Cells[0].Value.ToString();
                        servico.Nome_Produto = dg_Produtos.Rows[i].Cells[1].Value.ToString();
                        if (dg_Produtos.Rows[i].Cells[2].Value.ToString().Length > 0)
                        {
                            servico.Referencia_Produto = dg_Produtos.Rows[i].Cells[2].Value.ToString();
                        }
                        else
                        {
                            servico.Referencia_Produto = "null";
                        }
                        
                        if (dg_Produtos.Rows[i].Cells[3].Value.ToString().Contains("Unidade"))
                        {
                            servico.Unidade_Produto = "Unidade";
                        }
                        if (dg_Produtos.Rows[i].Cells[3].Value.ToString().Contains("Kg"))
                        {
                            servico.Unidade_Produto = "Kg";
                        }
                        if (dg_Produtos.Rows[i].Cells[3].Value.ToString().Contains("Metro(s)"))
                        {
                            servico.Unidade_Produto = "Metro(s)";
                        }
                        if (dg_Produtos.Rows[i].Cells[3].Value.ToString().Contains("L"))
                        {
                            servico.Unidade_Produto = "L";
                        }
                        string quantidade = dg_Produtos.Rows[i].Cells[3].Value.ToString().Replace(",", ".");
                        quantidade = quantidade.Replace("Kg", "").Replace("L", "").Replace("Unidade", "").Replace("Metro(s)","");
                        servico.Quantidade_Produto = quantidade;
                        servico.Descricao = txt_Descricao.Text;
                        servico.ValidaClasse();
                        servico.InsertServico();
                    }
                }
                if (dg_Produtos.Rows.Count == 0)
                {
                    servico.Nome = txt_Nome.Text;
                    servico.Codigo = txt_Codigo.Text;
                    servico.Referencia = txt_Referencia.Text;
                    servico.Venda = txt_Venda.Text.Replace(",", ".");
                    servico.Descricao = txt_Descricao.Text;
                    servico.Quantidade_Produto = "0.00";
                    servico.ValidaClasse();
                    servico.InsertServico();
                }
                MessageBox.Show("Serviço cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
