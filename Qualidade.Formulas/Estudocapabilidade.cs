using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qualidade.Formulas
{
    class Estudocapabilidade
    {

        public Estudocapabilidade()
        {
            xamostras();
            //x é a media dos valores da amostra
            //acessando a tabela de amostras, deve entrar em cada id modelo que seja igual ao que deve ser estudado e carregar em uma lista as 25 amostras.
            //para calcular x, primeiro deve acessar lista de modelos e verificar se existem 25 amostras preenchidas no modelo.
            //caso não tenha 25 amostras preenchidas, o estudo de capabilidade não devera ser gerado, uma mensagem devera informar o usuario.
            //caso esteja preenchidas as 25 amostras entao deve proceder com o calculo da media x.
            //para calcular x temos a lista com as 25 amostras, deve percorrer as 25 amostras e cada vez que achar uma amostra com o mesmo idamostra entao deve preencher
            //um contador i com +1, fazer while com i <=5. 
            //dentro desse while deve existir a somatoria para efeito de calculo da media que carregara a soma em uma repetição de 5 X.
            //apos somado 5 vezes devera guardar na lista esse valor.
            //apos efetuado a operação de somatoria para as 25 amostras, devera ser efetuado em um for de 25 repetições os calculos de divisão.
            //os calculos de divisao sera o valor da somatoria dividido por cinco, o resultado devera sobreescrever o valor das somas na lista
            //pronto já temos as 25 medias de x.
        }

        public void xamostras()
        {
            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();
            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())
            {
                


            }
        }


        /*if (item.idmodelo == Idmodelo)
        {
          todasamostras.Add(item);
        }
}
      foreach (var item in todasamostras) //filtraamostranomodelo
      {
        if (item.idamostra == Idamostra)
        {
          amostraexistenteemDAO = true;
        }
      }

  */
    }
}


