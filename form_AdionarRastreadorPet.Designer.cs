namespace Pet_Monitor
{
    partial class form_AdionarRastreadorPet
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_buscarRastreadoresDisponiveis = new System.Windows.Forms.Button();
            this.txt_codRastreador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_adicionarRastreador = new System.Windows.Forms.Button();
            this.txt_codPet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(12, 55);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(137, 20);
            this.txt_senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha Usuario";
            // 
            // bt_buscarRastreadoresDisponiveis
            // 
            this.bt_buscarRastreadoresDisponiveis.Location = new System.Drawing.Point(155, 52);
            this.bt_buscarRastreadoresDisponiveis.Name = "bt_buscarRastreadoresDisponiveis";
            this.bt_buscarRastreadoresDisponiveis.Size = new System.Drawing.Size(114, 23);
            this.bt_buscarRastreadoresDisponiveis.TabIndex = 3;
            this.bt_buscarRastreadoresDisponiveis.Text = "Buscar Rastreadores";
            this.bt_buscarRastreadoresDisponiveis.UseVisualStyleBackColor = true;
            this.bt_buscarRastreadoresDisponiveis.Click += new System.EventHandler(this.bt_buscarRastreadoresDisponiveis_Click);
            // 
            // txt_codRastreador
            // 
            this.txt_codRastreador.Location = new System.Drawing.Point(12, 95);
            this.txt_codRastreador.Name = "txt_codRastreador";
            this.txt_codRastreador.Size = new System.Drawing.Size(137, 20);
            this.txt_codRastreador.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo Rastreador";
            // 
            // bt_adicionarRastreador
            // 
            this.bt_adicionarRastreador.Location = new System.Drawing.Point(194, 93);
            this.bt_adicionarRastreador.Name = "bt_adicionarRastreador";
            this.bt_adicionarRastreador.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionarRastreador.TabIndex = 6;
            this.bt_adicionarRastreador.Text = "Adicionar";
            this.bt_adicionarRastreador.UseVisualStyleBackColor = true;
            this.bt_adicionarRastreador.Click += new System.EventHandler(this.bt_adicionarRastreador_Click);
            // 
            // txt_codPet
            // 
            this.txt_codPet.Enabled = false;
            this.txt_codPet.Location = new System.Drawing.Point(41, 12);
            this.txt_codPet.Name = "txt_codPet";
            this.txt_codPet.Size = new System.Drawing.Size(45, 20);
            this.txt_codPet.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pet";
            // 
            // form_AdionarRastreadorPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codPet);
            this.Controls.Add(this.bt_adicionarRastreador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codRastreador);
            this.Controls.Add(this.bt_buscarRastreadoresDisponiveis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_AdionarRastreadorPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_AdionarRastreadorPet";
            this.Load += new System.EventHandler(this.form_AdionarRastreadorPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_buscarRastreadoresDisponiveis;
        private System.Windows.Forms.TextBox txt_codRastreador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_adicionarRastreador;
        private System.Windows.Forms.TextBox txt_codPet;
        private System.Windows.Forms.Label label3;
    }
}