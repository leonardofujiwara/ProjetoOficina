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
    public partial class frm_Ficha_Funcionario : Form
    {
        public frm_Ficha_Funcionario(string codigo)
        {
            InitializeComponent();
            btn_Salvar.Enabled = false;
            preencheFormulario(codigo);
            if (txt_Status.Text == "Desligado")
            {
                DesativarFormulario();
                btn_Salvar.Enabled = false;
                btn_Alterar.Enabled = false;
            }
        }
        public void preencheFormulario(string codigo)
        {
            SQLServerClass db = new SQLServerClass();
            string sql = "select [Codigo Funcionario]" +
                         ", [Nome]" +
                         ", [Cpf]" +
                         ", [Cep]" +
                         ", [Logradouro]" +
                         ", [Bairro]" +
                         ", [Cidade]" +
                         ", [Estado]" +
                         ", convert(nvarchar(10),[Data de Admissão], 103)" +
                         ", convert(nvarchar(10),[Data de Demissão], 103)" +
                         ", [Porcentagem MO]" +
                         ", [Porcentagem Produto]" +
                         ", [Pagamento]" +
                         ", convert(nvarchar(10),[Salario])" +
                         ", [Tipo de Pagamento]" +
                         ", [Rg]" +
                         ", [Numero]" +
                         ", [Celular]" +
                         ", [Telefone]" +
                         ", [Status]" +
                         ", convert(nvarchar(10),[Nascimento],103) " +
                         "from tabela_funcionarios " +
                         "where [codigo funcionario] = " + codigo;
            
            
            var dt = db.SqlQuery(sql);
            txt_Codigo.Text = dt.Rows[0][0].ToString();
            txt_Nome.Text = dt.Rows[0][1].ToString();
            msk_Cpf.Text = dt.Rows[0][2].ToString();
            msk_Cep.Text = dt.Rows[0][3].ToString();
            txt_Logradouro.Text = dt.Rows[0][4].ToString();
            txt_Bairro.Text = dt.Rows[0][5].ToString();
            txt_Cidade.Text = dt.Rows[0][6].ToString();
            cmb_Estado.Text = dt.Rows[0][7].ToString();
            txt_Admissao.Text = dt.Rows[0][8].ToString();
            string demissao = dt.Rows[0][9].ToString();
            if (demissao == "01/01/1900")
            {
                txt_Demissao.Text = "";
            }
            else
            {
                txt_Demissao.Text = dt.Rows[0][9].ToString();
            }
            txt_Comissao_Servicos.Text = dt.Rows[0][10].ToString();
            txt_Comissao_Produtos.Text = dt.Rows[0][11].ToString();
            cmb_Pagamento.Text = dt.Rows[0][12].ToString();
            txt_Salario.Text = dt.Rows[0][13].ToString();
            string tipoPagamento =  dt.Rows[0][14].ToString();
            if (tipoPagamento == "Diário")
            {
                rdb_Diario.Checked = true;
            }
            if (tipoPagamento == "Semanal")
            {
                rdb_Semanal.Checked = true;
            }
            if (tipoPagamento == "Mensal")
            {
                rdb_Mensal.Checked = true;
            }
            msk_Rg.Text = dt.Rows[0][15].ToString();
            txt_Numero.Text = dt.Rows[0][16].ToString();
            msk_Celular.Text = dt.Rows[0][17].ToString();
            msk_Telefone.Text = dt.Rows[0][18].ToString();
            txt_Status.Text = dt.Rows[0][19].ToString();
            string nascimento = dt.Rows[0][20].ToString();
            if (nascimento == "01/01/1900")
            {
                msk_Nascimento.Text = "";
            }
            else
            {
                msk_Nascimento.Text = dt.Rows[0][20].ToString();
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Funcionario.Unit func = new cls_Funcionario.Unit();
                func.Codigo = txt_Codigo.Text;
                func.Nome = txt_Nome.Text;
                func.Cpf = msk_Cpf.Text;
                func.Rg = msk_Rg.Text;
                func.Admissao = txt_Admissao.Text;
                func.Demissao = txt_Demissao.Text;
                func.Status = txt_Status.Text;
                func.Nascimento = msk_Nascimento.Text;
                func.ComissaoProduto = txt_Comissao_Produtos.Text;
                func.ComissaoServico = txt_Comissao_Servicos.Text;
                func.Pagamento = cmb_Pagamento.Text;
                if (rdb_Diario.Checked)
                {
                    func.TipoPagamento = "Diário";
                }
                if (rdb_Semanal.Checked)
                {
                    func.TipoPagamento = "Semanal";
                }
                if (rdb_Mensal.Checked)
                {
                    func.TipoPagamento = "Mensal";
                }
                func.Salario = txt_Salario.Text;
                func.Cep = msk_Cep.Text;
                func.Logradouro = txt_Logradouro.Text;
                func.Bairro = txt_Bairro.Text;
                func.Cidade = txt_Cidade.Text;
                func.Estado = cmb_Estado.Text;
                func.Numero = txt_Numero.Text;
                func.Complemento = txt_Complemento.Text;
                func.Celular = msk_Celular.Text;
                func.Telefone = msk_Telefone.Text;
                func.ValidaClasse();
                btn_Salvar.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Programa Oficina",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
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
                func.Admissao = txt_Admissao.Text;
                func.Demissao = txt_Demissao.Text;
                func.Status = txt_Status.Text;
                func.Nascimento = msk_Nascimento.Text;
                func.ComissaoProduto = txt_Comissao_Produtos.Text;
                func.ComissaoServico = txt_Comissao_Servicos.Text;
                func.Pagamento = cmb_Pagamento.Text;
                if (rdb_Diario.Checked)
                {
                    func.TipoPagamento = "Diário";
                }
                if (rdb_Semanal.Checked)
                {
                    func.TipoPagamento = "Semanal";
                }
                if (rdb_Mensal.Checked)
                {
                    func.TipoPagamento = "Mensal";
                }
                string salario = txt_Salario.Text.Replace(",", ".");
                func.Salario = salario;
                func.Cep = msk_Cep.Text;
                func.Logradouro = txt_Logradouro.Text;
                func.Bairro = txt_Bairro.Text;
                func.Cidade = txt_Cidade.Text;
                func.Estado = cmb_Estado.Text;
                func.Numero = txt_Numero.Text;
                func.Complemento = txt_Complemento.Text;
                func.Celular = msk_Celular.Text;
                func.Telefone = msk_Telefone.Text;
                func.ValidaClasse();
                if (func.ValidaClasse())
                {
                    if (func.CodigoIgualNome(txt_Codigo.Text, txt_Nome.Text))
                    {
                        func.UpdateFuncionario(txt_Codigo.ToString());
                        MessageBox.Show("Funcionário atualizado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Código do Funcionário diferente do Nome. Deseja alterar mesmo assim ?",
                           "Programa Oficina",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            func.UpdateFuncionario(txt_Codigo.ToString());
                            MessageBox.Show("Funcionário atualizado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Funcionario.Unit func = new cls_Funcionario.Unit();
                func.Codigo = txt_Codigo.Text;
                func.Nome = txt_Nome.Text;
                func.Cpf = msk_Cpf.Text;
                func.Rg = msk_Rg.Text;
                func.Admissao = txt_Admissao.Text;
                func.Demissao = txt_Demissao.Text;
                func.Status = txt_Status.Text;
                func.Nascimento = msk_Nascimento.Text;
                func.ComissaoProduto = txt_Comissao_Produtos.Text;
                func.ComissaoServico = txt_Comissao_Servicos.Text;
                func.Pagamento = cmb_Pagamento.Text;
                if (rdb_Diario.Checked)
                {
                    func.TipoPagamento = "Diário";
                }
                if (rdb_Semanal.Checked)
                {
                    func.TipoPagamento = "Semanal";
                }
                if (rdb_Mensal.Checked)
                {
                    func.TipoPagamento = "Mensal";
                }
                func.Salario = txt_Salario.Text;
                func.Cep = msk_Cep.Text;
                func.Logradouro = txt_Logradouro.Text;
                func.Bairro = txt_Bairro.Text;
                func.Cidade = txt_Cidade.Text;
                func.Estado = cmb_Estado.Text;
                func.Numero = txt_Numero.Text;
                func.Complemento = txt_Complemento.Text;
                func.Celular = msk_Celular.Text;
                func.Telefone = msk_Telefone.Text;
                func.ValidaClasse();
                btn_Salvar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                func.Admissao = txt_Admissao.Text;
                func.Demissao = txt_Demissao.Text;
                func.Status = txt_Status.Text;
                func.Nascimento = msk_Nascimento.Text;
                func.ComissaoProduto = txt_Comissao_Produtos.Text;
                func.ComissaoServico = txt_Comissao_Servicos.Text;
                func.Pagamento = cmb_Pagamento.Text;
                if (rdb_Diario.Checked)
                {
                    func.TipoPagamento = "Diário";
                }
                if (rdb_Semanal.Checked)
                {
                    func.TipoPagamento = "Semanal";
                }
                if (rdb_Mensal.Checked)
                {
                    func.TipoPagamento = "Mensal";
                }
                string salario = txt_Salario.Text.Replace(",", ".");
                func.Salario = salario;
                func.Cep = msk_Cep.Text;
                func.Logradouro = txt_Logradouro.Text;
                func.Bairro = txt_Bairro.Text;
                func.Cidade = txt_Cidade.Text;
                func.Estado = cmb_Estado.Text;
                func.Numero = txt_Numero.Text;
                func.Complemento = txt_Complemento.Text;
                func.Celular = msk_Celular.Text;
                func.Telefone = msk_Telefone.Text;
                func.ValidaClasse();
                if (func.ValidaClasse())
                {
                    if (func.CodigoIgualNome(txt_Codigo.Text, txt_Nome.Text))
                    {
                        func.UpdateFuncionario(txt_Codigo.ToString());
                        MessageBox.Show("Funcionário atualizado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Código do Funcionário diferente do Nome. Deseja alterar mesmo assim ?",
                           "Programa Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            func.UpdateFuncionario(txt_Codigo.ToString());
                            MessageBox.Show("Funcionário atualizado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DesativarFormulario()
        {
            txt_Codigo.ReadOnly = true;
            txt_Nome.ReadOnly = true;
            msk_Nascimento.ReadOnly = true;
            msk_Cpf.ReadOnly = true;
            msk_Cep.ReadOnly = true;
            txt_Logradouro.ReadOnly = true;
            txt_Bairro.ReadOnly = true;
            txt_Cidade.ReadOnly = true;
            cmb_Estado.Enabled = false;
            txt_Admissao.ReadOnly = true;
            txt_Comissao_Servicos.ReadOnly = true;
            txt_Comissao_Produtos.ReadOnly = true;
            cmb_Pagamento.Enabled = false;
            txt_Salario.ReadOnly = true;
            rdb_Diario.Enabled = false;
            rdb_Semanal.Enabled = false;
            rdb_Mensal.Enabled = false;
            msk_Rg.ReadOnly = true;
            txt_Numero.ReadOnly = true;
            msk_Celular.ReadOnly = true;
            msk_Telefone.ReadOnly = true;
            txt_Status.ReadOnly = true;
        }
    }
}
