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

namespace Programa_Oficina.Formulários.Funcionario
{
    public partial class frm_Funcionarios : Form
    {
        public frm_Funcionarios()
        {
            InitializeComponent();
            cmb_FiltroPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmb_FiltroPesquisa.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_FiltroPesquisa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_FiltroPesquisa.SelectedIndex = 1;
            preencheDataGrid();

            cmb_Periodo.SelectedIndex = 3;
            dt_Final.Value = DateTime.UtcNow;
            dt_Inicial.Value = dt_Final.Value.AddMonths(-3);

            chb_Data.Checked = true;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Desligar.Enabled = false;
            btn_Religar.Enabled = false;
            ConfiguraDataGrid();
        }

        private void ConfiguraDataGrid()
        {
            dg_Funcionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dg_Funcionarios.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dg_Funcionarios.RowHeadersVisible = false;
            col_Codigo.Width = 50;
            col_Nome.Width = 220;
            col_Cidade.Width = 140;
            col_Estado.Width = 140;
            col_PorcentagemMO.Width = 60;
            col_PorcentagemProduto.Width = 60;
            col_TipoPagamento.Width = 90;
            col_Pagamento.Width = 120;
            col_Admissao.Width = 100;
            col_Status.Width = 70;
        }

        private void preencheDataGrid()
        {
            try
            {
                dg_Funcionarios.Rows.Clear();
                cls_Funcionario.Unit func = new cls_Funcionario.Unit();
                DataTable dt = new DataTable();
                if (chb_Data.Checked)
                {
                    dt = func.PesquisarFuncComTempo(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text, dt_Inicial.Text, dt_Final.Text);
                }
                else
                {
                    dt = func.PesquisarFuncSemTempo(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Funcionarios.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         dt.Rows[i][3].ToString(),
                                         dt.Rows[i][4].ToString(),
                                         dt.Rows[i][5].ToString(),
                                         dt.Rows[i][6].ToString(),
                                         dt.Rows[i][7].ToString(),
                                         dt.Rows[i][8].ToString(),
                                         dt.Rows[i][9].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_Funcionarios_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dg_Funcionarios.ClearSelection();
                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
            }
        }

        private void cmb_FiltroPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ValorPesquisa.Text = cmb_FiltroPesquisa.Text;
        }

        private void chb_Data_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Data.Checked)
            {
                dt_Inicial.Enabled = true;
                dt_Final.Enabled = true;
                cmb_Periodo.Enabled = true;
            }
            else
            {
                dt_Inicial.Enabled = false;
                dt_Final.Enabled = false;
                cmb_Periodo.Enabled = false;
            }
        }

        private void dg_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dg_Funcionarios.SelectedCells[0].RowIndex;
            string valor = dg_Funcionarios.Rows[rowindex].Cells[0].Value.ToString();
            frm_Ficha_Funcionario fc = new frm_Ficha_Funcionario(valor);
            fc.ShowDialog();
            dg_Funcionarios.Rows.Clear();
            preencheDataGrid();
        }

        private void dg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_Funcionarios.SelectedCells.Count == 1)
            {
                try
                {
                    int rowindex = dg_Funcionarios.SelectedCells[0].RowIndex;
                    string valor = dg_Funcionarios.Rows[rowindex].Cells[9].Value.ToString();
                    if (valor == "Ativo")
                    {
                        btn_Desligar.Enabled = true;
                        btn_Excluir.Enabled = false;
                        btn_Religar.Enabled = false;
                    }
                    if (valor == "Desligado")
                    {
                        btn_Desligar.Enabled = false;
                        btn_Excluir.Enabled = true;
                        btn_Religar.Enabled = true;
                    }
                    btn_Alterar.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_FiltroPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Funcionarios.Rows.Clear();
                cls_Funcionario.Unit func = new cls_Funcionario.Unit();
                DataTable dt = new DataTable();
                if (chb_Data.Checked)
                {
                    dt = func.PesquisarFuncComTempo(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text, dt_Inicial.Text, dt_Final.Text);
                }
                else
                {
                    dt = func.PesquisarFuncSemTempo(cmb_FiltroPesquisa.Text, txt_Pesquisa.Text);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Funcionarios.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         dt.Rows[i][3].ToString(),
                                         dt.Rows[i][4].ToString(),
                                         dt.Rows[i][5].ToString(),
                                         dt.Rows[i][6].ToString(),
                                         dt.Rows[i][7].ToString(),
                                         dt.Rows[i][8].ToString(),
                                         dt.Rows[i][9].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selecionado;
            if (cmb_Periodo.SelectedIndex == 1)
            {
                selecionado = -1;
                int dia = (DateTime.UtcNow.Day - (DateTime.UtcNow.Day * 2)) + 1;
                dt_Final.Value = DateTime.UtcNow;
                dt_Inicial.Value = dt_Final.Value.AddMonths(selecionado);
                dt_Inicial.Value = dt_Final.Value.AddDays(dia);
            }
            if (cmb_Periodo.SelectedIndex == 2)
            {
                selecionado = -1;
                int dia = DateTime.UtcNow.Day - (DateTime.UtcNow.Day * 2);
                dt_Final.Value = dt_Final.Value.AddDays(dia);
                dt_Inicial.Value = DateTime.UtcNow.AddDays(dia);
                dia = (dt_Inicial.Value.Day - (dt_Inicial.Value.Day * 2)) + 1;
                dt_Inicial.Value = dt_Inicial.Value.AddDays(dia);
            }
            if (cmb_Periodo.SelectedIndex == 3)
            {
                selecionado = -3;
                dt_Final.Value = DateTime.UtcNow;
                dt_Inicial.Value = dt_Final.Value.AddMonths(selecionado);
            }
            if (cmb_Periodo.SelectedIndex == 4)
            {
                selecionado = -6;
                dt_Final.Value = DateTime.UtcNow;
                dt_Inicial.Value = dt_Final.Value.AddMonths(selecionado);
            }
            if (cmb_Periodo.SelectedIndex == 5)
            {
                selecionado = -9;
                dt_Final.Value = DateTime.UtcNow;
                dt_Inicial.Value = dt_Final.Value.AddMonths(selecionado);
            }
            if (cmb_Periodo.SelectedIndex == 6)
            {
                selecionado = -1;
                dt_Final.Value = DateTime.UtcNow;
                dt_Inicial.Value = dt_Final.Value.AddYears(selecionado);
            }
        }

        private void dt_Inicial_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cmb_Periodo.SelectedIndex = 0;
            }
        }

        private void dt_Final_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cmb_Periodo.SelectedIndex = 0;
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Funcionarios.SelectedCells[0].RowIndex;
            string valor = dg_Funcionarios.Rows[rowindex].Cells[0].Value.ToString();
            frm_Ficha_Funcionario fc = new frm_Ficha_Funcionario(valor);
            fc.ShowDialog();
            dg_Funcionarios.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Desligar_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Funcionarios.SelectedCells[0].RowIndex;
            string valor = dg_Funcionarios.Rows[rowindex].Cells[0].Value.ToString();
            frm_Desligar_Funcionario desligar = new frm_Desligar_Funcionario(valor);
            desligar.ShowDialog();
            dg_Funcionarios.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Funcionarios.SelectedCells[0].RowIndex;
            string valor = dg_Funcionarios.Rows[rowindex].Cells[0].Value.ToString();
            frm_Excluir_Funcionario excluir = new frm_Excluir_Funcionario(valor);
            excluir.ShowDialog();
            dg_Funcionarios.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Religar_Click(object sender, EventArgs e)
        {
            int rowindex = dg_Funcionarios.SelectedCells[0].RowIndex;
            string valor = dg_Funcionarios.Rows[rowindex].Cells[0].Value.ToString();
            frm_Religar_Funcionario religar = new frm_Religar_Funcionario(valor);
            religar.ShowDialog();
            dg_Funcionarios.Rows.Clear();
            preencheDataGrid();
        }

        private void btn_Novo_Funcionario_Click(object sender, EventArgs e)
        {
            frm_Novo_Funcionario novo = new frm_Novo_Funcionario();
            novo.ShowDialog();
            dg_Funcionarios.Rows.Clear();
            preencheDataGrid();
        }
    }
}
