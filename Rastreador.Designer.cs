namespace Pet_Monitor
{
    partial class form_Rastreador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codRastreador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_inserirRastreador = new System.Windows.Forms.Button();
            this.bt_DeleteRastreador = new System.Windows.Forms.Button();
            this.bt_exibirRastreadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo rastreador";
            // 
            // txt_codRastreador
            // 
            this.txt_codRastreador.Location = new System.Drawing.Point(110, 56);
            this.txt_codRastreador.Name = "txt_codRastreador";
            this.txt_codRastreador.Size = new System.Drawing.Size(147, 20);
            this.txt_codRastreador.TabIndex = 2;
            this.txt_codRastreador.TextChanged += new System.EventHandler(this.txt_codRastreador_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dados Rastreador";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(110, 82);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(147, 20);
            this.txt_senha.TabIndex = 7;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha de usuario";
            // 
            // bt_inserirRastreador
            // 
            this.bt_inserirRastreador.Location = new System.Drawing.Point(357, 80);
            this.bt_inserirRastreador.Name = "bt_inserirRastreador";
            this.bt_inserirRastreador.Size = new System.Drawing.Size(75, 23);
            this.bt_inserirRastreador.TabIndex = 10;
            this.bt_inserirRastreador.Text = "Inserir";
            this.bt_inserirRastreador.UseVisualStyleBackColor = true;
            this.bt_inserirRastreador.Click += new System.EventHandler(this.InserirRastreador_Click);
            // 
            // bt_DeleteRastreador
            // 
            this.bt_DeleteRastreador.Location = new System.Drawing.Point(438, 80);
            this.bt_DeleteRastreador.Name = "bt_DeleteRastreador";
            this.bt_DeleteRastreador.Size = new System.Drawing.Size(75, 23);
            this.bt_DeleteRastreador.TabIndex = 13;
            this.bt_DeleteRastreador.Text = "Delete";
            this.bt_DeleteRastreador.UseVisualStyleBackColor = true;
            this.bt_DeleteRastreador.Click += new System.EventHandler(this.bt_DeleteRastreador_Click);
            // 
            // bt_exibirRastreadores
            // 
            this.bt_exibirRastreadores.Location = new System.Drawing.Point(438, 301);
            this.bt_exibirRastreadores.Name = "bt_exibirRastreadores";
            this.bt_exibirRastreadores.Size = new System.Drawing.Size(75, 23);
            this.bt_exibirRastreadores.TabIndex = 14;
            this.bt_exibirRastreadores.Text = "Exibir Dados";
            this.bt_exibirRastreadores.UseVisualStyleBackColor = true;
            this.bt_exibirRastreadores.Click += new System.EventHandler(this.bt_exibirRastreadores_Click);
            // 
            // form_Rastreador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 335);
            this.Controls.Add(this.bt_exibirRastreadores);
            this.Controls.Add(this.bt_DeleteRastreador);
            this.Controls.Add(this.bt_inserirRastreador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codRastreador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_Rastreador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastreador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codRastreador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_inserirRastreador;
        private System.Windows.Forms.Button bt_DeleteRastreador;
        private System.Windows.Forms.Button bt_exibirRastreadores;
    }
}