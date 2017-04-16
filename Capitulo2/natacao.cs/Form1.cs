using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace natacao.cs
{
    public partial class matricula : Form
    {
        public matricula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNascimento_Enter(object sender, EventArgs e)
        {
            if( txtNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("Informe o ano de nascimento!", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNascimento.Focus();
            }
        }

        private void txtUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if(txtUltimoAniversario.Text != String.Empty && Convert.ToInt32(txtNascimento.Text) >= Convert.ToInt32(txtUltimoAniversario.Text))
            {
                MessageBox.Show("Último aniversário deve ser maior que nascimento!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNascimento.Text == String.Empty || txtUltimoAniversario.Text == String.Empty
                || textNome.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idade = Convert.ToInt32(txtUltimoAniversario.Text) - Convert.ToInt32(txtNascimento.Text);

                if (idade> 17)
                {
                    txtCategoria.Text = "Adulto";
                } else if (idade > 13)
                {
                    txtCategoria.Text = "Juvenil B";
                } else if (idade > 10)
                {
                    txtCategoria.Text = "Juvenil A";
                } else if(idade >7)
                {
                    txtCategoria.Text = "Infantil B";

                } else if (idade >= 5)
                {
                    txtCategoria.Text = "Infantil A";
                } else
                {
                    txtCategoria.Text = "Não tem categoria";
                }
            }
        }
    }
}
