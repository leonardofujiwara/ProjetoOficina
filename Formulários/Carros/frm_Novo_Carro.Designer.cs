namespace Programa_Oficina.Formulários.Carros
{
    partial class frm_Novo_Carro
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
            System.Windows.Forms.Label lbl_Ano;
            System.Windows.Forms.Label lbl_Cor;
            System.Windows.Forms.Label lbl_Chassi;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Novo_Carro));
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_Proprietario = new System.Windows.Forms.Label();
            this.cmb_Proprietario = new System.Windows.Forms.ComboBox();
            this.grp_Categoria = new System.Windows.Forms.GroupBox();
            this.rdb_Agricola = new System.Windows.Forms.RadioButton();
            this.rdb_Caminhao = new System.Windows.Forms.RadioButton();
            this.rdb_Van = new System.Windows.Forms.RadioButton();
            this.rdb_Carro = new System.Windows.Forms.RadioButton();
            this.grp_Caracteristicas = new System.Windows.Forms.GroupBox();
            this.lbl_Opicional = new System.Windows.Forms.Label();
            this.txt_Chassi = new System.Windows.Forms.TextBox();
            this.txt_Cor = new System.Windows.Forms.TextBox();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.cmb_Modelo = new System.Windows.Forms.ComboBox();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.cmb_Marca = new System.Windows.Forms.ComboBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.txt_CodigoCliente = new System.Windows.Forms.TextBox();
            this.lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.pcb_Fechar = new System.Windows.Forms.PictureBox();
            this.pcb_Salvar = new System.Windows.Forms.PictureBox();
            lbl_Ano = new System.Windows.Forms.Label();
            lbl_Cor = new System.Windows.Forms.Label();
            lbl_Chassi = new System.Windows.Forms.Label();
            this.grp_Categoria.SuspendLayout();
            this.grp_Caracteristicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ano
            // 
            lbl_Ano.AutoSize = true;
            lbl_Ano.Location = new System.Drawing.Point(221, 128);
            lbl_Ano.Name = "lbl_Ano";
            lbl_Ano.Size = new System.Drawing.Size(40, 21);
            lbl_Ano.TabIndex = 6;
            lbl_Ano.Text = "Ano";
            // 
            // lbl_Cor
            // 
            lbl_Cor.AutoSize = true;
            lbl_Cor.Location = new System.Drawing.Point(408, 128);
            lbl_Cor.Name = "lbl_Cor";
            lbl_Cor.Size = new System.Drawing.Size(36, 21);
            lbl_Cor.TabIndex = 8;
            lbl_Cor.Text = "Cor";
            // 
            // lbl_Chassi
            // 
            lbl_Chassi.AutoSize = true;
            lbl_Chassi.Location = new System.Drawing.Point(15, 215);
            lbl_Chassi.Name = "lbl_Chassi";
            lbl_Chassi.Size = new System.Drawing.Size(55, 21);
            lbl_Chassi.TabIndex = 10;
            lbl_Chassi.Text = "Chassi";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Numero.Location = new System.Drawing.Point(23, 13);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(139, 21);
            this.lbl_Numero.TabIndex = 0;
            this.lbl_Numero.Text = "Número Cadastro";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Numero.Location = new System.Drawing.Point(25, 37);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.ReadOnly = true;
            this.txt_Numero.Size = new System.Drawing.Size(140, 29);
            this.txt_Numero.TabIndex = 1;
            // 
            // lbl_Proprietario
            // 
            this.lbl_Proprietario.AutoSize = true;
            this.lbl_Proprietario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Proprietario.Location = new System.Drawing.Point(92, 93);
            this.lbl_Proprietario.Name = "lbl_Proprietario";
            this.lbl_Proprietario.Size = new System.Drawing.Size(98, 21);
            this.lbl_Proprietario.TabIndex = 2;
            this.lbl_Proprietario.Text = "Proprietário";
            // 
            // cmb_Proprietario
            // 
            this.cmb_Proprietario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_Proprietario.FormattingEnabled = true;
            this.cmb_Proprietario.Location = new System.Drawing.Point(96, 126);
            this.cmb_Proprietario.Name = "cmb_Proprietario";
            this.cmb_Proprietario.Size = new System.Drawing.Size(335, 29);
            this.cmb_Proprietario.TabIndex = 3;
            this.cmb_Proprietario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Proprietario_KeyDown);
            this.cmb_Proprietario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Proprietario_KeyUp);
            this.cmb_Proprietario.Leave += new System.EventHandler(this.cmb_Proprietario_Leave);
            this.cmb_Proprietario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_Proprietario_MouseClick);
            // 
            // grp_Categoria
            // 
            this.grp_Categoria.Controls.Add(this.rdb_Agricola);
            this.grp_Categoria.Controls.Add(this.rdb_Caminhao);
            this.grp_Categoria.Controls.Add(this.rdb_Van);
            this.grp_Categoria.Controls.Add(this.rdb_Carro);
            this.grp_Categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grp_Categoria.Location = new System.Drawing.Point(17, 166);
            this.grp_Categoria.Name = "grp_Categoria";
            this.grp_Categoria.Size = new System.Drawing.Size(516, 63);
            this.grp_Categoria.TabIndex = 4;
            this.grp_Categoria.TabStop = false;
            this.grp_Categoria.Text = "Categoria";
            // 
            // rdb_Agricola
            // 
            this.rdb_Agricola.AutoSize = true;
            this.rdb_Agricola.Location = new System.Drawing.Point(376, 25);
            this.rdb_Agricola.Name = "rdb_Agricola";
            this.rdb_Agricola.Size = new System.Drawing.Size(130, 25);
            this.rdb_Agricola.TabIndex = 3;
            this.rdb_Agricola.TabStop = true;
            this.rdb_Agricola.Text = "Maq. Agrícola";
            this.rdb_Agricola.UseVisualStyleBackColor = true;
            // 
            // rdb_Caminhao
            // 
            this.rdb_Caminhao.AutoSize = true;
            this.rdb_Caminhao.Location = new System.Drawing.Point(245, 25);
            this.rdb_Caminhao.Name = "rdb_Caminhao";
            this.rdb_Caminhao.Size = new System.Drawing.Size(100, 25);
            this.rdb_Caminhao.TabIndex = 2;
            this.rdb_Caminhao.TabStop = true;
            this.rdb_Caminhao.Text = "Caminhão";
            this.rdb_Caminhao.UseVisualStyleBackColor = true;
            // 
            // rdb_Van
            // 
            this.rdb_Van.AutoSize = true;
            this.rdb_Van.Location = new System.Drawing.Point(145, 25);
            this.rdb_Van.Name = "rdb_Van";
            this.rdb_Van.Size = new System.Drawing.Size(54, 25);
            this.rdb_Van.TabIndex = 1;
            this.rdb_Van.TabStop = true;
            this.rdb_Van.Text = "Van";
            this.rdb_Van.UseVisualStyleBackColor = true;
            // 
            // rdb_Carro
            // 
            this.rdb_Carro.AutoSize = true;
            this.rdb_Carro.Location = new System.Drawing.Point(30, 25);
            this.rdb_Carro.Name = "rdb_Carro";
            this.rdb_Carro.Size = new System.Drawing.Size(68, 25);
            this.rdb_Carro.TabIndex = 0;
            this.rdb_Carro.TabStop = true;
            this.rdb_Carro.Text = "Carro";
            this.rdb_Carro.UseVisualStyleBackColor = true;
            // 
            // grp_Caracteristicas
            // 
            this.grp_Caracteristicas.Controls.Add(this.lbl_Opicional);
            this.grp_Caracteristicas.Controls.Add(this.txt_Chassi);
            this.grp_Caracteristicas.Controls.Add(lbl_Chassi);
            this.grp_Caracteristicas.Controls.Add(this.txt_Cor);
            this.grp_Caracteristicas.Controls.Add(lbl_Cor);
            this.grp_Caracteristicas.Controls.Add(this.txt_Ano);
            this.grp_Caracteristicas.Controls.Add(lbl_Ano);
            this.grp_Caracteristicas.Controls.Add(this.txt_Placa);
            this.grp_Caracteristicas.Controls.Add(this.lbl_Placa);
            this.grp_Caracteristicas.Controls.Add(this.cmb_Modelo);
            this.grp_Caracteristicas.Controls.Add(this.lbl_Modelo);
            this.grp_Caracteristicas.Controls.Add(this.cmb_Marca);
            this.grp_Caracteristicas.Controls.Add(this.lbl_Marca);
            this.grp_Caracteristicas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grp_Caracteristicas.Location = new System.Drawing.Point(17, 249);
            this.grp_Caracteristicas.Name = "grp_Caracteristicas";
            this.grp_Caracteristicas.Size = new System.Drawing.Size(749, 285);
            this.grp_Caracteristicas.TabIndex = 5;
            this.grp_Caracteristicas.TabStop = false;
            this.grp_Caracteristicas.Text = "Características";
            // 
            // lbl_Opicional
            // 
            this.lbl_Opicional.AutoSize = true;
            this.lbl_Opicional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lbl_Opicional.Location = new System.Drawing.Point(76, 221);
            this.lbl_Opicional.Name = "lbl_Opicional";
            this.lbl_Opicional.Size = new System.Drawing.Size(59, 13);
            this.lbl_Opicional.TabIndex = 12;
            this.lbl_Opicional.Text = "(Opicional)";
            // 
            // txt_Chassi
            // 
            this.txt_Chassi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Chassi.Location = new System.Drawing.Point(17, 239);
            this.txt_Chassi.Name = "txt_Chassi";
            this.txt_Chassi.Size = new System.Drawing.Size(413, 29);
            this.txt_Chassi.TabIndex = 11;
            // 
            // txt_Cor
            // 
            this.txt_Cor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Cor.Location = new System.Drawing.Point(408, 152);
            this.txt_Cor.Name = "txt_Cor";
            this.txt_Cor.Size = new System.Drawing.Size(210, 29);
            this.txt_Cor.TabIndex = 9;
            // 
            // txt_Ano
            // 
            this.txt_Ano.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Ano.Location = new System.Drawing.Point(221, 152);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(121, 29);
            this.txt_Ano.TabIndex = 7;
            // 
            // txt_Placa
            // 
            this.txt_Placa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Placa.Location = new System.Drawing.Point(17, 152);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(130, 29);
            this.txt_Placa.TabIndex = 5;
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.Location = new System.Drawing.Point(15, 128);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(47, 21);
            this.lbl_Placa.TabIndex = 4;
            this.lbl_Placa.Text = "Placa";
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(303, 65);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(435, 29);
            this.cmb_Modelo.TabIndex = 3;
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(303, 41);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(68, 21);
            this.lbl_Modelo.TabIndex = 2;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.IntegralHeight = false;
            this.cmb_Marca.ItemHeight = 21;
            this.cmb_Marca.Items.AddRange(new object[] {
            "Agrale",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "BYD",
            "Caoa Chery",
            "Case",
            "Caterpillar",
            "Chevrolet",
            "Chrysler",
            "Citroën",
            "Daewoo",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Foton",
            "Ford",
            "Honda",
            "Husqvarna",
            "Hyundai",
            "Iveco",
            "JAC",
            "Jaguar",
            "JCB",
            "Jeep",
            "John Deere",
            "Kia",
            "Komatsu",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Lifan",
            "Man",
            "Massei Ferguson",
            "Maserati",
            "McLaren",
            "Mercedes-Benz",
            "Mini",
            "Mitsubishi",
            "New Holland",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Ram",
            "Renault",
            "Rolls Royce",
            "Royal Enfield",
            "Scania",
            "Smart",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Triumph",
            "Troller",
            "Valtra",
            "Volkswagen",
            "Volvo",
            "Yamaha"});
            this.cmb_Marca.Location = new System.Drawing.Point(15, 65);
            this.cmb_Marca.MaxDropDownItems = 5;
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(228, 29);
            this.cmb_Marca.TabIndex = 1;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(15, 41);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(55, 21);
            this.lbl_Marca.TabIndex = 0;
            this.lbl_Marca.Text = "Marca";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Salvar.Location = new System.Drawing.Point(484, 543);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(123, 42);
            this.btn_Salvar.TabIndex = 6;
            this.btn_Salvar.Text = "Salvar   ";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Location = new System.Drawing.Point(649, 543);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(123, 42);
            this.btn_Fechar.TabIndex = 7;
            this.btn_Fechar.Text = "Fechar   ";
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_CodigoCliente.Location = new System.Drawing.Point(25, 126);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.Size = new System.Drawing.Size(62, 29);
            this.txt_CodigoCliente.TabIndex = 10;
            this.txt_CodigoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CodigoCliente_KeyDown);
            // 
            // lbl_CodigoCliente
            // 
            this.lbl_CodigoCliente.AutoSize = true;
            this.lbl_CodigoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_CodigoCliente.Location = new System.Drawing.Point(23, 93);
            this.lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            this.lbl_CodigoCliente.Size = new System.Drawing.Size(33, 21);
            this.lbl_CodigoCliente.TabIndex = 11;
            this.lbl_CodigoCliente.Text = "Nº ";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Programa_Oficina.Properties.Resources.search20px;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(447, 126);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(86, 29);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // pcb_Fechar
            // 
            this.pcb_Fechar.Image = global::Programa_Oficina.Properties.Resources.icons8_exit_96;
            this.pcb_Fechar.Location = new System.Drawing.Point(660, 548);
            this.pcb_Fechar.Name = "pcb_Fechar";
            this.pcb_Fechar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Fechar.TabIndex = 9;
            this.pcb_Fechar.TabStop = false;
            this.pcb_Fechar.Click += new System.EventHandler(this.pcb_Fechar_Click);
            // 
            // pcb_Salvar
            // 
            this.pcb_Salvar.Image = global::Programa_Oficina.Properties.Resources.icons8_save_96;
            this.pcb_Salvar.Location = new System.Drawing.Point(495, 548);
            this.pcb_Salvar.Name = "pcb_Salvar";
            this.pcb_Salvar.Size = new System.Drawing.Size(32, 32);
            this.pcb_Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Salvar.TabIndex = 8;
            this.pcb_Salvar.TabStop = false;
            this.pcb_Salvar.Click += new System.EventHandler(this.pcb_Salvar_Click);
            // 
            // frm_Novo_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 597);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.lbl_CodigoCliente);
            this.Controls.Add(this.txt_CodigoCliente);
            this.Controls.Add(this.pcb_Fechar);
            this.Controls.Add(this.pcb_Salvar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.grp_Caracteristicas);
            this.Controls.Add(this.grp_Categoria);
            this.Controls.Add(this.cmb_Proprietario);
            this.Controls.Add(this.lbl_Proprietario);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_Numero);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frm_Novo_Carro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de veículo";
            this.grp_Categoria.ResumeLayout(false);
            this.grp_Categoria.PerformLayout();
            this.grp_Caracteristicas.ResumeLayout(false);
            this.grp_Caracteristicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Salvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Proprietario;
        private System.Windows.Forms.ComboBox cmb_Proprietario;
        private System.Windows.Forms.GroupBox grp_Categoria;
        private System.Windows.Forms.RadioButton rdb_Agricola;
        private System.Windows.Forms.RadioButton rdb_Caminhao;
        private System.Windows.Forms.RadioButton rdb_Van;
        private System.Windows.Forms.RadioButton rdb_Carro;
        private System.Windows.Forms.GroupBox grp_Caracteristicas;
        private System.Windows.Forms.ComboBox cmb_Marca;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Opicional;
        private System.Windows.Forms.TextBox txt_Chassi;
        private System.Windows.Forms.TextBox txt_Cor;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.ComboBox cmb_Modelo;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.PictureBox pcb_Salvar;
        private System.Windows.Forms.PictureBox pcb_Fechar;
        private System.Windows.Forms.TextBox txt_CodigoCliente;
        private System.Windows.Forms.Label lbl_CodigoCliente;
        private System.Windows.Forms.Button btn_Buscar;
    }
}