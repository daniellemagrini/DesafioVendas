namespace DesafioVendas.Forms
{
    partial class frm_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_clientes));
            this.bt_cadastrar_cliente = new System.Windows.Forms.Button();
            this.pb_cadastrar_cliente = new System.Windows.Forms.PictureBox();
            this.pb_remover_cliente = new System.Windows.Forms.PictureBox();
            this.bt_remover_cliente = new System.Windows.Forms.Button();
            this.pb_editar_cliente = new System.Windows.Forms.PictureBox();
            this.bt_editar_cliente = new System.Windows.Forms.Button();
            this.pb_consultar_cliente = new System.Windows.Forms.PictureBox();
            this.bt_consultar_cliente = new System.Windows.Forms.Button();
            this.lb_id_cliente = new System.Windows.Forms.Label();
            this.tb_id_cliente = new System.Windows.Forms.TextBox();
            this.lb_tipo_cliente = new System.Windows.Forms.Label();
            this.cb_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.tb_cpf_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.lb_cpf_cnpj_cliente = new System.Windows.Forms.Label();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.lb_nome_cliente = new System.Windows.Forms.Label();
            this.tb_dt_nascimento_cliente = new System.Windows.Forms.TextBox();
            this.lb_dt_nascimento_cliente = new System.Windows.Forms.Label();
            this.lb_celular_cliente = new System.Windows.Forms.Label();
            this.tb_celular_cliente = new System.Windows.Forms.TextBox();
            this.tb_cep_cliente = new System.Windows.Forms.TextBox();
            this.lb_cep_cliente = new System.Windows.Forms.Label();
            this.tb_cidade_cliente = new System.Windows.Forms.TextBox();
            this.lb_cidade_cliente = new System.Windows.Forms.Label();
            this.tb_estado_cliente = new System.Windows.Forms.TextBox();
            this.lb_estado_cliente = new System.Windows.Forms.Label();
            this.tb_bairro_cliente = new System.Windows.Forms.TextBox();
            this.lb_bairro_cliente = new System.Windows.Forms.Label();
            this.tb_numero_end_cliente = new System.Windows.Forms.TextBox();
            this.lb_numero_end_cliente = new System.Windows.Forms.Label();
            this.tb_complemento_cliente = new System.Windows.Forms.TextBox();
            this.lb_complemento_cliente = new System.Windows.Forms.Label();
            this.tb_endereco_cliente = new System.Windows.Forms.TextBox();
            this.lb_endereco_cliente = new System.Windows.Forms.Label();
            this.tb_email_cliente = new System.Windows.Forms.TextBox();
            this.lb_email_cliente = new System.Windows.Forms.Label();
            this.bt_consulta_cep_cliente = new System.Windows.Forms.Button();
            this.bt_limpar_cliente = new System.Windows.Forms.Button();
            this.bt_salvar_cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cadastrar_cliente
            // 
            this.bt_cadastrar_cliente.BackColor = System.Drawing.Color.White;
            this.bt_cadastrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar_cliente.FlatAppearance.BorderSize = 3;
            this.bt_cadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cadastrar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar_cliente.Location = new System.Drawing.Point(59, 12);
            this.bt_cadastrar_cliente.Name = "bt_cadastrar_cliente";
            this.bt_cadastrar_cliente.Size = new System.Drawing.Size(90, 70);
            this.bt_cadastrar_cliente.TabIndex = 11;
            this.bt_cadastrar_cliente.Text = "CADASTRAR";
            this.bt_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cadastrar_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_cadastrar_cliente.UseVisualStyleBackColor = false;
            // 
            // pb_cadastrar_cliente
            // 
            this.pb_cadastrar_cliente.BackColor = System.Drawing.Color.White;
            this.pb_cadastrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cadastrar_cliente.Image = global::DesafioVendas.Properties.Resources.kisspng_plus_and_minus_signs_addition_clip_art_plus_sign_clipart_5aae23f077ebb2_3950908215213619044912;
            this.pb_cadastrar_cliente.Location = new System.Drawing.Point(82, 22);
            this.pb_cadastrar_cliente.Name = "pb_cadastrar_cliente";
            this.pb_cadastrar_cliente.Size = new System.Drawing.Size(43, 39);
            this.pb_cadastrar_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cadastrar_cliente.TabIndex = 4;
            this.pb_cadastrar_cliente.TabStop = false;
            this.pb_cadastrar_cliente.Click += new System.EventHandler(this.pb_cadastrar_cliente_Click);
            // 
            // pb_remover_cliente
            // 
            this.pb_remover_cliente.BackColor = System.Drawing.Color.White;
            this.pb_remover_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_remover_cliente.Image = global::DesafioVendas.Properties.Resources.menos;
            this.pb_remover_cliente.Location = new System.Drawing.Point(178, 22);
            this.pb_remover_cliente.Name = "pb_remover_cliente";
            this.pb_remover_cliente.Size = new System.Drawing.Size(43, 39);
            this.pb_remover_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_remover_cliente.TabIndex = 6;
            this.pb_remover_cliente.TabStop = false;
            this.pb_remover_cliente.Click += new System.EventHandler(this.pb_remover_cliente_Click);
            // 
            // bt_remover_cliente
            // 
            this.bt_remover_cliente.BackColor = System.Drawing.Color.White;
            this.bt_remover_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remover_cliente.FlatAppearance.BorderSize = 3;
            this.bt_remover_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_remover_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover_cliente.Location = new System.Drawing.Point(155, 12);
            this.bt_remover_cliente.Name = "bt_remover_cliente";
            this.bt_remover_cliente.Size = new System.Drawing.Size(90, 70);
            this.bt_remover_cliente.TabIndex = 5;
            this.bt_remover_cliente.Text = "REMOVER";
            this.bt_remover_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_remover_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_remover_cliente.UseVisualStyleBackColor = false;
            // 
            // pb_editar_cliente
            // 
            this.pb_editar_cliente.BackColor = System.Drawing.Color.White;
            this.pb_editar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editar_cliente.Image = global::DesafioVendas.Properties.Resources.editar;
            this.pb_editar_cliente.Location = new System.Drawing.Point(274, 22);
            this.pb_editar_cliente.Name = "pb_editar_cliente";
            this.pb_editar_cliente.Size = new System.Drawing.Size(43, 39);
            this.pb_editar_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editar_cliente.TabIndex = 8;
            this.pb_editar_cliente.TabStop = false;
            this.pb_editar_cliente.Click += new System.EventHandler(this.pb_editar_cliente_Click);
            // 
            // bt_editar_cliente
            // 
            this.bt_editar_cliente.BackColor = System.Drawing.Color.White;
            this.bt_editar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar_cliente.FlatAppearance.BorderSize = 3;
            this.bt_editar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar_cliente.Location = new System.Drawing.Point(251, 12);
            this.bt_editar_cliente.Name = "bt_editar_cliente";
            this.bt_editar_cliente.Size = new System.Drawing.Size(90, 70);
            this.bt_editar_cliente.TabIndex = 20;
            this.bt_editar_cliente.Text = "EDITAR";
            this.bt_editar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_editar_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_editar_cliente.UseVisualStyleBackColor = false;
            // 
            // pb_consultar_cliente
            // 
            this.pb_consultar_cliente.BackColor = System.Drawing.Color.White;
            this.pb_consultar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_consultar_cliente.Image = global::DesafioVendas.Properties.Resources.consultar;
            this.pb_consultar_cliente.Location = new System.Drawing.Point(370, 22);
            this.pb_consultar_cliente.Name = "pb_consultar_cliente";
            this.pb_consultar_cliente.Size = new System.Drawing.Size(43, 39);
            this.pb_consultar_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_consultar_cliente.TabIndex = 10;
            this.pb_consultar_cliente.TabStop = false;
            this.pb_consultar_cliente.Click += new System.EventHandler(this.pb_consultar_cliente_Click);
            // 
            // bt_consultar_cliente
            // 
            this.bt_consultar_cliente.BackColor = System.Drawing.Color.White;
            this.bt_consultar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consultar_cliente.FlatAppearance.BorderSize = 3;
            this.bt_consultar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_consultar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar_cliente.Location = new System.Drawing.Point(347, 12);
            this.bt_consultar_cliente.Name = "bt_consultar_cliente";
            this.bt_consultar_cliente.Size = new System.Drawing.Size(90, 70);
            this.bt_consultar_cliente.TabIndex = 12;
            this.bt_consultar_cliente.Text = "CONSULTAR";
            this.bt_consultar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_consultar_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_consultar_cliente.UseVisualStyleBackColor = false;
            // 
            // lb_id_cliente
            // 
            this.lb_id_cliente.AutoSize = true;
            this.lb_id_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_cliente.Location = new System.Drawing.Point(31, 127);
            this.lb_id_cliente.Name = "lb_id_cliente";
            this.lb_id_cliente.Size = new System.Drawing.Size(24, 13);
            this.lb_id_cliente.TabIndex = 11;
            this.lb_id_cliente.Text = "ID:";
            // 
            // tb_id_cliente
            // 
            this.tb_id_cliente.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_id_cliente.Enabled = false;
            this.tb_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_cliente.Location = new System.Drawing.Point(53, 124);
            this.tb_id_cliente.Name = "tb_id_cliente";
            this.tb_id_cliente.Size = new System.Drawing.Size(67, 20);
            this.tb_id_cliente.TabIndex = 55;
            // 
            // lb_tipo_cliente
            // 
            this.lb_tipo_cliente.AutoSize = true;
            this.lb_tipo_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_tipo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo_cliente.Location = new System.Drawing.Point(134, 127);
            this.lb_tipo_cliente.Name = "lb_tipo_cliente";
            this.lb_tipo_cliente.Size = new System.Drawing.Size(40, 13);
            this.lb_tipo_cliente.TabIndex = 56;
            this.lb_tipo_cliente.Text = "TIPO:";
            // 
            // cb_tipo_cliente
            // 
            this.cb_tipo_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tipo_cliente.FormattingEnabled = true;
            this.cb_tipo_cliente.Items.AddRange(new object[] {
            "PESSOA FÍSICA",
            "PESSOA JURÍDICA"});
            this.cb_tipo_cliente.Location = new System.Drawing.Point(171, 123);
            this.cb_tipo_cliente.Name = "cb_tipo_cliente";
            this.cb_tipo_cliente.Size = new System.Drawing.Size(104, 21);
            this.cb_tipo_cliente.TabIndex = 0;
            // 
            // tb_cpf_cnpj_cliente
            // 
            this.tb_cpf_cnpj_cliente.BackColor = System.Drawing.Color.White;
            this.tb_cpf_cnpj_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpf_cnpj_cliente.Location = new System.Drawing.Point(360, 124);
            this.tb_cpf_cnpj_cliente.Name = "tb_cpf_cnpj_cliente";
            this.tb_cpf_cnpj_cliente.Size = new System.Drawing.Size(102, 20);
            this.tb_cpf_cnpj_cliente.TabIndex = 1;
            this.tb_cpf_cnpj_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cpf_cnpj_cliente_KeyPress);
            // 
            // lb_cpf_cnpj_cliente
            // 
            this.lb_cpf_cnpj_cliente.AutoSize = true;
            this.lb_cpf_cnpj_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_cpf_cnpj_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf_cnpj_cliente.Location = new System.Drawing.Point(291, 127);
            this.lb_cpf_cnpj_cliente.Name = "lb_cpf_cnpj_cliente";
            this.lb_cpf_cnpj_cliente.Size = new System.Drawing.Size(71, 13);
            this.lb_cpf_cnpj_cliente.TabIndex = 2;
            this.lb_cpf_cnpj_cliente.Text = "CPF/CNPJ:";
            // 
            // tb_nome_cliente
            // 
            this.tb_nome_cliente.BackColor = System.Drawing.Color.White;
            this.tb_nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_cliente.Location = new System.Drawing.Point(147, 160);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(315, 20);
            this.tb_nome_cliente.TabIndex = 2;
            this.tb_nome_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nome_cliente_KeyPress);
            this.tb_nome_cliente.Leave += new System.EventHandler(this.tb_nome_cliente_Leave);
            // 
            // lb_nome_cliente
            // 
            this.lb_nome_cliente.AutoSize = true;
            this.lb_nome_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_cliente.Location = new System.Drawing.Point(31, 163);
            this.lb_nome_cliente.Name = "lb_nome_cliente";
            this.lb_nome_cliente.Size = new System.Drawing.Size(118, 13);
            this.lb_nome_cliente.TabIndex = 59;
            this.lb_nome_cliente.Text = "NOME COMPLETO:";
            // 
            // tb_dt_nascimento_cliente
            // 
            this.tb_dt_nascimento_cliente.BackColor = System.Drawing.Color.White;
            this.tb_dt_nascimento_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dt_nascimento_cliente.Location = new System.Drawing.Point(177, 193);
            this.tb_dt_nascimento_cliente.Name = "tb_dt_nascimento_cliente";
            this.tb_dt_nascimento_cliente.Size = new System.Drawing.Size(98, 20);
            this.tb_dt_nascimento_cliente.TabIndex = 3;
            this.tb_dt_nascimento_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dt_nascimento_cliente_KeyPress);
            // 
            // lb_dt_nascimento_cliente
            // 
            this.lb_dt_nascimento_cliente.AutoSize = true;
            this.lb_dt_nascimento_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_dt_nascimento_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dt_nascimento_cliente.Location = new System.Drawing.Point(31, 196);
            this.lb_dt_nascimento_cliente.Name = "lb_dt_nascimento_cliente";
            this.lb_dt_nascimento_cliente.Size = new System.Drawing.Size(150, 13);
            this.lb_dt_nascimento_cliente.TabIndex = 61;
            this.lb_dt_nascimento_cliente.Text = "DATA DE NASCIMENTO:";
            // 
            // lb_celular_cliente
            // 
            this.lb_celular_cliente.AutoSize = true;
            this.lb_celular_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_celular_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular_cliente.Location = new System.Drawing.Point(287, 196);
            this.lb_celular_cliente.Name = "lb_celular_cliente";
            this.lb_celular_cliente.Size = new System.Drawing.Size(67, 13);
            this.lb_celular_cliente.TabIndex = 63;
            this.lb_celular_cliente.Text = "CELULAR:";
            // 
            // tb_celular_cliente
            // 
            this.tb_celular_cliente.BackColor = System.Drawing.Color.White;
            this.tb_celular_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_celular_cliente.Location = new System.Drawing.Point(353, 193);
            this.tb_celular_cliente.Name = "tb_celular_cliente";
            this.tb_celular_cliente.Size = new System.Drawing.Size(109, 20);
            this.tb_celular_cliente.TabIndex = 4;
            this.tb_celular_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_celular_cliente_KeyPress);
            // 
            // tb_cep_cliente
            // 
            this.tb_cep_cliente.BackColor = System.Drawing.Color.White;
            this.tb_cep_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cep_cliente.Location = new System.Drawing.Point(64, 228);
            this.tb_cep_cliente.Name = "tb_cep_cliente";
            this.tb_cep_cliente.Size = new System.Drawing.Size(85, 20);
            this.tb_cep_cliente.TabIndex = 5;
            this.tb_cep_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cep_cliente_KeyPress);
            this.tb_cep_cliente.Leave += new System.EventHandler(this.tb_cep_cliente_Leave);
            // 
            // lb_cep_cliente
            // 
            this.lb_cep_cliente.AutoSize = true;
            this.lb_cep_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_cep_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cep_cliente.Location = new System.Drawing.Point(31, 231);
            this.lb_cep_cliente.Name = "lb_cep_cliente";
            this.lb_cep_cliente.Size = new System.Drawing.Size(35, 13);
            this.lb_cep_cliente.TabIndex = 65;
            this.lb_cep_cliente.Text = "CEP:";
            // 
            // tb_cidade_cliente
            // 
            this.tb_cidade_cliente.BackColor = System.Drawing.Color.White;
            this.tb_cidade_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade_cliente.Location = new System.Drawing.Point(217, 228);
            this.tb_cidade_cliente.Name = "tb_cidade_cliente";
            this.tb_cidade_cliente.Size = new System.Drawing.Size(128, 20);
            this.tb_cidade_cliente.TabIndex = 60;
            // 
            // lb_cidade_cliente
            // 
            this.lb_cidade_cliente.AutoSize = true;
            this.lb_cidade_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_cidade_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade_cliente.Location = new System.Drawing.Point(163, 231);
            this.lb_cidade_cliente.Name = "lb_cidade_cliente";
            this.lb_cidade_cliente.Size = new System.Drawing.Size(57, 13);
            this.lb_cidade_cliente.TabIndex = 67;
            this.lb_cidade_cliente.Text = "CIDADE:";
            // 
            // tb_estado_cliente
            // 
            this.tb_estado_cliente.BackColor = System.Drawing.Color.White;
            this.tb_estado_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estado_cliente.Location = new System.Drawing.Point(414, 228);
            this.tb_estado_cliente.Name = "tb_estado_cliente";
            this.tb_estado_cliente.Size = new System.Drawing.Size(48, 20);
            this.tb_estado_cliente.TabIndex = 70;
            // 
            // lb_estado_cliente
            // 
            this.lb_estado_cliente.AutoSize = true;
            this.lb_estado_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_estado_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado_cliente.Location = new System.Drawing.Point(351, 231);
            this.lb_estado_cliente.Name = "lb_estado_cliente";
            this.lb_estado_cliente.Size = new System.Drawing.Size(61, 13);
            this.lb_estado_cliente.TabIndex = 69;
            this.lb_estado_cliente.Text = "ESTADO:";
            // 
            // tb_bairro_cliente
            // 
            this.tb_bairro_cliente.BackColor = System.Drawing.Color.White;
            this.tb_bairro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro_cliente.Location = new System.Drawing.Point(85, 272);
            this.tb_bairro_cliente.Name = "tb_bairro_cliente";
            this.tb_bairro_cliente.Size = new System.Drawing.Size(128, 20);
            this.tb_bairro_cliente.TabIndex = 6;
            this.tb_bairro_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_bairro_cliente_KeyPress);
            this.tb_bairro_cliente.Leave += new System.EventHandler(this.tb_bairro_cliente_Leave);
            // 
            // lb_bairro_cliente
            // 
            this.lb_bairro_cliente.AutoSize = true;
            this.lb_bairro_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_bairro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro_cliente.Location = new System.Drawing.Point(31, 275);
            this.lb_bairro_cliente.Name = "lb_bairro_cliente";
            this.lb_bairro_cliente.Size = new System.Drawing.Size(58, 13);
            this.lb_bairro_cliente.TabIndex = 71;
            this.lb_bairro_cliente.Text = "BAIRRO:";
            // 
            // tb_numero_end_cliente
            // 
            this.tb_numero_end_cliente.BackColor = System.Drawing.Color.White;
            this.tb_numero_end_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero_end_cliente.Location = new System.Drawing.Point(414, 304);
            this.tb_numero_end_cliente.Name = "tb_numero_end_cliente";
            this.tb_numero_end_cliente.Size = new System.Drawing.Size(48, 20);
            this.tb_numero_end_cliente.TabIndex = 9;
            this.tb_numero_end_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numero_end_cliente_KeyPress);
            this.tb_numero_end_cliente.Leave += new System.EventHandler(this.tb_numero_end_cliente_Leave);
            // 
            // lb_numero_end_cliente
            // 
            this.lb_numero_end_cliente.AutoSize = true;
            this.lb_numero_end_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_numero_end_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero_end_cliente.Location = new System.Drawing.Point(387, 307);
            this.lb_numero_end_cliente.Name = "lb_numero_end_cliente";
            this.lb_numero_end_cliente.Size = new System.Drawing.Size(25, 13);
            this.lb_numero_end_cliente.TabIndex = 73;
            this.lb_numero_end_cliente.Text = "Nº:";
            // 
            // tb_complemento_cliente
            // 
            this.tb_complemento_cliente.BackColor = System.Drawing.Color.White;
            this.tb_complemento_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_complemento_cliente.Location = new System.Drawing.Point(327, 272);
            this.tb_complemento_cliente.Name = "tb_complemento_cliente";
            this.tb_complemento_cliente.Size = new System.Drawing.Size(135, 20);
            this.tb_complemento_cliente.TabIndex = 7;
            this.tb_complemento_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_complemento_cliente_KeyPress);
            this.tb_complemento_cliente.Leave += new System.EventHandler(this.tb_complemento_cliente_Leave);
            // 
            // lb_complemento_cliente
            // 
            this.lb_complemento_cliente.AutoSize = true;
            this.lb_complemento_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_complemento_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_complemento_cliente.Location = new System.Drawing.Point(224, 275);
            this.lb_complemento_cliente.Name = "lb_complemento_cliente";
            this.lb_complemento_cliente.Size = new System.Drawing.Size(105, 13);
            this.lb_complemento_cliente.TabIndex = 75;
            this.lb_complemento_cliente.Text = "COMPLEMENTO:";
            // 
            // tb_endereco_cliente
            // 
            this.tb_endereco_cliente.BackColor = System.Drawing.Color.White;
            this.tb_endereco_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco_cliente.Location = new System.Drawing.Point(106, 304);
            this.tb_endereco_cliente.Name = "tb_endereco_cliente";
            this.tb_endereco_cliente.Size = new System.Drawing.Size(267, 20);
            this.tb_endereco_cliente.TabIndex = 8;
            this.tb_endereco_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_endereco_cliente_KeyPress);
            this.tb_endereco_cliente.Leave += new System.EventHandler(this.tb_endereco_cliente_Leave);
            // 
            // lb_endereco_cliente
            // 
            this.lb_endereco_cliente.AutoSize = true;
            this.lb_endereco_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_endereco_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco_cliente.Location = new System.Drawing.Point(31, 307);
            this.lb_endereco_cliente.Name = "lb_endereco_cliente";
            this.lb_endereco_cliente.Size = new System.Drawing.Size(79, 13);
            this.lb_endereco_cliente.TabIndex = 77;
            this.lb_endereco_cliente.Text = "ENDEREÇO:";
            // 
            // tb_email_cliente
            // 
            this.tb_email_cliente.BackColor = System.Drawing.Color.White;
            this.tb_email_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email_cliente.Location = new System.Drawing.Point(85, 339);
            this.tb_email_cliente.Name = "tb_email_cliente";
            this.tb_email_cliente.Size = new System.Drawing.Size(372, 20);
            this.tb_email_cliente.TabIndex = 10;
            // 
            // lb_email_cliente
            // 
            this.lb_email_cliente.AutoSize = true;
            this.lb_email_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_email_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email_cliente.Location = new System.Drawing.Point(31, 342);
            this.lb_email_cliente.Name = "lb_email_cliente";
            this.lb_email_cliente.Size = new System.Drawing.Size(52, 13);
            this.lb_email_cliente.TabIndex = 79;
            this.lb_email_cliente.Text = "E-MAIL:";
            // 
            // bt_consulta_cep_cliente
            // 
            this.bt_consulta_cep_cliente.BackColor = System.Drawing.Color.Transparent;
            this.bt_consulta_cep_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consulta_cep_cliente.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bt_consulta_cep_cliente.Location = new System.Drawing.Point(80, 248);
            this.bt_consulta_cep_cliente.Name = "bt_consulta_cep_cliente";
            this.bt_consulta_cep_cliente.Size = new System.Drawing.Size(70, 20);
            this.bt_consulta_cep_cliente.TabIndex = 81;
            this.bt_consulta_cep_cliente.Text = "Não sei meu cep";
            this.bt_consulta_cep_cliente.UseVisualStyleBackColor = false;
            this.bt_consulta_cep_cliente.Click += new System.EventHandler(this.bt_consulta_cep_cliente_Click);
            // 
            // bt_limpar_cliente
            // 
            this.bt_limpar_cliente.BackColor = System.Drawing.Color.White;
            this.bt_limpar_cliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_limpar_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_limpar_cliente.FlatAppearance.BorderSize = 3;
            this.bt_limpar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_limpar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_limpar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar_cliente.ForeColor = System.Drawing.Color.Indigo;
            this.bt_limpar_cliente.Location = new System.Drawing.Point(399, 88);
            this.bt_limpar_cliente.Name = "bt_limpar_cliente";
            this.bt_limpar_cliente.Size = new System.Drawing.Size(63, 20);
            this.bt_limpar_cliente.TabIndex = 82;
            this.bt_limpar_cliente.Text = "LIMPAR";
            this.bt_limpar_cliente.UseVisualStyleBackColor = false;
            this.bt_limpar_cliente.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_salvar_cliente
            // 
            this.bt_salvar_cliente.BackColor = System.Drawing.Color.White;
            this.bt_salvar_cliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_salvar_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_salvar_cliente.FlatAppearance.BorderSize = 3;
            this.bt_salvar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_salvar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_salvar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar_cliente.ForeColor = System.Drawing.Color.Indigo;
            this.bt_salvar_cliente.Location = new System.Drawing.Point(330, 88);
            this.bt_salvar_cliente.Name = "bt_salvar_cliente";
            this.bt_salvar_cliente.Size = new System.Drawing.Size(63, 20);
            this.bt_salvar_cliente.TabIndex = 83;
            this.bt_salvar_cliente.Text = "SALVAR";
            this.bt_salvar_cliente.UseVisualStyleBackColor = false;
            this.bt_salvar_cliente.Click += new System.EventHandler(this.bt_salvar_cliente_Click);
            // 
            // frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioVendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 380);
            this.Controls.Add(this.bt_salvar_cliente);
            this.Controls.Add(this.bt_limpar_cliente);
            this.Controls.Add(this.bt_consulta_cep_cliente);
            this.Controls.Add(this.tb_email_cliente);
            this.Controls.Add(this.lb_email_cliente);
            this.Controls.Add(this.tb_endereco_cliente);
            this.Controls.Add(this.lb_endereco_cliente);
            this.Controls.Add(this.tb_complemento_cliente);
            this.Controls.Add(this.lb_complemento_cliente);
            this.Controls.Add(this.tb_numero_end_cliente);
            this.Controls.Add(this.lb_numero_end_cliente);
            this.Controls.Add(this.tb_bairro_cliente);
            this.Controls.Add(this.lb_bairro_cliente);
            this.Controls.Add(this.tb_estado_cliente);
            this.Controls.Add(this.lb_estado_cliente);
            this.Controls.Add(this.tb_cidade_cliente);
            this.Controls.Add(this.lb_cidade_cliente);
            this.Controls.Add(this.tb_cep_cliente);
            this.Controls.Add(this.lb_cep_cliente);
            this.Controls.Add(this.tb_celular_cliente);
            this.Controls.Add(this.lb_celular_cliente);
            this.Controls.Add(this.tb_dt_nascimento_cliente);
            this.Controls.Add(this.lb_dt_nascimento_cliente);
            this.Controls.Add(this.tb_nome_cliente);
            this.Controls.Add(this.lb_nome_cliente);
            this.Controls.Add(this.tb_cpf_cnpj_cliente);
            this.Controls.Add(this.lb_cpf_cnpj_cliente);
            this.Controls.Add(this.cb_tipo_cliente);
            this.Controls.Add(this.lb_tipo_cliente);
            this.Controls.Add(this.tb_id_cliente);
            this.Controls.Add(this.lb_id_cliente);
            this.Controls.Add(this.pb_consultar_cliente);
            this.Controls.Add(this.bt_consultar_cliente);
            this.Controls.Add(this.pb_editar_cliente);
            this.Controls.Add(this.bt_editar_cliente);
            this.Controls.Add(this.pb_remover_cliente);
            this.Controls.Add(this.bt_remover_cliente);
            this.Controls.Add(this.pb_cadastrar_cliente);
            this.Controls.Add(this.bt_cadastrar_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrar_cliente;
        private System.Windows.Forms.PictureBox pb_cadastrar_cliente;
        private System.Windows.Forms.PictureBox pb_remover_cliente;
        private System.Windows.Forms.Button bt_remover_cliente;
        private System.Windows.Forms.PictureBox pb_editar_cliente;
        private System.Windows.Forms.Button bt_editar_cliente;
        private System.Windows.Forms.PictureBox pb_consultar_cliente;
        private System.Windows.Forms.Button bt_consultar_cliente;
        private System.Windows.Forms.Label lb_id_cliente;
        private System.Windows.Forms.TextBox tb_id_cliente;
        private System.Windows.Forms.Label lb_tipo_cliente;
        private System.Windows.Forms.ComboBox cb_tipo_cliente;
        private System.Windows.Forms.TextBox tb_cpf_cnpj_cliente;
        private System.Windows.Forms.Label lb_cpf_cnpj_cliente;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.Label lb_nome_cliente;
        private System.Windows.Forms.TextBox tb_dt_nascimento_cliente;
        private System.Windows.Forms.Label lb_dt_nascimento_cliente;
        private System.Windows.Forms.Label lb_celular_cliente;
        private System.Windows.Forms.TextBox tb_celular_cliente;
        private System.Windows.Forms.TextBox tb_cep_cliente;
        private System.Windows.Forms.Label lb_cep_cliente;
        private System.Windows.Forms.TextBox tb_cidade_cliente;
        private System.Windows.Forms.Label lb_cidade_cliente;
        private System.Windows.Forms.TextBox tb_estado_cliente;
        private System.Windows.Forms.Label lb_estado_cliente;
        private System.Windows.Forms.TextBox tb_bairro_cliente;
        private System.Windows.Forms.Label lb_bairro_cliente;
        private System.Windows.Forms.TextBox tb_numero_end_cliente;
        private System.Windows.Forms.Label lb_numero_end_cliente;
        private System.Windows.Forms.TextBox tb_complemento_cliente;
        private System.Windows.Forms.Label lb_complemento_cliente;
        private System.Windows.Forms.TextBox tb_endereco_cliente;
        private System.Windows.Forms.Label lb_endereco_cliente;
        private System.Windows.Forms.TextBox tb_email_cliente;
        private System.Windows.Forms.Label lb_email_cliente;
        private System.Windows.Forms.Button bt_consulta_cep_cliente;
        private System.Windows.Forms.Button bt_limpar_cliente;
        private System.Windows.Forms.Button bt_salvar_cliente;
    }
}