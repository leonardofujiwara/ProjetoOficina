using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Programa_Oficina.Classes;

namespace Programa_Oficina.Formulários.Clientes
{
    public partial class frm_Ficha_Cliente : Form
    {
        public frm_Ficha_Cliente(string ClienteID)
        {
            InitializeComponent();
            preencheFormulario(ClienteID);
            btn_Salvar.Enabled = false;
        }
        private void preencheFormulario(string ID)
        {
            SQLServerClass db = new SQLServerClass();
            string SQL = "Select [Codigo Cliente]" +
                         ",[Nome]" +
                         ",[Tipo]" +
                         ",CONVERT(VARCHAR(10), [Nascimento], 103)" +
                         ",[CPF]"+
                         ",[CNPJ]"+
                         ",[CEP]"+
                         ",[Logradouro]"+
                         ",[Bairro]"+
                         ",[Cidade]"+
                         ",[Estado]"+
                         ",[Numero]"+
                         ",[Complemento]"+
                         ",[Celular]"+
                         ",[Telefone]"+
                         ",[Email]"+
                         ",CONVERT(VARCHAR(10), [Data de cadastro], 103)" +
                         "From Tabela_Clientes where [codigo cliente] = " + ID;
            var dt = db.SqlQuery(SQL);
            txt_Codigo.Text = dt.Rows[0][0].ToString();
            txt_Nome.Text = dt.Rows[0][1].ToString();
            string tipo = dt.Rows[0][2].ToString();
            if (tipo == "Pessoa Física")
            {
                rdb_Fisica.Checked = true;
            }
            else
            {
                rdb_Juridica.Checked = true;
            }
            if (dt.Rows[0][3].ToString() == "01/01/1900")
            {
                msk_Nascimento.Text = "";
            }
            else
            {
                msk_Nascimento.Text = dt.Rows[0][3].ToString();
            }
            msk_Cpf.Text = dt.Rows[0][4].ToString();
            msk_Cnpj.Text = dt.Rows[0][5].ToString();
            msk_Cep.Text = dt.Rows[0][6].ToString();
            txt_Logradouro.Text = dt.Rows[0][7].ToString();
            txt_Bairro.Text = dt.Rows[0][8].ToString();
            txt_Cidade.Text = dt.Rows[0][9].ToString();
            cmb_Estado.Text = dt.Rows[0][10].ToString();
            txt_Numero.Text = dt.Rows[0][11].ToString();
            txt_Complemento.Text = dt.Rows[0][12].ToString();
            msk_Celular.Text = dt.Rows[0][13].ToString();
            msk_Telefone.Text = dt.Rows[0][14].ToString();
            txt_Email.Text = dt.Rows[0][15].ToString();
            txt_DataCadastro.Text = dt.Rows[0][16].ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Cliente.Unit cliente = new cls_Cliente.Unit();
                cliente.Codigo = txt_Codigo.Text;
                cliente.Nome = txt_Nome.Text;
                cliente.Nascimento = msk_Nascimento.Text;
                if (rdb_Fisica.Checked)
                {
                    cliente.Pessoa = "Pessoa Física";
                }
                if (rdb_Juridica.Checked)
                {
                    cliente.Pessoa = "Pessoa Jurídica";
                }
                string cpf = msk_Cpf.Text.Replace(".", "").Replace("-", "").Replace("_", "");
                if (cpf == "         ")
                {
                    cliente.Cpf = msk_Cpf.Text;
                }
                else
                {
                    bool validacpf = Valida.ValidaCpf(msk_Cpf.Text);
                    if (!validacpf)
                    {
                        throw new Exception("CPF inválido.");
                    }
                    else
                    {
                        cliente.Cpf = msk_Cpf.Text;
                    }
                }
                string cnpj = msk_Cnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (cnpj == "            ")
                {
                    cliente.Cnpj = msk_Cnpj.Text;
                }
                else
                {
                    bool validacnpj = Valida.ValidaCnpj(msk_Cnpj.Text);
                    if (!validacnpj)
                    {
                        throw new Exception("CNPJ inválido.");
                    }
                    else
                    {
                        cliente.Cnpj = msk_Cnpj.Text;
                    }
                }
                cliente.Cep = msk_Cep.Text;
                cliente.Logradouro = txt_Logradouro.Text;
                cliente.Bairro = txt_Bairro.Text;
                cliente.Cidade = txt_Cidade.Text;
                cliente.Estado = cmb_Estado.Text;
                cliente.Numero = txt_Numero.Text;
                cliente.Complemento = txt_Complemento.Text;
                cliente.Telefone = msk_Telefone.Text;
                cliente.Celular = msk_Celular.Text;
                cliente.Email = txt_Email.Text;
                if (cliente.ValidaClasse())
                {
                    btn_Salvar.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Cliente.Unit cliente = new cls_Cliente.Unit();
                cliente.Codigo = txt_Codigo.Text;
                cliente.Nome = txt_Nome.Text;
                cliente.Nascimento = msk_Nascimento.Text;
                if (rdb_Fisica.Checked)
                {
                    cliente.Pessoa = "Pessoa Física";
                }
                if (rdb_Juridica.Checked)
                {
                    cliente.Pessoa = "Pessoa Jurídica";
                }
                string cpf = msk_Cpf.Text.Replace(".", "").Replace("-", "").Replace("_", "");
                if (cpf == "         ")
                {
                    cliente.Cpf = msk_Cpf.Text;
                }
                else
                {
                    bool validacpf = Valida.ValidaCpf(msk_Cpf.Text);
                    if (!validacpf)
                    {
                        throw new Exception("CPF inválido.");
                    }
                    else
                    {
                        cliente.Cpf = msk_Cpf.Text;
                    }
                }
                string cnpj = msk_Cnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (cnpj == "            ")
                {
                    cliente.Cnpj = msk_Cnpj.Text;
                }
                else
                {
                    bool validacnpj = Valida.ValidaCnpj(msk_Cnpj.Text);
                    if (!validacnpj)
                    {
                        throw new Exception("CNPJ inválido.");
                    }
                    else
                    {
                        cliente.Cnpj = msk_Cnpj.Text;
                    }
                }
                cliente.Cep = msk_Cep.Text;
                cliente.Logradouro = txt_Logradouro.Text;
                cliente.Bairro = txt_Bairro.Text;
                cliente.Cidade = txt_Cidade.Text;
                cliente.Estado = cmb_Estado.Text;
                cliente.Numero = txt_Numero.Text;
                cliente.Complemento = txt_Complemento.Text;
                cliente.Telefone = msk_Telefone.Text;
                cliente.Celular = msk_Celular.Text;
                cliente.Email = txt_Email.Text;
                if (cliente.ValidaClasse())
                {
                    cliente.UpdateCliente(txt_Codigo.Text);
                    MessageBox.Show("Cadastro alterado com sucesso.", "Program Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void pcb_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Cliente.Unit cliente = new cls_Cliente.Unit();
                cliente.Codigo = txt_Codigo.Text;
                cliente.Nome = txt_Nome.Text;
                cliente.Nascimento = msk_Nascimento.Text;
                if (rdb_Fisica.Checked)
                {
                    cliente.Pessoa = "Pessoa Física";
                }
                if (rdb_Juridica.Checked)
                {
                    cliente.Pessoa = "Pessoa Jurídica";
                }
                string cpf = msk_Cpf.Text.Replace(".", "").Replace("-", "").Replace("_", "");
                if (cpf == "         ")
                {
                    cliente.Cpf = msk_Cpf.Text;
                }
                else
                {
                    bool validacpf = Valida.ValidaCpf(msk_Cpf.Text);
                    if (!validacpf)
                    {
                        throw new Exception("CPF inválido.");
                    }
                    else
                    {
                        cliente.Cpf = msk_Cpf.Text;
                    }
                }
                string cnpj = msk_Cnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (cnpj == "            ")
                {
                    cliente.Cnpj = msk_Cnpj.Text;
                }
                else
                {
                    bool validacnpj = Valida.ValidaCnpj(msk_Cnpj.Text);
                    if (!validacnpj)
                    {
                        throw new Exception("CNPJ inválido.");
                    }
                    else
                    {
                        cliente.Cnpj = msk_Cnpj.Text;
                    }
                }
                cliente.Cep = msk_Cep.Text;
                cliente.Logradouro = txt_Logradouro.Text;
                cliente.Bairro = txt_Bairro.Text;
                cliente.Cidade = txt_Cidade.Text;
                cliente.Estado = cmb_Estado.Text;
                cliente.Numero = txt_Numero.Text;
                cliente.Complemento = txt_Complemento.Text;
                cliente.Telefone = msk_Telefone.Text;
                cliente.Celular = msk_Celular.Text;
                cliente.Email = txt_Email.Text;
                if (cliente.ValidaClasse())
                {
                    cliente.UpdateCliente(txt_Codigo.Text);
                    MessageBox.Show("Cadastro alterado com sucesso.", "Program Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
                cls_Cliente.Unit cliente = new cls_Cliente.Unit();
                cliente.Codigo = txt_Codigo.Text;
                cliente.Nome = txt_Nome.Text;
                cliente.Nascimento = msk_Nascimento.Text;
                if (rdb_Fisica.Checked)
                {
                    cliente.Pessoa = "Pessoa Física";
                }
                if (rdb_Juridica.Checked)
                {
                    cliente.Pessoa = "Pessoa Jurídica";
                }
                string cpf = msk_Cpf.Text.Replace(".", "").Replace("-", "").Replace("_", "");
                if (cpf == "         ")
                {
                    cliente.Cpf = msk_Cpf.Text;
                }
                else
                {
                    bool validacpf = Valida.ValidaCpf(msk_Cpf.Text);
                    if (!validacpf)
                    {
                        throw new Exception("CPF inválido.");
                    }
                    else
                    {
                        cliente.Cpf = msk_Cpf.Text;
                    }
                }
                string cnpj = msk_Cnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (cnpj == "            ")
                {
                    cliente.Cnpj = msk_Cnpj.Text;
                }
                else
                {
                    bool validacnpj = Valida.ValidaCnpj(msk_Cnpj.Text);
                    if (!validacnpj)
                    {
                        throw new Exception("CNPJ inválido.");
                    }
                    else
                    {
                        cliente.Cnpj = msk_Cnpj.Text;
                    }
                }
                cliente.Cep = msk_Cep.Text;
                cliente.Logradouro = txt_Logradouro.Text;
                cliente.Bairro = txt_Bairro.Text;
                cliente.Cidade = txt_Cidade.Text;
                cliente.Estado = cmb_Estado.Text;
                cliente.Numero = txt_Numero.Text;
                cliente.Complemento = txt_Complemento.Text;
                cliente.Telefone = msk_Telefone.Text;
                cliente.Celular = msk_Celular.Text;
                cliente.Email = txt_Email.Text;
                if (cliente.ValidaClasse())
                {
                    btn_Salvar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
