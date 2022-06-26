namespace DesafioVendas.Forms
{
    partial class frm_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_estoque));
            this.tb_produto_estoque = new System.Windows.Forms.TextBox();
            this.tb_qtde_compras = new System.Windows.Forms.TextBox();
            this.lb_qtde_compras = new System.Windows.Forms.Label();
            this.tb_cod_barra_compras = new System.Windows.Forms.TextBox();
            this.lb_cod_barra_compras = new System.Windows.Forms.Label();
            this.lb_produto_estoque = new System.Windows.Forms.Label();
            this.tb_id_estoque = new System.Windows.Forms.TextBox();
            this.pb_consultar_estoque = new System.Windows.Forms.PictureBox();
            this.bt_consultar_estoque = new System.Windows.Forms.Button();
            this.pb_editar_estoque = new System.Windows.Forms.PictureBox();
            this.bt_editar_estoque = new System.Windows.Forms.Button();
            this.pb_remover_estoque = new System.Windows.Forms.PictureBox();
            this.bt_remover_estoque = new System.Windows.Forms.Button();
            this.pb_cadastrar_estoque = new System.Windows.Forms.PictureBox();
            this.bt_cadastrar_estoque = new System.Windows.Forms.Button();
            this.lb_id_estoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_produto_estoque
            // 
            this.tb_produto_estoque.BackColor = System.Drawing.Color.White;
            this.tb_produto_estoque.Enabled = false;
            this.tb_produto_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produto_estoque.Location = new System.Drawing.Point(184, 127);
            this.tb_produto_estoque.Name = "tb_produto_estoque";
            this.tb_produto_estoque.Size = new System.Drawing.Size(259, 20);
            this.tb_produto_estoque.TabIndex = 0;
            // 
            // tb_qtde_compras
            // 
            this.tb_qtde_compras.BackColor = System.Drawing.Color.White;
            this.tb_qtde_compras.Enabled = false;
            this.tb_qtde_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde_compras.Location = new System.Drawing.Point(392, 164);
            this.tb_qtde_compras.Name = "tb_qtde_compras";
            this.tb_qtde_compras.Size = new System.Drawing.Size(49, 20);
            this.tb_qtde_compras.TabIndex = 2;
            // 
            // lb_qtde_compras
            // 
            this.lb_qtde_compras.AutoSize = true;
            this.lb_qtde_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_qtde_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtde_compras.Location = new System.Drawing.Point(302, 167);
            this.lb_qtde_compras.Name = "lb_qtde_compras";
            this.lb_qtde_compras.Size = new System.Drawing.Size(92, 13);
            this.lb_qtde_compras.TabIndex = 142;
            this.lb_qtde_compras.Text = "QUANTIDADE:";
            // 
            // tb_cod_barra_compras
            // 
            this.tb_cod_barra_compras.BackColor = System.Drawing.Color.White;
            this.tb_cod_barra_compras.Enabled = false;
            this.tb_cod_barra_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_barra_compras.Location = new System.Drawing.Point(140, 164);
            this.tb_cod_barra_compras.Name = "tb_cod_barra_compras";
            this.tb_cod_barra_compras.Size = new System.Drawing.Size(162, 20);
            this.tb_cod_barra_compras.TabIndex = 1;
            // 
            // lb_cod_barra_compras
            // 
            this.lb_cod_barra_compras.AutoSize = true;
            this.lb_cod_barra_compras.BackColor = System.Drawing.Color.Transparent;
            this.lb_cod_barra_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cod_barra_compras.Location = new System.Drawing.Point(16, 167);
            this.lb_cod_barra_compras.Name = "lb_cod_barra_compras";
            this.lb_cod_barra_compras.Size = new System.Drawing.Size(126, 13);
            this.lb_cod_barra_compras.TabIndex = 139;
            this.lb_cod_barra_compras.Text = "CÓDIGO DE BARRA:";
            // 
            // lb_produto_estoque
            // 
            this.lb_produto_estoque.AutoSize = true;
            this.lb_produto_estoque.BackColor = System.Drawing.Color.Transparent;
            this.lb_produto_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_produto_estoque.Location = new System.Drawing.Point(115, 130);
            this.lb_produto_estoque.Name = "lb_produto_estoque";
            this.lb_produto_estoque.Size = new System.Drawing.Size(72, 13);
            this.lb_produto_estoque.TabIndex = 134;
            this.lb_produto_estoque.Text = "PRODUTO:";
            // 
            // tb_id_estoque
            // 
            this.tb_id_estoque.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_id_estoque.Enabled = false;
            this.tb_id_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_estoque.Location = new System.Drawing.Point(37, 127);
            this.tb_id_estoque.Name = "tb_id_estoque";
            this.tb_id_estoque.Size = new System.Drawing.Size(67, 20);
            this.tb_id_estoque.TabIndex = 133;
            // 
            // pb_consultar_estoque
            // 
            this.pb_consultar_estoque.BackColor = System.Drawing.Color.White;
            this.pb_consultar_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_consultar_estoque.Image = global::DesafioVendas.Properties.Resources.consultar;
            this.pb_consultar_estoque.Location = new System.Drawing.Point(351, 25);
            this.pb_consultar_estoque.Name = "pb_consultar_estoque";
            this.pb_consultar_estoque.Size = new System.Drawing.Size(43, 39);
            this.pb_consultar_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_consultar_estoque.TabIndex = 132;
            this.pb_consultar_estoque.TabStop = false;
            // 
            // bt_consultar_estoque
            // 
            this.bt_consultar_estoque.BackColor = System.Drawing.Color.White;
            this.bt_consultar_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consultar_estoque.FlatAppearance.BorderSize = 3;
            this.bt_consultar_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_consultar_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar_estoque.Location = new System.Drawing.Point(328, 15);
            this.bt_consultar_estoque.Name = "bt_consultar_estoque";
            this.bt_consultar_estoque.Size = new System.Drawing.Size(90, 70);
            this.bt_consultar_estoque.TabIndex = 3;
            this.bt_consultar_estoque.Text = "CONSULTAR";
            this.bt_consultar_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_consultar_estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_consultar_estoque.UseVisualStyleBackColor = false;
            // 
            // pb_editar_estoque
            // 
            this.pb_editar_estoque.BackColor = System.Drawing.Color.White;
            this.pb_editar_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editar_estoque.Image = global::DesafioVendas.Properties.Resources.editar;
            this.pb_editar_estoque.Location = new System.Drawing.Point(255, 25);
            this.pb_editar_estoque.Name = "pb_editar_estoque";
            this.pb_editar_estoque.Size = new System.Drawing.Size(43, 39);
            this.pb_editar_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editar_estoque.TabIndex = 130;
            this.pb_editar_estoque.TabStop = false;
            // 
            // bt_editar_estoque
            // 
            this.bt_editar_estoque.BackColor = System.Drawing.Color.White;
            this.bt_editar_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar_estoque.FlatAppearance.BorderSize = 3;
            this.bt_editar_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar_estoque.Location = new System.Drawing.Point(232, 15);
            this.bt_editar_estoque.Name = "bt_editar_estoque";
            this.bt_editar_estoque.Size = new System.Drawing.Size(90, 70);
            this.bt_editar_estoque.TabIndex = 129;
            this.bt_editar_estoque.Text = "EDITAR";
            this.bt_editar_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_editar_estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_editar_estoque.UseVisualStyleBackColor = false;
            // 
            // pb_remover_estoque
            // 
            this.pb_remover_estoque.BackColor = System.Drawing.Color.White;
            this.pb_remover_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_remover_estoque.Enabled = false;
            this.pb_remover_estoque.Image = global::DesafioVendas.Properties.Resources.menos;
            this.pb_remover_estoque.Location = new System.Drawing.Point(159, 25);
            this.pb_remover_estoque.Name = "pb_remover_estoque";
            this.pb_remover_estoque.Size = new System.Drawing.Size(43, 39);
            this.pb_remover_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_remover_estoque.TabIndex = 128;
            this.pb_remover_estoque.TabStop = false;
            // 
            // bt_remover_estoque
            // 
            this.bt_remover_estoque.BackColor = System.Drawing.Color.White;
            this.bt_remover_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remover_estoque.Enabled = false;
            this.bt_remover_estoque.FlatAppearance.BorderSize = 3;
            this.bt_remover_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_remover_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover_estoque.Location = new System.Drawing.Point(136, 15);
            this.bt_remover_estoque.Name = "bt_remover_estoque";
            this.bt_remover_estoque.Size = new System.Drawing.Size(90, 70);
            this.bt_remover_estoque.TabIndex = 127;
            this.bt_remover_estoque.Text = "REMOVER";
            this.bt_remover_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_remover_estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_remover_estoque.UseVisualStyleBackColor = false;
            // 
            // pb_cadastrar_estoque
            // 
            this.pb_cadastrar_estoque.BackColor = System.Drawing.Color.White;
            this.pb_cadastrar_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cadastrar_estoque.Enabled = false;
            this.pb_cadastrar_estoque.Image = global::DesafioVendas.Properties.Resources.kisspng_plus_and_minus_signs_addition_clip_art_plus_sign_clipart_5aae23f077ebb2_3950908215213619044912;
            this.pb_cadastrar_estoque.Location = new System.Drawing.Point(63, 25);
            this.pb_cadastrar_estoque.Name = "pb_cadastrar_estoque";
            this.pb_cadastrar_estoque.Size = new System.Drawing.Size(43, 39);
            this.pb_cadastrar_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cadastrar_estoque.TabIndex = 126;
            this.pb_cadastrar_estoque.TabStop = false;
            // 
            // bt_cadastrar_estoque
            // 
            this.bt_cadastrar_estoque.BackColor = System.Drawing.Color.White;
            this.bt_cadastrar_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar_estoque.Enabled = false;
            this.bt_cadastrar_estoque.FlatAppearance.BorderSize = 3;
            this.bt_cadastrar_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cadastrar_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar_estoque.Location = new System.Drawing.Point(40, 15);
            this.bt_cadastrar_estoque.Name = "bt_cadastrar_estoque";
            this.bt_cadastrar_estoque.Size = new System.Drawing.Size(90, 70);
            this.bt_cadastrar_estoque.TabIndex = 124;
            this.bt_cadastrar_estoque.Text = "CADASTRAR";
            this.bt_cadastrar_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cadastrar_estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_cadastrar_estoque.UseVisualStyleBackColor = false;
            // 
            // lb_id_estoque
            // 
            this.lb_id_estoque.AutoSize = true;
            this.lb_id_estoque.BackColor = System.Drawing.Color.Transparent;
            this.lb_id_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_estoque.Location = new System.Drawing.Point(12, 130);
            this.lb_id_estoque.Name = "lb_id_estoque";
            this.lb_id_estoque.Size = new System.Drawing.Size(24, 13);
            this.lb_id_estoque.TabIndex = 145;
            this.lb_id_estoque.Text = "ID:";
            // 
            // frm_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioVendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 225);
            this.Controls.Add(this.lb_id_estoque);
            this.Controls.Add(this.tb_produto_estoque);
            this.Controls.Add(this.tb_qtde_compras);
            this.Controls.Add(this.lb_qtde_compras);
            this.Controls.Add(this.tb_cod_barra_compras);
            this.Controls.Add(this.lb_cod_barra_compras);
            this.Controls.Add(this.lb_produto_estoque);
            this.Controls.Add(this.tb_id_estoque);
            this.Controls.Add(this.pb_consultar_estoque);
            this.Controls.Add(this.bt_consultar_estoque);
            this.Controls.Add(this.pb_editar_estoque);
            this.Controls.Add(this.bt_editar_estoque);
            this.Controls.Add(this.pb_remover_estoque);
            this.Controls.Add(this.bt_remover_estoque);
            this.Controls.Add(this.pb_cadastrar_estoque);
            this.Controls.Add(this.bt_cadastrar_estoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pb_consultar_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover_estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cadastrar_estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_produto_estoque;
        private System.Windows.Forms.TextBox tb_qtde_compras;
        private System.Windows.Forms.Label lb_qtde_compras;
        private System.Windows.Forms.TextBox tb_cod_barra_compras;
        private System.Windows.Forms.Label lb_cod_barra_compras;
        private System.Windows.Forms.Label lb_produto_estoque;
        private System.Windows.Forms.TextBox tb_id_estoque;
        private System.Windows.Forms.PictureBox pb_consultar_estoque;
        private System.Windows.Forms.Button bt_consultar_estoque;
        private System.Windows.Forms.PictureBox pb_editar_estoque;
        private System.Windows.Forms.Button bt_editar_estoque;
        private System.Windows.Forms.PictureBox pb_remover_estoque;
        private System.Windows.Forms.Button bt_remover_estoque;
        private System.Windows.Forms.PictureBox pb_cadastrar_estoque;
        private System.Windows.Forms.Button bt_cadastrar_estoque;
        private System.Windows.Forms.Label lb_id_estoque;
    }
}