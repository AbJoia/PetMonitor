namespace Pet_Monitor
{
    partial class Form_Relatorio
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
            this.bt_planiLocalizacao = new System.Windows.Forms.Button();
            this.bt_planiPeriodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_planiLocalizacao
            // 
            this.bt_planiLocalizacao.Location = new System.Drawing.Point(12, 24);
            this.bt_planiLocalizacao.Name = "bt_planiLocalizacao";
            this.bt_planiLocalizacao.Size = new System.Drawing.Size(122, 23);
            this.bt_planiLocalizacao.TabIndex = 1;
            this.bt_planiLocalizacao.Text = "Planilha Localização";
            this.bt_planiLocalizacao.UseVisualStyleBackColor = true;
            this.bt_planiLocalizacao.Click += new System.EventHandler(this.bt_planiLocalizacao_Click);
            // 
            // bt_planiPeriodo
            // 
            this.bt_planiPeriodo.Location = new System.Drawing.Point(140, 24);
            this.bt_planiPeriodo.Name = "bt_planiPeriodo";
            this.bt_planiPeriodo.Size = new System.Drawing.Size(122, 23);
            this.bt_planiPeriodo.TabIndex = 2;
            this.bt_planiPeriodo.Text = "Planilha Periodo";
            this.bt_planiPeriodo.UseVisualStyleBackColor = true;
            this.bt_planiPeriodo.Click += new System.EventHandler(this.bt_planiPeriodo_Click);
            // 
            // Form_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 343);
            this.Controls.Add(this.bt_planiPeriodo);
            this.Controls.Add(this.bt_planiLocalizacao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Relatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_planiLocalizacao;
        private System.Windows.Forms.Button bt_planiPeriodo;
    }
}