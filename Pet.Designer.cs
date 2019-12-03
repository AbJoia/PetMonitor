namespace Pet_Monitor
{
    partial class Pet
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomePet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_sexoPet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_nascPet = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tipoPet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_buscaPet = new System.Windows.Forms.Button();
            this.bt_deletePet = new System.Windows.Forms.Button();
            this.bt_exibirDados = new System.Windows.Forms.Button();
            this.bt_inserirPet = new System.Windows.Forms.Button();
            this.bt_alterarPet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_raca = new System.Windows.Forms.ComboBox();
            this.txt_senhaUsuario = new System.Windows.Forms.TextBox();
            this.bt_BuscarRaca = new System.Windows.Forms.Button();
            this.bt_adicionarRastreador = new System.Windows.Forms.Button();
            this.bt_RemoveRastreador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(96, 47);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(46, 20);
            this.txt_cod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados Pet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_codBusca
            // 
            this.txt_codBusca.Location = new System.Drawing.Point(379, 44);
            this.txt_codBusca.Name = "txt_codBusca";
            this.txt_codBusca.Size = new System.Drawing.Size(46, 20);
            this.txt_codBusca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod";
            // 
            // txt_nomePet
            // 
            this.txt_nomePet.Location = new System.Drawing.Point(96, 73);
            this.txt_nomePet.Name = "txt_nomePet";
            this.txt_nomePet.Size = new System.Drawing.Size(121, 20);
            this.txt_nomePet.TabIndex = 5;
            this.txt_nomePet.TextChanged += new System.EventHandler(this.txt_nomePet_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome";
            // 
            // cmb_sexoPet
            // 
            this.cmb_sexoPet.FormattingEnabled = true;
            this.cmb_sexoPet.Items.AddRange(new object[] {
            "Macho",
            "Femea"});
            this.cmb_sexoPet.Location = new System.Drawing.Point(96, 99);
            this.cmb_sexoPet.Name = "cmb_sexoPet";
            this.cmb_sexoPet.Size = new System.Drawing.Size(121, 21);
            this.cmb_sexoPet.TabIndex = 7;
            this.cmb_sexoPet.SelectedIndexChanged += new System.EventHandler(this.cmb_sexoPet_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo";
            // 
            // dt_nascPet
            // 
            this.dt_nascPet.Location = new System.Drawing.Point(96, 126);
            this.dt_nascPet.Name = "dt_nascPet";
            this.dt_nascPet.Size = new System.Drawing.Size(121, 20);
            this.dt_nascPet.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nasc.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo";
            // 
            // cmb_tipoPet
            // 
            this.cmb_tipoPet.FormattingEnabled = true;
            this.cmb_tipoPet.Items.AddRange(new object[] {
            "Canina",
            "Felina",
            "Reptil",
            "Ave"});
            this.cmb_tipoPet.Location = new System.Drawing.Point(96, 152);
            this.cmb_tipoPet.Name = "cmb_tipoPet";
            this.cmb_tipoPet.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipoPet.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Senha Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 146);
            this.dataGridView1.TabIndex = 15;
            // 
            // bt_buscaPet
            // 
            this.bt_buscaPet.Location = new System.Drawing.Point(431, 43);
            this.bt_buscaPet.Name = "bt_buscaPet";
            this.bt_buscaPet.Size = new System.Drawing.Size(75, 23);
            this.bt_buscaPet.TabIndex = 16;
            this.bt_buscaPet.Text = "Buscar";
            this.bt_buscaPet.UseVisualStyleBackColor = true;
            this.bt_buscaPet.Click += new System.EventHandler(this.bt_buscaPet_Click);
            // 
            // bt_deletePet
            // 
            this.bt_deletePet.Location = new System.Drawing.Point(511, 44);
            this.bt_deletePet.Name = "bt_deletePet";
            this.bt_deletePet.Size = new System.Drawing.Size(75, 23);
            this.bt_deletePet.TabIndex = 17;
            this.bt_deletePet.Text = "Delete";
            this.bt_deletePet.UseVisualStyleBackColor = true;
            this.bt_deletePet.Click += new System.EventHandler(this.bt_deletePet_Click);
            // 
            // bt_exibirDados
            // 
            this.bt_exibirDados.Location = new System.Drawing.Point(512, 394);
            this.bt_exibirDados.Name = "bt_exibirDados";
            this.bt_exibirDados.Size = new System.Drawing.Size(75, 23);
            this.bt_exibirDados.TabIndex = 18;
            this.bt_exibirDados.Text = "Exibir Dados";
            this.bt_exibirDados.UseVisualStyleBackColor = true;
            this.bt_exibirDados.Click += new System.EventHandler(this.bt_exibirDados_Click);
            // 
            // bt_inserirPet
            // 
            this.bt_inserirPet.Location = new System.Drawing.Point(431, 207);
            this.bt_inserirPet.Name = "bt_inserirPet";
            this.bt_inserirPet.Size = new System.Drawing.Size(75, 23);
            this.bt_inserirPet.TabIndex = 19;
            this.bt_inserirPet.Text = "Inserir";
            this.bt_inserirPet.UseVisualStyleBackColor = true;
            this.bt_inserirPet.Click += new System.EventHandler(this.bt_inserirPet_Click);
            // 
            // bt_alterarPet
            // 
            this.bt_alterarPet.Location = new System.Drawing.Point(512, 207);
            this.bt_alterarPet.Name = "bt_alterarPet";
            this.bt_alterarPet.Size = new System.Drawing.Size(75, 23);
            this.bt_alterarPet.TabIndex = 20;
            this.bt_alterarPet.Text = "Alterar";
            this.bt_alterarPet.UseVisualStyleBackColor = true;
            this.bt_alterarPet.Click += new System.EventHandler(this.bt_alterarPet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Raça";
            // 
            // cmb_raca
            // 
            this.cmb_raca.FormattingEnabled = true;
            this.cmb_raca.Location = new System.Drawing.Point(96, 180);
            this.cmb_raca.Name = "cmb_raca";
            this.cmb_raca.Size = new System.Drawing.Size(121, 21);
            this.cmb_raca.TabIndex = 23;
            this.cmb_raca.SelectedIndexChanged += new System.EventHandler(this.cmb_raca_SelectedIndexChanged);
            // 
            // txt_senhaUsuario
            // 
            this.txt_senhaUsuario.Location = new System.Drawing.Point(96, 207);
            this.txt_senhaUsuario.Name = "txt_senhaUsuario";
            this.txt_senhaUsuario.PasswordChar = '*';
            this.txt_senhaUsuario.Size = new System.Drawing.Size(121, 20);
            this.txt_senhaUsuario.TabIndex = 24;
            // 
            // bt_BuscarRaca
            // 
            this.bt_BuscarRaca.Location = new System.Drawing.Point(223, 180);
            this.bt_BuscarRaca.Name = "bt_BuscarRaca";
            this.bt_BuscarRaca.Size = new System.Drawing.Size(88, 23);
            this.bt_BuscarRaca.TabIndex = 25;
            this.bt_BuscarRaca.Text = "Buscar Raças";
            this.bt_BuscarRaca.UseVisualStyleBackColor = true;
            this.bt_BuscarRaca.Click += new System.EventHandler(this.bt_BuscarRaca_Click);
            // 
            // bt_adicionarRastreador
            // 
            this.bt_adicionarRastreador.Location = new System.Drawing.Point(431, 73);
            this.bt_adicionarRastreador.Name = "bt_adicionarRastreador";
            this.bt_adicionarRastreador.Size = new System.Drawing.Size(155, 30);
            this.bt_adicionarRastreador.TabIndex = 26;
            this.bt_adicionarRastreador.Text = "Adicionar Rastreador";
            this.bt_adicionarRastreador.UseVisualStyleBackColor = true;
            this.bt_adicionarRastreador.Click += new System.EventHandler(this.bt_adicionarRastreador_Click);
            // 
            // bt_RemoveRastreador
            // 
            this.bt_RemoveRastreador.Location = new System.Drawing.Point(432, 171);
            this.bt_RemoveRastreador.Name = "bt_RemoveRastreador";
            this.bt_RemoveRastreador.Size = new System.Drawing.Size(155, 30);
            this.bt_RemoveRastreador.TabIndex = 27;
            this.bt_RemoveRastreador.Text = "Remover Rastreador";
            this.bt_RemoveRastreador.UseVisualStyleBackColor = true;
            this.bt_RemoveRastreador.Click += new System.EventHandler(this.bt_RemoveRastreador_Click);
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 423);
            this.Controls.Add(this.bt_RemoveRastreador);
            this.Controls.Add(this.bt_adicionarRastreador);
            this.Controls.Add(this.bt_BuscarRaca);
            this.Controls.Add(this.txt_senhaUsuario);
            this.Controls.Add(this.cmb_raca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_alterarPet);
            this.Controls.Add(this.bt_inserirPet);
            this.Controls.Add(this.bt_exibirDados);
            this.Controls.Add(this.bt_deletePet);
            this.Controls.Add(this.bt_buscaPet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_tipoPet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_nascPet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_sexoPet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nomePet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cod);
            this.Name = "Pet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.Pet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nomePet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_sexoPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_nascPet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tipoPet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_buscaPet;
        private System.Windows.Forms.Button bt_deletePet;
        private System.Windows.Forms.Button bt_exibirDados;
        private System.Windows.Forms.Button bt_inserirPet;
        private System.Windows.Forms.Button bt_alterarPet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_raca;
        private System.Windows.Forms.TextBox txt_senhaUsuario;
        private System.Windows.Forms.Button bt_BuscarRaca;
        private System.Windows.Forms.Button bt_adicionarRastreador;
        private System.Windows.Forms.Button bt_RemoveRastreador;
    }
}