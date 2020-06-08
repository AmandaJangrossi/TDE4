using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE4
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtsenha.Text == "")
            {
                lblavisologin.Visible = true;
                lblavisosenha.Visible = true;
                MessageBox.Show("Preencha os campos login e senha!");
            }
            else if (txtuser.Text == "Amanda" && txtsenha.Text == "1234")
            {
                frmtabela tabela  = new frmtabela();
                tabela.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados Incorretos!");
            }
        }

        private void btnlcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
