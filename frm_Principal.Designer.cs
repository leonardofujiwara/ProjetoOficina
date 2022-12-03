namespace Programa_Oficina
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.grp_Principal = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Estoque = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Produtos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcb_Wallpaper = new System.Windows.Forms.PictureBox();
            this.btn_Os = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Carro = new System.Windows.Forms.Button();
            this.grp_Principal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Principal
            // 
            this.grp_Principal.Controls.Add(this.btn_Os);
            this.grp_Principal.Controls.Add(this.btn_Clientes);
            this.grp_Principal.Controls.Add(this.btn_Carro);
            this.grp_Principal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grp_Principal.Location = new System.Drawing.Point(12, 41);
            this.grp_Principal.Name = "grp_Principal";
            this.grp_Principal.Size = new System.Drawing.Size(567, 171);
            this.grp_Principal.TabIndex = 0;
            this.grp_Principal.TabStop = false;
            this.grp_Principal.Text = "Principal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.serviçoToolStripMenuItem});
            this.novoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.carroToolStripMenuItem.Text = "Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // btn_Estoque
            // 
            this.btn_Estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Estoque.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Estoque.Image = global::Programa_Oficina.Properties.Resources.estoque_icon;
            this.btn_Estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Estoque.Location = new System.Drawing.Point(1153, 57);
            this.btn_Estoque.Name = "btn_Estoque";
            this.btn_Estoque.Size = new System.Drawing.Size(155, 150);
            this.btn_Estoque.TabIndex = 6;
            this.btn_Estoque.Text = "Estoque";
            this.btn_Estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Estoque.UseVisualStyleBackColor = true;
            this.btn_Estoque.Click += new System.EventHandler(this.btn_Estoque_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::Programa_Oficina.Properties.Resources.servico_icon;
            this.button2.Location = new System.Drawing.Point(965, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 150);
            this.button2.TabIndex = 5;
            this.button2.Text = "Serviços";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Produtos
            // 
            this.btn_Produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Produtos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Produtos.Image = global::Programa_Oficina.Properties.Resources.produto_jpeg;
            this.btn_Produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Produtos.Location = new System.Drawing.Point(774, 57);
            this.btn_Produtos.Name = "btn_Produtos";
            this.btn_Produtos.Size = new System.Drawing.Size(155, 150);
            this.btn_Produtos.TabIndex = 4;
            this.btn_Produtos.Text = "Produtos";
            this.btn_Produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Produtos.UseVisualStyleBackColor = true;
            this.btn_Produtos.Click += new System.EventHandler(this.btn_Produtos_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::Programa_Oficina.Properties.Resources.mecanico;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(585, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 150);
            this.button1.TabIndex = 3;
            this.button1.Text = "Funcionários";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcb_Wallpaper
            // 
            this.pcb_Wallpaper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_Wallpaper.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Wallpaper.Image")));
            this.pcb_Wallpaper.Location = new System.Drawing.Point(18, 229);
            this.pcb_Wallpaper.Name = "pcb_Wallpaper";
            this.pcb_Wallpaper.Size = new System.Drawing.Size(1448, 720);
            this.pcb_Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Wallpaper.TabIndex = 2;
            this.pcb_Wallpaper.TabStop = false;
            // 
            // btn_Os
            // 
            this.btn_Os.BackgroundImage = global::Programa_Oficina.Properties.Resources.clipboard_with_paper_document_and_bill_money_vector_30199288;
            this.btn_Os.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Os.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Os.Location = new System.Drawing.Point(388, 14);
            this.btn_Os.Name = "btn_Os";
            this.btn_Os.Size = new System.Drawing.Size(155, 150);
            this.btn_Os.TabIndex = 2;
            this.btn_Os.Text = "Ordem de Serviço";
            this.btn_Os.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Os.UseVisualStyleBackColor = true;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackgroundImage = global::Programa_Oficina.Properties.Resources._78_786314_computer_user_icon_peolpe_avatar_group_people_avatar;
            this.btn_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Clientes.Location = new System.Drawing.Point(207, 14);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(155, 150);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Carro
            // 
            this.btn_Carro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Carro.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Carro.Image = global::Programa_Oficina.Properties.Resources.car_icon_final;
            this.btn_Carro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Carro.Location = new System.Drawing.Point(24, 14);
            this.btn_Carro.Name = "btn_Carro";
            this.btn_Carro.Size = new System.Drawing.Size(155, 150);
            this.btn_Carro.TabIndex = 0;
            this.btn_Carro.Text = "Carros";
            this.btn_Carro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Carro.UseVisualStyleBackColor = true;
            this.btn_Carro.Click += new System.EventHandler(this.btn_Carro_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.btn_Estoque);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Produtos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcb_Wallpaper);
            this.Controls.Add(this.grp_Principal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Oficina";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.grp_Principal.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Principal;
        private System.Windows.Forms.Button btn_Os;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Carro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcb_Wallpaper;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Button btn_Produtos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Estoque;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
    }
}