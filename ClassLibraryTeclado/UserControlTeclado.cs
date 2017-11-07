using System;
using System.Windows.Forms;

namespace ClassLibraryTeclado
{
    public partial class UserControlTeclado : UserControl
    {
        private char _UltimaTeclaPremida;

        public char UltimaTeclaPremida
        {
            get { return _UltimaTeclaPremida; }
            set { _UltimaTeclaPremida = value; }
        }
        public UserControlTeclado()
        {
            InitializeComponent();
        }

        public void addOnButtonClickHandler(EventHandler handler)
        {
            buttonNumZero.Click += handler;
            buttonNumUm.Click += handler;
            buttonNumDois.Click += handler;
            buttonNumTres.Click += handler;
            buttonNumQuatro.Click += handler;
            buttonNumCinco.Click += handler;
            buttonNumSeis.Click += handler;
            buttonNumSete.Click += handler;
            buttonNumOito.Click += handler;
            buttonNumNove.Click += handler;

            buttonVirgula.Click += handler;

            buttonSoma.Click += handler;
            buttonMultiplicacao.Click += handler;
            buttonSubtracao.Click += handler;
            buttonDivisao.Click += handler;

            buttonPorCento.Click += handler;
            buttonRaizQuadrada.Click += handler;
            buttonQuadrado.Click += handler;

            buttonLimpar.Click += handler;

            buttonIgual.Click += handler;

        }

        private void buttonNumZero_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '0';
        }

        private void buttonNumUm_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '1';
            
        }

        private void buttonNumDois_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '2';
        }

        private void buttonNumTres_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '3';
        }

        private void buttonNumQuatro_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '4';
        }

        private void buttonNumCinco_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '5';
        }

        private void buttonNumSeis_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '6';
        }

        private void buttonNumSete_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '7';
        }

        private void buttonNumOito_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '8';
        }

        private void buttonNumNove_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '9';
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '.';
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '=';
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '+';
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '-';
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = 'x';
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '/';
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = 'c';
        }

        private void buttonQuadrado_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = 'q';
        }

        private void buttonRaizQuadrada_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = 'r';
        }

        private void buttonPorCento_Click(object sender, EventArgs e)
        {
            UltimaTeclaPremida = '%';
        }
    }
}
