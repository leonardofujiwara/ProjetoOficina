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

namespace Programa_Oficina.Formulários.Clientes
{
    public partial class frm_Novo_Cliente : Form
    {
        public frm_Novo_Cliente()
        {
            InitializeComponent();
            rdb_Fisica.Select();
            msk_Cnpj.Enabled = false;
            cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmb_Estado.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Estado.AutoCompleteSource = AutoCompleteSource.ListItems;
            cls_Cliente.Unit cliente = new cls_Cliente.Unit();
            txt_Codigo.Text = cliente.GeraCodigo().ToString();
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
            catch(Exception ex)
            {
                return "";
            }

        }

        private void btn_Fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msk_Cep_KeyDown_1(object sender, KeyEventArgs e)
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

        private void msk_Cep_Leave_1(object sender, EventArgs e)
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

        private void rdb_Fisica_CheckedChanged_1(object sender, EventArgs e)
        {
            msk_Cpf.Enabled = true;
            msk_Cnpj.Enabled = false;
        }

        private void rdb_Juridica_CheckedChanged(object sender, EventArgs e)
        {
            msk_Cpf.Enabled = false;
            msk_Cnpj.Enabled = true;
        }

        private void btn_Salvar_Click_1(object sender, EventArgs e)
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
                    cliente.InsertCliente();
                    MessageBox.Show("Cliente cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcb_Fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_Salvar_Click_1(object sender, EventArgs e)
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
                    cliente.InsertCliente();
                    MessageBox.Show("Cliente cadastrado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
