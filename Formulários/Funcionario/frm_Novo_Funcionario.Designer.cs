namespace Programa_Oficina.Formulários.Funcionario
{
    partial class frm_Novo_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Novo_Funcionario));
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.grp_Contato = new System.Windows.Forms.GroupBox();
            this.msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.msk_Celular = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.grp_Endereco = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.lbl_Logradouro = new System.Windows.Forms.Label();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.msk_Cep = new System.Windows.Forms.MaskedTextBox();
            this.grp_Dados = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.msk_Rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Rg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.msk_Nascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nascimento = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.pcb_Fechar = new System.Windows.Forms.PictureBox();
            this.pcb_Salvar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grp_Valores = new System.Windows.Forms.GroupBox();
            this.cmb_Pagamento = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rdb_Mensal = new System.Windows.Forms.RadioButton();
            this.rdb_Semanal = new System.Windows.Forms.RadioButton();
            this.rdb_Diario = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Comissao_Servicos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Comissao_Produtos = new System.Windows.Forms.TextBox();
            this.lbl_Comissao_Produtos = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.grp_Contato.SuspendLayout();
            this.grp_Endereco.SuspendLayout();
            this.grp_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).BeginInit();
            this.grp_Valores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Location = new System.Drawing.Point(658, 779);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(123, 42);
            this.btn_Fechar.TabIndex = 21;
            this.btn_Fechar.Text = "Fechar   ";
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Salvar.Location = new System.Drawing.Point(503, 779);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(123, 42);
            this.btn_Salvar.TabIndex = 20;
            this.btn_Salvar.Text = "Salvar   ";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // grp_Contato
            // 
            this.grp_Contato.Controls.Add(this.msk_Telefone);
            this.grp_Contato.Controls.Add(this.msk_Celular);
            this.grp_Contato.Controls.Add(this.lbl_Telefone);
            this.grp_Contato.Controls.Add(this.lbl_Celular);
            this.grp_Contato.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_Contato.Location = new System.Drawing.Point(20, 666);
            this.grp_Contato.Name = "grp_Contato";
            this.grp_Contato.Size = new System.Drawing.Size(761, 106);
            this.grp_Contato.TabIndex = 19;
            this.grp_Contato.TabStop = false;
            this.grp_Contato.Text = "Contato";
            // 
            // msk_Telefone
            // 
            this.msk_Telefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Telefone.Location = new System.Drawing.Point(275, 62);
            this.msk_Telefone.Mask = "(00)0000-0000";
            this.msk_Telefone.Name = "msk_Telefone";
            this.msk_Telefone.Size = new System.Drawing.Size(146, 29);
            this.msk_Telefone.TabIndex = 7;
            this.msk_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msk_Celular
            // 
            this.msk_Celular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Celular.Location = new System.Drawing.Point(24, 62);
            this.msk_Celular.Mask = "(00)00000-0000";
            this.msk_Celular.Name = "msk_Celular";
            this.msk_Celular.Size = new System.Drawing.Size(146, 29);
            this.msk_Celular.TabIndex = 6;
            this.msk_Celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Telefone.Location = new System.Drawing.Point(271, 30);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(73, 21);
            this.lbl_Telefone.TabIndex = 2;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Celular.Location = new System.Drawing.Point(24, 30);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(60, 21);
            this.lbl_Celular.TabIndex = 0;
            this.lbl_Celular.Text = "Celular";
            // 
            // grp_Endereco
            // 
            this.grp_Endereco.Controls.Add(this.label7);
            this.grp_Endereco.Controls.Add(this.label6);
            this.grp_Endereco.Controls.Add(this.label5);
            this.grp_Endereco.Controls.Add(this.label4);
            this.grp_Endereco.Controls.Add(this.label3);
            this.grp_Endereco.Controls.Add(this.label2);
            this.grp_Endereco.Controls.Add(this.txt_Complemento);
            this.grp_Endereco.Controls.Add(this.lbl_Complemento);
            this.grp_Endereco.Controls.Add(this.cmb_Estado);
            this.grp_Endereco.Controls.Add(this.lbl_Estado);
            this.grp_Endereco.Controls.Add(this.txt_Cidade);
            this.grp_Endereco.Controls.Add(this.lbl_Cidade);
            this.grp_Endereco.Controls.Add(this.txt_Bairro);
            this.grp_Endereco.Controls.Add(this.lbl_Bairro);
            this.grp_Endereco.Controls.Add(this.txt_Numero);
            this.grp_Endereco.Controls.Add(this.lbl_Numero);
            this.grp_Endereco.Controls.Add(this.txt_Logradouro);
            this.grp_Endereco.Controls.Add(this.lbl_Logradouro);
            this.grp_Endereco.Controls.Add(this.lbl_Cep);
            this.grp_Endereco.Controls.Add(this.msk_Cep);
            this.grp_Endereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_Endereco.Location = new System.Drawing.Point(20, 433);
            this.grp_Endereco.Name = "grp_Endereco";
            this.grp_Endereco.Size = new System.Drawing.Size(761, 227);
            this.grp_Endereco.TabIndex = 18;
            this.grp_Endereco.TabStop = false;
            this.grp_Endereco.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "*";
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Complemento.Location = new System.Drawing.Point(24, 186);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(713, 29);
            this.txt_Complemento.TabIndex = 14;
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Complemento.Location = new System.Drawing.Point(24, 162);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(115, 21);
            this.lbl_Complemento.TabIndex = 13;
            this.lbl_Complemento.Text = "Complemento";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmb_Estado.Location = new System.Drawing.Point(554, 125);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(183, 29);
            this.cmb_Estado.TabIndex = 12;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Estado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Estado.Location = new System.Drawing.Point(554, 101);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(59, 21);
            this.lbl_Estado.TabIndex = 11;
            this.lbl_Estado.Text = "Estado";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Cidade.Location = new System.Drawing.Point(271, 125);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(258, 29);
            this.txt_Cidade.TabIndex = 10;
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Cidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Cidade.Location = new System.Drawing.Point(271, 101);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(61, 21);
            this.lbl_Cidade.TabIndex = 9;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Bairro.Location = new System.Drawing.Point(24, 125);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(211, 29);
            this.txt_Bairro.TabIndex = 8;
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Bairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Bairro.Location = new System.Drawing.Point(24, 101);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(54, 21);
            this.lbl_Bairro.TabIndex = 7;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Numero.Location = new System.Drawing.Point(637, 59);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 29);
            this.txt_Numero.TabIndex = 6;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Numero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Numero.Location = new System.Drawing.Point(637, 37);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(29, 21);
            this.lbl_Numero.TabIndex = 5;
            this.lbl_Numero.Text = "Nº";
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Logradouro.Location = new System.Drawing.Point(159, 59);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(454, 29);
            this.txt_Logradouro.TabIndex = 4;
            // 
            // lbl_Logradouro
            // 
            this.lbl_Logradouro.AutoSize = true;
            this.lbl_Logradouro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Logradouro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Logradouro.Location = new System.Drawing.Point(159, 34);
            this.lbl_Logradouro.Name = "lbl_Logradouro";
            this.lbl_Logradouro.Size = new System.Drawing.Size(97, 21);
            this.lbl_Logradouro.TabIndex = 3;
            this.lbl_Logradouro.Text = "Logradouro";
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Cep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Cep.Location = new System.Drawing.Point(24, 31);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(37, 21);
            this.lbl_Cep.TabIndex = 2;
            this.lbl_Cep.Text = "CEP";
            // 
            // msk_Cep
            // 
            this.msk_Cep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Cep.Location = new System.Drawing.Point(24, 55);
            this.msk_Cep.Mask = "00000-000";
            this.msk_Cep.Name = "msk_Cep";
            this.msk_Cep.Size = new System.Drawing.Size(100, 29);
            this.msk_Cep.TabIndex = 1;
            this.msk_Cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_Cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msk_Cep_KeyDown);
            this.msk_Cep.Leave += new System.EventHandler(this.msk_Cep_Leave);
            // 
            // grp_Dados
            // 
            this.grp_Dados.Controls.Add(this.label11);
            this.grp_Dados.Controls.Add(this.msk_Rg);
            this.grp_Dados.Controls.Add(this.lbl_Rg);
            this.grp_Dados.Controls.Add(this.label8);
            this.grp_Dados.Controls.Add(this.msk_Cpf);
            this.grp_Dados.Controls.Add(this.lbl_Cpf);
            this.grp_Dados.Controls.Add(this.msk_Nascimento);
            this.grp_Dados.Controls.Add(this.lbl_Nascimento);
            this.grp_Dados.Controls.Add(this.txt_Nome);
            this.grp_Dados.Controls.Add(this.lbl_Nome);
            this.grp_Dados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_Dados.Location = new System.Drawing.Point(20, 83);
            this.grp_Dados.Name = "grp_Dados";
            this.grp_Dados.Size = new System.Drawing.Size(761, 180);
            this.grp_Dados.TabIndex = 17;
            this.grp_Dados.TabStop = false;
            this.grp_Dados.Text = "Dados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "*";
            // 
            // msk_Rg
            // 
            this.msk_Rg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Rg.Location = new System.Drawing.Point(271, 126);
            this.msk_Rg.Mask = "00,000,000-C";
            this.msk_Rg.Name = "msk_Rg";
            this.msk_Rg.Size = new System.Drawing.Size(146, 29);
            this.msk_Rg.TabIndex = 28;
            this.msk_Rg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Rg
            // 
            this.lbl_Rg.AutoSize = true;
            this.lbl_Rg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Rg.Location = new System.Drawing.Point(267, 102);
            this.lbl_Rg.Name = "lbl_Rg";
            this.lbl_Rg.Size = new System.Drawing.Size(31, 21);
            this.lbl_Rg.TabIndex = 27;
            this.lbl_Rg.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "*";
            // 
            // msk_Cpf
            // 
            this.msk_Cpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Cpf.Location = new System.Drawing.Point(24, 126);
            this.msk_Cpf.Mask = "000,000,000-00";
            this.msk_Cpf.Name = "msk_Cpf";
            this.msk_Cpf.Size = new System.Drawing.Size(146, 29);
            this.msk_Cpf.TabIndex = 5;
            this.msk_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Cpf.Location = new System.Drawing.Point(24, 102);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(37, 21);
            this.lbl_Cpf.TabIndex = 4;
            this.lbl_Cpf.Text = "CPF";
            // 
            // msk_Nascimento
            // 
            this.msk_Nascimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Nascimento.Location = new System.Drawing.Point(553, 57);
            this.msk_Nascimento.Mask = "00/00/0000";
            this.msk_Nascimento.Name = "msk_Nascimento";
            this.msk_Nascimento.Size = new System.Drawing.Size(154, 29);
            this.msk_Nascimento.TabIndex = 3;
            this.msk_Nascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Nascimento
            // 
            this.lbl_Nascimento.AutoSize = true;
            this.lbl_Nascimento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Nascimento.Location = new System.Drawing.Point(550, 33);
            this.lbl_Nascimento.Name = "lbl_Nascimento";
            this.lbl_Nascimento.Size = new System.Drawing.Size(157, 21);
            this.lbl_Nascimento.TabIndex = 2;
            this.lbl_Nascimento.Text = "Data de Nascimento";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(24, 57);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(458, 25);
            this.txt_Nome.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Nome.Location = new System.Drawing.Point(24, 33);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(55, 21);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txt_Codigo.Location = new System.Drawing.Point(20, 33);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(184, 33);
            this.txt_Codigo.TabIndex = 16;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Codigo.Location = new System.Drawing.Point(20, 9);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(70, 21);
            this.lbl_Codigo.TabIndex = 15;
            this.lbl_Codigo.Text = "Número";
            // 
            // pcb_Fechar
            // 
            this.pcb_Fechar.Image = global::Programa_Oficina.Properties.Resources.icons8_exit_96;
            this.pcb_Fechar.Location = new System.Drawing.Point(664, 783);
            this.pcb_Fechar.Name = "pcb_Fechar";
            this.pcb_Fechar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Fechar.TabIndex = 23;
            this.pcb_Fechar.TabStop = false;
            this.pcb_Fechar.Click += new System.EventHandler(this.pcb_Fechar_Click);
            // 
            // pcb_Salvar
            // 
            this.pcb_Salvar.Image = global::Programa_Oficina.Properties.Resources.icons8_save_96;
            this.pcb_Salvar.Location = new System.Drawing.Point(510, 783);
            this.pcb_Salvar.Name = "pcb_Salvar";
            this.pcb_Salvar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Salvar.TabIndex = 22;
            this.pcb_Salvar.TabStop = false;
            this.pcb_Salvar.Click += new System.EventHandler(this.pcb_Salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(693, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(532, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Campos Obrigatórios";
            // 
            // grp_Valores
            // 
            this.grp_Valores.Controls.Add(this.label18);
            this.grp_Valores.Controls.Add(this.txt_Salario);
            this.grp_Valores.Controls.Add(this.cmb_Pagamento);
            this.grp_Valores.Controls.Add(this.label16);
            this.grp_Valores.Controls.Add(this.rdb_Mensal);
            this.grp_Valores.Controls.Add(this.rdb_Semanal);
            this.grp_Valores.Controls.Add(this.rdb_Diario);
            this.grp_Valores.Controls.Add(this.label15);
            this.grp_Valores.Controls.Add(this.label14);
            this.grp_Valores.Controls.Add(this.label13);
            this.grp_Valores.Controls.Add(this.txt_Comissao_Servicos);
            this.grp_Valores.Controls.Add(this.label12);
            this.grp_Valores.Controls.Add(this.txt_Comissao_Produtos);
            this.grp_Valores.Controls.Add(this.lbl_Comissao_Produtos);
            this.grp_Valores.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_Valores.Location = new System.Drawing.Point(20, 269);
            this.grp_Valores.Name = "grp_Valores";
            this.grp_Valores.Size = new System.Drawing.Size(761, 165);
            this.grp_Valores.TabIndex = 28;
            this.grp_Valores.TabStop = false;
            this.grp_Valores.Text = "Valores";
            // 
            // cmb_Pagamento
            // 
            this.cmb_Pagamento.FormattingEnabled = true;
            this.cmb_Pagamento.IntegralHeight = false;
            this.cmb_Pagamento.ItemHeight = 17;
            this.cmb_Pagamento.Location = new System.Drawing.Point(504, 122);
            this.cmb_Pagamento.Name = "cmb_Pagamento";
            this.cmb_Pagamento.Size = new System.Drawing.Size(162, 25);
            this.cmb_Pagamento.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(330, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Pagamento Salário";
            // 
            // rdb_Mensal
            // 
            this.rdb_Mensal.AutoSize = true;
            this.rdb_Mensal.Location = new System.Drawing.Point(660, 65);
            this.rdb_Mensal.Name = "rdb_Mensal";
            this.rdb_Mensal.Size = new System.Drawing.Size(69, 21);
            this.rdb_Mensal.TabIndex = 36;
            this.rdb_Mensal.TabStop = true;
            this.rdb_Mensal.Text = "Mensal";
            this.rdb_Mensal.UseVisualStyleBackColor = true;
            this.rdb_Mensal.CheckedChanged += new System.EventHandler(this.rdb_Mensal_CheckedChanged);
            // 
            // rdb_Semanal
            // 
            this.rdb_Semanal.AutoSize = true;
            this.rdb_Semanal.Location = new System.Drawing.Point(547, 65);
            this.rdb_Semanal.Name = "rdb_Semanal";
            this.rdb_Semanal.Size = new System.Drawing.Size(77, 21);
            this.rdb_Semanal.TabIndex = 35;
            this.rdb_Semanal.TabStop = true;
            this.rdb_Semanal.Text = "Semanal";
            this.rdb_Semanal.UseVisualStyleBackColor = true;
            this.rdb_Semanal.CheckedChanged += new System.EventHandler(this.rdb_Semanal_CheckedChanged);
            // 
            // rdb_Diario
            // 
            this.rdb_Diario.AutoSize = true;
            this.rdb_Diario.Location = new System.Drawing.Point(458, 65);
            this.rdb_Diario.Name = "rdb_Diario";
            this.rdb_Diario.Size = new System.Drawing.Size(61, 21);
            this.rdb_Diario.TabIndex = 34;
            this.rdb_Diario.TabStop = true;
            this.rdb_Diario.Text = "Diário";
            this.rdb_Diario.UseVisualStyleBackColor = true;
            this.rdb_Diario.CheckedChanged += new System.EventHandler(this.rdb_Diario_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(330, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "Salário";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(264, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(101, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "%";
            // 
            // txt_Comissao_Servicos
            // 
            this.txt_Comissao_Servicos.Location = new System.Drawing.Point(187, 65);
            this.txt_Comissao_Servicos.Name = "txt_Comissao_Servicos";
            this.txt_Comissao_Servicos.Size = new System.Drawing.Size(73, 25);
            this.txt_Comissao_Servicos.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(184, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 41);
            this.label12.TabIndex = 2;
            this.label12.Text = "Comissão de Serviços";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Comissao_Produtos
            // 
            this.txt_Comissao_Produtos.Location = new System.Drawing.Point(24, 65);
            this.txt_Comissao_Produtos.Name = "txt_Comissao_Produtos";
            this.txt_Comissao_Produtos.Size = new System.Drawing.Size(73, 25);
            this.txt_Comissao_Produtos.TabIndex = 1;
            // 
            // lbl_Comissao_Produtos
            // 
            this.lbl_Comissao_Produtos.Location = new System.Drawing.Point(21, 21);
            this.lbl_Comissao_Produtos.Name = "lbl_Comissao_Produtos";
            this.lbl_Comissao_Produtos.Size = new System.Drawing.Size(103, 41);
            this.lbl_Comissao_Produtos.TabIndex = 0;
            this.lbl_Comissao_Produtos.Text = "Comissão de Peças/Produtos";
            this.lbl_Comissao_Produtos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(307, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 21);
            this.label18.TabIndex = 53;
            this.label18.Text = "R$";
            // 
            // txt_Salario
            // 
            this.txt_Salario.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txt_Salario.Location = new System.Drawing.Point(334, 58);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(97, 33);
            this.txt_Salario.TabIndex = 52;
            this.txt_Salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Novo_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 830);
            this.Controls.Add(this.grp_Valores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_Fechar);
            this.Controls.Add(this.pcb_Salvar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.grp_Contato);
            this.Controls.Add(this.grp_Endereco);
            this.Controls.Add(this.grp_Dados);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Novo_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Funcionário";
            this.grp_Contato.ResumeLayout(false);
            this.grp_Contato.PerformLayout();
            this.grp_Endereco.ResumeLayout(false);
            this.grp_Endereco.PerformLayout();
            this.grp_Dados.ResumeLayout(false);
            this.grp_Dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).EndInit();
            this.grp_Valores.ResumeLayout(false);
            this.grp_Valores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcb_Fechar;
        private System.Windows.Forms.PictureBox pcb_Salvar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.GroupBox grp_Contato;
        private System.Windows.Forms.MaskedTextBox msk_Telefone;
        private System.Windows.Forms.MaskedTextBox msk_Celular;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.GroupBox grp_Endereco;
        private System.Windows.Forms.TextBox txt_Complemento;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.Label lbl_Logradouro;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.MaskedTextBox msk_Cep;
        private System.Windows.Forms.GroupBox grp_Dados;
        private System.Windows.Forms.MaskedTextBox msk_Cpf;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.MaskedTextBox msk_Nascimento;
        private System.Windows.Forms.Label lbl_Nascimento;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox msk_Rg;
        private System.Windows.Forms.Label lbl_Rg;
        private System.Windows.Forms.GroupBox grp_Valores;
        private System.Windows.Forms.ComboBox cmb_Pagamento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdb_Mensal;
        private System.Windows.Forms.RadioButton rdb_Semanal;
        private System.Windows.Forms.RadioButton rdb_Diario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Comissao_Servicos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Comissao_Produtos;
        private System.Windows.Forms.Label lbl_Comissao_Produtos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Salario;
    }
}