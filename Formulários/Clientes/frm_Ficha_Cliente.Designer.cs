namespace Programa_Oficina.Formulários.Clientes
{
    partial class frm_Ficha_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ficha_Cliente));
            this.pcb_Fechar = new System.Windows.Forms.PictureBox();
            this.pcb_Salvar = new System.Windows.Forms.PictureBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.grp_Contato = new System.Windows.Forms.GroupBox();
            this.msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.msk_Celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.grp_Endereco = new System.Windows.Forms.GroupBox();
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
            this.msk_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.rdb_Juridica = new System.Windows.Forms.RadioButton();
            this.lbl_Cnpj = new System.Windows.Forms.Label();
            this.rdb_Fisica = new System.Windows.Forms.RadioButton();
            this.msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.msk_Nascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nascimento = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DataCadastro = new System.Windows.Forms.TextBox();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).BeginInit();
            this.grp_Contato.SuspendLayout();
            this.grp_Endereco.SuspendLayout();
            this.grp_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Fechar
            // 
            this.pcb_Fechar.Image = global::Programa_Oficina.Properties.Resources.icons8_exit_96;
            this.pcb_Fechar.Location = new System.Drawing.Point(663, 684);
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
            this.pcb_Salvar.Location = new System.Drawing.Point(509, 684);
            this.pcb_Salvar.Name = "pcb_Salvar";
            this.pcb_Salvar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Salvar.TabIndex = 22;
            this.pcb_Salvar.TabStop = false;
            this.pcb_Salvar.Click += new System.EventHandler(this.pcb_Salvar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Location = new System.Drawing.Point(657, 680);
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
            this.btn_Salvar.Location = new System.Drawing.Point(502, 680);
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
            this.grp_Contato.Controls.Add(this.txt_Email);
            this.grp_Contato.Controls.Add(this.lbl_Email);
            this.grp_Contato.Controls.Add(this.lbl_Telefone);
            this.grp_Contato.Controls.Add(this.lbl_Celular);
            this.grp_Contato.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_Contato.Location = new System.Drawing.Point(19, 514);
            this.grp_Contato.Name = "grp_Contato";
            this.grp_Contato.Size = new System.Drawing.Size(761, 153);
            this.grp_Contato.TabIndex = 19;
            this.grp_Contato.TabStop = false;
            this.grp_Contato.Text = "Contato";
            // 
            // msk_Telefone
            // 
            this.msk_Telefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Telefone.Location = new System.Drawing.Point(286, 62);
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
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Email.Location = new System.Drawing.Point(22, 115);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(438, 29);
            this.txt_Email.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.Location = new System.Drawing.Point(22, 91);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(54, 21);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "E-mail";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Telefone.Location = new System.Drawing.Point(282, 30);
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
            this.grp_Endereco.Location = new System.Drawing.Point(19, 276);
            this.grp_Endereco.Name = "grp_Endereco";
            this.grp_Endereco.Size = new System.Drawing.Size(761, 227);
            this.grp_Endereco.TabIndex = 18;
            this.grp_Endereco.TabStop = false;
            this.grp_Endereco.Text = "Endereço";
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
            this.grp_Dados.Controls.Add(this.msk_Cnpj);
            this.grp_Dados.Controls.Add(this.rdb_Juridica);
            this.grp_Dados.Controls.Add(this.lbl_Cnpj);
            this.grp_Dados.Controls.Add(this.rdb_Fisica);
            this.grp_Dados.Controls.Add(this.msk_Cpf);
            this.grp_Dados.Controls.Add(this.lbl_Cpf);
            this.grp_Dados.Controls.Add(this.msk_Nascimento);
            this.grp_Dados.Controls.Add(this.lbl_Nascimento);
            this.grp_Dados.Controls.Add(this.txt_Nome);
            this.grp_Dados.Controls.Add(this.lbl_Nome);
            this.grp_Dados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_Dados.Location = new System.Drawing.Point(19, 84);
            this.grp_Dados.Name = "grp_Dados";
            this.grp_Dados.Size = new System.Drawing.Size(761, 180);
            this.grp_Dados.TabIndex = 17;
            this.grp_Dados.TabStop = false;
            this.grp_Dados.Text = "Dados";
            // 
            // msk_Cnpj
            // 
            this.msk_Cnpj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msk_Cnpj.Location = new System.Drawing.Point(244, 126);
            this.msk_Cnpj.Mask = "00,000,000/0000-00";
            this.msk_Cnpj.Name = "msk_Cnpj";
            this.msk_Cnpj.Size = new System.Drawing.Size(181, 29);
            this.msk_Cnpj.TabIndex = 7;
            this.msk_Cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_Juridica
            // 
            this.rdb_Juridica.AutoSize = true;
            this.rdb_Juridica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rdb_Juridica.Location = new System.Drawing.Point(538, 60);
            this.rdb_Juridica.Name = "rdb_Juridica";
            this.rdb_Juridica.Size = new System.Drawing.Size(136, 25);
            this.rdb_Juridica.TabIndex = 12;
            this.rdb_Juridica.TabStop = true;
            this.rdb_Juridica.Text = "Pessoa Jurídica";
            this.rdb_Juridica.UseVisualStyleBackColor = true;
            // 
            // lbl_Cnpj
            // 
            this.lbl_Cnpj.AutoSize = true;
            this.lbl_Cnpj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Cnpj.Location = new System.Drawing.Point(244, 102);
            this.lbl_Cnpj.Name = "lbl_Cnpj";
            this.lbl_Cnpj.Size = new System.Drawing.Size(46, 21);
            this.lbl_Cnpj.TabIndex = 6;
            this.lbl_Cnpj.Text = "CNPJ";
            // 
            // rdb_Fisica
            // 
            this.rdb_Fisica.AutoSize = true;
            this.rdb_Fisica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rdb_Fisica.Location = new System.Drawing.Point(539, 29);
            this.rdb_Fisica.Name = "rdb_Fisica";
            this.rdb_Fisica.Size = new System.Drawing.Size(120, 25);
            this.rdb_Fisica.TabIndex = 11;
            this.rdb_Fisica.TabStop = true;
            this.rdb_Fisica.Text = "Pessoa Física";
            this.rdb_Fisica.UseVisualStyleBackColor = true;
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
            this.msk_Nascimento.Location = new System.Drawing.Point(538, 126);
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
            this.lbl_Nascimento.Location = new System.Drawing.Point(535, 102);
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
            this.txt_Codigo.Location = new System.Drawing.Point(19, 34);
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
            this.lbl_Codigo.Location = new System.Drawing.Point(19, 10);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(70, 21);
            this.lbl_Codigo.TabIndex = 15;
            this.lbl_Codigo.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(537, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data de Cadastro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DataCadastro
            // 
            this.txt_DataCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txt_DataCadastro.Location = new System.Drawing.Point(542, 34);
            this.txt_DataCadastro.Name = "txt_DataCadastro";
            this.txt_DataCadastro.ReadOnly = true;
            this.txt_DataCadastro.Size = new System.Drawing.Size(125, 33);
            this.txt_DataCadastro.TabIndex = 25;
            this.txt_DataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Alterar.Location = new System.Drawing.Point(345, 680);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(123, 42);
            this.btn_Alterar.TabIndex = 26;
            this.btn_Alterar.Text = "Alterar  ";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Programa_Oficina.Properties.Resources.icons8_repeat_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(352, 685);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Ficha_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.txt_DataCadastro);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frm_Ficha_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).EndInit();
            this.grp_Contato.ResumeLayout(false);
            this.grp_Contato.PerformLayout();
            this.grp_Endereco.ResumeLayout(false);
            this.grp_Endereco.PerformLayout();
            this.grp_Dados.ResumeLayout(false);
            this.grp_Dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
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
        private System.Windows.Forms.MaskedTextBox msk_Cnpj;
        private System.Windows.Forms.RadioButton rdb_Juridica;
        private System.Windows.Forms.Label lbl_Cnpj;
        private System.Windows.Forms.RadioButton rdb_Fisica;
        private System.Windows.Forms.MaskedTextBox msk_Cpf;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.MaskedTextBox msk_Nascimento;
        private System.Windows.Forms.Label lbl_Nascimento;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DataCadastro;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}