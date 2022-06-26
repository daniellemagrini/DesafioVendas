namespace DesafioVendas.Forms
{
    partial class frm_compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_compras));
            this.tb_cod_barra_compras = new System.Windows.Forms.TextBox();
            this.lb_cod_barra_compras = new System.Windows.Forms.Label();
            this.lb_vl_compra_compras = new System.Windows.Forms.Label();
            this.tb_produto_compras = new System.Windows.Forms.TextBox();
            this.lb_produto_compras = new System.Windows.Forms.Label();
            this.tb_dt_entrada_compras = new System.Windows.Forms.TextBox();
            this.lb_dt_entrada_compras = new System.Windows.Forms.Label();
            this.lb_nf_compras = new System.Windows.Forms.Label();
            this.tb_id_compras = new System.Windows.Forms.TextBox();
            this.lb_id_compras = new System.Windows.Forms.Label();
            this.pb_consultar_compras = new System.Windows.Forms.PictureBox();
            this.bt_consultar_compras = new System.Windows.Forms.Button();
            this.pb_editar_compras = new System.Windows.Forms.PictureBox();
            this.bt_editar_compras = new System.Windows.Forms.Button();
            this.pb_remover_compras = new System.Windows.Forms.PictureBox();
            this.bt_remover_compras = new System.Windows.Forms.Button();
            this.pb_cadastrar_compras = new System.Windows.Forms.PictureBox();
            this.bt_cadastrar_compras = new System.Windows.Forms.Button();
            this.tb_vl_compra_produto = new System.Windows.Forms.TextBox();
            this.tb_qtde_compras = new System.Windows.Forms.TextBox();
            this.lb_qtde_compras = new System.Windows.Forms.Label();
            this.tb_nf_compras = new System.Windows.Forms.TextBox();
            this.bt_salvar_compra = new System.Windows.Forms.Button();
            this.bt_limpar_compra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cod_barra_compras
            // 
            this.tb_cod_barra_compras.BackColor = System.Drawing.Color.White;
            this.tb_cod_barra_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_barra_compras.Location = new System.Drawing.Point(150, 198);
            this.tb_cod_barra_compras.Name = "tb_cod_barra_compras";
            this.tb_cod_barra_compras.Size = new System.Drawing.Size(162, 20);
            this.tb_cod_barra_compras.TabIndex = 3;
            this.tb_cod_barra_compras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_barra_compras_KeyPress);
            // 
            // lb_cod_barra_compras
            // 
            this.lb_cod_barra_compras.AutoSize = true;
            this.lb_cod_barra_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_cod_barra_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_barra_compras.Location = new System.Drawing.Point(26, 201);
            this.lb_cod_barra_compras.Name = "lb_cod_barra_compras";
            this.lb_cod_barra_compras.Size = new System.Drawing.Size(126, 13);
            this.lb_cod_barra_compras.TabIndex = 116;
            this.lb_cod_barra_compras.Text = "CÓDIGO DE BARRA:";
            // 
            // lb_vl_compra_compras
            // 
            this.lb_vl_compra_compras.AutoSize = true;
            this.lb_vl_compra_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_vl_compra_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vl_compra_compras.Location = new System.Drawing.Point(26, 237);
            this.lb_vl_compra_compras.Name = "lb_vl_compra_compras";
            this.lb_vl_compra_compras.Size = new System.Drawing.Size(129, 13);
            this.lb_vl_compra_compras.TabIndex = 102;
            this.lb_vl_compra_compras.Text = "VALOR DE COMPRA:";
            // 
            // tb_produto_compras
            // 
            this.tb_produto_compras.BackColor = System.Drawing.Color.White;
            this.tb_produto_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produto_compras.Location = new System.Drawing.Point(97, 162);
            this.tb_produto_compras.Name = "tb_produto_compras";
            this.tb_produto_compras.Size = new System.Drawing.Size(360, 20);
            this.tb_produto_compras.TabIndex = 2;
            this.tb_produto_compras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_produto_compras_KeyPress);
            this.tb_produto_compras.Leave += new System.EventHandler(this.tb_produto_compras_Leave);
            // 
            // lb_produto_compras
            // 
            this.lb_produto_compras.AutoSize = true;
            this.lb_produto_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_produto_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_produto_compras.Location = new System.Drawing.Point(26, 165);
            this.lb_produto_compras.Name = "lb_produto_compras";
            this.lb_produto_compras.Size = new System.Drawing.Size(72, 13);
            this.lb_produto_compras.TabIndex = 96;
            this.lb_produto_compras.Text = "PRODUTO:";
            // 
            // tb_dt_entrada_compras
            // 
            this.tb_dt_entrada_compras.BackColor = System.Drawing.Color.White;
            this.tb_dt_entrada_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dt_entrada_compras.Location = new System.Drawing.Point(355, 126);
            this.tb_dt_entrada_compras.Name = "tb_dt_entrada_compras";
            this.tb_dt_entrada_compras.Size = new System.Drawing.Size(102, 20);
            this.tb_dt_entrada_compras.TabIndex = 1;
            this.tb_dt_entrada_compras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dt_entrada_compras_KeyPress);
            // 
            // lb_dt_entrada_compras
            // 
            this.lb_dt_entrada_compras.AutoSize = true;
            this.lb_dt_entrada_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_dt_entrada_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dt_entrada_compras.Location = new System.Drawing.Point(242, 129);
            this.lb_dt_entrada_compras.Name = "lb_dt_entrada_compras";
            this.lb_dt_entrada_compras.Size = new System.Drawing.Size(107, 13);
            this.lb_dt_entrada_compras.TabIndex = 84;
            this.lb_dt_entrada_compras.Text = "DATA ENTRADA:";
            // 
            // lb_nf_compras
            // 
            this.lb_nf_compras.AutoSize = true;
            this.lb_nf_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_nf_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nf_compras.Location = new System.Drawing.Point(129, 129);
            this.lb_nf_compras.Name = "lb_nf_compras";
            this.lb_nf_compras.Size = new System.Drawing.Size(27, 13);
            this.lb_nf_compras.TabIndex = 94;
            this.lb_nf_compras.Text = "NF:";
            // 
            // tb_id_compras
            // 
            this.tb_id_compras.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_id_compras.Enabled = false;
            this.tb_id_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_compras.Location = new System.Drawing.Point(48, 126);
            this.tb_id_compras.Name = "tb_id_compras";
            this.tb_id_compras.Size = new System.Drawing.Size(67, 20);
            this.tb_id_compras.TabIndex = 93;
            // 
            // lb_id_compras
            // 
            this.lb_id_compras.AutoSize = true;
            this.lb_id_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_id_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_compras.Location = new System.Drawing.Point(26, 129);
            this.lb_id_compras.Name = "lb_id_compras";
            this.lb_id_compras.Size = new System.Drawing.Size(24, 13);
            this.lb_id_compras.TabIndex = 92;
            this.lb_id_compras.Text = "ID:";
            // 
            // pb_consultar_compras
            // 
            this.pb_consultar_compras.BackColor = System.Drawing.Color.White;
            this.pb_consultar_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_consultar_compras.Image = global::DesafioVendas.Properties.Resources.consultar;
            this.pb_consultar_compras.Location = new System.Drawing.Point(365, 24);
            this.pb_consultar_compras.Name = "pb_consultar_compras";
            this.pb_consultar_compras.Size = new System.Drawing.Size(43, 39);
            this.pb_consultar_compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_consultar_compras.TabIndex = 91;
            this.pb_consultar_compras.TabStop = false;
            this.pb_consultar_compras.Click += new System.EventHandler(this.pb_consultar_compras_Click);
            // 
            // bt_consultar_compras
            // 
            this.bt_consultar_compras.BackColor = System.Drawing.Color.White;
            this.bt_consultar_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consultar_compras.FlatAppearance.BorderSize = 3;
            this.bt_consultar_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_consultar_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar_compras.Location = new System.Drawing.Point(342, 14);
            this.bt_consultar_compras.Name = "bt_consultar_compras";
            this.bt_consultar_compras.Size = new System.Drawing.Size(90, 70);
            this.bt_consultar_compras.TabIndex = 8;
            this.bt_consultar_compras.Text = "CONSULTAR";
            this.bt_consultar_compras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_consultar_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_consultar_compras.UseVisualStyleBackColor = false;
            // 
            // pb_editar_compras
            // 
            this.pb_editar_compras.BackColor = System.Drawing.Color.White;
            this.pb_editar_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editar_compras.Image = global::DesafioVendas.Properties.Resources.editar;
            this.pb_editar_compras.Location = new System.Drawing.Point(269, 24);
            this.pb_editar_compras.Name = "pb_editar_compras";
            this.pb_editar_compras.Size = new System.Drawing.Size(43, 39);
            this.pb_editar_compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editar_compras.TabIndex = 89;
            this.pb_editar_compras.TabStop = false;
            this.pb_editar_compras.Click += new System.EventHandler(this.pb_editar_compras_Click);
            // 
            // bt_editar_compras
            // 
            this.bt_editar_compras.BackColor = System.Drawing.Color.White;
            this.bt_editar_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar_compras.FlatAppearance.BorderSize = 3;
            this.bt_editar_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar_compras.Location = new System.Drawing.Point(246, 14);
            this.bt_editar_compras.Name = "bt_editar_compras";
            this.bt_editar_compras.Size = new System.Drawing.Size(90, 70);
            this.bt_editar_compras.TabIndex = 88;
            this.bt_editar_compras.Text = "EDITAR";
            this.bt_editar_compras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_editar_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_editar_compras.UseVisualStyleBackColor = false;
            // 
            // pb_remover_compras
            // 
            this.pb_remover_compras.BackColor = System.Drawing.Color.White;
            this.pb_remover_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_remover_compras.Image = global::DesafioVendas.Properties.Resources.menos;
            this.pb_remover_compras.Location = new System.Drawing.Point(173, 24);
            this.pb_remover_compras.Name = "pb_remover_compras";
            this.pb_remover_compras.Size = new System.Drawing.Size(43, 39);
            this.pb_remover_compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_remover_compras.TabIndex = 87;
            this.pb_remover_compras.TabStop = false;
            this.pb_remover_compras.Click += new System.EventHandler(this.pb_remover_compras_Click);
            // 
            // bt_remover_compras
            // 
            this.bt_remover_compras.BackColor = System.Drawing.Color.White;
            this.bt_remover_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remover_compras.FlatAppearance.BorderSize = 3;
            this.bt_remover_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_remover_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover_compras.Location = new System.Drawing.Point(150, 14);
            this.bt_remover_compras.Name = "bt_remover_compras";
            this.bt_remover_compras.Size = new System.Drawing.Size(90, 70);
            this.bt_remover_compras.TabIndex = 86;
            this.bt_remover_compras.Text = "REMOVER";
            this.bt_remover_compras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_remover_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_remover_compras.UseVisualStyleBackColor = false;
            // 
            // pb_cadastrar_compras
            // 
            this.pb_cadastrar_compras.BackColor = System.Drawing.Color.White;
            this.pb_cadastrar_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cadastrar_compras.Image = global::DesafioVendas.Properties.Resources.kisspng_plus_and_minus_signs_addition_clip_art_plus_sign_clipart_5aae23f077ebb2_3950908215213619044912;
            this.pb_cadastrar_compras.Location = new System.Drawing.Point(77, 24);
            this.pb_cadastrar_compras.Name = "pb_cadastrar_compras";
            this.pb_cadastrar_compras.Size = new System.Drawing.Size(43, 39);
            this.pb_cadastrar_compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cadastrar_compras.TabIndex = 85;
            this.pb_cadastrar_compras.TabStop = false;
            this.pb_cadastrar_compras.Click += new System.EventHandler(this.pb_cadastrar_compras_Click);
            // 
            // bt_cadastrar_compras
            // 
            this.bt_cadastrar_compras.BackColor = System.Drawing.Color.White;
            this.bt_cadastrar_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar_compras.FlatAppearance.BorderSize = 3;
            this.bt_cadastrar_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cadastrar_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar_compras.Location = new System.Drawing.Point(54, 14);
            this.bt_cadastrar_compras.Name = "bt_cadastrar_compras";
            this.bt_cadastrar_compras.Size = new System.Drawing.Size(90, 70);
            this.bt_cadastrar_compras.TabIndex = 7;
            this.bt_cadastrar_compras.Text = "CADASTRAR";
            this.bt_cadastrar_compras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cadastrar_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_cadastrar_compras.UseVisualStyleBackColor = false;
            // 
            // tb_vl_compra_produto
            // 
            this.tb_vl_compra_produto.BackColor = System.Drawing.Color.White;
            this.tb_vl_compra_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vl_compra_produto.Location = new System.Drawing.Point(154, 234);
            this.tb_vl_compra_produto.Name = "tb_vl_compra_produto";
            this.tb_vl_compra_produto.Size = new System.Drawing.Size(62, 20);
            this.tb_vl_compra_produto.TabIndex = 5;
            this.tb_vl_compra_produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_vl_compra_produto_KeyPress);
            // 
            // tb_qtde_compras
            // 
            this.tb_qtde_compras.BackColor = System.Drawing.Color.White;
            this.tb_qtde_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_compras.Location = new System.Drawing.Point(408, 195);
            this.tb_qtde_compras.Name = "tb_qtde_compras";
            this.tb_qtde_compras.Size = new System.Drawing.Size(49, 20);
            this.tb_qtde_compras.TabIndex = 4;
            this.tb_qtde_compras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtde_compras_KeyPress);
            // 
            // lb_qtde_compras
            // 
            this.lb_qtde_compras.AutoSize = true;
            this.lb_qtde_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_qtde_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtde_compras.Location = new System.Drawing.Point(318, 198);
            this.lb_qtde_compras.Name = "lb_qtde_compras";
            this.lb_qtde_compras.Size = new System.Drawing.Size(92, 13);
            this.lb_qtde_compras.TabIndex = 121;
            this.lb_qtde_compras.Text = "QUANTIDADE:";
            // 
            // tb_nf_compras
            // 
            this.tb_nf_compras.BackColor = System.Drawing.Color.White;
            this.tb_nf_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nf_compras.Location = new System.Drawing.Point(154, 126);
            this.tb_nf_compras.Name = "tb_nf_compras";
            this.tb_nf_compras.Size = new System.Drawing.Size(62, 20);
            this.tb_nf_compras.TabIndex = 0;
            this.tb_nf_compras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nf_compras_KeyPress);
            // 
            // bt_salvar_compra
            // 
            this.bt_salvar_compra.BackColor = System.Drawing.Color.White;
            this.bt_salvar_compra.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_salvar_compra.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_salvar_compra.FlatAppearance.BorderSize = 3;
            this.bt_salvar_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_salvar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_salvar_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar_compra.ForeColor = System.Drawing.Color.Indigo;
            this.bt_salvar_compra.Location = new System.Drawing.Point(325, 90);
            this.bt_salvar_compra.Name = "bt_salvar_compra";
            this.bt_salvar_compra.Size = new System.Drawing.Size(63, 20);
            this.bt_salvar_compra.TabIndex = 123;
            this.bt_salvar_compra.Text = "SALVAR";
            this.bt_salvar_compra.UseVisualStyleBackColor = false;
            this.bt_salvar_compra.Click += new System.EventHandler(this.bt_salvar_cliente_Click);
            // 
            // bt_limpar_compra
            // 
            this.bt_limpar_compra.BackColor = System.Drawing.Color.White;
            this.bt_limpar_compra.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_limpar_compra.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_limpar_compra.FlatAppearance.BorderSize = 3;
            this.bt_limpar_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_limpar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_limpar_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar_compra.ForeColor = System.Drawing.Color.Indigo;
            this.bt_limpar_compra.Location = new System.Drawing.Point(394, 90);
            this.bt_limpar_compra.Name = "bt_limpar_compra";
            this.bt_limpar_compra.Size = new System.Drawing.Size(63, 20);
            this.bt_limpar_compra.TabIndex = 122;
            this.bt_limpar_compra.Text = "LIMPAR";
            this.bt_limpar_compra.UseVisualStyleBackColor = false;
            this.bt_limpar_compra.Click += new System.EventHandler(this.bt_limpar_cliente_Click);
            // 
            // frm_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioVendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 380);
            this.Controls.Add(this.bt_salvar_compra);
            this.Controls.Add(this.bt_limpar_compra);
            this.Controls.Add(this.tb_nf_compras);
            this.Controls.Add(this.tb_qtde_compras);
            this.Controls.Add(this.lb_qtde_compras);
            this.Controls.Add(this.tb_vl_compra_produto);
            this.Controls.Add(this.tb_cod_barra_compras);
            this.Controls.Add(this.lb_cod_barra_compras);
            this.Controls.Add(this.lb_vl_compra_compras);
            this.Controls.Add(this.tb_produto_compras);
            this.Controls.Add(this.lb_produto_compras);
            this.Controls.Add(this.tb_dt_entrada_compras);
            this.Controls.Add(this.lb_dt_entrada_compras);
            this.Controls.Add(this.lb_nf_compras);
            this.Controls.Add(this.tb_id_compras);
            this.Controls.Add(this.lb_id_compras);
            this.Controls.Add(this.pb_consultar_compras);
            this.Controls.Add(this.bt_consultar_compras);
            this.Controls.Add(this.pb_editar_compras);
            this.Controls.Add(this.bt_editar_compras);
            this.Controls.Add(this.pb_remover_compras);
            this.Controls.Add(this.bt_remover_compras);
            this.Controls.Add(this.pb_cadastrar_compras);
            this.Controls.Add(this.bt_cadastrar_compras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_cod_barra_compras;
        private System.Windows.Forms.Label lb_cod_barra_compras;
        private System.Windows.Forms.Label lb_vl_compra_compras;
        private System.Windows.Forms.TextBox tb_produto_compras;
        private System.Windows.Forms.Label lb_produto_compras;
        private System.Windows.Forms.TextBox tb_dt_entrada_compras;
        private System.Windows.Forms.Label lb_dt_entrada_compras;
        private System.Windows.Forms.Label lb_nf_compras;
        private System.Windows.Forms.TextBox tb_id_compras;
        private System.Windows.Forms.Label lb_id_compras;
        private System.Windows.Forms.PictureBox pb_consultar_compras;
        private System.Windows.Forms.Button bt_consultar_compras;
        private System.Windows.Forms.PictureBox pb_editar_compras;
        private System.Windows.Forms.Button bt_editar_compras;
        private System.Windows.Forms.PictureBox pb_remover_compras;
        private System.Windows.Forms.Button bt_remover_compras;
        private System.Windows.Forms.PictureBox pb_cadastrar_compras;
        private System.Windows.Forms.Button bt_cadastrar_compras;
        private System.Windows.Forms.TextBox tb_vl_compra_produto;
        private System.Windows.Forms.TextBox tb_qtde_compras;
        private System.Windows.Forms.Label lb_qtde_compras;
        private System.Windows.Forms.TextBox tb_nf_compras;
        private System.Windows.Forms.Button bt_salvar_compra;
        private System.Windows.Forms.Button bt_limpar_compra;
    }
}