using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'auebdDataSet1.Contatos'. Você pode movê-la ou removê-la conforme necessário.
            this.contatosTableAdapter1.Fill(this.auebdDataSet1.Contatos);
            

        }

        private void btn_inclui_Click(object sender, EventArgs e){

            contatosBindingSource1.AddNew();
        }

        private void btn_Contar_No_de_contatos_por_cidade_Click(object sender, EventArgs e){

            contatosBindingSource1.Equals(nome.Text);
            contatosBindingSource1.Equals(sexo.Text);
            contatosBindingSource1.Equals(cidade.Text);
            contatosBindingSource1.Equals(Data.DataBindings.ToString());

        }

        private void btn_altera_Click(object sender, EventArgs e){

            contatosBindingSource1.EndEdit();

        }

        private void btn_exclui_Click(object sender, EventArgs e){

            contatosBindingSource1.RemoveCurrent();
        }

        private void btn_salvar_Click(object sender, EventArgs e){

            contatosBindingSource1.EndEdit();
            
        }
    }
}
