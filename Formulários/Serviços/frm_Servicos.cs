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
    public partial class frm_Servicos : Form
    {
        public frm_Servicos()
        {
            InitializeComponent();
            preencheDataGrid();
            configuraDataGrid();
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
            cmb_FiltroPesquisa.SelectedIndex = 2;
        }

        public void preencheDataGrid()
        {
            cls_Servico.Unit serv = new cls_Servico.Unit();
            var dt = serv.SelectServicos();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dg_Servicos.Rows.Add(dt.Rows[i][0].ToString(),
                                     dt.Rows[i][1].ToString(),
                                     dt.Rows[i][2].ToString(),
                                     dt.Rows[i][3].ToString(),
                                     dt.Rows[i][4].ToString(),
                                     float.Parse(dt.Rows[i][5].ToString()).ToString("0.00"));
            }
        }

        public void configuraDataGrid()
        {
            col_Codigo.Width = 92;
            col_Referencia.Width = 120;
            col_Nome.Width = 180;
            col_Ref_Produtos.Width = 180;
            col_Descricao.Width = 358;
            col_Venda.Width = 80;
        }

        private void btn_Novo_Servico_Click(object sender, EventArgs e)
        {
            frm_Novo_Servico novo = new frm_Novo_Servico();
            novo.ShowDialog();
            dg_Servicos.Rows.Clear();
            preencheDataGrid();
        }

        private void dg_Servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_Servicos.SelectedCells.Count > 0)
            {
                btn_Alterar.Enabled = true;
                btn_Excluir.Enabled = true;
            }
            else
            {
                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
            }
        }

        private void btn_FiltroPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Servicos.Rows.Clear();
                string filtro = "";
                if (cmb_FiltroPesquisa.SelectedIndex == 0)
                {
                    filtro = "codigo servico";
                }
                if (cmb_FiltroPesquisa.SelectedIndex == 1)
                {
                    filtro = "referencia";
                }
                if (cmb_FiltroPesquisa.SelectedIndex == 2)
                {
                    filtro = "nome servico";
                }
                if (cmb_FiltroPesquisa.SelectedIndex == 3)
                {
                    filtro = "referencia produto";
                }
                if (cmb_FiltroPesquisa.SelectedIndex == 4)
                {
                    filtro = "descricao";
                }
                if (cmb_FiltroPesquisa.SelectedIndex == 5)
                {
                    filtro = "valor venda";
                }

                cls_Servico.Unit serv = new cls_Servico.Unit();
                var dt = serv.SelectPesquisaServico(filtro, txt_Pesquisa.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Servicos.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         dt.Rows[i][3].ToString(),
                                         dt.Rows[i][4].ToString(),
                                         float.Parse(dt.Rows[i][5].ToString()).ToString("0.00"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Serviço não cadastrado.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Servicos.SelectedCells[0].RowIndex;
            string valor = dg_Servicos.Rows[rowindex].Cells[0].Value.ToString();
            frm_Alterar_Servico alt = new frm_Alterar_Servico(valor);
            alt.ShowDialog();
            dg_Servicos.Rows.Clear();
            preencheDataGrid();
        }

        private void dg_Servicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dg_Servicos.SelectedCells[0].RowIndex;
            string valor = dg_Servicos.Rows[rowindex].Cells[0].Value.ToString();
            frm_Alterar_Servico alt = new frm_Alterar_Servico(valor);
            alt.ShowDialog();
            dg_Servicos.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Servicos.SelectedCells[0].RowIndex;
            string valor = dg_Servicos.Rows[rowindex].Cells[0].Value.ToString();
            frm_Excluir_Servico exc = new frm_Excluir_Servico(valor);
            exc.ShowDialog();
            dg_Servicos.Rows.Clear();
            preencheDataGrid();
        }
    }
}
