namespace Pet_Monitor
{
    partial class Form_RemoverRastreador
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codRastreador = new System.Windows.Forms.TextBox();
            this.bt_removerRastreador = new System.Windows.Forms.Button();
            this.bt_exibirDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha Usuario";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(107, 32);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CodRastreador";
            // 
            // txt_codRastreador
            // 
            this.txt_codRastreador.Location = new System.Drawing.Point(107, 75);
            this.txt_codRastreador.Name = "txt_codRastreador";
            this.txt_codRastreador.Size = new System.Drawing.Size(100, 20);
            this.txt_codRastreador.TabIndex = 4;
            // 
            // bt_removerRastreador
            // 
            this.bt_removerRastreador.Location = new System.Drawing.Point(248, 75);
            this.bt_removerRastreador.Name = "bt_removerRastreador";
            this.bt_removerRastreador.Size = new System.Drawing.Size(75, 23);
            this.bt_removerRastreador.TabIndex = 5;
            this.bt_removerRastreador.Text = "Remover";
            this.bt_removerRastreador.UseVisualStyleBackColor = true;
            this.bt_removerRastreador.Click += new System.EventHandler(this.bt_removerRastreador_Click);
            // 
            // bt_exibirDados
            // 
            this.bt_exibirDados.Location = new System.Drawing.Point(213, 32);
            this.bt_exibirDados.Name = "bt_exibirDados";
            this.bt_exibirDados.Size = new System.Drawing.Size(110, 23);
            this.bt_exibirDados.TabIndex = 6;
            this.bt_exibirDados.Text = "Exibir Rastreadores";
            this.bt_exibirDados.UseVisualStyleBackColor = true;
            this.bt_exibirDados.Click += new System.EventHandler(this.bt_exibirDados_Click);
            // 
            // Form_RemoverRastreador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 312);
            this.Controls.Add(this.bt_exibirDados);
            this.Controls.Add(this.bt_removerRastreador);
            this.Controls.Add(this.txt_codRastreador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_RemoverRastreador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RemoverRastreador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codRastreador;
        private System.Windows.Forms.Button bt_removerRastreador;
        private System.Windows.Forms.Button bt_exibirDados;
    }
}