using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_12_Felipe_Relac_1000
{
    public partial class frm_Clientes : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=OSA0625257W10-1;Initial Catalog=RELACIONAMENTOS_200;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Clientes()
        {
            InitializeComponent();
            
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            carregarLista();
        }
        private void carregarLista()
        {
            conn.Open();
            comando.CommandText = "select * from Clientes";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read()) //enquanto estiver lendo os arquivos das linhas...
                {
                    lboCodigo.Items.Add(dr[0].ToString()); // adicionar a primeira linha (codigo) como string dentro do list box
                    lboNome.Items.Add(dr[1].ToString()); // adicionar a segunda linha (nome) como string dentro do list box
                    lboEndereco.Items.Add(dr[2].ToString()); // adicionar a terceira linha (endereco) como string dentro do list box
                    lboNascimento.Items.Add(dr[3].ToString());
                    lboTelefone.Items.Add(dr[4].ToString());
                    lboEmail.Items.Add(dr[5].ToString());
                }

            }
            conn.Close();

        }
        private void MetodoSelecionar(object sender) //Método SELECIONAR
        {
            ListBox l = sender as ListBox;  //L representa Linhas
            if (l.SelectedIndex != -1)
            {
                lboCodigo.SelectedIndex = l.SelectedIndex;
                lboNome.SelectedIndex = l.SelectedIndex;
                lboEndereco.SelectedIndex = l.SelectedIndex;
                lboNascimento.SelectedIndex = l.SelectedIndex;
                lboTelefone.SelectedIndex = l.SelectedIndex;
                lboEmail.SelectedIndex = l.SelectedIndex;

                txbCod.Text = lboCodigo.SelectedItem.ToString();
                txbNome.Text = lboNome.SelectedItem.ToString();
                txbEndereco.Text = lboEndereco.SelectedItem.ToString();
                txbNascimento.Text = lboNascimento.SelectedItem.ToString();
                txbTelefone.Text = lboTelefone.SelectedItem.ToString();
                txbEmail.Text = lboEmail.SelectedItem.ToString();
            }
        }








        //MÉTODO SELECIONAR A LINHA INTEIRA ----------------------------------------------------------------------
        private void lboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoSelecionar(sender);
        }

        private void lboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoSelecionar(sender);
        }

        private void lboEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoSelecionar(sender);
        }

        private void lboNascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoSelecionar(sender);
        }

        private void lboTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoSelecionar(sender);
        }

        private void lboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoSelecionar(sender);
        }       
        //MÉTODO SELECIONAR A LINHA INTEIRA ----------------------------------------------------------------------

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txbCod.Clear();
            txbNome.Clear();
            txbEndereco.Clear();
            txbNascimento.Clear();
            txbTelefone.Clear();
            txbEmail.Clear();

            txbNome.Focus();
        }

        private void txbCod_TextChanged(object sender, EventArgs e)
        {
            txbCod.Enabled = false;
        }
    }
}
