namespace DesafioVendas.Forms
{
    partial class frm_caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_caixa));
            this.lb_id_caixa = new System.Windows.Forms.Label();
            this.tb_dt_caixa = new System.Windows.Forms.TextBox();
            this.tb_vl_caixa = new System.Windows.Forms.TextBox();
            this.lb_vl_caixa = new System.Windows.Forms.Label();
            this.lb_dt_caixa = new System.Windows.Forms.Label();
            this.tb_id_caixa = new System.Windows.Forms.TextBox();
            this.pb_consultar_caixa = new System.Windows.Forms.PictureBox();
            this.bt_consultar_caixa = new System.Windows.Forms.Button();
            this.pb_editar_caixa = new System.Windows.Forms.PictureBox();
            this.bt_editar_caixa = new System.Windows.Forms.Button();
            this.pb_remover_caixa = new System.Windows.Forms.PictureBox();
            this.bt_remover_caixa = new System.Windows.Forms.Button();
            this.pb_cadastrar_caixa = new System.Windows.Forms.PictureBox();
            this.bt_cadastrar_caixa = new System.Windows.Forms.Button();
            this.dg_caixa = new System.Windows.Forms.DataGridView();
            this.dg_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_id_caixa
            // 
            this.lb_id_caixa.AutoSize = true;
            this.lb_id_caixa.BackColor = System.Drawing.Color.Transparent;
            this.lb_id_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_caixa.Location = new System.Drawing.Point(20, 139);
            this.lb_id_caixa.Name = "lb_id_caixa";
            this.lb_id_caixa.Size = new System.Drawing.Size(24, 13);
            this.lb_id_caixa.TabIndex = 161;
            this.lb_id_caixa.Text = "ID:";
            // 
            // tb_dt_caixa
            // 
            this.tb_dt_caixa.BackColor = System.Drawing.Color.White;
            this.tb_dt_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dt_caixa.Location = new System.Drawing.Point(194, 136);
            this.tb_dt_caixa.Name = "tb_dt_caixa";
            this.tb_dt_caixa.Size = new System.Drawing.Size(85, 20);
            this.tb_dt_caixa.TabIndex = 0;
            // 
            // tb_vl_caixa
            // 
            this.tb_vl_caixa.BackColor = System.Drawing.Color.White;
            this.tb_vl_caixa.Enabled = false;
            this.tb_vl_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vl_caixa.Location = new System.Drawing.Point(360, 136);
            this.tb_vl_caixa.Name = "tb_vl_caixa";
            this.tb_vl_caixa.Size = new System.Drawing.Size(58, 20);
            this.tb_vl_caixa.TabIndex = 159;
            // 
            // lb_vl_caixa
            // 
            this.lb_vl_caixa.AutoSize = true;
            this.lb_vl_caixa.BackColor = System.Drawing.Color.Transparent;
            this.lb_vl_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vl_caixa.Location = new System.Drawing.Point(308, 139);
            this.lb_vl_caixa.Name = "lb_vl_caixa";
            this.lb_vl_caixa.Size = new System.Drawing.Size(52, 13);
            this.lb_vl_caixa.TabIndex = 158;
            this.lb_vl_caixa.Text = "VALOR:";
            // 
            // lb_dt_caixa
            // 
            this.lb_dt_caixa.AutoSize = true;
            this.lb_dt_caixa.BackColor = System.Drawing.Color.Transparent;
            this.lb_dt_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dt_caixa.Location = new System.Drawing.Point(151, 139);
            this.lb_dt_caixa.Name = "lb_dt_caixa";
            this.lb_dt_caixa.Size = new System.Drawing.Size(44, 13);
            this.lb_dt_caixa.TabIndex = 155;
            this.lb_dt_caixa.Text = "DATA:";
            // 
            // tb_id_caixa
            // 
            this.tb_id_caixa.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_id_caixa.Enabled = false;
            this.tb_id_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_caixa.Location = new System.Drawing.Point(45, 136);
            this.tb_id_caixa.Name = "tb_id_caixa";
            this.tb_id_caixa.Size = new System.Drawing.Size(67, 20);
            this.tb_id_caixa.TabIndex = 154;
            // 
            // pb_consultar_caixa
            // 
            this.pb_consultar_caixa.BackColor = System.Drawing.Color.White;
            this.pb_consultar_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_consultar_caixa.Image = global::DesafioVendas.Properties.Resources.consultar;
            this.pb_consultar_caixa.Location = new System.Drawing.Point(341, 34);
            this.pb_consultar_caixa.Name = "pb_consultar_caixa";
            this.pb_consultar_caixa.Size = new System.Drawing.Size(43, 39);
            this.pb_consultar_caixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_consultar_caixa.TabIndex = 153;
            this.pb_consultar_caixa.TabStop = false;
            // 
            // bt_consultar_caixa
            // 
            this.bt_consultar_caixa.BackColor = System.Drawing.Color.White;
            this.bt_consultar_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consultar_caixa.FlatAppearance.BorderSize = 3;
            this.bt_consultar_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_consultar_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar_caixa.Location = new System.Drawing.Point(318, 24);
            this.bt_consultar_caixa.Name = "bt_consultar_caixa";
            this.bt_consultar_caixa.Size = new System.Drawing.Size(90, 70);
            this.bt_consultar_caixa.TabIndex = 1;
            this.bt_consultar_caixa.Text = "CONSULTAR";
            this.bt_consultar_caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_consultar_caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_consultar_caixa.UseVisualStyleBackColor = false;
            // 
            // pb_editar_caixa
            // 
            this.pb_editar_caixa.BackColor = System.Drawing.Color.White;
            this.pb_editar_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editar_caixa.Enabled = false;
            this.pb_editar_caixa.Image = global::DesafioVendas.Properties.Resources.editar;
            this.pb_editar_caixa.Location = new System.Drawing.Point(245, 34);
            this.pb_editar_caixa.Name = "pb_editar_caixa";
            this.pb_editar_caixa.Size = new System.Drawing.Size(43, 39);
            this.pb_editar_caixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editar_caixa.TabIndex = 151;
            this.pb_editar_caixa.TabStop = false;
            // 
            // bt_editar_caixa
            // 
            this.bt_editar_caixa.BackColor = System.Drawing.Color.White;
            this.bt_editar_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar_caixa.Enabled = false;
            this.bt_editar_caixa.FlatAppearance.BorderSize = 3;
            this.bt_editar_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar_caixa.Location = new System.Drawing.Point(222, 24);
            this.bt_editar_caixa.Name = "bt_editar_caixa";
            this.bt_editar_caixa.Size = new System.Drawing.Size(90, 70);
            this.bt_editar_caixa.TabIndex = 150;
            this.bt_editar_caixa.Text = "EDITAR";
            this.bt_editar_caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_editar_caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_editar_caixa.UseVisualStyleBackColor = false;
            // 
            // pb_remover_caixa
            // 
            this.pb_remover_caixa.BackColor = System.Drawing.Color.White;
            this.pb_remover_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_remover_caixa.Enabled = false;
            this.pb_remover_caixa.Image = global::DesafioVendas.Properties.Resources.menos;
            this.pb_remover_caixa.Location = new System.Drawing.Point(149, 34);
            this.pb_remover_caixa.Name = "pb_remover_caixa";
            this.pb_remover_caixa.Size = new System.Drawing.Size(43, 39);
            this.pb_remover_caixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_remover_caixa.TabIndex = 149;
            this.pb_remover_caixa.TabStop = false;
            // 
            // bt_remover_caixa
            // 
            this.bt_remover_caixa.BackColor = System.Drawing.Color.White;
            this.bt_remover_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remover_caixa.Enabled = false;
            this.bt_remover_caixa.FlatAppearance.BorderSize = 3;
            this.bt_remover_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_remover_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover_caixa.Location = new System.Drawing.Point(126, 24);
            this.bt_remover_caixa.Name = "bt_remover_caixa";
            this.bt_remover_caixa.Size = new System.Drawing.Size(90, 70);
            this.bt_remover_caixa.TabIndex = 148;
            this.bt_remover_caixa.Text = "REMOVER";
            this.bt_remover_caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_remover_caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_remover_caixa.UseVisualStyleBackColor = false;
            // 
            // pb_cadastrar_caixa
            // 
            this.pb_cadastrar_caixa.BackColor = System.Drawing.Color.White;
            this.pb_cadastrar_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cadastrar_caixa.Enabled = false;
            this.pb_cadastrar_caixa.Image = global::DesafioVendas.Properties.Resources.kisspng_plus_and_minus_signs_addition_clip_art_plus_sign_clipart_5aae23f077ebb2_3950908215213619044912;
            this.pb_cadastrar_caixa.Location = new System.Drawing.Point(53, 34);
            this.pb_cadastrar_caixa.Name = "pb_cadastrar_caixa";
            this.pb_cadastrar_caixa.Size = new System.Drawing.Size(43, 39);
            this.pb_cadastrar_caixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cadastrar_caixa.TabIndex = 147;
            this.pb_cadastrar_caixa.TabStop = false;
            // 
            // bt_cadastrar_caixa
            // 
            this.bt_cadastrar_caixa.BackColor = System.Drawing.Color.White;
            this.bt_cadastrar_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar_caixa.Enabled = false;
            this.bt_cadastrar_caixa.FlatAppearance.BorderSize = 3;
            this.bt_cadastrar_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cadastrar_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar_caixa.Location = new System.Drawing.Point(30, 24);
            this.bt_cadastrar_caixa.Name = "bt_cadastrar_caixa";
            this.bt_cadastrar_caixa.Size = new System.Drawing.Size(90, 70);
            this.bt_cadastrar_caixa.TabIndex = 146;
            this.bt_cadastrar_caixa.Text = "CADASTRAR";
            this.bt_cadastrar_caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cadastrar_caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_cadastrar_caixa.UseVisualStyleBackColor = false;
            // 
            // dg_caixa
            // 
            this.dg_caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_caixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_entrada,
            this.dg_saida});
            this.dg_caixa.Location = new System.Drawing.Point(97, 181);
            this.dg_caixa.Name = "dg_caixa";
            this.dg_caixa.Size = new System.Drawing.Size(240, 239);
            this.dg_caixa.TabIndex = 162;
            // 
            // dg_entrada
            // 
            this.dg_entrada.HeaderText = "Entrada";
            this.dg_entrada.Name = "dg_entrada";
            this.dg_entrada.ReadOnly = true;
            // 
            // dg_saida
            // 
            this.dg_saida.HeaderText = "Saída";
            this.dg_saida.Name = "dg_saida";
            this.dg_saida.ReadOnly = true;
            // 
            // frm_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioVendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 432);
            this.Controls.Add(this.dg_caixa);
            this.Controls.Add(this.lb_id_caixa);
            this.Controls.Add(this.tb_dt_caixa);
            this.Controls.Add(this.tb_vl_caixa);
            this.Controls.Add(this.lb_vl_caixa);
            this.Controls.Add(this.lb_dt_caixa);
            this.Controls.Add(this.tb_id_caixa);
            this.Controls.Add(this.pb_consultar_caixa);
            this.Controls.Add(this.bt_consultar_caixa);
            this.Controls.Add(this.pb_editar_caixa);
            this.Controls.Add(this.bt_editar_caixa);
            this.Controls.Add(this.pb_remover_caixa);
            this.Controls.Add(this.bt_remover_caixa);
            this.Controls.Add(this.pb_cadastrar_caixa);
            this.Controls.Add(this.bt_cadastrar_caixa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_caixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id_caixa;
        private System.Windows.Forms.TextBox tb_dt_caixa;
        private System.Windows.Forms.TextBox tb_vl_caixa;
        private System.Windows.Forms.Label lb_vl_caixa;
        private System.Windows.Forms.Label lb_dt_caixa;
        private System.Windows.Forms.TextBox tb_id_caixa;
        private System.Windows.Forms.PictureBox pb_consultar_caixa;
        private System.Windows.Forms.Button bt_consultar_caixa;
        private System.Windows.Forms.PictureBox pb_editar_caixa;
        private System.Windows.Forms.Button bt_editar_caixa;
        private System.Windows.Forms.PictureBox pb_remover_caixa;
        private System.Windows.Forms.Button bt_remover_caixa;
        private System.Windows.Forms.PictureBox pb_cadastrar_caixa;
        private System.Windows.Forms.Button bt_cadastrar_caixa;
        private System.Windows.Forms.DataGridView dg_caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_saida;
    }
}