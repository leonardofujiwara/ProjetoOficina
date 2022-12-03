namespace Programa_Oficina.Formulários.Clientes
{
    partial class frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            this.dg_Clientes = new System.Windows.Forms.DataGridView();
            this.col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_FiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.lbl_Datainicial = new System.Windows.Forms.Label();
            this.lbl_Datafinal = new System.Windows.Forms.Label();
            this.btn_FiltroPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ValorPesquisa = new System.Windows.Forms.Label();
            this.chb_Data = new System.Windows.Forms.CheckBox();
            this.grp_PesquisaGrid = new System.Windows.Forms.GroupBox();
            this.lbl_Periodo = new System.Windows.Forms.Label();
            this.cmb_Periodo = new System.Windows.Forms.ComboBox();
            this.pct_Pesquisar = new System.Windows.Forms.PictureBox();
            this.grp_Botoes = new System.Windows.Forms.GroupBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo_Cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Clientes)).BeginInit();
            this.grp_PesquisaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Pesquisar)).BeginInit();
            this.grp_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_Clientes
            // 
            this.dg_Clientes.AllowUserToAddRows = false;
            this.dg_Clientes.AllowUserToDeleteRows = false;
            this.dg_Clientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Codigo,
            this.col_Nome,
            this.col_Tipo,
            this.col_Cidade,
            this.col_Estado,
            this.col_Celular,
            this.col_Telefone,
            this.col_Email,
            this.col_Cadastro});
            this.dg_Clientes.Location = new System.Drawing.Point(12, 220);
            this.dg_Clientes.MultiSelect = false;
            this.dg_Clientes.Name = "dg_Clientes";
            this.dg_Clientes.ReadOnly = true;
            this.dg_Clientes.Size = new System.Drawing.Size(1053, 529);
            this.dg_Clientes.TabIndex = 0;
            this.dg_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Clientes_CellClick);
            this.dg_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Clientes_CellDoubleClick);
            // 
            // col_Codigo
            // 
            this.col_Codigo.HeaderText = "Nº";
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.ReadOnly = true;
            // 
            // col_Nome
            // 
            this.col_Nome.HeaderText = "Nome";
            this.col_Nome.Name = "col_Nome";
            this.col_Nome.ReadOnly = true;
            // 
            // col_Tipo
            // 
            this.col_Tipo.HeaderText = "Tipo de Cadastro";
            this.col_Tipo.Name = "col_Tipo";
            this.col_Tipo.ReadOnly = true;
            // 
            // col_Cidade
            // 
            this.col_Cidade.HeaderText = "Cidade";
            this.col_Cidade.Name = "col_Cidade";
            this.col_Cidade.ReadOnly = true;
            // 
            // col_Estado
            // 
            this.col_Estado.HeaderText = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.ReadOnly = true;
            // 
            // col_Celular
            // 
            this.col_Celular.HeaderText = "Celular";
            this.col_Celular.Name = "col_Celular";
            this.col_Celular.ReadOnly = true;
            // 
            // col_Telefone
            // 
            this.col_Telefone.HeaderText = "Telefone";
            this.col_Telefone.Name = "col_Telefone";
            this.col_Telefone.ReadOnly = true;
            // 
            // col_Email
            // 
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            this.col_Email.ReadOnly = true;
            // 
            // col_Cadastro
            // 
            this.col_Cadastro.HeaderText = "Data de Cadastro";
            this.col_Cadastro.Name = "col_Cadastro";
            this.col_Cadastro.ReadOnly = true;
            // 
            // cmb_FiltroPesquisa
            // 
            this.cmb_FiltroPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_FiltroPesquisa.FormattingEnabled = true;
            this.cmb_FiltroPesquisa.Items.AddRange(new object[] {
            "Codigo do Cliente",
            "Nome",
            "Tipo",
            "Cidade",
            "Estado",
            "Celular",
            "Telefone",
            "Email"});
            this.cmb_FiltroPesquisa.Location = new System.Drawing.Point(10, 48);
            this.cmb_FiltroPesquisa.Name = "cmb_FiltroPesquisa";
            this.cmb_FiltroPesquisa.Size = new System.Drawing.Size(206, 25);
            this.cmb_FiltroPesquisa.TabIndex = 1;
            this.cmb_FiltroPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltroPesquisa_SelectedIndexChanged);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Pesquisa.Location = new System.Drawing.Point(222, 48);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(304, 25);
            this.txt_Pesquisa.TabIndex = 2;
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.dt_Inicial.CustomFormat = "   dd/MM/yyyy";
            this.dt_Inicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Inicial.Location = new System.Drawing.Point(612, 45);
            this.dt_Inicial.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dt_Inicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(125, 29);
            this.dt_Inicial.TabIndex = 3;
            this.dt_Inicial.Value = new System.DateTime(2022, 6, 23, 0, 0, 0, 0);
            this.dt_Inicial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dt_Inicial_MouseUp);
            // 
            // dt_Final
            // 
            this.dt_Final.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.dt_Final.CustomFormat = "   dd/MM/yyyy";
            this.dt_Final.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Final.Location = new System.Drawing.Point(803, 45);
            this.dt_Final.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dt_Final.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(125, 29);
            this.dt_Final.TabIndex = 5;
            this.dt_Final.Value = new System.DateTime(2022, 6, 23, 0, 0, 0, 0);
            this.dt_Final.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dt_Final_MouseUp);
            // 
            // lbl_Datainicial
            // 
            this.lbl_Datainicial.AutoSize = true;
            this.lbl_Datainicial.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Datainicial.Location = new System.Drawing.Point(537, 45);
            this.lbl_Datainicial.Name = "lbl_Datainicial";
            this.lbl_Datainicial.Size = new System.Drawing.Size(69, 25);
            this.lbl_Datainicial.TabIndex = 6;
            this.lbl_Datainicial.Text = "Início :";
            // 
            // lbl_Datafinal
            // 
            this.lbl_Datafinal.AutoSize = true;
            this.lbl_Datafinal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Datafinal.Location = new System.Drawing.Point(743, 48);
            this.lbl_Datafinal.Name = "lbl_Datafinal";
            this.lbl_Datafinal.Size = new System.Drawing.Size(54, 25);
            this.lbl_Datafinal.TabIndex = 7;
            this.lbl_Datafinal.Text = "Fim :";
            // 
            // btn_FiltroPesquisa
            // 
            this.btn_FiltroPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FiltroPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_FiltroPesquisa.Location = new System.Drawing.Point(936, 44);
            this.btn_FiltroPesquisa.Name = "btn_FiltroPesquisa";
            this.btn_FiltroPesquisa.Size = new System.Drawing.Size(109, 29);
            this.btn_FiltroPesquisa.TabIndex = 8;
            this.btn_FiltroPesquisa.Text = "Pesquisar";
            this.btn_FiltroPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FiltroPesquisa.UseVisualStyleBackColor = true;
            this.btn_FiltroPesquisa.Click += new System.EventHandler(this.btn_FiltroPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro de Pesquisa";
            // 
            // lbl_ValorPesquisa
            // 
            this.lbl_ValorPesquisa.AutoSize = true;
            this.lbl_ValorPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ValorPesquisa.Location = new System.Drawing.Point(218, 15);
            this.lbl_ValorPesquisa.Name = "lbl_ValorPesquisa";
            this.lbl_ValorPesquisa.Size = new System.Drawing.Size(0, 21);
            this.lbl_ValorPesquisa.TabIndex = 11;
            // 
            // chb_Data
            // 
            this.chb_Data.AutoSize = true;
            this.chb_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chb_Data.Location = new System.Drawing.Point(803, 16);
            this.chb_Data.Name = "chb_Data";
            this.chb_Data.Size = new System.Drawing.Size(154, 25);
            this.chb_Data.TabIndex = 12;
            this.chb_Data.Text = "Data de Cadastro";
            this.chb_Data.UseVisualStyleBackColor = true;
            this.chb_Data.CheckedChanged += new System.EventHandler(this.chb_Data_CheckedChanged);
            // 
            // grp_PesquisaGrid
            // 
            this.grp_PesquisaGrid.Controls.Add(this.lbl_Periodo);
            this.grp_PesquisaGrid.Controls.Add(this.cmb_Periodo);
            this.grp_PesquisaGrid.Controls.Add(this.label1);
            this.grp_PesquisaGrid.Controls.Add(this.chb_Data);
            this.grp_PesquisaGrid.Controls.Add(this.cmb_FiltroPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_ValorPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.txt_Pesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.dt_Inicial);
            this.grp_PesquisaGrid.Controls.Add(this.pct_Pesquisar);
            this.grp_PesquisaGrid.Controls.Add(this.dt_Final);
            this.grp_PesquisaGrid.Controls.Add(this.btn_FiltroPesquisa);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_Datainicial);
            this.grp_PesquisaGrid.Controls.Add(this.lbl_Datafinal);
            this.grp_PesquisaGrid.Location = new System.Drawing.Point(12, 141);
            this.grp_PesquisaGrid.Name = "grp_PesquisaGrid";
            this.grp_PesquisaGrid.Size = new System.Drawing.Size(1053, 80);
            this.grp_PesquisaGrid.TabIndex = 13;
            this.grp_PesquisaGrid.TabStop = false;
            // 
            // lbl_Periodo
            // 
            this.lbl_Periodo.AutoSize = true;
            this.lbl_Periodo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Periodo.Location = new System.Drawing.Point(538, 15);
            this.lbl_Periodo.Name = "lbl_Periodo";
            this.lbl_Periodo.Size = new System.Drawing.Size(98, 21);
            this.lbl_Periodo.TabIndex = 14;
            this.lbl_Periodo.Text = "Período de :";
            // 
            // cmb_Periodo
            // 
            this.cmb_Periodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Periodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Periodo.FormattingEnabled = true;
            this.cmb_Periodo.Items.AddRange(new object[] {
            "Seleção manual",
            "Mês atual",
            "Mês anterior",
            "3 Meses",
            "6 Meses",
            "9 Meses",
            "1 ano"});
            this.cmb_Periodo.Location = new System.Drawing.Point(642, 15);
            this.cmb_Periodo.Name = "cmb_Periodo";
            this.cmb_Periodo.Size = new System.Drawing.Size(141, 25);
            this.cmb_Periodo.TabIndex = 13;
            this.cmb_Periodo.SelectedIndexChanged += new System.EventHandler(this.cmb_Periodo_SelectedIndexChanged);
            // 
            // pct_Pesquisar
            // 
            this.pct_Pesquisar.BackgroundImage = global::Programa_Oficina.Properties.Resources.icons8_pesquisar_30;
            this.pct_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_Pesquisar.Location = new System.Drawing.Point(945, 47);
            this.pct_Pesquisar.Name = "pct_Pesquisar";
            this.pct_Pesquisar.Size = new System.Drawing.Size(22, 22);
            this.pct_Pesquisar.TabIndex = 9;
            this.pct_Pesquisar.TabStop = false;
            // 
            // grp_Botoes
            // 
            this.grp_Botoes.Controls.Add(this.btn_Excluir);
            this.grp_Botoes.Controls.Add(this.btn_Alterar);
            this.grp_Botoes.Controls.Add(this.btn_Novo_Cliente);
            this.grp_Botoes.Location = new System.Drawing.Point(12, 3);
            this.grp_Botoes.Name = "grp_Botoes";
            this.grp_Botoes.Size = new System.Drawing.Size(1053, 137);
            this.grp_Botoes.TabIndex = 14;
            this.grp_Botoes.TabStop = false;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::Programa_Oficina.Properties.Resources.icons8_delete_view_80;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Excluir.Location = new System.Drawing.Point(722, 16);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(113, 113);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Cadastro";
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
            // btn_Novo_Cliente
            // 
            this.btn_Novo_Cliente.BackgroundImage = global::Programa_Oficina.Properties.Resources.Webp_net_resizeimage;
            this.btn_Novo_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Novo_Cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo_Cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Novo_Cliente.Location = new System.Drawing.Point(233, 16);
            this.btn_Novo_Cliente.Name = "btn_Novo_Cliente";
            this.btn_Novo_Cliente.Size = new System.Drawing.Size(113, 113);
            this.btn_Novo_Cliente.TabIndex = 0;
            this.btn_Novo_Cliente.Text = "Novo Cliente";
            this.btn_Novo_Cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novo_Cliente.UseVisualStyleBackColor = true;
            this.btn_Novo_Cliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 761);
            this.Controls.Add(this.grp_Botoes);
            this.Controls.Add(this.grp_PesquisaGrid);
            this.Controls.Add(this.dg_Clientes);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Clientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Clientes)).EndInit();
            this.grp_PesquisaGrid.ResumeLayout(false);
            this.grp_PesquisaGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Pesquisar)).EndInit();
            this.grp_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dg_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cadastro;
        private System.Windows.Forms.ComboBox cmb_FiltroPesquisa;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label lbl_Datainicial;
        private System.Windows.Forms.Label lbl_Datafinal;
        private System.Windows.Forms.Button btn_FiltroPesquisa;
        private System.Windows.Forms.PictureBox pct_Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ValorPesquisa;
        private System.Windows.Forms.CheckBox chb_Data;
        private System.Windows.Forms.GroupBox grp_PesquisaGrid;
        private System.Windows.Forms.GroupBox grp_Botoes;
        private System.Windows.Forms.Button btn_Novo_Cliente;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label lbl_Periodo;
        private System.Windows.Forms.ComboBox cmb_Periodo;
    }
}