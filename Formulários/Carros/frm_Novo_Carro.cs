using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class frm_Novo_Carro : Form
    {
        public frm_Novo_Carro()
        {
            InitializeComponent();
            rdb_Carro.Select();
            cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmb_Marca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Marca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_Marca.MaxDropDownItems = 5;
            cmb_Proprietario.MaxDropDownItems = 10;
            cls_Carro.Unit carro = new cls_Carro.Unit();
            txt_Numero.Text = carro.GeraCodigo().ToString();

        }   
                       
     

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try {
                cls_Carro.Unit carro = new cls_Carro.Unit();
                carro.Codigo = txt_Numero.Text;
                string proprietario = this.regexProprietario(cmb_Proprietario.Text);
                carro.Proprietario = proprietario;
                carro.CodigoCliente = carro.SelectCodigoCliente(cmb_Proprietario.Text);
                if ( carro.CodigoCliente.Length > 0 )
                {
                    if (rdb_Carro.Checked)
                    {
                        carro.Categoria = "Carro";
                    }
                    if (rdb_Caminhao.Checked)
                    {
                        carro.Categoria = "Caminhão";
                    }
                    if (rdb_Van.Checked)
                    {
                        carro.Categoria = "Van";
                    }
                    if (rdb_Agricola.Checked)
                    {
                        carro.Categoria = "Máquinha Agricola";
                    }
                    carro.Marca = cmb_Marca.Text;
                    carro.Modelo = cmb_Modelo.Text;
                    carro.Placa = txt_Placa.Text;
                    carro.Ano = txt_Ano.Text;
                    carro.Cor = txt_Cor.Text;
                    carro.Chassi = txt_Chassi.Text;
                    carro.DataCadastro = DateTime.UtcNow.ToString("dd/MM/yyyy");
                    if (carro.ValidaClasse())
                    {
                        carro.InsertCarro();
                        MessageBox.Show("Veículo cadastrado com sucesso!", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Veículo inválido.");
                    }
                }
                
                else
                {
                    throw new Exception("Cliente inválido.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void pcb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Carro.Unit carro = new cls_Carro.Unit();
                carro.Codigo = txt_Numero.Text;
                string proprietario = this.regexProprietario(cmb_Proprietario.Text);
                carro.Proprietario = proprietario;
                carro.CodigoCliente = carro.SelectCodigoCliente(cmb_Proprietario.Text);
                if (carro.CodigoCliente.Length > 0)
                {
                    if (rdb_Carro.Checked)
                    {
                        carro.Categoria = "Carro";
                    }
                    if (rdb_Caminhao.Checked)
                    {
                        carro.Categoria = "Caminhão";
                    }
                    if (rdb_Van.Checked)
                    {
                        carro.Categoria = "Van";
                    }
                    if (rdb_Agricola.Checked)
                    {
                        carro.Categoria = "Máquinha Agricola";
                    }
                    carro.Marca = cmb_Marca.Text;
                    carro.Modelo = cmb_Modelo.Text;
                    carro.Placa = txt_Placa.Text;
                    carro.Ano = txt_Ano.Text;
                    carro.Cor = txt_Cor.Text;
                    carro.Chassi = txt_Chassi.Text;
                    carro.DataCadastro = DateTime.UtcNow.ToString("dd/MM/yyyy");
                    if (carro.ValidaClasse())
                    {
                        carro.InsertCarro();
                        MessageBox.Show("Veículo cadastrado com sucesso!", "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Veículo inválido.");
                    }
                }

                else
                {
                    throw new Exception("Cliente inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string regexProprietario(string proprietario)
        {
            proprietario = proprietario.Replace("Nº","").Replace("     ", "");
            proprietario = Regex.Replace(proprietario,"[0-9]", "");
            return proprietario;
        }

        private void txt_CodigoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_Carro.Unit car = new cls_Carro.Unit();
                cmb_Proprietario.Text = car.SelectNomeCliente(txt_CodigoCliente.Text);
            }
        }
    }      
}

