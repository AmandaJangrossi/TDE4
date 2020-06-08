namespace TDE4
{
    partial class frmtabela
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.lblcpf = new System.Windows.Forms.Label();
            this.mtxtelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblavisonome = new System.Windows.Forms.Label();
            this.lblavisocpf = new System.Windows.Forms.Label();
            this.lblavisotelefone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldiv = new System.Windows.Forms.Label();
            this.lblcad = new System.Windows.Forms.Label();
            this.btnajuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnadicionar.FlatAppearance.BorderSize = 0;
            this.btnadicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.Location = new System.Drawing.Point(38, 250);
            this.btnadicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(137, 56);
            this.btnadicionar.TabIndex = 0;
            this.btnadicionar.Text = "Adicionar dados";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.dgvusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNome,
            this.clnTelefone,
            this.clnCPF,
            this.clnEndereco});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvusuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvusuarios.GridColor = System.Drawing.Color.White;
            this.dgvusuarios.Location = new System.Drawing.Point(394, 0);
            this.dgvusuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvusuarios.Name = "dgvusuarios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvusuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvusuarios.Size = new System.Drawing.Size(890, 423);
            this.dgvusuarios.TabIndex = 1;
            this.dgvusuarios.DoubleClick += new System.EventHandler(this.dgvusuarios_DoubleClick);
            // 
            // clnNome
            // 
            this.clnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            // 
            // clnTelefone
            // 
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            // 
            // clnCPF
            // 
            this.clnCPF.HeaderText = "CPF";
            this.clnCPF.Name = "clnCPF";
            // 
            // clnEndereco
            // 
            this.clnEndereco.HeaderText = "Endereço";
            this.clnEndereco.Name = "clnEndereco";
            this.clnEndereco.Width = 200;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(16, 67);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 18);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnome.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtnome.Location = new System.Drawing.Point(78, 69);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(286, 16);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(13, 119);
            this.lbltelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(74, 18);
            this.lbltelefone.TabIndex = 4;
            this.lbltelefone.Text = "Telefone:";
            // 
            // txtendereco
            // 
            this.txtendereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtendereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtendereco.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtendereco.Location = new System.Drawing.Point(96, 169);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(268, 16);
            this.txtendereco.TabIndex = 7;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(14, 167);
            this.lblendereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(78, 18);
            this.lblendereco.TabIndex = 6;
            this.lblendereco.Text = "Endereço:";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(54)))));
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(182, 250);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(134, 56);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexcluir.FlatAppearance.BorderSize = 0;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(38, 312);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(137, 56);
            this.btnexcluir.TabIndex = 9;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnatualizar.FlatAppearance.BorderSize = 0;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizar.ForeColor = System.Drawing.Color.White;
            this.btnatualizar.Location = new System.Drawing.Point(182, 312);
            this.btnatualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(134, 56);
            this.btnatualizar.TabIndex = 10;
            this.btnatualizar.Text = "Atualizar Registros";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(205, 118);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(39, 18);
            this.lblcpf.TabIndex = 11;
            this.lblcpf.Text = "CPF:";
            // 
            // mtxtelefone
            // 
            this.mtxtelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.mtxtelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtelefone.ForeColor = System.Drawing.SystemColors.Menu;
            this.mtxtelefone.Location = new System.Drawing.Point(90, 120);
            this.mtxtelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtelefone.Mask = "(00)00000-0000";
            this.mtxtelefone.Name = "mtxtelefone";
            this.mtxtelefone.Size = new System.Drawing.Size(95, 16);
            this.mtxtelefone.TabIndex = 12;
            this.mtxtelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxcpf
            // 
            this.mtxcpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.mtxcpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxcpf.ForeColor = System.Drawing.SystemColors.Menu;
            this.mtxcpf.Location = new System.Drawing.Point(248, 120);
            this.mtxcpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxcpf.Mask = "000.000.000-00";
            this.mtxcpf.Name = "mtxcpf";
            this.mtxcpf.Size = new System.Drawing.Size(116, 16);
            this.mtxcpf.TabIndex = 13;
            this.mtxcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblavisonome
            // 
            this.lblavisonome.AutoSize = true;
            this.lblavisonome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavisonome.ForeColor = System.Drawing.Color.Red;
            this.lblavisonome.Location = new System.Drawing.Point(358, 65);
            this.lblavisonome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavisonome.Name = "lblavisonome";
            this.lblavisonome.Size = new System.Drawing.Size(15, 20);
            this.lblavisonome.TabIndex = 14;
            this.lblavisonome.Text = "*";
            this.lblavisonome.Visible = false;
            // 
            // lblavisocpf
            // 
            this.lblavisocpf.AutoSize = true;
            this.lblavisocpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavisocpf.ForeColor = System.Drawing.Color.Red;
            this.lblavisocpf.Location = new System.Drawing.Point(358, 117);
            this.lblavisocpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavisocpf.Name = "lblavisocpf";
            this.lblavisocpf.Size = new System.Drawing.Size(15, 20);
            this.lblavisocpf.TabIndex = 15;
            this.lblavisocpf.Text = "*";
            this.lblavisocpf.Visible = false;
            // 
            // lblavisotelefone
            // 
            this.lblavisotelefone.AutoSize = true;
            this.lblavisotelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavisotelefone.ForeColor = System.Drawing.Color.Red;
            this.lblavisotelefone.Location = new System.Drawing.Point(182, 118);
            this.lblavisotelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavisotelefone.Name = "lblavisotelefone";
            this.lblavisotelefone.Size = new System.Drawing.Size(15, 20);
            this.lblavisotelefone.TabIndex = 16;
            this.lblavisotelefone.Text = "*";
            this.lblavisotelefone.Visible = false;
            this.lblavisotelefone.Click += new System.EventHandler(this.lblavisotelefone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnajuda);
            this.panel1.Controls.Add(this.lbldiv);
            this.panel1.Controls.Add(this.lblcad);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.lblavisotelefone);
            this.panel1.Controls.Add(this.btnadicionar);
            this.panel1.Controls.Add(this.lblavisocpf);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lblavisonome);
            this.panel1.Controls.Add(this.lbltelefone);
            this.panel1.Controls.Add(this.mtxcpf);
            this.panel1.Controls.Add(this.lblendereco);
            this.panel1.Controls.Add(this.mtxtelefone);
            this.panel1.Controls.Add(this.txtendereco);
            this.panel1.Controls.Add(this.lblcpf);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btnatualizar);
            this.panel1.Controls.Add(this.btnexcluir);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 426);
            this.panel1.TabIndex = 17;
            // 
            // lbldiv
            // 
            this.lbldiv.AutoSize = true;
            this.lbldiv.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(161)))), ((int)(((byte)(107)))));
            this.lbldiv.Location = new System.Drawing.Point(13, 27);
            this.lbldiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiv.Name = "lbldiv";
            this.lbldiv.Size = new System.Drawing.Size(374, 18);
            this.lbldiv.TabIndex = 18;
            this.lbldiv.Text = "_____________________________________________________________";
            // 
            // lblcad
            // 
            this.lblcad.AutoSize = true;
            this.lblcad.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(161)))), ((int)(((byte)(107)))));
            this.lblcad.Location = new System.Drawing.Point(13, 9);
            this.lblcad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcad.Name = "lblcad";
            this.lblcad.Size = new System.Drawing.Size(140, 18);
            this.lblcad.TabIndex = 17;
            this.lblcad.Text = "Formulário Cadstro";
            // 
            // btnajuda
            // 
            this.btnajuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnajuda.FlatAppearance.BorderSize = 0;
            this.btnajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajuda.ForeColor = System.Drawing.Color.White;
            this.btnajuda.Image = global::TDE4.Properties.Resources.question__1_;
            this.btnajuda.Location = new System.Drawing.Point(350, 3);
            this.btnajuda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnajuda.Name = "btnajuda";
            this.btnajuda.Size = new System.Drawing.Size(45, 38);
            this.btnajuda.TabIndex = 19;
            this.btnajuda.UseVisualStyleBackColor = false;
            this.btnajuda.Click += new System.EventHandler(this.btnajuda_Click);
            // 
            // frmtabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1284, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvusuarios);
            this.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmtabela";
            this.Text = "Adicionar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.MaskedTextBox mtxtelefone;
        private System.Windows.Forms.MaskedTextBox mtxcpf;
        private System.Windows.Forms.Label lblavisonome;
        private System.Windows.Forms.Label lblavisocpf;
        private System.Windows.Forms.Label lblavisotelefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldiv;
        private System.Windows.Forms.Label lblcad;
        private System.Windows.Forms.Button btnajuda;
    }
}