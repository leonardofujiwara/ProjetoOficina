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
using System.Text.RegularExpressions;

namespace Programa_Oficina.Formulários.Ordem_de_Serviço
{
    public partial class UC_Cliente : UserControl
    {
        public UC_Cliente()
        {
            InitializeComponent();
        }

        private void cmb_Proprietario_KeyDown(object sender, KeyEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            if (e.KeyCode == Keys.Enter)
            {
                if (cmb_Proprietario.SelectedIndex == -1)
                {
                    cmb_Proprietario.Items.Clear();
                    cls_Cliente.Unit c = new cls_Cliente.Unit();
                    string proprietario = this.regexProprietario(cmb_Proprietario.Text);
                    cmb_Proprietario.Text = proprietario;
                    var dt = c.SelectCliente(proprietario);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmb_Proprietario.Items.Add("Nº" + dt.Rows[i][0].ToString() + "     " + dt.Rows[i][1].ToString());
                    }
                }

            }
        }

        private void cmb_Proprietario_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(cmb_Proprietario.SelectedIndex == -1))
            {
                cls_Carro.Unit car = new cls_Carro.Unit();
                string proprietario = this.regexProprietario(cmb_Proprietario.Text);
                cmb_Proprietario.Text = proprietario;
                txt_CodigoCliente.Text = car.SelectCodigoCliente(proprietario);
            }
        }

        private void cmb_Proprietario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.Default;
                if (cmb_Proprietario.SelectedIndex == -1)
                {
                    cmb_Proprietario.DroppedDown = true;
                }
                else
                {
                    cls_Carro.Unit car = new cls_Carro.Unit();
                    cmb_Proprietario.Text = this.regexProprietario(cmb_Proprietario.Text);
                    txt_CodigoCliente.Text = car.SelectCodigoCliente(cmb_Proprietario.Text);
                }
            }
        }

        public void cmb_Proprietario_Leave(object sender, EventArgs e)
        {
            cls_Carro.Unit car = new cls_Carro.Unit();
            string proprietario = this.regexProprietario(cmb_Proprietario.Text);
            cmb_Proprietario.Text = proprietario;
            txt_CodigoCliente.Text = car.SelectCodigoCliente(cmb_Proprietario.Text);
        }

        private string regexProprietario(string proprietario)
        {
            proprietario = proprietario.Replace("Nº", "").Replace("     ", "");
            proprietario = Regex.Replace(proprietario, "[0-9]", "");
            return proprietario;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            cmb_Proprietario.Items.Clear();
            cls_Cliente.Unit c = new cls_Cliente.Unit();
            string proprietario = this.regexProprietario(cmb_Proprietario.Text);
            cmb_Proprietario.Text = proprietario;
            var dt = c.SelectCliente(proprietario);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_Proprietario.Items.Add("Nº" + dt.Rows[i][0].ToString() + "     " + dt.Rows[i][1].ToString());
            }
            cmb_Proprietario.DroppedDown = true;
        }

        private void UC_Cliente_Click(object sender, EventArgs e)
        {
            lbl_CodigoCliente.Focus();
        }

    }
}
