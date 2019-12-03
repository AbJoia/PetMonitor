namespace Pet_Monitor
{
    partial class Form_inicio
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
            this.bt_rastreador = new System.Windows.Forms.Button();
            this.bt_tutor = new System.Windows.Forms.Button();
            this.bt_Pet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_relatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_rastreador
            // 
            this.bt_rastreador.Location = new System.Drawing.Point(135, 144);
            this.bt_rastreador.Name = "bt_rastreador";
            this.bt_rastreador.Size = new System.Drawing.Size(106, 48);
            this.bt_rastreador.TabIndex = 2;
            this.bt_rastreador.Text = "Rastreador";
            this.bt_rastreador.UseVisualStyleBackColor = true;
            this.bt_rastreador.Click += new System.EventHandler(this.bt_rastreador_Click);
            // 
            // bt_tutor
            // 
            this.bt_tutor.Location = new System.Drawing.Point(23, 144);
            this.bt_tutor.Name = "bt_tutor";
            this.bt_tutor.Size = new System.Drawing.Size(106, 48);
            this.bt_tutor.TabIndex = 3;
            this.bt_tutor.Text = "Tutor";
            this.bt_tutor.UseVisualStyleBackColor = true;
            this.bt_tutor.Click += new System.EventHandler(this.bt_tutor_Click);
            // 
            // bt_Pet
            // 
            this.bt_Pet.Location = new System.Drawing.Point(247, 144);
            this.bt_Pet.Name = "bt_Pet";
            this.bt_Pet.Size = new System.Drawing.Size(106, 48);
            this.bt_Pet.TabIndex = 4;
            this.bt_Pet.Text = "Pet";
            this.bt_Pet.UseVisualStyleBackColor = true;
            this.bt_Pet.Click += new System.EventHandler(this.bt_Pet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monitoramento Pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastro e Manutenção de Dados";
            // 
            // bt_relatorios
            // 
            this.bt_relatorios.Location = new System.Drawing.Point(359, 144);
            this.bt_relatorios.Name = "bt_relatorios";
            this.bt_relatorios.Size = new System.Drawing.Size(106, 48);
            this.bt_relatorios.TabIndex = 7;
            this.bt_relatorios.Text = "Relatorios";
            this.bt_relatorios.UseVisualStyleBackColor = true;
            this.bt_relatorios.Click += new System.EventHandler(this.bt_relatorios_Click);
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 253);
            this.Controls.Add(this.bt_relatorios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Pet);
            this.Controls.Add(this.bt_tutor);
            this.Controls.Add(this.bt_rastreador);
            this.Name = "Form_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_rastreador;
        private System.Windows.Forms.Button bt_tutor;
        private System.Windows.Forms.Button bt_Pet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_relatorios;
    }
}

