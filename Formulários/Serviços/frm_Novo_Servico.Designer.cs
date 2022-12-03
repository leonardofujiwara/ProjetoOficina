namespace Programa_Oficina.Formulários.Serviços
{
    partial class frm_Novo_Servico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Novo_Servico));
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.grp_Descricao = new System.Windows.Forms.GroupBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Código = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Venda = new System.Windows.Forms.Label();
            this.txt_Venda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_Produto = new System.Windows.Forms.GroupBox();
            this.dg_Produtos = new System.Windows.Forms.DataGridView();
            this.col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Referência = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Referencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Referencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Codigo_Produto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Unidade = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.cmb_Nome_Produto = new System.Windows.Forms.ComboBox();
            this.pcb_Fechar = new System.Windows.Forms.PictureBox();
            this.pcb_Salvar = new System.Windows.Forms.PictureBox();
            this.grp_Descricao.SuspendLayout();
            this.grp_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Location = new System.Drawing.Point(665, 657);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(123, 42);
            this.btn_Fechar.TabIndex = 33;
            this.btn_Fechar.Text = "Fechar   ";
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Salvar.Location = new System.Drawing.Point(510, 657);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(123, 42);
            this.btn_Salvar.TabIndex = 32;
            this.btn_Salvar.Text = "Salvar   ";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // grp_Descricao
            // 
            this.grp_Descricao.Controls.Add(this.txt_Descricao);
            this.grp_Descricao.Controls.Add(this.lbl_Descricao);
            this.grp_Descricao.Location = new System.Drawing.Point(17, 517);
            this.grp_Descricao.Name = "grp_Descricao";
            this.grp_Descricao.Size = new System.Drawing.Size(771, 134);
            this.grp_Descricao.TabIndex = 31;
            this.grp_Descricao.TabStop = false;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descricao.Location = new System.Drawing.Point(25, 40);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(721, 82);
            this.txt_Descricao.TabIndex = 18;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.Location = new System.Drawing.Point(21, 16);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(81, 21);
            this.lbl_Descricao.TabIndex = 17;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(41, 33);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(116, 29);
            this.txt_Codigo.TabIndex = 29;
            // 
            // lbl_Código
            // 
            this.lbl_Código.AutoSize = true;
            this.lbl_Código.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Código.Location = new System.Drawing.Point(37, 9);
            this.lbl_Código.Name = "lbl_Código";
            this.lbl_Código.Size = new System.Drawing.Size(64, 21);
            this.lbl_Código.TabIndex = 28;
            this.lbl_Código.Text = "Código";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(21, 21);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(55, 21);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(25, 45);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(281, 25);
            this.txt_Nome.TabIndex = 4;
            // 
            // lbl_Venda
            // 
            this.lbl_Venda.AutoSize = true;
            this.lbl_Venda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Venda.Location = new System.Drawing.Point(611, 21);
            this.lbl_Venda.Name = "lbl_Venda";
            this.lbl_Venda.Size = new System.Drawing.Size(124, 21);
            this.lbl_Venda.TabIndex = 10;
            this.lbl_Venda.Text = "Preço de Venda";
            // 
            // txt_Venda
            // 
            this.txt_Venda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Venda.Location = new System.Drawing.Point(649, 45);
            this.txt_Venda.Name = "txt_Venda";
            this.txt_Venda.Size = new System.Drawing.Size(97, 29);
            this.txt_Venda.TabIndex = 11;
            this.txt_Venda.Text = "00,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "R$";
            // 
            // grp_Produto
            // 
            this.grp_Produto.Controls.Add(this.dg_Produtos);
            this.grp_Produto.Controls.Add(this.txt_Referencia);
            this.grp_Produto.Controls.Add(this.label6);
            this.grp_Produto.Controls.Add(this.label5);
            this.grp_Produto.Controls.Add(this.cmb_Referencia);
            this.grp_Produto.Controls.Add(this.label1);
            this.grp_Produto.Controls.Add(this.cmb_Codigo_Produto);
            this.grp_Produto.Controls.Add(this.label4);
            this.grp_Produto.Controls.Add(this.label2);
            this.grp_Produto.Controls.Add(this.lbl_Unidade);
            this.grp_Produto.Controls.Add(this.txt_Quantidade);
            this.grp_Produto.Controls.Add(this.btn_Remover);
            this.grp_Produto.Controls.Add(this.btn_Adicionar);
            this.grp_Produto.Controls.Add(this.cmb_Nome_Produto);
            this.grp_Produto.Controls.Add(this.label3);
            this.grp_Produto.Controls.Add(this.txt_Venda);
            this.grp_Produto.Controls.Add(this.lbl_Venda);
            this.grp_Produto.Controls.Add(this.txt_Nome);
            this.grp_Produto.Controls.Add(this.lbl_Nome);
            this.grp_Produto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Produto.Location = new System.Drawing.Point(16, 84);
            this.grp_Produto.Name = "grp_Produto";
            this.grp_Produto.Size = new System.Drawing.Size(771, 427);
            this.grp_Produto.TabIndex = 30;
            this.grp_Produto.TabStop = false;
            // 
            // dg_Produtos
            // 
            this.dg_Produtos.AllowUserToAddRows = false;
            this.dg_Produtos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Codigo,
            this.col_Nome,
            this.col_Referência,
            this.col_Quantidade});
            this.dg_Produtos.Location = new System.Drawing.Point(25, 197);
            this.dg_Produtos.Name = "dg_Produtos";
            this.dg_Produtos.RowHeadersVisible = false;
            this.dg_Produtos.Size = new System.Drawing.Size(613, 224);
            this.dg_Produtos.TabIndex = 29;
            // 
            // col_Codigo
            // 
            this.col_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Codigo.HeaderText = "Código";
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.ReadOnly = true;
            // 
            // col_Nome
            // 
            this.col_Nome.HeaderText = "Nome do Produto";
            this.col_Nome.Name = "col_Nome";
            this.col_Nome.ReadOnly = true;
            // 
            // col_Referência
            // 
            this.col_Referência.HeaderText = "Referência";
            this.col_Referência.Name = "col_Referência";
            this.col_Referência.ReadOnly = true;
            // 
            // col_Quantidade
            // 
            this.col_Quantidade.HeaderText = "Quantidade";
            this.col_Quantidade.Name = "col_Quantidade";
            // 
            // txt_Referencia
            // 
            this.txt_Referencia.Location = new System.Drawing.Point(321, 45);
            this.txt_Referencia.Name = "txt_Referencia";
            this.txt_Referencia.Size = new System.Drawing.Size(266, 25);
            this.txt_Referencia.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Codigo Referência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(360, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Referência";
            // 
            // cmb_Referencia
            // 
            this.cmb_Referencia.FormattingEnabled = true;
            this.cmb_Referencia.IntegralHeight = false;
            this.cmb_Referencia.Location = new System.Drawing.Point(364, 165);
            this.cmb_Referencia.Name = "cmb_Referencia";
            this.cmb_Referencia.Size = new System.Drawing.Size(155, 25);
            this.cmb_Referencia.TabIndex = 24;
            this.cmb_Referencia.SelectedIndexChanged += new System.EventHandler(this.cmb_Referencia_SelectedIndexChanged);
            this.cmb_Referencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Referencia_KeyDown);
            this.cmb_Referencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Referencia_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código";
            // 
            // cmb_Codigo_Produto
            // 
            this.cmb_Codigo_Produto.FormattingEnabled = true;
            this.cmb_Codigo_Produto.IntegralHeight = false;
            this.cmb_Codigo_Produto.Location = new System.Drawing.Point(25, 165);
            this.cmb_Codigo_Produto.Name = "cmb_Codigo_Produto";
            this.cmb_Codigo_Produto.Size = new System.Drawing.Size(97, 25);
            this.cmb_Codigo_Produto.TabIndex = 22;
            this.cmb_Codigo_Produto.DropDown += new System.EventHandler(this.cmb_Codigo_Produto_DropDown);
            this.cmb_Codigo_Produto.SelectedIndexChanged += new System.EventHandler(this.cmb_Codigo_Produto_SelectedIndexChanged);
            this.cmb_Codigo_Produto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Codigo_Produto_KeyDown);
            this.cmb_Codigo_Produto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Codigo_Produto_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(534, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome do Produto";
            // 
            // lbl_Unidade
            // 
            this.lbl_Unidade.AutoSize = true;
            this.lbl_Unidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Unidade.Location = new System.Drawing.Point(644, 168);
            this.lbl_Unidade.Name = "lbl_Unidade";
            this.lbl_Unidade.Size = new System.Drawing.Size(71, 21);
            this.lbl_Unidade.TabIndex = 19;
            this.lbl_Unidade.Text = "Unidade";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(538, 165);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(100, 25);
            this.txt_Quantidade.TabIndex = 18;
            this.txt_Quantidade.Text = "00,00";
            this.txt_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Remover
            // 
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.Location = new System.Drawing.Point(642, 283);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(72, 33);
            this.btn_Remover.TabIndex = 17;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(642, 213);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(73, 33);
            this.btn_Adicionar.TabIndex = 16;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // cmb_Nome_Produto
            // 
            this.cmb_Nome_Produto.FormattingEnabled = true;
            this.cmb_Nome_Produto.IntegralHeight = false;
            this.cmb_Nome_Produto.Location = new System.Drawing.Point(140, 165);
            this.cmb_Nome_Produto.Name = "cmb_Nome_Produto";
            this.cmb_Nome_Produto.Size = new System.Drawing.Size(207, 25);
            this.cmb_Nome_Produto.TabIndex = 14;
            this.cmb_Nome_Produto.SelectedIndexChanged += new System.EventHandler(this.cmb_Nome_Produto_SelectedIndexChanged);
            this.cmb_Nome_Produto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Nome_Produto_KeyDown);
            this.cmb_Nome_Produto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Nome_Produto_KeyUp);
            // 
            // pcb_Fechar
            // 
            this.pcb_Fechar.Image = global::Programa_Oficina.Properties.Resources.icons8_exit_96;
            this.pcb_Fechar.Location = new System.Drawing.Point(671, 661);
            this.pcb_Fechar.Name = "pcb_Fechar";
            this.pcb_Fechar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Fechar.TabIndex = 35;
            this.pcb_Fechar.TabStop = false;
            this.pcb_Fechar.Click += new System.EventHandler(this.pcb_Fechar_Click);
            // 
            // pcb_Salvar
            // 
            this.pcb_Salvar.Image = global::Programa_Oficina.Properties.Resources.icons8_save_96;
            this.pcb_Salvar.Location = new System.Drawing.Point(517, 661);
            this.pcb_Salvar.Name = "pcb_Salvar";
            this.pcb_Salvar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Salvar.TabIndex = 34;
            this.pcb_Salvar.TabStop = false;
            // 
            // frm_Novo_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.pcb_Fechar);
            this.Controls.Add(this.pcb_Salvar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.grp_Descricao);
            this.Controls.Add(this.grp_Produto);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Código);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Novo_Servico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Serviço";
            this.grp_Descricao.ResumeLayout(false);
            this.grp_Descricao.PerformLayout();
            this.grp_Produto.ResumeLayout(false);
            this.grp_Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Fechar;
        private System.Windows.Forms.PictureBox pcb_Salvar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox grp_Descricao;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Código;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Venda;
        private System.Windows.Forms.TextBox txt_Venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Unidade;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ComboBox cmb_Nome_Produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Referencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Codigo_Produto;
        private System.Windows.Forms.TextBox txt_Referencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dg_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Referência;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantidade;
    }
}