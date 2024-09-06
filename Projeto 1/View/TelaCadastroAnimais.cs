using Projeto_1.Controller;
using Projeto_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1.View
{
    public partial class TelaCadastroAnimais : Form
    {
        public TelaCadastroAnimais()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastroAnimais_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Animais.Nome = tbx_name.Text;
            Animais.Raca = tbx_raca.Text;
            Animais.Porte = cbx_porte.Text;

            ControllerAnimais controllerAnimais = new ControllerAnimais();
            controllerAnimais.EnviarBanco();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
