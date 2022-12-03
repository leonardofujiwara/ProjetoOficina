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
    public partial class frm_Excluir_Cadastro : Form
    {
        public frm_Excluir_Cadastro(string ID)
        {
            InitializeComponent();
            preencheFormulario(ID);
        }

        private void preencheFormulario(string ID)
        {
            SQLServerClass db = new SQLServerClass();
            string SQL = "Select [Codigo Cliente]" +
                         ",[Nome]" +
                         ",[Tipo]" +
                         ",CONVERT(VARCHAR(10), [Nascimento], 103)" +
                         ",[CPF]" +
                         ",[CNPJ]" +
                         ",[CEP]" +
                         ",[Logradouro]" +
                         ",[Bairro]" +
                         ",[Cidade]" +
                         ",[Estado]" +
                         ",[Numero]" +
                         ",[Complemento]" +
                         ",[Celular]" +
                         ",[Telefone]" +
                         ",[Email]" +
                         ",CONVERT(VARCHAR(10), [Data de cadastro], 103)" +
                         "From Tabela_Clientes where [codigo cliente] = " + ID;
            var dt = db.SqlQuery(SQL);
            tx_Codigo.Text = dt.Rows[0][0].ToString();
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
            tx_DataCadastro.Text = dt.Rows[0][16].ToString();
        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir o cliente " + txt_Nome.Text + "?", "Programa Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    cls_Cliente.Unit cliente = new cls_Cliente.Unit();
                    cliente.DeleteCliente(tx_Codigo.Text);
                    MessageBox.Show("Cadastro excluído com sucesso", "Programa Oficina",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
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
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir o cliente " + txt_Nome.Text + "?", "Programa Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    cls_Cliente.Unit cliente = new cls_Cliente.Unit();
                    cliente.DeleteCliente(tx_Codigo.Text);
                    MessageBox.Show("Cadastro excluído com sucesso", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
