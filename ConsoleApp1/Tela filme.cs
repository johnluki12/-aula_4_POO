using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Tela_filme : Form
    {
        public Tela_filme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Filme f = new Filme();//instanciando objeto
        Filme[]vet = new Filme[5];//declaração do vetor de objetos
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (i==5)
            {
                MessageBox.Show("Não foi possivel gravar!");
            }
            else
            {
                f.Titulo = txtTitulo.Text;
                f.Classificacao=txtClassificacao.Text;
                f.Genero = txtGenero.Text;
                f.Sinopse = txtSinopse.Text;
                vet[i] = f;
                i++;
            }
            limpar();
        }
        private void limpar()
        {
            txtSinopse.Text = null;
            txtTitulo.Text = null;
            txtGenero.Text = null;
            txtClassificacao.Text = null;
        }
        private void btnPesquisar_Click(object sender,EventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                if (txtTitulo.Text.Equals(vet[x].Titulo))
                {
                    txtClassificacao.Text = vet[x].Classificacao;
                    txtGenero.Text = vet[x].Genero;
                    txtSinopse.Text = vet[x].Sinopse;
                    x = 5;

                }
                else
                {
                    if(x==4)
                    {
                        MessageBox.Show("Titulo não existe!");
                    }
                }
            }
        }

       
    }
}
