namespace DesafioVendas
{
    partial class frm_principal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.ms_principal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_cliente_principal = new System.Windows.Forms.Button();
            this.pb_cliente_principal = new System.Windows.Forms.PictureBox();
            this.bt_compras_principal = new System.Windows.Forms.Button();
            this.pb_compras_principal = new System.Windows.Forms.PictureBox();
            this.pb_vendas_principal = new System.Windows.Forms.PictureBox();
            this.bt_vendas_principal = new System.Windows.Forms.Button();
            this.lb_desenvolvido_principal = new System.Windows.Forms.Label();
            this.bt_estoque = new System.Windows.Forms.Button();
            this.pb_estoque_principal = new System.Windows.Forms.PictureBox();
            this.ms_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cliente_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_compras_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vendas_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_estoque_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_principal
            // 
            this.ms_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem1,
            this.sairToolStripMenuItem,
            this.toolStripMenuItem1});
            this.ms_principal.Location = new System.Drawing.Point(0, 0);
            this.ms_principal.Name = "ms_principal";
            this.ms_principal.Size = new System.Drawing.Size(311, 24);
            this.ms_principal.TabIndex = 0;
            this.ms_principal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem2});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.produtosToolStripMenuItem.Text = "Compras";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem2
            // 
            this.vendasToolStripMenuItem2.Name = "vendasToolStripMenuItem2";
            this.vendasToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.vendasToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.vendasToolStripMenuItem2.Text = "Vendas";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.caixaToolStripMenuItem1});
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.vendasToolStripMenuItem1.Text = "Consulta";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.caixaToolStripMenuItem.Text = "Estoque";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem1
            // 
            this.caixaToolStripMenuItem1.Name = "caixaToolStripMenuItem1";
            this.caixaToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.caixaToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.caixaToolStripMenuItem1.Text = "Caixa";
            this.caixaToolStripMenuItem1.Click += new System.EventHandler(this.caixaToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharSistemaToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // bt_cliente_principal
            // 
            this.bt_cliente_principal.BackColor = System.Drawing.Color.White;
            this.bt_cliente_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_cliente_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cliente_principal.FlatAppearance.BorderSize = 3;
            this.bt_cliente_principal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cliente_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cliente_principal.Location = new System.Drawing.Point(15, 30);
            this.bt_cliente_principal.Name = "bt_cliente_principal";
            this.bt_cliente_principal.Size = new System.Drawing.Size(75, 66);
            this.bt_cliente_principal.TabIndex = 1;
            this.bt_cliente_principal.Text = "CLIENTES";
            this.bt_cliente_principal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cliente_principal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_cliente_principal.UseVisualStyleBackColor = false;
            this.bt_cliente_principal.Click += new System.EventHandler(this.bt_cliente_principal_Click);
            // 
            // pb_cliente_principal
            // 
            this.pb_cliente_principal.BackColor = System.Drawing.Color.White;
            this.pb_cliente_principal.BackgroundImage = global::DesafioVendas.Properties.Resources.kisspng_computer_icons_customer_icon_design_users_group_customer_group_customers_forum_people_users_ic_5ab19556355223_5886768715215875422184;
            this.pb_cliente_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_cliente_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cliente_principal.Location = new System.Drawing.Point(27, 39);
            this.pb_cliente_principal.Name = "pb_cliente_principal";
            this.pb_cliente_principal.Size = new System.Drawing.Size(53, 36);
            this.pb_cliente_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_cliente_principal.TabIndex = 2;
            this.pb_cliente_principal.TabStop = false;
            this.pb_cliente_principal.Click += new System.EventHandler(this.pb_cliente_principal_Click);
            // 
            // bt_compras_principal
            // 
            this.bt_compras_principal.BackColor = System.Drawing.Color.White;
            this.bt_compras_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_compras_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_compras_principal.FlatAppearance.BorderSize = 3;
            this.bt_compras_principal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_compras_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compras_principal.Location = new System.Drawing.Point(96, 30);
            this.bt_compras_principal.Name = "bt_compras_principal";
            this.bt_compras_principal.Size = new System.Drawing.Size(85, 66);
            this.bt_compras_principal.TabIndex = 3;
            this.bt_compras_principal.Text = "COMPRAS";
            this.bt_compras_principal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_compras_principal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_compras_principal.UseVisualStyleBackColor = false;
            this.bt_compras_principal.Click += new System.EventHandler(this.bt_produto_principal_Click);
            // 
            // pb_compras_principal
            // 
            this.pb_compras_principal.BackColor = System.Drawing.Color.White;
            this.pb_compras_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_compras_principal.Image = global::DesafioVendas.Properties.Resources.piao;
            this.pb_compras_principal.Location = new System.Drawing.Point(112, 39);
            this.pb_compras_principal.Name = "pb_compras_principal";
            this.pb_compras_principal.Size = new System.Drawing.Size(53, 36);
            this.pb_compras_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_compras_principal.TabIndex = 4;
            this.pb_compras_principal.TabStop = false;
            this.pb_compras_principal.Click += new System.EventHandler(this.pb_produto_principal_Click);
            // 
            // pb_vendas_principal
            // 
            this.pb_vendas_principal.BackColor = System.Drawing.Color.White;
            this.pb_vendas_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_vendas_principal.Image = global::DesafioVendas.Properties.Resources.venda;
            this.pb_vendas_principal.Location = new System.Drawing.Point(205, 39);
            this.pb_vendas_principal.Name = "pb_vendas_principal";
            this.pb_vendas_principal.Size = new System.Drawing.Size(53, 36);
            this.pb_vendas_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_vendas_principal.TabIndex = 6;
            this.pb_vendas_principal.TabStop = false;
            this.pb_vendas_principal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_vendas_principal
            // 
            this.bt_vendas_principal.BackColor = System.Drawing.Color.White;
            this.bt_vendas_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_vendas_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_vendas_principal.FlatAppearance.BorderSize = 3;
            this.bt_vendas_principal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_vendas_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vendas_principal.Location = new System.Drawing.Point(189, 30);
            this.bt_vendas_principal.Name = "bt_vendas_principal";
            this.bt_vendas_principal.Size = new System.Drawing.Size(85, 66);
            this.bt_vendas_principal.TabIndex = 0;
            this.bt_vendas_principal.Text = "VENDAS";
            this.bt_vendas_principal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_vendas_principal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_vendas_principal.UseVisualStyleBackColor = false;
            this.bt_vendas_principal.Click += new System.EventHandler(this.bt_caixa_principal_Click);
            // 
            // lb_desenvolvido_principal
            // 
            this.lb_desenvolvido_principal.AutoSize = true;
            this.lb_desenvolvido_principal.BackColor = System.Drawing.Color.Transparent;
            this.lb_desenvolvido_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desenvolvido_principal.Location = new System.Drawing.Point(98, 238);
            this.lb_desenvolvido_principal.Name = "lb_desenvolvido_principal";
            this.lb_desenvolvido_principal.Size = new System.Drawing.Size(201, 13);
            this.lb_desenvolvido_principal.TabIndex = 7;
            this.lb_desenvolvido_principal.Text = "Desenvolvido por Danielle Magrini";
            // 
            // bt_estoque
            // 
            this.bt_estoque.BackColor = System.Drawing.Color.White;
            this.bt_estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_estoque.FlatAppearance.BorderSize = 3;
            this.bt_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estoque.Location = new System.Drawing.Point(15, 105);
            this.bt_estoque.Name = "bt_estoque";
            this.bt_estoque.Size = new System.Drawing.Size(75, 66);
            this.bt_estoque.TabIndex = 8;
            this.bt_estoque.Text = "ESTOQUE";
            this.bt_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_estoque.UseVisualStyleBackColor = false;
            this.bt_estoque.Click += new System.EventHandler(this.bt_estoque_Click);
            // 
            // pb_estoque_principal
            // 
            this.pb_estoque_principal.BackColor = System.Drawing.Color.White;
            this.pb_estoque_principal.BackgroundImage = global::DesafioVendas.Properties.Resources.kisspng_computer_icons_customer_icon_design_users_group_customer_group_customers_forum_people_users_ic_5ab19556355223_5886768715215875422184;
            this.pb_estoque_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_estoque_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_estoque_principal.Image = global::DesafioVendas.Properties.Resources.estoque;
            this.pb_estoque_principal.Location = new System.Drawing.Point(26, 115);
            this.pb_estoque_principal.Name = "pb_estoque_principal";
            this.pb_estoque_principal.Size = new System.Drawing.Size(53, 36);
            this.pb_estoque_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_estoque_principal.TabIndex = 9;
            this.pb_estoque_principal.TabStop = false;
            this.pb_estoque_principal.Click += new System.EventHandler(this.pb_estoque_principal_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioVendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 260);
            this.Controls.Add(this.pb_estoque_principal);
            this.Controls.Add(this.bt_estoque);
            this.Controls.Add(this.lb_desenvolvido_principal);
            this.Controls.Add(this.pb_vendas_principal);
            this.Controls.Add(this.bt_vendas_principal);
            this.Controls.Add(this.pb_compras_principal);
            this.Controls.Add(this.bt_compras_principal);
            this.Controls.Add(this.pb_cliente_principal);
            this.Controls.Add(this.bt_cliente_principal);
            this.Controls.Add(this.ms_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_principal;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.ms_principal.ResumeLayout(false);
            this.ms_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cliente_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_compras_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vendas_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_estoque_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_principal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button bt_cliente_principal;
        private System.Windows.Forms.PictureBox pb_cliente_principal;
        private System.Windows.Forms.Button bt_compras_principal;
        private System.Windows.Forms.PictureBox pb_compras_principal;
        private System.Windows.Forms.PictureBox pb_vendas_principal;
        private System.Windows.Forms.Button bt_vendas_principal;
        private System.Windows.Forms.Label lb_desenvolvido_principal;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem2;
        private System.Windows.Forms.Button bt_estoque;
        private System.Windows.Forms.PictureBox pb_estoque_principal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem1;
    }
}

