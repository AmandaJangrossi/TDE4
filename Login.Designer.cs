namespace TDE4
{
    partial class frmlogin
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
            this.btnlogar = new System.Windows.Forms.Button();
            this.btnlcancelar = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblavisologin = new System.Windows.Forms.Label();
            this.lblavisosenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogar
            // 
            this.btnlogar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnlogar.FlatAppearance.BorderSize = 0;
            this.btnlogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogar.Location = new System.Drawing.Point(182, 268);
            this.btnlogar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(131, 55);
            this.btnlogar.TabIndex = 0;
            this.btnlogar.Text = "Logar";
            this.btnlogar.UseVisualStyleBackColor = false;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // btnlcancelar
            // 
            this.btnlcancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnlcancelar.FlatAppearance.BorderSize = 0;
            this.btnlcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlcancelar.Location = new System.Drawing.Point(30, 268);
            this.btnlcancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlcancelar.Name = "btnlcancelar";
            this.btnlcancelar.Size = new System.Drawing.Size(131, 55);
            this.btnlcancelar.TabIndex = 1;
            this.btnlcancelar.Text = "Cancelar";
            this.btnlcancelar.UseVisualStyleBackColor = false;
            this.btnlcancelar.Click += new System.EventHandler(this.btnlcancelar_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbluser.Location = new System.Drawing.Point(16, 96);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(57, 15);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "Usuário:";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(73, 90);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(208, 23);
            this.txtuser.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.Location = new System.Drawing.Point(73, 184);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(208, 23);
            this.txtsenha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // lblavisologin
            // 
            this.lblavisologin.AutoSize = true;
            this.lblavisologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavisologin.ForeColor = System.Drawing.Color.Red;
            this.lblavisologin.Location = new System.Drawing.Point(289, 93);
            this.lblavisologin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavisologin.Name = "lblavisologin";
            this.lblavisologin.Size = new System.Drawing.Size(13, 16);
            this.lblavisologin.TabIndex = 6;
            this.lblavisologin.Text = "*";
            // 
            // lblavisosenha
            // 
            this.lblavisosenha.AutoSize = true;
            this.lblavisosenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavisosenha.ForeColor = System.Drawing.Color.Red;
            this.lblavisosenha.Location = new System.Drawing.Point(289, 185);
            this.lblavisosenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavisosenha.Name = "lblavisosenha";
            this.lblavisosenha.Size = new System.Drawing.Size(13, 16);
            this.lblavisosenha.TabIndex = 7;
            this.lblavisosenha.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(161)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "__________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(161)))), ((int)(((byte)(107)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(345, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblavisosenha);
            this.Controls.Add(this.lblavisologin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnlcancelar);
            this.Controls.Add(this.btnlogar);
            this.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmlogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.Button btnlcancelar;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblavisologin;
        private System.Windows.Forms.Label lblavisosenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

