using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nomeTextBox.Text;
            cliente.Sobrenome = sobrenomeTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;
            cliente.Email = emailTextBox.Text;

            cliente.Inserir();
        }

        private void deletarButton_Click(object sender, EventArgs e)
        {

        }

        private void alterarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
