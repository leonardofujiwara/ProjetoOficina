namespace Programa_Oficina.Formulários.Ordem_de_Serviço
{
    partial class UC_Cliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.txt_CodigoCliente = new System.Windows.Forms.TextBox();
            this.cmb_Proprietario = new System.Windows.Forms.ComboBox();
            this.lbl_Proprietario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Programa_Oficina.Properties.Resources.search20px;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(459, 116);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(86, 29);
            this.btn_Buscar.TabIndex = 17;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_CodigoCliente
            // 
            this.lbl_CodigoCliente.AutoSize = true;
            this.lbl_CodigoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_CodigoCliente.Location = new System.Drawing.Point(35, 83);
            this.lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            this.lbl_CodigoCliente.Size = new System.Drawing.Size(33, 21);
            this.lbl_CodigoCliente.TabIndex = 16;
            this.lbl_CodigoCliente.Text = "Nº ";
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_CodigoCliente.Location = new System.Drawing.Point(37, 116);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.Size = new System.Drawing.Size(62, 29);
            this.txt_CodigoCliente.TabIndex = 15;
            // 
            // cmb_Proprietario
            // 
            this.cmb_Proprietario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_Proprietario.FormattingEnabled = true;
            this.cmb_Proprietario.Location = new System.Drawing.Point(108, 116);
            this.cmb_Proprietario.Name = "cmb_Proprietario";
            this.cmb_Proprietario.Size = new System.Drawing.Size(335, 29);
            this.cmb_Proprietario.TabIndex = 14;
            this.cmb_Proprietario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Proprietario_KeyDown);
            this.cmb_Proprietario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_Proprietario_KeyUp);
            this.cmb_Proprietario.Leave += new System.EventHandler(this.cmb_Proprietario_Leave);
            this.cmb_Proprietario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_Proprietario_MouseClick);
            // 
            // lbl_Proprietario
            // 
            this.lbl_Proprietario.AutoSize = true;
            this.lbl_Proprietario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Proprietario.Location = new System.Drawing.Point(104, 83);
            this.lbl_Proprietario.Name = "lbl_Proprietario";
            this.lbl_Proprietario.Size = new System.Drawing.Size(98, 21);
            this.lbl_Proprietario.TabIndex = 13;
            this.lbl_Proprietario.Text = "Proprietário";
            // 
            // UC_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.lbl_CodigoCliente);
            this.Controls.Add(this.txt_CodigoCliente);
            this.Controls.Add(this.cmb_Proprietario);
            this.Controls.Add(this.lbl_Proprietario);
            this.Name = "UC_Cliente";
            this.Size = new System.Drawing.Size(960, 567);
            this.Click += new System.EventHandler(this.UC_Cliente_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_CodigoCliente;
        private System.Windows.Forms.TextBox txt_CodigoCliente;
        private System.Windows.Forms.ComboBox cmb_Proprietario;
        private System.Windows.Forms.Label lbl_Proprietario;
    }
}
