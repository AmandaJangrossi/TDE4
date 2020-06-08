using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE4
{
    public partial class frmtabela : Form
    {

        List<List<string>> tabela = new List<List<string>>();
        int indexatual = -1;

        public frmtabela()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || mtxtelefone.Text == "" || mtxcpf.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos obrigatórios!");
                lblavisonome.Visible = true;
                lblavisocpf.Visible = true;
                lblavisotelefone.Visible = true;
            }
            else
            {
                btnadicionar.Enabled = true;
                List<String> dados = new List<string>();
                String Nome = txtnome.Text;
                String Telefone = mtxtelefone.Text;
                String CPF = mtxcpf.Text;
                String Endereco = txtendereco.Text;

                lblavisonome.Visible = false;
                lblavisocpf.Visible = false;
                lblavisotelefone.Visible = false;

                dados.Add(Nome);
                dados.Add(Telefone);
                dados.Add(CPF);
                dados.Add(Endereco);

                tabela.Add(dados);

                dgvusuarios.Rows.Clear();

                for (int i = 0; i < tabela.Count; i++)
                {
                    dgvusuarios.Rows.Add(tabela[i][0], tabela[i][1], tabela[i][2], tabela[i][3]);
                }
            }
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void lblavisotelefone_Click(object sender, EventArgs e)
        {

        }

        private void dgvusuarios_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvusuarios.CurrentCell.RowIndex;
            indexatual = index;

            if(indexatual >= 0)
            {
                txtnome.Text = tabela[index][0];
                mtxtelefone.Text = tabela[index][1];
                mtxcpf.Text = tabela[index][2];
                txtendereco.Text = tabela[index][3];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvusuarios.Rows.Clear();

            for (int i = 0; i < tabela.Count; i++)
            {
                dgvusuarios.Rows.Add(tabela[i][0], tabela[i][1], tabela[i][2], tabela[i][3]);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (indexatual >= 0)
            {
                tabela[indexatual][0] = txtnome.Text;
                tabela[indexatual][1] = mtxtelefone.Text;
                tabela[indexatual][2] = mtxcpf.Text;
                tabela[indexatual][3] = txtendereco.Text;

                dgvusuarios.Rows[indexatual].Cells[0].Value = txtnome.Text;
                dgvusuarios.Rows[indexatual].Cells[1].Value = mtxtelefone.Text;
                dgvusuarios.Rows[indexatual].Cells[2].Value = mtxcpf.Text;
                dgvusuarios.Rows[indexatual].Cells[3].Value = txtendereco.Text;
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (indexatual >= 0)
            {
                tabela.RemoveAt(indexatual);
                dgvusuarios.Rows.RemoveAt(indexatual);
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para adicionar um usuário, preencha todos os campos e clique em 'Adicionar Dados' \n" +
                "Para editar um usuário, dê um clique duplo em uma linha da tabela, edite os dados e cliqeu em 'Editar'\n" +
                "Para excluir um usuário, dê um clique duplo em seu nome e clique em 'Excluir'\n" +
                "Para ver os dados inseridos na tabela, clique em 'Atualizar Registros'");

        }
    }
}
