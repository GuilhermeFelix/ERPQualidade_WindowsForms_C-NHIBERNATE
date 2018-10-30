using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualidade.View
{
    public partial class ConfiguracoesCapabilidade : Form
    {
        public ConfiguracoesCapabilidade()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfiguracoesCapabilidade_Load(object sender, EventArgs e)
        {
            lst_CaracteristicaChave.Items.Clear();
            carregarlistaCaracteristicaChave();



        }


        private void carregarlistaCaracteristicaChave()
        {

            //carregar nomes na lista
            int i = 0;
            ConfiguracaoCaracteristicaChaveCapabilidadeBO carregarcaracteristicachave = new ConfiguracaoCaracteristicaChaveCapabilidadeBO();
            if (carregarcaracteristicachave.capabilidade_Caracteristicachaves.Count() == 0)
            {
                lst_CaracteristicaChave.Items.Clear();
                lst_CaracteristicaChave.Items.Add("Nova Caracteristica");
            }


            foreach (var item in carregarcaracteristicachave.capabilidade_Caracteristicachaves)
            {
                if (i == 0)
                {
                    lst_CaracteristicaChave.Items.Clear();
                    lst_CaracteristicaChave.Items.Add("Nova Caracteristica");
                }

                lst_CaracteristicaChave.SelectedIndex.Equals(0);
                lst_CaracteristicaChave.Items.Add(item.caracteristica.ToString());

                i++;
            }
        }

        private void btn_SalvarCaracteristicaChave_Click(object sender, EventArgs e)
        {
            
            if (lst_CaracteristicaChave.SelectedItem == null)
            {
                errorProvider1.SetError(lst_CaracteristicaChave, "Selecione uma opção!");
            }
            else
            {
                if (lst_CaracteristicaChave.SelectedItem.ToString() == "Nova Caracteristica")
                {
                    //Salvar
                    ConfiguracaoCaracteristicaChaveCapabilidadeBO salvarcaracteristica = new ConfiguracaoCaracteristicaChaveCapabilidadeBO(txt_CaracteristicaChave.Text.ToString());

                }
                else
                {
                    //Alterar
                    ConfiguracaoCaracteristicaChaveCapabilidadeBO alterarcaracteristica = new ConfiguracaoCaracteristicaChaveCapabilidadeBO(txt_CaracteristicaChave.Text.ToString() , lst_CaracteristicaChave.SelectedItem.ToString());
                }
            }

            lst_CaracteristicaChave.Items.Clear();
            txt_CaracteristicaChave.Text = "";
            carregarlistaCaracteristicaChave();
        }

        private void lst_CaracteristicaChave_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btn_RemoverCaracteristica_Click(object sender, EventArgs e)
        {
            if (lst_CaracteristicaChave.SelectedItem.ToString() == "Nova Caracteristica")
            {
                errorProvider1.SetError(lst_CaracteristicaChave, "Selecione um item para remover");
            }
            else
            {
                ConfiguracaoCaracteristicaChaveCapabilidadeBO remover = new ConfiguracaoCaracteristicaChaveCapabilidadeBO(lst_CaracteristicaChave.SelectedItem.ToString(), true);
                MessageBox.Show("Remoção Concluida!");
                lst_CaracteristicaChave.Items.Clear();
                carregarlistaCaracteristicaChave();
            }
        }
    }
}
