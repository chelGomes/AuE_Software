namespace Cadastro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codContatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auebdDataSet1 = new Cadastro.auebdDataSet1();
            this.contatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contatosTableAdapter1 = new Cadastro.auebdDataSet1TableAdapters.ContatosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.Label();
            this.masculino = new System.Windows.Forms.CheckBox();
            this.feminino = new System.Windows.Forms.CheckBox();
            this.cidade = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_inclui = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.btn_exclui = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btn_Contar_No_de_contatos_por_cidade = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auebdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codContatoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contatosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 71);
            this.dataGridView1.TabIndex = 0;
            // 
            // codContatoDataGridViewTextBoxColumn
            // 
            this.codContatoDataGridViewTextBoxColumn.DataPropertyName = "CodContato";
            this.codContatoDataGridViewTextBoxColumn.HeaderText = "CodContato";
            this.codContatoDataGridViewTextBoxColumn.Name = "codContatoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // auebdDataSet1
            // 
            this.auebdDataSet1.DataSetName = "auebdDataSet1";
            this.auebdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatosBindingSource1
            // 
            this.contatosBindingSource1.DataMember = "Contatos";
            this.contatosBindingSource1.DataSource = this.auebdDataSet1;
            // 
            // contatosTableAdapter1
            // 
            this.contatosTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Data);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btn_Contar_No_de_contatos_por_cidade);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.btn_exclui);
            this.groupBox1.Controls.Add(this.btn_altera);
            this.groupBox1.Controls.Add(this.btn_inclui);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.cidade);
            this.groupBox1.Controls.Add(this.feminino);
            this.groupBox1.Controls.Add(this.masculino);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 174);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(339, 61);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource1, "Nome", true));
            this.textBox1.Location = new System.Drawing.Point(378, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 20);
            this.textBox1.TabIndex = 2;
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(338, 107);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(31, 13);
            this.sexo.TabIndex = 3;
            this.sexo.Text = "Sexo";
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource1, "Sexo", true));
            this.masculino.Location = new System.Drawing.Point(389, 107);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(74, 17);
            this.masculino.TabIndex = 4;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource1, "Sexo", true));
            this.feminino.Location = new System.Drawing.Point(469, 106);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(68, 17);
            this.feminino.TabIndex = 5;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Location = new System.Drawing.Point(339, 142);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(40, 13);
            this.cidade.TabIndex = 6;
            this.cidade.Text = "Cidade";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource1, "Cidade", true));
            this.textBox2.Location = new System.Drawing.Point(378, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(472, 20);
            this.textBox2.TabIndex = 7;
            // 
            // btn_inclui
            // 
            this.btn_inclui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inclui.Location = new System.Drawing.Point(344, 187);
            this.btn_inclui.Name = "btn_inclui";
            this.btn_inclui.Size = new System.Drawing.Size(75, 23);
            this.btn_inclui.TabIndex = 8;
            this.btn_inclui.Text = "Inclui";
            this.btn_inclui.UseVisualStyleBackColor = true;
            this.btn_inclui.Click += new System.EventHandler(this.btn_inclui_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera.Location = new System.Drawing.Point(452, 187);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 9;
            this.btn_altera.Text = "Altera";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.btn_altera_Click);
            // 
            // btn_exclui
            // 
            this.btn_exclui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exclui.Location = new System.Drawing.Point(562, 188);
            this.btn_exclui.Name = "btn_exclui";
            this.btn_exclui.Size = new System.Drawing.Size(75, 23);
            this.btn_exclui.TabIndex = 10;
            this.btn_exclui.Text = "Exclui";
            this.btn_exclui.UseVisualStyleBackColor = true;
            this.btn_exclui.Click += new System.EventHandler(this.btn_exclui_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 225);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(839, 79);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Contar_No_de_contatos_por_cidade
            // 
            this.btn_Contar_No_de_contatos_por_cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Contar_No_de_contatos_por_cidade.Location = new System.Drawing.Point(6, 320);
            this.btn_Contar_No_de_contatos_por_cidade.Name = "btn_Contar_No_de_contatos_por_cidade";
            this.btn_Contar_No_de_contatos_por_cidade.Size = new System.Drawing.Size(489, 23);
            this.btn_Contar_No_de_contatos_por_cidade.TabIndex = 12;
            this.btn_Contar_No_de_contatos_por_cidade.Text = "Contar No de contatos por cidade";
            this.btn_Contar_No_de_contatos_por_cidade.UseVisualStyleBackColor = true;
            this.btn_Contar_No_de_contatos_por_cidade.Click += new System.EventHandler(this.btn_Contar_No_de_contatos_por_cidade_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource1, "Data", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(671, 188);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(562, 107);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 15;
            this.Data.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auebdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codContatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private auebdDataSet1 auebdDataSet1;
        private System.Windows.Forms.BindingSource contatosBindingSource1;
        private auebdDataSet1TableAdapters.ContatosTableAdapter contatosTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_inclui;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.CheckBox feminino;
        private System.Windows.Forms.CheckBox masculino;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Contar_No_de_contatos_por_cidade;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btn_exclui;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label Data;
    }
}

