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
            carregarlistaMaquinaFabricacao();
            carregarlistaferramentademedicao();


        }


        private void carregarlistaferramentademedicao()
        {

            //carregar nomes na lista
            int i = 0;
            ConfiguracaoFerramentadeMedicaoCapabilidadeBO carregarferramentademedicao = new ConfiguracaoFerramentadeMedicaoCapabilidadeBO();
            if (carregarferramentademedicao.capabilidade_ferramentademedicao.Count() == 0)
            {
                lst_FerramentadeMedicao.Items.Clear();
                lst_FerramentadeMedicao.Items.Add("Nova Ferramenta");
            }


            foreach (var item in carregarferramentademedicao.capabilidade_ferramentademedicao)
            {
                if (i == 0)
                {
                    lst_FerramentadeMedicao.Items.Clear();
                    lst_FerramentadeMedicao.Items.Add("Nova Ferramenta");
                }

                lst_FerramentadeMedicao.SelectedIndex.Equals(0);
                lst_FerramentadeMedicao.Items.Add(item.ferramentademedicao.ToString());

                i++;
            }
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



        private void carregarlistaMaquinaFabricacao()
        {

            //carregar nomes na lista
            int i = 0;
            ConfiguracaoMaquinaFabricacaoCapabilidadeBO carregarmaquina = new ConfiguracaoMaquinaFabricacaoCapabilidadeBO();
            if (carregarmaquina.capabilidade_maquinafabricacao.Count() == 0)
            {
                lst_MaquinaFabricacao.Items.Clear();
                lst_MaquinaFabricacao.Items.Add("Nova Maquina");
            }


            foreach (var item in carregarmaquina.capabilidade_maquinafabricacao)
            {
                if (i == 0)
                {
                    lst_MaquinaFabricacao.Items.Clear();
                    lst_MaquinaFabricacao.Items.Add("Nova Maquina");
                }

                lst_MaquinaFabricacao.SelectedIndex.Equals(0);
                lst_MaquinaFabricacao.Items.Add(item.maquinafabricacao.ToString());

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

        private void btn_RemoverMaquina_Click(object sender, EventArgs e)
        {
            
            if (lst_MaquinaFabricacao.SelectedItem.ToString() == "Nova Maquina")
            {
                errorProvider1.SetError(lst_MaquinaFabricacao, "Selecione um item para remover");
            }
            else
            {
                ConfiguracaoMaquinaFabricacaoCapabilidadeBO remover = new ConfiguracaoMaquinaFabricacaoCapabilidadeBO(lst_MaquinaFabricacao.SelectedItem.ToString(), true);
                MessageBox.Show("Remoção Concluida!");
               
                lst_MaquinaFabricacao.Items.Clear();
                carregarlistaMaquinaFabricacao();
            }
        }

        private void btn_SalvarMaquina_Click(object sender, EventArgs e)
        {
            if (lst_MaquinaFabricacao.SelectedItem == null)
            {
                errorProvider1.SetError(lst_MaquinaFabricacao, "Selecione uma opção!");
            }
            else
            {
                if (lst_MaquinaFabricacao.SelectedItem.ToString() == "Nova Maquina")
                {
                    //Salvar
                    ConfiguracaoMaquinaFabricacaoCapabilidadeBO salvarmaquina = new ConfiguracaoMaquinaFabricacaoCapabilidadeBO(txt_Maquina.Text.ToString());

                }
                else
                {
                    //Alterar
                    ConfiguracaoMaquinaFabricacaoCapabilidadeBO alterarmaquina = new ConfiguracaoMaquinaFabricacaoCapabilidadeBO(txt_Maquina.Text.ToString(), lst_MaquinaFabricacao.SelectedItem.ToString());
                }
            }

            lst_MaquinaFabricacao.Items.Clear();
            txt_Maquina.Text = "";
            carregarlistaMaquinaFabricacao();
        }

        private void lst_MaquinaFabricacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Maquina_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_CaracteristicaChave_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btn_SalvarFerramenta_Click(object sender, EventArgs e)
        {
            if (lst_FerramentadeMedicao.SelectedItem == null)
            {
                errorProvider1.SetError(lst_FerramentadeMedicao, "Selecione uma opção!");
            }
            else
            {
                if (lst_FerramentadeMedicao.SelectedItem.ToString() == "Nova Ferramenta")
                {
                    //Salvar
                    ConfiguracaoFerramentadeMedicaoCapabilidadeBO salvarferramenta = new ConfiguracaoFerramentadeMedicaoCapabilidadeBO(txt_Ferramenta.Text.ToString());

                }
                else
                {
                    //Alterar
                    ConfiguracaoFerramentadeMedicaoCapabilidadeBO alterarferramenta = new ConfiguracaoFerramentadeMedicaoCapabilidadeBO(txt_Ferramenta.Text.ToString(), lst_FerramentadeMedicao.SelectedItem.ToString());
                }
            }

            lst_FerramentadeMedicao.Items.Clear();
            txt_Ferramenta.Text = "";
            carregarlistaferramentademedicao();
        }

        private void btn_RemoverFerramenta_Click(object sender, EventArgs e)
        {
            if (lst_FerramentadeMedicao.SelectedItem.ToString() == "Nova Ferramenta")
            {
                errorProvider1.SetError(lst_FerramentadeMedicao, "Selecione um item para remover");
            }
            else
            {
                ConfiguracaoFerramentadeMedicaoCapabilidadeBO remover = new ConfiguracaoFerramentadeMedicaoCapabilidadeBO(lst_FerramentadeMedicao.SelectedItem.ToString(), true);
                MessageBox.Show("Remoção Concluida!");

                lst_FerramentadeMedicao.Items.Clear();
                carregarlistaferramentademedicao();
            }
        }
    }
}
