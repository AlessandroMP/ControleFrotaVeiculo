using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Frota
{
    public partial class Controledefrota : Form
    {
        public Controledefrota()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)//Evento do botão salvar
        {
            if (txtEixo.Visible == false)
            {
                Veiculo novocarro = new Veiculo();//instanciando objeto do tipo veiculo


                /* novocarro.GravaModelo(txtModelo.Text); //Gravar o texto que escreve dentro do txtModelo.
                 novocarro.GravaPlaca(txtPlaca.Text); //Gravar o texto que escreve dentro do txtPlaca.
                 novocarro.GravaKm(txtKm.Text); //Gravar o texto que escreve dentro do txtKm.


                 txtCarro.Text += novocarro.MostraModelo() + "\t"; // mostrar o modelo no txtCarro,
                 txtCarro.Text += novocarro.MostraPlaca() + "\t"; // mostra a placa no txtCarro, 
                 txtCarro.Text += novocarro.MostraKm() + "\r\n"; // mostrar o Km no txtCarro*/

                novocarro.propriedadesModelo = txtModelo.Text;
                novocarro.propriedadesPlaca = txtPlaca.Text;
                novocarro.propriedadesKm = txtKm.Text;

                txtCarros.AppendText(novocarro.propriedadesModelo + "\t");
                txtCarros.AppendText(novocarro.propriedadesPlaca + "\t");
                txtCarros.AppendText(novocarro.propriedadesKm + "\n");
                Limpar();
            }
            else
            {
                Caminhao novoCaminhao = new Caminhao(); //instanciando o objeto Caminhão

                novoCaminhao.propriedadesModelo = txtModelo.Text; 
                novoCaminhao.propriedadesPlaca = txtPlaca.Text;
                novoCaminhao.propriedadesKm = txtKm.Text;

                txtCaminhoes.AppendText(novoCaminhao.propriedadesModelo + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadesPlaca + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadesKm + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadeEixo + "\n");
                Limpar();
            }
        }
        private void BtnCaminhao_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = true; //transforma em visivel o componente btnSalvar.
            lblEixo.Visible = true; //transforma em visivel o componente lblEixo.
            txtEixo.Visible = true; //transforma em visivel o componente txtEixo.
            pbCaminhao.Visible = true; //transforma em visivel o componente pictureBox pbCaminhao.
            txtCaminhoes.Visible = true; //transforma em visivel o componente txtCaminhoes.
            //torna invisivel os componentes txtCarros e o pbCarros
            txtCarros.Visible = false;
            pbCarros.Visible = false;
        }

        private void BtnCarro_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = true; //torna em visivel o componente btnSalvar
            lblEixo.Visible = false; //transforma em invisivel o componente lblEixo
            txtEixo.Visible = false; //transforma em invisivel o componente txtEixo
            txtCarros.Visible = true; //transforma em visivel o componente txtCarros.
            pbCarros.Visible = true; //transforma em visivel o componente pictureBox pbCarros.
            //torna invisivel os componentes txtCaminhoes e o pbCaminhao
            txtCaminhoes.Visible = false; //transforma em visivel o componente pictureBox txtCaminhoes.
            pbCaminhao.Visible = false; //transforma em visivel o componente pictureBox pbCaminhao.
        }

        private void Limpar()
        {
            txtModelo.Clear();
            txtPlaca.Clear();
            txtKm.Clear();
            txtEixo.Clear();
        }
    }

    public class Veiculo //classe veiculo
    {
        private string Modelo, Placa, Km; //Variáveis encapsuladas metodo de segurança

        /*        
        //métodos atribuidores de valores do objeto
        public void GravaModelo(string modelo)
        {
            this.Modelo = modelo; // adicionando valor ao atributo
        }

        public void GravaPlaca(string placa)
        {
            this.Placa = placa;// adicionando valor ao atributo
        }

        public void GravaKm(string km)
        {
            this.Km = km;// adicionando valor ao atributo
        }

        //-----------------------------------------------------------

        //métodos que lêem os atributos do objeto -----------------
        public string MostraModelo()
        {
            return Modelo; //retorna o valor do atributo
        }

        public string MostraPlaca()
        {
            return Placa; //retorna o valor do atributo
        }

        public string MostraKm()
        {
            return Km; //retorna o valor do atributo
        }*/ //Aula Passada - clique no + para visualizar o código....

        public String propriedadesModelo
        {
            set { Modelo = value; }
            get { return Modelo; }
        }

        public String propriedadesPlaca
        {
            set { Placa = value; }
            get { return Placa; }
        }
        public String propriedadesKm
        {
            set { Km = value; }
            get { return Km; }
        }
    }

    public class Caminhao : Veiculo
    {
       public string propriedadeEixo { set; get; }
    }   
}

