using Microsoft.VisualBasic;
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
    public partial class frm_Novo_Funcionario : Form
    {
        public frm_Novo_Funcionario()
        {
            InitializeComponent();
            cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmb_Estado.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Estado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cls_Funcionario.Unit funcionario = new cls_Funcionario.Unit();
            txt_Codigo.Text = funcionario.GeraCodigo().ToString();
            rdb_Mensal.Select();
            for (int i = 1; i == 31; i++)
            {
                cmb_Pagamento.Items.Add("Todo dia " + i);
            }
            cmb_Pagamento.SelectedItem = 19;
            cmb_Pagamento.MaxDropDownItems = 8;
        }

        public string ConvertToUtf8(string String)
        {
            try
            {
                if (!(String == null))
                {
                    String = String.Replace("Ã¡", "á").Replace("Ã©", "é").Replace("Ã­", "í").Replace("Ã³", "ó").Replace("Ãº", "ú");
                    String = String.Replace("Ã£", "ã").Replace("Ãµ", "õ");
                    String = String.Replace("Ã¢", "â").Replace("Ãª", "ê").Replace("Ã®", "î").Replace("Ã´", "ô").Replace("Ã»", "û");
                    String = String.Replace("Ã§", "ç");
                    return String;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        private void msk_Cep_KeyDown(object sender, KeyEventArgs e)
        {
            string vCep = msk_Cep.Text.Replace("-", "");
            if (vCep != "" && e.KeyCode == Keys.Enter)
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = cls_Cep.GeraJSONCEP(vCep);
                        cls_Cep.Unit CEP = new cls_Cep.Unit();
                        CEP = cls_Cep.DesSerializedClassUnit(vJson);
                        txt_Logradouro.Text = this.ConvertToUtf8(CEP.logradouro);
                        txt_Bairro.Text = this.ConvertToUtf8(CEP.bairro);
                        txt_Cidade.Text = this.ConvertToUtf8(CEP.localidade);

                        cmb_Estado.SelectedIndex = -1;
                        for (int i = 0; i <= cmb_Estado.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(cmb_Estado.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                cmb_Estado.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void msk_Cep_Leave(object sender, EventArgs e)
        {
            string vCep = msk_Cep.Text.Replace("-", "");
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = cls_Cep.GeraJSONCEP(vCep);
                        cls_Cep.Unit CEP = new cls_Cep.Unit();
                        CEP = cls_Cep.DesSerializedClassUnit(vJson);
                        txt_Logradouro.Text = this.ConvertToUtf8(CEP.logradouro);
                        txt_Bairro.Text = this.ConvertToUtf8(CEP.bairro);
                        txt_Cidade.Text = this.ConvertToUtf8(CEP.localidade);

                        cmb_Estado.SelectedIndex = -1;
                        for (int i = 0; i <= cmb_Estado.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(cmb_Estado.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                cmb_Estado.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void rdb_Diario_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Pagamento.Items.Clear();
            cmb_Pagamento.Items.Add("Dia Trabalhado");
            cmb_Pagamento.SelectedIndex = 0;
        }

        private void rdb_Semanal_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Pagamento.Items.Clear();
            cmb_Pagamento.Items.Add("Toda Segunda-Feira");
            cmb_Pagamento.Items.Add("Toda Terça-Feira");
            cmb_Pagamento.Items.Add("Toda Quarta-Feira");
            cmb_Pagamento.Items.Add("Toda Quinta-Feira");
            cmb_Pagamento.Items.Add("Toda Sexta-Feira");
            cmb_Pagamento.Items.Add("Todo Sábado");
            cmb_Pagamento.Items.Add("Todo Domingo");
            cmb_Pagamento.SelectedIndex = 5;
        }

        private void rdb_Mensal_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Pagamento.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                cmb_Pagamento.Items.Add("Todo dia " + i.ToString());
            }
            cmb_Pagamento.SelectedIndex = 19;
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
                cls_Funcionario.Unit func = new cls_Funcionario.Unit();
                func.Codigo = txt_Codigo.Text;
                func.Nome = txt_Nome.Text;
                func.Cpf = msk_Cpf.Text;
                func.Rg = msk_Rg.Text;
                func.Nascimento = msk_Nascimento.Text;
                func.ComissaoProduto = txt_Comissao_Produtos.Text;
                func.ComissaoServico = txt_Comissao_Servicos.Text;
                if (rdb_Diario.Checked)
                {
                    func.TipoPagamento = "Diario";
                }
                if (rdb_Semanal.Checked)
                {
                    func.TipoPagamento = "Semanal";
                }
                if (rdb_Mensal.Checked)
                {
                    func.TipoPagamento = "Mensal";
                }
                func.Pagamento = cmb_Pagamento.Text;
                func.Salario = txt_Salario.Text.Replace(",",".");
                func.Cep = msk_Cep.Text;
                func.Logradouro = txt_Logradouro.Text;
                func.Bairro = txt_Bairro.Text;
                func.Cidade = txt_Cidade.Text;
                func.Estado = cmb_Estado.Text;
                func.Numero = txt_Numero.Text;
                func.Complemento = txt_Complemento.Text;
                func.Celular = msk_Celular.Text;
                func.Telefone = msk_Telefone.Text;
                func.Admissao = DateTime.UtcNow.ToString("dd/MM/yyyy");
                func.Status = "Ativo";

                func.ValidaClasse();
                func.InsertFuncionario();
                MessageBox.Show("Funcionário cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pcb_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Funcionario.Unit func = new cls_Funcionario.Unit();
                func.Codigo = txt_Codigo.Text;
                func.Nome = txt_Nome.Text;
                func.Cpf = msk_Cpf.Text;
                func.Rg = msk_Rg.Text;
                func.Nascimento = msk_Nascimento.Text;
                func.ComissaoProduto = txt_Comissao_Produtos.Text;
                func.ComissaoServico = txt_Comissao_Servicos.Text;
                if (rdb_Diario.Checked)
                {
                    func.TipoPagamento = "Diario";
                }
                if (rdb_Semanal.Checked)
                {
                    func.TipoPagamento = "Semanal";
                }
                if (rdb_Mensal.Checked)
                {
                    func.TipoPagamento = "Mensal";
                }
                func.Pagamento = cmb_Pagamento.Text;
                func.Salario = txt_Salario.Text.Replace(",", ".");
                func.Cep = msk_Cep.Text;
                func.Logradouro = txt_Logradouro.Text;
                func.Bairro = txt_Bairro.Text;
                func.Cidade = txt_Cidade.Text;
                func.Estado = cmb_Estado.Text;
                func.Numero = txt_Numero.Text;
                func.Complemento = txt_Complemento.Text;
                func.Celular = msk_Celular.Text;
                func.Telefone = msk_Telefone.Text;
                func.Admissao = DateTime.UtcNow.ToString("dd/MM/yyyy");
                func.Status = "Ativo";

                func.ValidaClasse();
                func.InsertFuncionario();
                MessageBox.Show("Funcionário cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
