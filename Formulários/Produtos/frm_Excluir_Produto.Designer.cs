namespace Programa_Oficina.Formulários.Produtos
{
    partial class frm_Excluir_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Excluir_Produto));
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.grp_Descricao = new System.Windows.Forms.GroupBox();
            this.txt_Descrição = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.grp_Produto = new System.Windows.Forms.GroupBox();
            this.cmb_Unidade = new System.Windows.Forms.ComboBox();
            this.txt_Contem = new System.Windows.Forms.TextBox();
            this.lbl_Contem = new System.Windows.Forms.Label();
            this.cmb_Marca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Fornecedor = new System.Windows.Forms.ComboBox();
            this.lbl_Fornecedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Venda = new System.Windows.Forms.TextBox();
            this.lbl_Venda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Compra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Referencia = new System.Windows.Forms.TextBox();
            this.lbl_Referencia = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Código = new System.Windows.Forms.Label();
            this.pcb_Fechar = new System.Windows.Forms.PictureBox();
            this.pcb_Salvar = new System.Windows.Forms.PictureBox();
            this.grp_Descricao.SuspendLayout();
            this.grp_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Location = new System.Drawing.Point(665, 581);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(123, 42);
            this.btn_Fechar.TabIndex = 43;
            this.btn_Fechar.Text = "Fechar   ";
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Excluir.Location = new System.Drawing.Point(510, 581);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(123, 42);
            this.btn_Excluir.TabIndex = 42;
            this.btn_Excluir.Text = "Excluir   ";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // grp_Descricao
            // 
            this.grp_Descricao.Controls.Add(this.txt_Descrição);
            this.grp_Descricao.Controls.Add(this.lbl_Descricao);
            this.grp_Descricao.Location = new System.Drawing.Point(17, 441);
            this.grp_Descricao.Name = "grp_Descricao";
            this.grp_Descricao.Size = new System.Drawing.Size(771, 134);
            this.grp_Descricao.TabIndex = 41;
            this.grp_Descricao.TabStop = false;
            // 
            // txt_Descrição
            // 
            this.txt_Descrição.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descrição.Location = new System.Drawing.Point(15, 40);
            this.txt_Descrição.Multiline = true;
            this.txt_Descrição.Name = "txt_Descrição";
            this.txt_Descrição.ReadOnly = true;
            this.txt_Descrição.Size = new System.Drawing.Size(739, 82);
            this.txt_Descrição.TabIndex = 18;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.Location = new System.Drawing.Point(11, 16);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(81, 21);
            this.lbl_Descricao.TabIndex = 17;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // grp_Produto
            // 
            this.grp_Produto.Controls.Add(this.cmb_Unidade);
            this.grp_Produto.Controls.Add(this.txt_Contem);
            this.grp_Produto.Controls.Add(this.lbl_Contem);
            this.grp_Produto.Controls.Add(this.cmb_Marca);
            this.grp_Produto.Controls.Add(this.label4);
            this.grp_Produto.Controls.Add(this.cmb_Fornecedor);
            this.grp_Produto.Controls.Add(this.lbl_Fornecedor);
            this.grp_Produto.Controls.Add(this.label3);
            this.grp_Produto.Controls.Add(this.txt_Venda);
            this.grp_Produto.Controls.Add(this.lbl_Venda);
            this.grp_Produto.Controls.Add(this.label2);
            this.grp_Produto.Controls.Add(this.txt_Compra);
            this.grp_Produto.Controls.Add(this.label1);
            this.grp_Produto.Controls.Add(this.txt_Referencia);
            this.grp_Produto.Controls.Add(this.lbl_Referencia);
            this.grp_Produto.Controls.Add(this.txt_Nome);
            this.grp_Produto.Controls.Add(this.lbl_Nome);
            this.grp_Produto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Produto.Location = new System.Drawing.Point(16, 84);
            this.grp_Produto.Name = "grp_Produto";
            this.grp_Produto.Size = new System.Drawing.Size(771, 351);
            this.grp_Produto.TabIndex = 40;
            this.grp_Produto.TabStop = false;
            // 
            // cmb_Unidade
            // 
            this.cmb_Unidade.Enabled = false;
            this.cmb_Unidade.FormattingEnabled = true;
            this.cmb_Unidade.Items.AddRange(new object[] {
            "Unidade(s)",
            "ml",
            "Litro(s)",
            "gramas",
            "Kg"});
            this.cmb_Unidade.Location = new System.Drawing.Point(375, 221);
            this.cmb_Unidade.Name = "cmb_Unidade";
            this.cmb_Unidade.Size = new System.Drawing.Size(123, 25);
            this.cmb_Unidade.TabIndex = 19;
            // 
            // txt_Contem
            // 
            this.txt_Contem.Location = new System.Drawing.Point(231, 221);
            this.txt_Contem.Name = "txt_Contem";
            this.txt_Contem.ReadOnly = true;
            this.txt_Contem.Size = new System.Drawing.Size(138, 25);
            this.txt_Contem.TabIndex = 18;
            // 
            // lbl_Contem
            // 
            this.lbl_Contem.AutoSize = true;
            this.lbl_Contem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contem.Location = new System.Drawing.Point(228, 197);
            this.lbl_Contem.Name = "lbl_Contem";
            this.lbl_Contem.Size = new System.Drawing.Size(68, 21);
            this.lbl_Contem.TabIndex = 17;
            this.lbl_Contem.Text = "Contém";
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.Enabled = false;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Location = new System.Drawing.Point(405, 146);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(334, 25);
            this.cmb_Marca.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Marca";
            // 
            // cmb_Fornecedor
            // 
            this.cmb_Fornecedor.Enabled = false;
            this.cmb_Fornecedor.FormattingEnabled = true;
            this.cmb_Fornecedor.Location = new System.Drawing.Point(15, 146);
            this.cmb_Fornecedor.Name = "cmb_Fornecedor";
            this.cmb_Fornecedor.Size = new System.Drawing.Size(319, 25);
            this.cmb_Fornecedor.TabIndex = 14;
            // 
            // lbl_Fornecedor
            // 
            this.lbl_Fornecedor.AutoSize = true;
            this.lbl_Fornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fornecedor.Location = new System.Drawing.Point(11, 118);
            this.lbl_Fornecedor.Name = "lbl_Fornecedor";
            this.lbl_Fornecedor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Fornecedor.TabIndex = 13;
            this.lbl_Fornecedor.Text = "Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "R$";
            // 
            // txt_Venda
            // 
            this.txt_Venda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Venda.Location = new System.Drawing.Point(464, 307);
            this.txt_Venda.Name = "txt_Venda";
            this.txt_Venda.ReadOnly = true;
            this.txt_Venda.Size = new System.Drawing.Size(97, 29);
            this.txt_Venda.TabIndex = 11;
            // 
            // lbl_Venda
            // 
            this.lbl_Venda.AutoSize = true;
            this.lbl_Venda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Venda.Location = new System.Drawing.Point(426, 283);
            this.lbl_Venda.Name = "lbl_Venda";
            this.lbl_Venda.Size = new System.Drawing.Size(124, 21);
            this.lbl_Venda.TabIndex = 10;
            this.lbl_Venda.Text = "Preço de Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "R$";
            // 
            // txt_Compra
            // 
            this.txt_Compra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Compra.Location = new System.Drawing.Point(224, 307);
            this.txt_Compra.Name = "txt_Compra";
            this.txt_Compra.ReadOnly = true;
            this.txt_Compra.Size = new System.Drawing.Size(97, 29);
            this.txt_Compra.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Preço de Compra";
            // 
            // txt_Referencia
            // 
            this.txt_Referencia.Location = new System.Drawing.Point(405, 42);
            this.txt_Referencia.Name = "txt_Referencia";
            this.txt_Referencia.ReadOnly = true;
            this.txt_Referencia.Size = new System.Drawing.Size(334, 25);
            this.txt_Referencia.TabIndex = 6;
            // 
            // lbl_Referencia
            // 
            this.lbl_Referencia.AutoSize = true;
            this.lbl_Referencia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Referencia.Location = new System.Drawing.Point(401, 18);
            this.lbl_Referencia.Name = "lbl_Referencia";
            this.lbl_Referencia.Size = new System.Drawing.Size(169, 21);
            this.lbl_Referencia.TabIndex = 5;
            this.lbl_Referencia.Text = "Código de Referência";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(15, 42);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.ReadOnly = true;
            this.txt_Nome.Size = new System.Drawing.Size(319, 25);
            this.txt_Nome.TabIndex = 4;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(11, 18);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(55, 21);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(16, 35);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(116, 29);
            this.txt_Codigo.TabIndex = 39;
            // 
            // lbl_Código
            // 
            this.lbl_Código.AutoSize = true;
            this.lbl_Código.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Código.Location = new System.Drawing.Point(12, 11);
            this.lbl_Código.Name = "lbl_Código";
            this.lbl_Código.Size = new System.Drawing.Size(64, 21);
            this.lbl_Código.TabIndex = 38;
            this.lbl_Código.Text = "Código";
            // 
            // pcb_Fechar
            // 
            this.pcb_Fechar.Image = global::Programa_Oficina.Properties.Resources.icons8_exit_96;
            this.pcb_Fechar.Location = new System.Drawing.Point(671, 585);
            this.pcb_Fechar.Name = "pcb_Fechar";
            this.pcb_Fechar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Fechar.TabIndex = 45;
            this.pcb_Fechar.TabStop = false;
            this.pcb_Fechar.Click += new System.EventHandler(this.pcb_Fechar_Click);
            // 
            // pcb_Salvar
            // 
            this.pcb_Salvar.Image = global::Programa_Oficina.Properties.Resources.icons8_delete_65;
            this.pcb_Salvar.Location = new System.Drawing.Point(517, 585);
            this.pcb_Salvar.Name = "pcb_Salvar";
            this.pcb_Salvar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Salvar.TabIndex = 44;
            this.pcb_Salvar.TabStop = false;
            this.pcb_Salvar.Click += new System.EventHandler(this.pcb_Salvar_Click);
            // 
            // frm_Excluir_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.pcb_Fechar);
            this.Controls.Add(this.pcb_Salvar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.grp_Descricao);
            this.Controls.Add(this.grp_Produto);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Código);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Excluir_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Produto";
            this.grp_Descricao.ResumeLayout(false);
            this.grp_Descricao.PerformLayout();
            this.grp_Produto.ResumeLayout(false);
            this.grp_Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcb_Fechar;
        private System.Windows.Forms.PictureBox pcb_Salvar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.GroupBox grp_Descricao;
        private System.Windows.Forms.TextBox txt_Descrição;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.GroupBox grp_Produto;
        private System.Windows.Forms.ComboBox cmb_Unidade;
        private System.Windows.Forms.TextBox txt_Contem;
        private System.Windows.Forms.Label lbl_Contem;
        private System.Windows.Forms.ComboBox cmb_Marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Fornecedor;
        private System.Windows.Forms.Label lbl_Fornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Venda;
        private System.Windows.Forms.Label lbl_Venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Referencia;
        private System.Windows.Forms.Label lbl_Referencia;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Código;
    }
}