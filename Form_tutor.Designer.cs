namespace Pet_Monitor
{
    partial class Form_tutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codTutor = new System.Windows.Forms.TextBox();
            this.txt_nomeTutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sobreNomeTutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emailTutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usernameTutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_senhaTutor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.InserirTutor = new System.Windows.Forms.Button();
            this.bt_exibirDados = new System.Windows.Forms.Button();
            this.bt_deleteTutor = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.txt_CodBusca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_updateTutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            // 
            // txt_codTutor
            // 
            this.txt_codTutor.Enabled = false;
            this.txt_codTutor.Location = new System.Drawing.Point(84, 41);
            this.txt_codTutor.Name = "txt_codTutor";
            this.txt_codTutor.Size = new System.Drawing.Size(49, 20);
            this.txt_codTutor.TabIndex = 2;
            // 
            // txt_nomeTutor
            // 
            this.txt_nomeTutor.Location = new System.Drawing.Point(84, 67);
            this.txt_nomeTutor.Name = "txt_nomeTutor";
            this.txt_nomeTutor.Size = new System.Drawing.Size(186, 20);
            this.txt_nomeTutor.TabIndex = 3;
            this.txt_nomeTutor.TextChanged += new System.EventHandler(this.txt_nomeTutor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txt_sobreNomeTutor
            // 
            this.txt_sobreNomeTutor.Location = new System.Drawing.Point(84, 93);
            this.txt_sobreNomeTutor.Name = "txt_sobreNomeTutor";
            this.txt_sobreNomeTutor.Size = new System.Drawing.Size(186, 20);
            this.txt_sobreNomeTutor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome";
            // 
            // txt_emailTutor
            // 
            this.txt_emailTutor.Location = new System.Drawing.Point(84, 119);
            this.txt_emailTutor.Name = "txt_emailTutor";
            this.txt_emailTutor.Size = new System.Drawing.Size(299, 20);
            this.txt_emailTutor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // txt_usernameTutor
            // 
            this.txt_usernameTutor.Location = new System.Drawing.Point(84, 145);
            this.txt_usernameTutor.Name = "txt_usernameTutor";
            this.txt_usernameTutor.Size = new System.Drawing.Size(127, 20);
            this.txt_usernameTutor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha";
            // 
            // txt_senhaTutor
            // 
            this.txt_senhaTutor.Location = new System.Drawing.Point(261, 145);
            this.txt_senhaTutor.Name = "txt_senhaTutor";
            this.txt_senhaTutor.PasswordChar = '*';
            this.txt_senhaTutor.Size = new System.Drawing.Size(122, 20);
            this.txt_senhaTutor.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 218);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dados Tutor";
            // 
            // InserirTutor
            // 
            this.InserirTutor.Location = new System.Drawing.Point(422, 143);
            this.InserirTutor.Name = "InserirTutor";
            this.InserirTutor.Size = new System.Drawing.Size(75, 23);
            this.InserirTutor.TabIndex = 15;
            this.InserirTutor.Text = "Inserir";
            this.InserirTutor.UseVisualStyleBackColor = true;
            this.InserirTutor.Click += new System.EventHandler(this.InserirTutor_Click);
            // 
            // bt_exibirDados
            // 
            this.bt_exibirDados.Location = new System.Drawing.Point(497, 412);
            this.bt_exibirDados.Name = "bt_exibirDados";
            this.bt_exibirDados.Size = new System.Drawing.Size(75, 23);
            this.bt_exibirDados.TabIndex = 18;
            this.bt_exibirDados.Text = "Exibir Dados";
            this.bt_exibirDados.UseVisualStyleBackColor = true;
            this.bt_exibirDados.Click += new System.EventHandler(this.bt_exibirDados_Click);
            // 
            // bt_deleteTutor
            // 
            this.bt_deleteTutor.Location = new System.Drawing.Point(503, 35);
            this.bt_deleteTutor.Name = "bt_deleteTutor";
            this.bt_deleteTutor.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteTutor.TabIndex = 16;
            this.bt_deleteTutor.Text = "Delete";
            this.bt_deleteTutor.UseVisualStyleBackColor = true;
            this.bt_deleteTutor.Click += new System.EventHandler(this.bt_deleteTutor_Click);
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(422, 35);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 17;
            this.bt_select.Text = "Buscar";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // txt_CodBusca
            // 
            this.txt_CodBusca.Location = new System.Drawing.Point(367, 37);
            this.txt_CodBusca.Name = "txt_CodBusca";
            this.txt_CodBusca.Size = new System.Drawing.Size(49, 20);
            this.txt_CodBusca.TabIndex = 19;
            this.txt_CodBusca.TextChanged += new System.EventHandler(this.txt_CodBusca_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cod";
            // 
            // bt_updateTutor
            // 
            this.bt_updateTutor.Location = new System.Drawing.Point(503, 143);
            this.bt_updateTutor.Name = "bt_updateTutor";
            this.bt_updateTutor.Size = new System.Drawing.Size(75, 23);
            this.bt_updateTutor.TabIndex = 21;
            this.bt_updateTutor.Text = "Alterar";
            this.bt_updateTutor.UseVisualStyleBackColor = true;
            this.bt_updateTutor.Click += new System.EventHandler(this.bt_updateTutor_Click);
            // 
            // Form_tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 447);
            this.Controls.Add(this.bt_updateTutor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_CodBusca);
            this.Controls.Add(this.bt_exibirDados);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.bt_deleteTutor);
            this.Controls.Add(this.InserirTutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_senhaTutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_usernameTutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_emailTutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sobreNomeTutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomeTutor);
            this.Controls.Add(this.txt_codTutor);
            this.Controls.Add(this.label1);
            this.Name = "Form_tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.Form_tutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codTutor;
        private System.Windows.Forms.TextBox txt_nomeTutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sobreNomeTutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emailTutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usernameTutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_senhaTutor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button InserirTutor;
        private System.Windows.Forms.Button bt_exibirDados;
        private System.Windows.Forms.Button bt_deleteTutor;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.TextBox txt_CodBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_updateTutor;
    }
}