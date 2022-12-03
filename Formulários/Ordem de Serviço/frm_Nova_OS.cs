using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa_Oficina.Formulários.Produtos;

namespace Programa_Oficina.Formulários.Ordem_de_Serviço
{
    public partial class frm_Nova_OS : Form
    {
        public static frm_Nova_OS copia;
        public Label valorTotal;
        public Label Status;
        public Label valorComissao;
        public frm_Nova_OS()
        {
            InitializeComponent();
            TabPage tb = new TabPage();
            UC_Cliente cliente = new UC_Cliente();
            cliente.Dock = DockStyle.Fill;
            tb.Name = "Dados do Cliente/Veículo";
            tb.Text = "Dados do Cliente/Veículo";
            tb.Controls.Add(cliente);
            tbc_OS.TabPages.Add(tb);
            copia = this;
            valorTotal = lbl_total;
            Status = lbl_Status;
            valorComissao = lbl_Comissao;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
