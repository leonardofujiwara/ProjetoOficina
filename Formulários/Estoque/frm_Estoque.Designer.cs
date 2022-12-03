namespace Programa_Oficina.Formulários.Estoque
{
    partial class frm_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Estoque));
            this.grp_Adicionar = new System.Windows.Forms.GroupBox();
            this.cmb_Codigo = new System.Windows.Forms.ComboBox();
            this.cmb_Referencia = new System.Windows.Forms.ComboBox();
            this.txt_Fornecedor = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.msk_Validade = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Venda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Compra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lbl_Unidade = new System.Windows.Forms.Label();
            this.txt_Embalagem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Nome = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_PesquisaGrid = new System.Windows.Forms.GroupBox();
            this.cmb_Periodo = new System.Windows.Forms.ComboBox();
            this.lbl_Periodo = new System.Windows.Forms.Label();
            this.chb_Validade = new System.Windows.Forms.CheckBox();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.lbl_Datainicial = new System.Windows.Forms.Label();
            this.lbl_Datafinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_FiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.lbl_ValorPesquisa = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_FiltroPesquisa = new System.Windows.Forms.Button();
            this.dg_Estoque = new System.Windows.Forms.DataGridView();
            this.col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Adicionar_Produto = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.pct_Pesquisar = new System.Windows.Forms.PictureBox();
            this.grp_Adicionar.SuspendLayout();
            this.grp_PesquisaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Pesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Adicionar
            // 
            this.grp_Adicionar.Controls.Add(this.cmb_Codigo);
            this.grp_Adicionar.Controls.Add(this.cmb_Referencia);
            this.grp_Adicionar.Controls.Add(this.txt_Fornecedor);
            this.grp_Adicionar.Controls.Add(this.txt_Marca);
            this.grp_Adicionar.Controls.Add(this.msk_Validade);
            this.grp_Adicionar.Controls.Add(this.label15);
            this.grp_Adicionar.Controls.Add(this.label13);
            this.grp_Adicionar.Controls.Add(this.txt_Venda);
            this.grp_Adicionar.Controls.Add(this.label12);
            this.grp_Adicionar.Controls.Add(this.label10);
            this.grp_Adicionar.Controls.Add(this.txt_Compra);
            this.grp_Adicionar.Controls.Add(this.label9);
            this.grp_Adicionar.Controls.Add(this.label8);
            this.grp_Adicionar.Controls.Add(this.txt_Quantidade);
            this.grp_Adicionar.Controls.Add(this.btn_Adicionar);
            this.grp_Adicionar.Controls.Add(this.lbl_Unidade);
            this.grp_Adicionar.Controls.Add(this.txt_Embalagem);
            this.grp_Adicionar.Controls.Add(this.label7);
            this.grp_Adicionar.Controls.Add(this.label6);
            this.grp_Adicionar.Controls.Add(this.label5);
            this.grp_Adicionar.Controls.Add(this.label4);
            this.grp_Adicionar.Controls.Add(this.label3);
            this.grp_Adicionar.Controls.Add(this.cmb_Nome);
            this.grp_Adicionar.Controls.Add(this.label2);
            this.grp_Adicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grp_Adicionar.Location = new System.Drawing.Point(13, 7);
            this.grp_Adicionar.Name = "grp_Adicionar";
            this.grp_Adicionar.Size = new System.Drawing.Size(1053, 226);
            this.grp_Adicionar.TabIndex = 20;
            this.grp_Adicionar.TabStop = false;
            this.grp_Adicionar.Text = "Adiocionar Item";
            // 
            // cmb_Codigo
            // 
            this.cmb_Codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmb_Codigo.FormattingEnabled = true;
            this.cmb_Codigo.Location = new System.Drawing.Point(10, 62);
            this.cmb_Codigo.Name = "cmb_Codigo";
            this.cmb_Codigo.Size = new System.Drawing.Size(181, 25);
            this.cmb_Codigo.TabIndex = 40;
            this.cmb_Codigo.SelectedIndexChanged += new System.EventHandler(this.cmb_Codigo_SelectedIndexChanged);
            this.cmb_Codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Codigo_KeyDown);
            this.cmb_Codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Codigo_KeyUp);
            // 
            // cmb_Referencia
            // 
            this.cmb_Referencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmb_Referencia.FormattingEnabled = true;
            this.cmb_Referencia.Location = new System.Drawing.Point(10, 124);
            this.cmb_Referencia.Name = "cmb_Referencia";
            this.cmb_Referencia.Size = new System.Drawing.Size(181, 25);
            this.cmb_Referencia.TabIndex = 39;
            this.cmb_Referencia.SelectedIndexChanged += new System.EventHandler(this.cmb_Referencia_SelectedIndexChanged);
            this.cmb_Referencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Referencia_KeyDown);
            this.cmb_Referencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Referencia_KeyUp);
            // 
            // txt_Fornecedor
            // 
            this.txt_Fornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fornecedor.Location = new System.Drawing.Point(281, 124);
            this.txt_Fornecedor.Name = "txt_Fornecedor";
            this.txt_Fornecedor.Size = new System.Drawing.Size(361, 25);
            this.txt_Fornecedor.TabIndex = 38;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Marca.Location = new System.Drawing.Point(743, 62);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(181, 25);
            this.txt_Marca.TabIndex = 37;
            // 
            // msk_Validade
            // 
            this.msk_Validade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.msk_Validade.Location = new System.Drawing.Point(476, 185);
            this.msk_Validade.Mask = "00/00/0000";
            this.msk_Validade.Name = "msk_Validade";
            this.msk_Validade.Size = new System.Drawing.Size(106, 25);
            this.msk_Validade.TabIndex = 36;
            this.msk_Validade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(476, 162);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(72, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "Validade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 190);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(29, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "R$";
            // 
            // txt_Venda
            // 
            this.txt_Venda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Venda.Location = new System.Drawing.Point(253, 186);
            this.txt_Venda.Name = "txt_Venda";
            this.txt_Venda.Size = new System.Drawing.Size(150, 25);
            this.txt_Venda.TabIndex = 33;
            this.txt_Venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 185);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 162);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Preço Venda";
            // 
            // txt_Compra
            // 
            this.txt_Compra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Compra.Location = new System.Drawing.Point(41, 186);
            this.txt_Compra.Name = "txt_Compra";
            this.txt_Compra.Size = new System.Drawing.Size(114, 25);
            this.txt_Compra.TabIndex = 28;
            this.txt_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 162);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Preço Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 185);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = ": Quantidade";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(761, 185);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(80, 25);
            this.txt_Quantidade.TabIndex = 24;
            this.txt_Quantidade.Text = "1";
            this.txt_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(903, 177);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(106, 37);
            this.btn_Adicionar.TabIndex = 25;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lbl_Unidade
            // 
            this.lbl_Unidade.AutoSize = true;
            this.lbl_Unidade.Location = new System.Drawing.Point(942, 124);
            this.lbl_Unidade.Name = "lbl_Unidade";
            this.lbl_Unidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Unidade.Size = new System.Drawing.Size(71, 21);
            this.lbl_Unidade.TabIndex = 23;
            this.lbl_Unidade.Text = "Unidade";
            // 
            // txt_Embalagem
            // 
            this.txt_Embalagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Embalagem.Location = new System.Drawing.Point(743, 124);
            this.txt_Embalagem.Name = "txt_Embalagem";
            this.txt_Embalagem.Size = new System.Drawing.Size(193, 25);
            this.txt_Embalagem.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 100);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Embalagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 38);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 100);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cód. Referência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cód. Produto";
            // 
            // cmb_Nome
            // 
            this.cmb_Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_Nome.FormattingEnabled = true;
            this.cmb_Nome.Location = new System.Drawing.Point(281, 62);
            this.cmb_Nome.Name = "cmb_Nome";
            this.cmb_Nome.Size = new System.Drawing.Size(361, 25);
            this.cmb_Nome.TabIndex = 12;
            this.cmb_Nome.SelectedIndexChanged += new System.EventHandler(this.cmb_Nome_SelectedIndexChanged);
            this.cmb_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Nome_KeyDown);
            this.cmb_Nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Nome_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Produto";
            // 
            // grp_PesquisaGrid
            // 
            this.grp_PesquisaGrid.Controls.Add(this.cmb_Periodo);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_Periodo);
            this.grp_PesquisaGrid.Controls.Add(this.chb_Validade);
            this.grp_PesquisaGrid.Controls.Add(this.dt_Inicial);
            this.grp_PesquisaGrid.Controls.Add(this.dt_Final);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_Datainicial);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_Datafinal);
            this.grp_PesquisaGrid.Controls.Add(this.label1);
            this.grp_PesquisaGrid.Controls.Add(this.cmb_FiltroPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_ValorPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.txt_Pesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.pct_Pesquisar);
            this.grp_PesquisaGrid.Controls.Add(this.btn_FiltroPesquisa);
            this.grp_PesquisaGrid.Location = new System.Drawing.Point(13, 239);
            this.grp_PesquisaGrid.Name = "grp_PesquisaGrid";
            this.grp_PesquisaGrid.Size = new System.Drawing.Size(1053, 80);
            this.grp_PesquisaGrid.TabIndex = 19;
            this.grp_PesquisaGrid.TabStop = false;
            // 
            // cmb_Periodo
            // 
            this.cmb_Periodo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_Periodo.FormattingEnabled = true;
            this.cmb_Periodo.Items.AddRange(new object[] {
            "Seleção manual",
            "Mês atual",
            "Mês anterior",
            "3 Meses",
            "6 Meses",
            "9 Meses",
            "1 ano"});
            this.cmb_Periodo.Location = new System.Drawing.Point(641, 16);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Size = new System.Drawing.Size(155, 25);
            this.cmb_Periodo.TabIndex = 24;
            // 
            // lbl_Periodo
            // 
            this.lbl_Periodo.AutoSize = true;
            this.lbl_Periodo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Periodo.Location = new System.Drawing.Point(544, 16);
            this.lbl_Periodo.Name = "lbl_Periodo";
            this.lbl_Periodo.Size = new System.Drawing.Size(98, 21);
            this.lbl_Periodo.TabIndex = 23;
            this.lbl_Periodo.Text = "Período de :";
            // 
            // chb_Validade
            // 
            this.chb_Validade.AutoSize = true;
            this.chb_Validade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chb_Validade.Location = new System.Drawing.Point(809, 17);
            this.chb_Validade.Name = "chb_Validade";
            this.chb_Validade.Size = new System.Drawing.Size(151, 25);
            this.chb_Validade.TabIndex = 21;
            this.chb_Validade.Text = "Data de Validade";
            this.chb_Validade.UseVisualStyleBackColor = true;
            this.chb_Validade.CheckedChanged += new System.EventHandler(this.chb_Validade_CheckedChanged);
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.dt_Inicial.CustomFormat = "   dd/MM/yyyy";
            this.dt_Inicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Inicial.Location = new System.Drawing.Point(618, 46);
            this.dt_Inicial.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dt_Inicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(125, 29);
            this.dt_Inicial.TabIndex = 15;
            this.dt_Inicial.Value = new System.DateTime(2022, 6, 23, 0, 0, 0, 0);
            // 
            // dt_Final
            // 
            this.dt_Final.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.dt_Final.CustomFormat = "   dd/MM/yyyy";
            this.dt_Final.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Final.Location = new System.Drawing.Point(809, 46);
            this.dt_Final.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dt_Final.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(125, 29);
            this.dt_Final.TabIndex = 16;
            this.dt_Final.Value = new System.DateTime(2022, 6, 23, 0, 0, 0, 0);
            // 
            // lbl_Datainicial
            // 
            this.lbl_Datainicial.AutoSize = true;
            this.lbl_Datainicial.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Datainicial.Location = new System.Drawing.Point(543, 46);
            this.lbl_Datainicial.Name = "lbl_Datainicial";
            this.lbl_Datainicial.Size = new System.Drawing.Size(69, 25);
            this.lbl_Datainicial.TabIndex = 17;
            this.lbl_Datainicial.Text = "Início :";
            // 
            // lbl_Datafinal
            // 
            this.lbl_Datafinal.AutoSize = true;
            this.lbl_Datafinal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Datafinal.Location = new System.Drawing.Point(749, 49);
            this.lbl_Datafinal.Name = "lbl_Datafinal";
            this.lbl_Datafinal.Size = new System.Drawing.Size(54, 25);
            this.lbl_Datafinal.TabIndex = 18;
            this.lbl_Datafinal.Text = "Fim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 16);
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
            "Codigo Produto",
            "Referencia",
            "Nome",
            "Marca",
            "Quantidade",
            "Compra",
            "Venda",
            "Validade"});
            this.cmb_FiltroPesquisa.Location = new System.Drawing.Point(10, 49);
            this.cmb_FiltroPesquisa.Name = "cmb_FiltroPesquisa";
            this.cmb_FiltroPesquisa.Size = new System.Drawing.Size(206, 25);
            this.cmb_FiltroPesquisa.TabIndex = 1;
            // 
            // lbl_ValorPesquisa
            // 
            this.lbl_ValorPesquisa.AutoSize = true;
            this.lbl_ValorPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ValorPesquisa.Location = new System.Drawing.Point(218, 16);
            this.lbl_ValorPesquisa.Name = "lbl_ValorPesquisa";
            this.lbl_ValorPesquisa.Size = new System.Drawing.Size(0, 21);
            this.lbl_ValorPesquisa.TabIndex = 11;
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Pesquisa.Location = new System.Drawing.Point(222, 49);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(304, 25);
            this.txt_Pesquisa.TabIndex = 2;
            // 
            // btn_FiltroPesquisa
            // 
            this.btn_FiltroPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiltroPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_FiltroPesquisa.Location = new System.Drawing.Point(940, 48);
            this.btn_FiltroPesquisa.Name = "btn_FiltroPesquisa";
            this.btn_FiltroPesquisa.Size = new System.Drawing.Size(109, 29);
            this.btn_FiltroPesquisa.TabIndex = 8;
            this.btn_FiltroPesquisa.Text = "Pesquisar";
            this.btn_FiltroPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FiltroPesquisa.UseVisualStyleBackColor = true;
            this.btn_FiltroPesquisa.Click += new System.EventHandler(this.btn_FiltroPesquisa_Click);
            // 
            // dg_Estoque
            // 
            this.dg_Estoque.AllowUserToAddRows = false;
            this.dg_Estoque.AllowUserToDeleteRows = false;
            this.dg_Estoque.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Estoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Codigo,
            this.col_Referencia,
            this.col_Nome,
            this.col_Marca,
            this.col_Compra,
            this.col_Venda,
            this.col_Quantidade,
            this.col_Validade});
            this.dg_Estoque.Location = new System.Drawing.Point(13, 318);
            this.dg_Estoque.MultiSelect = false;
            this.dg_Estoque.Name = "dg_Estoque";
            this.dg_Estoque.ReadOnly = true;
            this.dg_Estoque.Size = new System.Drawing.Size(1053, 466);
            this.dg_Estoque.TabIndex = 18;
            this.dg_Estoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Estoque_CellClick);
            this.dg_Estoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Estoque_CellDoubleClick);
            // 
            // col_Codigo
            // 
            this.col_Codigo.HeaderText = "Código";
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.ReadOnly = true;
            // 
            // col_Referencia
            // 
            this.col_Referencia.HeaderText = "Referência";
            this.col_Referencia.Name = "col_Referencia";
            this.col_Referencia.ReadOnly = true;
            // 
            // col_Nome
            // 
            this.col_Nome.HeaderText = "Nome";
            this.col_Nome.Name = "col_Nome";
            this.col_Nome.ReadOnly = true;
            // 
            // col_Marca
            // 
            this.col_Marca.HeaderText = "Marca";
            this.col_Marca.Name = "col_Marca";
            this.col_Marca.ReadOnly = true;
            // 
            // col_Compra
            // 
            this.col_Compra.HeaderText = "$ Compra";
            this.col_Compra.Name = "col_Compra";
            this.col_Compra.ReadOnly = true;
            // 
            // col_Venda
            // 
            this.col_Venda.HeaderText = "$ Venda";
            this.col_Venda.Name = "col_Venda";
            this.col_Venda.ReadOnly = true;
            // 
            // col_Quantidade
            // 
            this.col_Quantidade.HeaderText = "Quantidade";
            this.col_Quantidade.Name = "col_Quantidade";
            this.col_Quantidade.ReadOnly = true;
            // 
            // col_Validade
            // 
            this.col_Validade.HeaderText = "Validade";
            this.col_Validade.Name = "col_Validade";
            this.col_Validade.ReadOnly = true;
            // 
            // btn_Adicionar_Produto
            // 
            this.btn_Adicionar_Produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar_Produto.Image = global::Programa_Oficina.Properties.Resources.add_produto_botao;
            this.btn_Adicionar_Produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Adicionar_Produto.Location = new System.Drawing.Point(598, 802);
            this.btn_Adicionar_Produto.Name = "btn_Adicionar_Produto";
            this.btn_Adicionar_Produto.Size = new System.Drawing.Size(130, 50);
            this.btn_Adicionar_Produto.TabIndex = 23;
            this.btn_Adicionar_Produto.Text = "Adicionar";
            this.btn_Adicionar_Produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Adicionar_Produto.UseVisualStyleBackColor = true;
            this.btn_Adicionar_Produto.Click += new System.EventHandler(this.btn_Adicionar_Produto_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Programa_Oficina.Properties.Resources.icons8_delete_65;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Location = new System.Drawing.Point(951, 802);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(115, 50);
            this.btn_Excluir.TabIndex = 22;
            this.btn_Excluir.Text = "Excluir ";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Image = global::Programa_Oficina.Properties.Resources.icons8_repeat_48;
            this.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alterar.Location = new System.Drawing.Point(774, 802);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(115, 50);
            this.btn_Alterar.TabIndex = 21;
            this.btn_Alterar.Text = "Alterar ";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // pct_Pesquisar
            // 
            this.pct_Pesquisar.BackgroundImage = global::Programa_Oficina.Properties.Resources.icons8_pesquisar_30;
            this.pct_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_Pesquisar.Location = new System.Drawing.Point(945, 51);
            this.pct_Pesquisar.Name = "pct_Pesquisar";
            this.pct_Pesquisar.Size = new System.Drawing.Size(22, 22);
            this.pct_Pesquisar.TabIndex = 9;
            this.pct_Pesquisar.TabStop = false;
            // 
            // frm_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 861);
            this.Controls.Add(this.btn_Adicionar_Produto);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.grp_Adicionar);
            this.Controls.Add(this.grp_PesquisaGrid);
            this.Controls.Add(this.dg_Estoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.grp_Adicionar.ResumeLayout(false);
            this.grp_Adicionar.PerformLayout();
            this.grp_PesquisaGrid.ResumeLayout(false);
            this.grp_PesquisaGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Pesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Adicionar;
        private System.Windows.Forms.GroupBox grp_PesquisaGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_FiltroPesquisa;
        private System.Windows.Forms.Label lbl_ValorPesquisa;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Button btn_FiltroPesquisa;
        private System.Windows.Forms.DataGridView dg_Estoque;
        private System.Windows.Forms.Label lbl_Unidade;
        private System.Windows.Forms.TextBox txt_Embalagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Compra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msk_Validade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Venda;
        private System.Windows.Forms.TextBox txt_Fornecedor;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.PictureBox pct_Pesquisar;
        private System.Windows.Forms.ComboBox cmb_Periodo;
        private System.Windows.Forms.Label lbl_Periodo;
        private System.Windows.Forms.CheckBox chb_Validade;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label lbl_Datainicial;
        private System.Windows.Forms.Label lbl_Datafinal;
        private System.Windows.Forms.ComboBox cmb_Codigo;
        private System.Windows.Forms.ComboBox cmb_Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Validade;
        private System.Windows.Forms.Button btn_Adicionar_Produto;
    }
}