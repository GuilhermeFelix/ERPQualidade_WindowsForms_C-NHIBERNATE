using NHibernate_PostGreSQLDAL;
using NHibernate_PostGreSQLDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade
{
    class GerarEstudoBO
    {
      public GerarEstudoBO(string _idmodelo)
      {
            this.Idmodelo  = _idmodelo;
            Iniciar();
      }

      private IList<Capabilidade_amostras> todasamostrasdomodelo = new List<Capabilidade_amostras>();
      private Double[] x = new Double[25]; //media
      private Double[] r = new Double[25]; //amplitude
      private Double[] caracteristicas = new Double[5];
      private Double[] todasascaracteristicas = new Double[25]; //mudar para [125]
      private Double maximo = 0, minimo = 0, variancia = 0, desviopadrao = 0, mediax = 0, minimox = 0,
                     maximox = 0, tolerancia = 0, variacaosixsigma = 0, pp = 0, ppu = 0, mediaminima = 0,
                     mediamaxima =0, ppl = 0, ppk = 0, mediaxb = 0, mediar = 0, amplitudemaxima = 0, varianciax =0,
                     desviopadraox = 0, varianciar = 0, desviopadraor = 0, desvioamostragemrbd2 = 0, desvioamostragema2rb = 0,
                     desvioamostragemvariacao = 0, cp = 0, cpu = 0, cpl = 0, cpk = 0, limitemediax = 0, limitemedialscx = 0,
                     limitemedialicx = 0, limiteamplitude = 0, limitelscr = 0;   
      public Boolean verificarsepode_rodarestudo;
      private int e = 0;
        private string idmodelo;
      private string idamostra;

      public string Idmodelo { get => idmodelo; set => idmodelo = value; }
      public string Idamostra { get => idamostra; set => idamostra = value; }


        #region INICIAR E VERIFICAR SE POSSUI 25 AMOSTRAS PREENCHIDAS NO MODELO
        private void Iniciar()
        {

            RepositoryCapabilidade_amostras dao = new RepositoryCapabilidade_amostras();
            
            foreach (var item in dao.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
              if (item.idmodelo == Idmodelo)
              {
                todasamostrasdomodelo.Add(item);
              }
            }

           if (todasamostrasdomodelo.Count!=5) //mudar 5 para 25 depois
           {      
              verificarsepode_rodarestudo = false;
           }
           else
           {
              verificarsepode_rodarestudo = true;
              Mediax_decadaamostra();
              Amplituder_decadaamostra();
              Performance();
              Desvios();
              LimiteseCapacidades();
              PersistirDadosemDAO();

           }
        }
        #endregion

        #region X (MEDIA DE CADA AMOSTRA)
        private void Mediax_decadaamostra()
        {
            foreach (var item in todasamostrasdomodelo)
            {
               x[(Convert.ToInt16(item.idamostra))-1] = (Convert.ToInt32(item.caracteristica1) + Convert.ToInt32(item.caracteristica2) + Convert.ToInt32(item.caracteristica3) + Convert.ToInt32(item.caracteristica4) + Convert.ToInt32(item.caracteristica5)) / 5 ; //mudar 5 para 25
            }
        }
        #endregion

        #region R (AMPLITUDE DE CADA AMOSTRA)
        private void Amplituder_decadaamostra()
        {
            
            foreach (var item in todasamostrasdomodelo)
            {
                //salvar as caracteristicas do item no vetor de caracteristicas
                caracteristicas[0] = Convert.ToDouble(item.caracteristica1);
                caracteristicas[1] = Convert.ToDouble(item.caracteristica2);
                caracteristicas[2] = Convert.ToDouble(item.caracteristica3);
                caracteristicas[3] = Convert.ToDouble(item.caracteristica4);
                caracteristicas[4] = Convert.ToDouble(item.caracteristica5);
                                
                //verificar no vetor de caracteristicas o maior valor e o menor valor.
                maximo = caracteristicas.Max();
                minimo = caracteristicas.Min();

                //calcular amplitude
                r[(Convert.ToInt16(item.idamostra)) - 1] = maximo - minimo;
            }
        }
        #endregion

        #region PERFORMANCE

        private void Performance()
        {

            RepositoryCapabilidade_modeloamostras daomodeloamostra = new RepositoryCapabilidade_modeloamostras();
            RepositoryCapabilidade_amostras daoamostra = new RepositoryCapabilidade_amostras();

            //Media de todas as caracteristicas de todas as amostras   
            e = 0;
            foreach (var item in todasamostrasdomodelo)
            {
                //salvar as caracteristicas do item no vetor de caracteristicas
                todasascaracteristicas[e] = Convert.ToDouble(item.caracteristica1);
                todasascaracteristicas[e + 1] = Convert.ToDouble(item.caracteristica2);
                todasascaracteristicas[e + 2] = Convert.ToDouble(item.caracteristica3);
                todasascaracteristicas[e + 3] = Convert.ToDouble(item.caracteristica4);
                todasascaracteristicas[e + 4] = Convert.ToDouble(item.caracteristica5);

                e = e + 5;
            }
            mediax = todasascaracteristicas.Average();

            e = 0;

            //media minima
            mediaminima = x.Min();

            //media maxima
            mediamaxima = x.Max();

            // Variancia
            foreach (var item in todasamostrasdomodelo)
            {
                //salvar as caracteristicas do item no vetor de caracteristicas
                caracteristicas[0] = Convert.ToDouble(item.caracteristica1);
                caracteristicas[1] = Convert.ToDouble(item.caracteristica2);
                caracteristicas[2] = Convert.ToDouble(item.caracteristica3);
                caracteristicas[3] = Convert.ToDouble(item.caracteristica4);
                caracteristicas[4] = Convert.ToDouble(item.caracteristica5);

              
            }


            foreach (var item in daoamostra.Consultar().OrderBy(x => x.id).ToList())
            {
                if (item.idmodelo == Idmodelo)
                {
                    variancia = variancia + Math.Pow((Convert.ToDouble(item.caracteristica1) - mediax), 2) +
                                             Math.Pow((Convert.ToDouble(item.caracteristica2) - mediax), 2) +
                                             Math.Pow((Convert.ToDouble(item.caracteristica3) - mediax), 2) +
                                             Math.Pow((Convert.ToDouble(item.caracteristica4) - mediax), 2) +
                                             Math.Pow((Convert.ToDouble(item.caracteristica5) - mediax), 2);
                }
            }
            variancia = variancia / 24; //trocar por 124

            //DesvioPadrao
            desviopadrao = Math.Sqrt(variancia);

            //Variação SixSigma
            variacaosixsigma = desviopadrao * 6;

            //Minimo de todas as caracteristicas de todas as amostras
            minimox = todasascaracteristicas.Min();

            //Maximo de todas as caracteristicas de todas as amostras
            maximox = todasascaracteristicas.Max();

            //Tolerancia  //é o LSE menos o LIE do modelo
            foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    tolerancia = Convert.ToDouble(item.lse) - Convert.ToDouble(item.lie);

                }
            }

            //PP
            pp = tolerancia / variacaosixsigma;

            //PPU
            foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    ppu = (Convert.ToDouble(item.lse) - mediax) / (3 * desviopadrao);
                }
            }

            //PPL
            foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    ppl = (mediax - (Convert.ToDouble(item.lie)) / (3 * desviopadrao));
                }
            }

            //PPK
            foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    if (Convert.ToDouble(item.lie) == 0)
                    {
                        ppk = ppu;
                    }
                    else
                    {
                        ppk = Math.Min(ppu, ppl);
                    }
                }
            }

            //Media Xb

            mediaxb = x.Average();

            //Media R

            mediar = r.Average();

            //Amplitude Maxima

            amplitudemaxima = r.Max();
           
        }
        #endregion

        #region DESVIOS
        private void Desvios()
        {
            
            //variancia de X
            for (int i = 0; i < x.Length; i++)
            {
                varianciax = varianciax + Math.Pow(x[i] - x.Average(), 2);
            }
            
            varianciax = varianciax / 24; //trocar por 124
            
            //DesvioPadraox
            desviopadraox = Math.Sqrt(varianciax);
            
            //variancia de R
            for (int i =0; i < x.Length; i++)
            {
                varianciar = varianciar + Math.Pow(r[i] - r.Average(), 2);
            }
            varianciar = varianciar / 24; //trocar por 124

            //DesvioPadraor
            desviopadraor = Math.Sqrt(varianciar);

            //Desvio Amostragem RB/d2
            desvioamostragemrbd2 = (maximox / 2.326);

            //Desvio Amostragem A2 / rb
            desvioamostragema2rb = (0.577 * maximox);

            //Desvio Amostragem Variação
            desvioamostragemvariacao = desvioamostragemrbd2 * 6;

        }
        #endregion

        #region LIMITES E CAPACIDADE
        private void LimiteseCapacidades()
        {
        //limiteMedia x
          limitemediax = mediax;

        //limiteMedia Lscx
          limitemedialscx = limitemediax + desvioamostragema2rb;

        //limiteMedia licx
          limitemedialicx = limitemediax - desvioamostragema2rb;

        //limite amplitude
          limiteamplitude = mediar;

        //limite lscr 
          limitelscr = limiteamplitude * 2.114;

        //CP
          cp = tolerancia / (6 * desvioamostragemrbd2);

        //CPU
          RepositoryCapabilidade_modeloamostras daomodeloamostra = new RepositoryCapabilidade_modeloamostras();
          foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
          {
                if (item.idmodelo == Idmodelo)
                {
                    cpu = (Convert.ToDouble(item.lse) + limitemediax) / (3 * desvioamostragemrbd2);
                }
          }

            //CPL
            foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    cpl = (mediax - Convert.ToDouble(item.lie)) / (3 * desvioamostragemrbd2);
                }
            }


            //CPK
            foreach (var item in daomodeloamostra.Consultar().OrderBy(x => x.id).ToList())//filtramodelo
            {
                if (item.idmodelo == Idmodelo)
                {
                    if (Convert.ToDouble(item.lie) == 0)
                    {
                        cpk = cpu;
                    }
                    else
                    {
                        cpk = Math.Min(cpu, cpl);
                    }
                }
            }

        }
        #endregion

        #region SALVAR NO BD
        //salvar x media de cada amostra
        private void PersistirDadosemDAO()
        {
            Capabilidade_xmediadecadaamostra novaxmedia = new Capabilidade_xmediadecadaamostra();
            RepositoryCapabilidade_xmediadecadaamostra dao = new RepositoryCapabilidade_xmediadecadaamostra();

            novaxmedia.idmodelo = idmodelo;
            novaxmedia.x1 = x[0].ToString();
            novaxmedia.x2 = x[1].ToString();
            novaxmedia.x3 = x[2].ToString();
            novaxmedia.x4 = x[3].ToString();
            novaxmedia.x5 = x[4].ToString();
            novaxmedia.x6 = x[5].ToString();
            novaxmedia.x7 = x[6].ToString();
            novaxmedia.x8 = x[7].ToString();
            novaxmedia.x9 = x[8].ToString();
            novaxmedia.x10 = x[9].ToString();
            novaxmedia.x11 = x[10].ToString();
            novaxmedia.x12 = x[11].ToString();
            novaxmedia.x13 = x[12].ToString();
            novaxmedia.x14 = x[13].ToString();
            novaxmedia.x15 = x[14].ToString();
            novaxmedia.x16 = x[15].ToString();
            novaxmedia.x17 = x[16].ToString();
            novaxmedia.x18 = x[17].ToString();
            novaxmedia.x19 = x[18].ToString();
            novaxmedia.x20 = x[19].ToString();
            novaxmedia.x21 = x[20].ToString();
            novaxmedia.x22 = x[21].ToString();
            novaxmedia.x23 = x[22].ToString();
            novaxmedia.x24 = x[23].ToString();
            novaxmedia.x25 = x[24].ToString();
            dao.Inserir(novaxmedia);

            
        //salvar r amplitude de cada amostra
            Capabilidade_ramplitudedecadaamostra novaramplitude = new Capabilidade_ramplitudedecadaamostra();
            RepositoryCapabilidade_ramplitudedecadaamostra dao2 = new RepositoryCapabilidade_ramplitudedecadaamostra();
            
            novaramplitude.idmodelo = idmodelo;
            novaramplitude.r1 = r[0].ToString();
            novaramplitude.r2 = r[1].ToString();
            novaramplitude.r3 = r[2].ToString();
            novaramplitude.r4 = r[3].ToString();
            novaramplitude.r5 = r[4].ToString();
            novaramplitude.r6 = r[5].ToString();
            novaramplitude.r7 = r[6].ToString();
            novaramplitude.r8 = r[7].ToString();
            novaramplitude.r9 = r[8].ToString();
            novaramplitude.r10 = r[9].ToString();
            novaramplitude.r11 = r[10].ToString();
            novaramplitude.r12 = r[11].ToString();
            novaramplitude.r13 = r[12].ToString();
            novaramplitude.r14 = r[13].ToString();
            novaramplitude.r15 = r[14].ToString();
            novaramplitude.r16 = r[15].ToString();
            novaramplitude.r17 = r[16].ToString();
            novaramplitude.r18 = r[17].ToString();
            novaramplitude.r19 = r[18].ToString();
            novaramplitude.r20 = r[19].ToString();
            novaramplitude.r21 = r[20].ToString();
            novaramplitude.r22 = r[21].ToString();
            novaramplitude.r23 = r[22].ToString();
            novaramplitude.r24 = r[23].ToString();
            novaramplitude.r25 = r[24].ToString();
            dao2.Inserir(novaramplitude);
        }
        
        #endregion
    }
}

