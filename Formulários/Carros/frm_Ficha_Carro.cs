using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa_Oficina.Classes;

namespace Programa_Oficina.Formulários.Carros
{
    public partial class frm_Ficha_Carro : Form
    {
        public frm_Ficha_Carro(string codigo)
        {
            InitializeComponent();
            preencheFormulario(codigo);
            btn_Salvar.Enabled = false;
        }

        private void pcb_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Carro.Unit carro = new cls_Carro.Unit();
                if (carro.SelectCodigoCliente(cmb_Proprietario.Text) == txt_CodigoCliente.Text)
                {
                    if (carro.SelectNomeCliente(txt_CodigoCliente.Text) == cmb_Proprietario.Text)
                    {
                        carro.Codigo = txt_Numero.Text;
                        carro.CodigoCliente = txt_CodigoCliente.Text;
                        carro.Proprietario = cmb_Proprietario.Text;
                        carro.Marca = cmb_Marca.Text;
                        carro.Modelo = cmb_Modelo.Text;
                        carro.Ano = txt_Ano.Text;
                        carro.Cor = txt_Cor.Text;
                        carro.Placa = txt_Placa.Text;
                        carro.Chassi = txt_Chassi.Text;
                        carro.DataCadastro = txt_DataCadastro.Text;
                        if (rdb_Carro.Checked)
                        {
                            carro.Categoria = "Carro";
                        }
                        if (rdb_Van.Checked)
                        {
                            carro.Categoria = "Van";
                        }
                        if (rdb_Caminhao.Checked)
                        {
                            carro.Categoria = "Caminhão";
                        }
                        if (rdb_Agricola.Checked)
                        {
                            carro.Categoria = "Máquinha Agricola";
                        }

                        carro.ValidaClasse();
                        carro.UpdateCarro(txt_Numero.Text);
                        MessageBox.Show("Veículo alterado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                    }
                }
                else
                {
                    throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preencheFormulario(string codigo)
        {
            cls_Carro.Unit carro = new cls_Carro.Unit();
            var dt = carro.SelectCarro(codigo);
            txt_Numero.Text = dt.Rows[0][10].ToString();
            txt_CodigoCliente.Text = dt.Rows[0][0].ToString();
            cmb_Proprietario.Text = dt.Rows[0][1].ToString();
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
            cmb_Marca.Text = dt.Rows[0][3].ToString();
            cmb_Modelo.Text = dt.Rows[0][4].ToString();
            txt_Placa.Text = dt.Rows[0][5].ToString();
            txt_Ano.Text = dt.Rows[0][6].ToString();
            txt_Cor.Text = dt.Rows[0][7].ToString();
            txt_Chassi.Text = dt.Rows[0][8].ToString();
            txt_DataCadastro.Text = dt.Rows[0][9].ToString();
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

        private void cmb_Proprietario_Leave(object sender, EventArgs e)
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

        private void txt_CodigoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_Carro.Unit car = new cls_Carro.Unit();
                cmb_Proprietario.Text = car.SelectNomeCliente(txt_CodigoCliente.Text);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Carro.Unit carro = new cls_Carro.Unit();
                if (carro.SelectCodigoCliente(cmb_Proprietario.Text) == txt_CodigoCliente.Text)
                {
                    if (carro.SelectNomeCliente(txt_CodigoCliente.Text) == cmb_Proprietario.Text)
                    {
                        carro.Codigo = txt_Numero.Text;
                        carro.CodigoCliente = txt_CodigoCliente.Text;
                        carro.Proprietario = cmb_Proprietario.Text;
                        carro.Marca = cmb_Marca.Text;
                        carro.Modelo = cmb_Modelo.Text;
                        carro.Ano = txt_Ano.Text;
                        carro.Cor = txt_Cor.Text;
                        carro.Placa = txt_Placa.Text;
                        carro.Chassi = txt_Chassi.Text;
                        carro.DataCadastro = txt_DataCadastro.Text;
                        if (rdb_Carro.Checked)
                        {
                            carro.Categoria = "Carro";
                        }
                        if (rdb_Van.Checked)
                        {
                            carro.Categoria = "Van";
                        }
                        if (rdb_Caminhao.Checked)
                        {
                            carro.Categoria = "Caminhão";
                        }
                        if (rdb_Agricola.Checked)
                        {
                            carro.Categoria = "Máquinha Agricola";
                        }

                        carro.ValidaClasse();
                        if (carro.ValidaClasse())
                        {
                            btn_Salvar.Enabled = true;
                        }
                        else
                        {
                            throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                        }
                    }
                    else
                    {
                        throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
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
                cls_Carro.Unit carro = new cls_Carro.Unit();
                if (carro.SelectCodigoCliente(cmb_Proprietario.Text) == txt_CodigoCliente.Text)
                {
                    if (carro.SelectNomeCliente(txt_CodigoCliente.Text) == cmb_Proprietario.Text)
                    {
                        carro.Codigo = txt_Numero.Text;
                        carro.CodigoCliente = txt_CodigoCliente.Text;
                        carro.Proprietario = cmb_Proprietario.Text;
                        carro.Marca = cmb_Marca.Text;
                        carro.Modelo = cmb_Modelo.Text;
                        carro.Ano = txt_Ano.Text;
                        carro.Cor = txt_Cor.Text;
                        carro.Placa = txt_Placa.Text;
                        carro.Chassi = txt_Chassi.Text;
                        carro.DataCadastro = txt_DataCadastro.Text;
                        if (rdb_Carro.Checked)
                        {
                            carro.Categoria = "Carro";
                        }
                        if (rdb_Van.Checked)
                        {
                            carro.Categoria = "Van";
                        }
                        if (rdb_Caminhao.Checked)
                        {
                            carro.Categoria = "Caminhão";
                        }
                        if (rdb_Agricola.Checked)
                        {
                            carro.Categoria = "Máquinha Agricola";
                        }

                        carro.ValidaClasse();
                        if (carro.ValidaClasse())
                        {
                            btn_Salvar.Enabled = true;
                        }
                        else
                        {
                            throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                        }
                    }
                    else
                    {
                        throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Carro.Unit carro = new cls_Carro.Unit();
                if(carro.SelectCodigoCliente(cmb_Proprietario.Text) == txt_CodigoCliente.Text)
                {
                    if (carro.SelectNomeCliente(txt_CodigoCliente.Text) == cmb_Proprietario.Text)
                    {
                        carro.Codigo = txt_Numero.Text;
                        carro.CodigoCliente = txt_CodigoCliente.Text;
                        carro.Proprietario = cmb_Proprietario.Text;
                        carro.Marca = cmb_Marca.Text;
                        carro.Modelo = cmb_Modelo.Text;
                        carro.Ano = txt_Ano.Text;
                        carro.Cor = txt_Cor.Text;
                        carro.Placa = txt_Placa.Text;
                        carro.Chassi = txt_Chassi.Text;
                        carro.DataCadastro = txt_DataCadastro.Text;
                        if (rdb_Carro.Checked)
                        {
                            carro.Categoria = "Carro";
                        }
                        if (rdb_Van.Checked)
                        {
                            carro.Categoria = "Van";
                        }
                        if (rdb_Caminhao.Checked)
                        {
                            carro.Categoria = "Caminhão";
                        }
                        if (rdb_Agricola.Checked)
                        {
                            carro.Categoria = "Máquinha Agricola";
                        }

                        carro.ValidaClasse();
                        carro.UpdateCarro(txt_Numero.Text);
                        MessageBox.Show("Veículo alterado com sucesso.", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                    }
                }
                else
                {
                    throw new Exception("Código do cliente não corresponde ao nome do proprietário.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            if (btn_Salvar.Enabled)
            {
                DialogResult resultado =  MessageBox.Show("Deseja fechar a ficha sem salvar ? (as alterações serão descartadas)", "Programa Oficina", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            if (btn_Salvar.Enabled)
            {
                DialogResult resultado = MessageBox.Show("Deseja fechar a ficha sem salvar ? (as alterações serão descartadas)", "Programa Oficina", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
