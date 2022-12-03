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

namespace Programa_Oficina.Formulários.Carros
{
    public partial class frm_Excluir_Carro : Form
    {
        public frm_Excluir_Carro(string codigo)
        {
            InitializeComponent();
            preencheFormulario(codigo);
        }

        private void preencheFormulario(string codigo)
        {
            cls_Carro.Unit carro = new cls_Carro.Unit();
            var dt = carro.SelectCarro(codigo);
            txt_Numero.Text = dt.Rows[0][10].ToString();
            txt_CodigoCliente.Text = dt.Rows[0][0].ToString();
            txt_Proprietario.Text = dt.Rows[0][1].ToString();
            if (dt.Rows[0][2].ToString() == "Carro")
            {
                rdb_Carro.Checked = true;
            }
            if (dt.Rows[0][2].ToString() == "Van")
            {
                rdb_Van.Checked = true;
            }
            if (dt.Rows[0][2].ToString() == "Caminhão")
            {
                rdb_Caminhao.Checked = true;
            }
            if (dt.Rows[0][2].ToString() == "Máquinha Agricola")
            {
                rdb_Agricola.Checked = true;
            }
            txt_Marca.Text = dt.Rows[0][3].ToString();
            txt_Modelo.Text = dt.Rows[0][4].ToString();
            txt_Placa.Text = dt.Rows[0][5].ToString();
            txt_Ano.Text = dt.Rows[0][6].ToString();
            txt_Cor.Text = dt.Rows[0][7].ToString();
            txt_Chassi.Text = dt.Rows[0][8].ToString();
            txt_DataCadastro.Text = dt.Rows[0][9].ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir cadastro do veículo " + txt_Modelo.Text + " ?", "Prgrama Oficina",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cls_Carro.Unit excluir = new cls_Carro.Unit();
                excluir.DeleteCarro(txt_Numero.Text);
                MessageBox.Show("Cadastro removido com sucesso.", "Prgrama Oficina",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void pcb_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir cadastro do veículo " + txt_Modelo.Text + " ?", "Prgrama Oficina",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cls_Carro.Unit excluir = new cls_Carro.Unit();
                excluir.DeleteCarro(txt_Numero.Text);
                MessageBox.Show("Cadastro removido com sucesso.", "Prgrama Oficina",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
