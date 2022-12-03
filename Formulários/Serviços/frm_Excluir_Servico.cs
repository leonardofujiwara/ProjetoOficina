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
    public partial class frm_Excluir_Servico : Form
    {
        public frm_Excluir_Servico(string codigo)
        {
            InitializeComponent();
            preencheFormulario(codigo);
        }

        public void preencheFormulario(string codigo)
        {
            cls_Servico.Unit serv = new cls_Servico.Unit();
            var dt = serv.SelectServicoFormulario(codigo);
            txt_Codigo.Text = dt.Rows[0][0].ToString();
            txt_Nome.Text = dt.Rows[0][1].ToString();
            txt_Venda.Text = float.Parse(dt.Rows[0][2].ToString()).ToString("0.00");
            txt_Descricao.Text = dt.Rows[0][3].ToString();
            txt_Referencia.Text = dt.Rows[0][6].ToString();
            if (dt.Rows[0][4].ToString().Length > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dg_Produtos.Rows.Add(dt.Rows[i][4].ToString(),
                                         dt.Rows[i][5].ToString(),
                                         dt.Rows[i][7].ToString(),
                                         dt.Rows[i][8].ToString() + " " + dt.Rows[i][9].ToString());
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir serviço com id : '" + "'" + txt_Codigo.Text + "'" + "' ?",
                                                  "Programa Oficina", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    cls_Servico.Unit serv = new cls_Servico.Unit();
                    serv.DeleteServico(txt_Codigo.Text);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
