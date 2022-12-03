namespace Programa_Oficina.Formulários.Produtos
{
    partial class frm_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Produtos));
            this.grp_Botoes = new System.Windows.Forms.GroupBox();
            this.grp_PesquisaGrid = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_FiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.lbl_ValorPesquisa = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_FiltroPesquisa = new System.Windows.Forms.Button();
            this.dg_Produtos = new System.Windows.Forms.DataGridView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo_Produto = new System.Windows.Forms.Button();
            this.pct_Pesquisar = new System.Windows.Forms.PictureBox();
            this.col_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Botoes.SuspendLayout();
            this.grp_PesquisaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Pesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Botoes
            // 
            this.grp_Botoes.Controls.Add(this.btn_Excluir);
            this.grp_Botoes.Controls.Add(this.btn_Alterar);
            this.grp_Botoes.Controls.Add(this.btn_Novo_Produto);
            this.grp_Botoes.Location = new System.Drawing.Point(13, 7);
            this.grp_Botoes.Name = "grp_Botoes";
            this.grp_Botoes.Size = new System.Drawing.Size(1053, 137);
            this.grp_Botoes.TabIndex = 17;
            this.grp_Botoes.TabStop = false;
            // 
            // grp_PesquisaGrid
            // 
            this.grp_PesquisaGrid.Controls.Add(this.label1);
            this.grp_PesquisaGrid.Controls.Add(this.cmb_FiltroPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_ValorPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.txt_Pesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.pct_Pesquisar);
            this.grp_PesquisaGrid.Controls.Add(this.btn_FiltroPesquisa);
            this.grp_PesquisaGrid.Location = new System.Drawing.Point(13, 145);
            this.grp_PesquisaGrid.Name = "grp_PesquisaGrid";
            this.grp_PesquisaGrid.Size = new System.Drawing.Size(1053, 80);
            this.grp_PesquisaGrid.TabIndex = 16;
            this.grp_PesquisaGrid.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(193, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro de Pesquisa";
            // 
            // cmb_FiltroPesquisa
            // 
            this.cmb_FiltroPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_FiltroPesquisa.FormattingEnabled = true;
            this.cmb_FiltroPesquisa.Items.AddRange(new object[] {
            "Código Produto",
            "Referencia",
            "Nome",
            "Marca",
            "Fornecedor",
            "Quantidade",
            "Unidade"});
            this.cmb_FiltroPesquisa.Location = new System.Drawing.Point(197, 49);
            this.cmb_FiltroPesquisa.Name = "cmb_FiltroPesquisa";
            this.cmb_FiltroPesquisa.Size = new System.Drawing.Size(206, 25);
            this.cmb_FiltroPesquisa.TabIndex = 1;
            this.cmb_FiltroPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltroPesquisa_SelectedIndexChanged);
            // 
            // lbl_ValorPesquisa
            // 
            this.lbl_ValorPesquisa.AutoSize = true;
            this.lbl_ValorPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ValorPesquisa.Location = new System.Drawing.Point(405, 16);
            this.lbl_ValorPesquisa.Name = "lbl_ValorPesquisa";
            this.lbl_ValorPesquisa.Size = new System.Drawing.Size(0, 21);
            this.lbl_ValorPesquisa.TabIndex = 11;
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Pesquisa.Location = new System.Drawing.Point(409, 49);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(304, 25);
            this.txt_Pesquisa.TabIndex = 2;
            this.txt_Pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pesquisa_KeyDown);
            // 
            // btn_FiltroPesquisa
            // 
            this.btn_FiltroPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiltroPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_FiltroPesquisa.Location = new System.Drawing.Point(726, 44);
            this.btn_FiltroPesquisa.Name = "btn_FiltroPesquisa";
            this.btn_FiltroPesquisa.Size = new System.Drawing.Size(109, 29);
            this.btn_FiltroPesquisa.TabIndex = 8;
            this.btn_FiltroPesquisa.Text = "Pesquisar";
            this.btn_FiltroPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FiltroPesquisa.UseVisualStyleBackColor = true;
            this.btn_FiltroPesquisa.Click += new System.EventHandler(this.btn_FiltroPesquisa_Click);
            // 
            // dg_Produtos
            // 
            this.dg_Produtos.AllowUserToAddRows = false;
            this.dg_Produtos.AllowUserToDeleteRows = false;
            this.dg_Produtos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Codigo,
            this.col_Referencia,
            this.col_Nome,
            this.col_Marca,
            this.col_Fornecedor,
            this.col_Compra,
            this.col_Venda,
            this.col_Quantidade});
            this.dg_Produtos.Location = new System.Drawing.Point(13, 224);
            this.dg_Produtos.MultiSelect = false;
            this.dg_Produtos.Name = "dg_Produtos";
            this.dg_Produtos.ReadOnly = true;
            this.dg_Produtos.Size = new System.Drawing.Size(1053, 529);
            this.dg_Produtos.TabIndex = 15;
            this.dg_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Produtos_CellClick);
            this.dg_Produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Produtos_CellDoubleClick);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Programa_Oficina.Properties.Resources.delete_produto;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Excluir.Location = new System.Drawing.Point(722, 16);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(113, 113);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Produto";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Image = global::Programa_Oficina.Properties.Resources.icons8_edit_property_80;
            this.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alterar.Location = new System.Drawing.Point(471, 16);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(113, 113);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo_Produto
            // 
            this.btn_Novo_Produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Novo_Produto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo_Produto.Image = global::Programa_Oficina.Properties.Resources.add_produto;
            this.btn_Novo_Produto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Novo_Produto.Location = new System.Drawing.Point(233, 16);
            this.btn_Novo_Produto.Name = "btn_Novo_Produto";
            this.btn_Novo_Produto.Size = new System.Drawing.Size(113, 113);
            this.btn_Novo_Produto.TabIndex = 0;
            this.btn_Novo_Produto.Text = "Novo Produto";
            this.btn_Novo_Produto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novo_Produto.UseVisualStyleBackColor = true;
            this.btn_Novo_Produto.Click += new System.EventHandler(this.btn_Novo_Produto_Click);
            // 
            // pct_Pesquisar
            // 
            this.pct_Pesquisar.BackgroundImage = global::Programa_Oficina.Properties.Resources.icons8_pesquisar_30;
            this.pct_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_Pesquisar.Location = new System.Drawing.Point(732, 47);
            this.pct_Pesquisar.Name = "pct_Pesquisar";
            this.pct_Pesquisar.Size = new System.Drawing.Size(22, 22);
            this.pct_Pesquisar.TabIndex = 9;
            this.pct_Pesquisar.TabStop = false;
            this.pct_Pesquisar.Click += new System.EventHandler(this.pct_Pesquisar_Click);
            // 
            // col_Quantidade
            // 
            this.col_Quantidade.HeaderText = "Quantidade";
            this.col_Quantidade.Name = "col_Quantidade";
            this.col_Quantidade.ReadOnly = true;
            // 
            // col_Venda
            // 
            this.col_Venda.HeaderText = "$ Venda";
            this.col_Venda.Name = "col_Venda";
            this.col_Venda.ReadOnly = true;
            // 
            // col_Compra
            // 
            this.col_Compra.HeaderText = "$ Compra";
            this.col_Compra.Name = "col_Compra";
            this.col_Compra.ReadOnly = true;
            // 
            // col_Fornecedor
            // 
            this.col_Fornecedor.HeaderText = "Fornecedor";
            this.col_Fornecedor.Name = "col_Fornecedor";
            this.col_Fornecedor.ReadOnly = true;
            // 
            // col_Marca
            // 
            this.col_Marca.HeaderText = "Marca";
            this.col_Marca.Name = "col_Marca";
            this.col_Marca.ReadOnly = true;
            // 
            // col_Nome
            // 
            this.col_Nome.HeaderText = "Nome";
            this.col_Nome.Name = "col_Nome";
            this.col_Nome.ReadOnly = true;
            // 
            // col_Referencia
            // 
            this.col_Referencia.HeaderText = "Referência";
            this.col_Referencia.Name = "col_Referencia";
            this.col_Referencia.ReadOnly = true;
            // 
            // col_Codigo
            // 
            this.col_Codigo.HeaderText = "Código";
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.ReadOnly = true;
            // 
            // frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 761);
            this.Controls.Add(this.grp_Botoes);
            this.Controls.Add(this.grp_PesquisaGrid);
            this.Controls.Add(this.dg_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Click += new System.EventHandler(this.frm_Produtos_Click);
            this.grp_Botoes.ResumeLayout(false);
            this.grp_PesquisaGrid.ResumeLayout(false);
            this.grp_PesquisaGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Pesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Botoes;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo_Produto;
        private System.Windows.Forms.GroupBox grp_PesquisaGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_FiltroPesquisa;
        private System.Windows.Forms.Label lbl_ValorPesquisa;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.PictureBox pct_Pesquisar;
        private System.Windows.Forms.DataGridView dg_Produtos;
        private System.Windows.Forms.Button btn_FiltroPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantidade;
    }
}