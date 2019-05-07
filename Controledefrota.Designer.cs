namespace Controle_de_Frota
{
    partial class Controledefrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controledefrota));
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCarros = new System.Windows.Forms.TextBox();
            this.txtCaminhoes = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblEixo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtEixo = new System.Windows.Forms.TextBox();
            this.pbCarros = new System.Windows.Forms.PictureBox();
            this.pbCaminhao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCarro.Image = ((System.Drawing.Image)(resources.GetObject("btnCarro.Image")));
            this.btnCarro.Location = new System.Drawing.Point(33, 32);
            this.btnCarro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(138, 64);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Carro";
            this.btnCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.BtnCarro_Click);
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminhao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminhao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCaminhao.Image = ((System.Drawing.Image)(resources.GetObject("btnCaminhao.Image")));
            this.btnCaminhao.Location = new System.Drawing.Point(276, 32);
            this.btnCaminhao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(138, 64);
            this.btnCaminhao.TabIndex = 1;
            this.btnCaminhao.Text = "Caminhões";
            this.btnCaminhao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaminhao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaminhao.UseVisualStyleBackColor = true;
            this.btnCaminhao.Click += new System.EventHandler(this.BtnCaminhao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(504, 32);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 64);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtCarros
            // 
            this.txtCarros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCarros.Location = new System.Drawing.Point(33, 295);
            this.txtCarros.Multiline = true;
            this.txtCarros.Name = "txtCarros";
            this.txtCarros.Size = new System.Drawing.Size(291, 225);
            this.txtCarros.TabIndex = 3;
            // 
            // txtCaminhoes
            // 
            this.txtCaminhoes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCaminhoes.Location = new System.Drawing.Point(368, 295);
            this.txtCaminhoes.Multiline = true;
            this.txtCaminhoes.Name = "txtCaminhoes";
            this.txtCaminhoes.Size = new System.Drawing.Size(291, 225);
            this.txtCaminhoes.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModelo.Location = new System.Drawing.Point(46, 117);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 20);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPlaca.Location = new System.Drawing.Point(46, 152);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblPlaca.TabIndex = 6;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKm.Location = new System.Drawing.Point(62, 189);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(36, 20);
            this.lblKm.TabIndex = 7;
            this.lblKm.Text = "Km:";
            // 
            // lblEixo
            // 
            this.lblEixo.AutoSize = true;
            this.lblEixo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEixo.Location = new System.Drawing.Point(382, 152);
            this.lblEixo.Name = "lblEixo";
            this.lblEixo.Size = new System.Drawing.Size(43, 20);
            this.lblEixo.TabIndex = 8;
            this.lblEixo.Text = "Eixo:";
            this.lblEixo.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtModelo.Location = new System.Drawing.Point(119, 114);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(523, 26);
            this.txtModelo.TabIndex = 9;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPlaca.Location = new System.Drawing.Point(119, 149);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(207, 26);
            this.txtPlaca.TabIndex = 10;
            // 
            // txtKm
            // 
            this.txtKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKm.Location = new System.Drawing.Point(119, 186);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(207, 26);
            this.txtKm.TabIndex = 11;
            // 
            // txtEixo
            // 
            this.txtEixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEixo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEixo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEixo.Location = new System.Drawing.Point(436, 149);
            this.txtEixo.Name = "txtEixo";
            this.txtEixo.Size = new System.Drawing.Size(206, 26);
            this.txtEixo.TabIndex = 12;
            this.txtEixo.Visible = false;
            // 
            // pbCarros
            // 
            this.pbCarros.Image = ((System.Drawing.Image)(resources.GetObject("pbCarros.Image")));
            this.pbCarros.Location = new System.Drawing.Point(33, 238);
            this.pbCarros.Name = "pbCarros";
            this.pbCarros.Size = new System.Drawing.Size(83, 54);
            this.pbCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarros.TabIndex = 13;
            this.pbCarros.TabStop = false;
            // 
            // pbCaminhao
            // 
            this.pbCaminhao.Image = ((System.Drawing.Image)(resources.GetObject("pbCaminhao.Image")));
            this.pbCaminhao.Location = new System.Drawing.Point(576, 238);
            this.pbCaminhao.Name = "pbCaminhao";
            this.pbCaminhao.Size = new System.Drawing.Size(83, 55);
            this.pbCaminhao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCaminhao.TabIndex = 14;
            this.pbCaminhao.TabStop = false;
            // 
            // Controledefrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 532);
            this.Controls.Add(this.pbCaminhao);
            this.Controls.Add(this.pbCarros);
            this.Controls.Add(this.txtEixo);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblEixo);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtCaminhoes);
            this.Controls.Add(this.txtCarros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaminhao);
            this.Controls.Add(this.btnCarro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Controledefrota";
            this.Text = "Controle de Frota";
            ((System.ComponentModel.ISupportInitialize)(this.pbCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnCaminhao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCarros;
        private System.Windows.Forms.TextBox txtCaminhoes;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblEixo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtEixo;
        private System.Windows.Forms.PictureBox pbCarros;
        private System.Windows.Forms.PictureBox pbCaminhao;
    }
}

