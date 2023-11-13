using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseCircuito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----------------------------------------ANÁLISE-DE-CIRCUITOS----------------------------------------\n");
            Console.Write("Quantas malhas têm o circuito? \n");
            int nMalha = int.Parse(Console.ReadLine());
            float [,] matrizConta = new float [nMalha, nMalha];  
            for (int i = 0; i < nMalha; i++) //percorre matriz por matriz
            {
                string resp1, resp2;
                Console.Write("----------------------------------------MALHA-" + (i+1) + "----------------------------------------\n");
                Console.Write("A malha " + (i+1) + " possui alguma fonte (s/n)? ");
                resp1 = Console.ReadLine().ToLower(); //lê a resposta do usuário, para saber se a malha possui alguma fonte ou não
                
                if (resp1 == "s") //se a resposta for "s" (sim), o programa continua dentro do if. Caso contrário o programa passa para a próxima etapa
                {
                    Console.Write("   Há quantas fontes nessa malha? ");
                    int nFonte = int.Parse(Console.ReadLine());
                    float[] valorFonte = new float[nFonte]; //vetor necessário para a soma das fontes pertencentes a matriz
                    float somaFonte = 0; 
                    for (int j = 0; j < nFonte; j++) //percorre os valores das fontes
                    {
                        Console.Write("   Informe o valor da " + (j+1) + "° fonte: ");
                        valorFonte[j] = float.Parse(Console.ReadLine());
                        Console.Write("   Qual o sentido dessa fonte? (Leve em consideração que a corrente está no sentido horário). Se estiver no mesmo sentido da corrente, digite (1), caso contrário digite (2): ");
                        bool resp = true; //necessário para que o usuário informe a posição corretamente 
                        int posicao; //posição da fonte (importante no cáluclo)
                        do
                        {
                           resp = true;
                           posicao = int.Parse(Console.ReadLine());
                           if (posicao == 1)
                           {
                                valorFonte[j] = valorFonte[j];
                           }
                           else if (posicao == 2)
                           {
                               valorFonte[j] = (-valorFonte[j]); //muda o valor da fonte para negativo, caso essa esteja em sentido contrário à corrente
                           }
                           else
                           {
                               Console.Write("   Erro! Digite novamente: ");
                               resp = false;
                           }
                        } while (!resp);
                        somaFonte += valorFonte[j]; //soma o valor de todas as fontes para usar na matriz
                    }
                    Console.WriteLine(somaFonte); //apenas para informar o cálculo
                }

                Console.Write("\nA malha " + (i+1) + " possui algum resistor (s/n)? ");
                resp2 = Console.ReadLine().ToLower();
                float somaResistor = 0, somaResistorCompartilhado = 0; //soma o valor de todos os resistores (compartilhados ou não) para usar na matriz
                if (resp2 == "s")
                {
                    Console.Write("   Há quantos resistores nessa malha? ");
                    int nResistor = int.Parse(Console.ReadLine());
                    float[] valorResistor = new float[nResistor]; //vetor necessário para a soma dos resistores pertencentes a matriz
                    int nResistorCompartilhadoF, nResistorCompartilhadoL, nResistorCompartilhadoM1, nResistorCompartilhadoM2; //L=last; F=first; M1=mid1; M=mid2
                    for (int k = 0; k < nResistor; k++)
                    {
                        Console.Write("   Informe o valor do " + (k+1) + "° resistor: ");

                        valorResistor[k] = float.Parse(Console.ReadLine());
                        somaResistor += valorResistor[k]; //armazena a soma dos valores de todos os resistores da matriz em questão
                    }
                    if (i==0) //primeira malha
                    {
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i+2) + "? ");
                        nResistorCompartilhadoF = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoF = new float[nResistorCompartilhadoF];
                        for (int l = 0; l < nResistorCompartilhadoF; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado: ");

                            valorResistorCompartilhadoF[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhado -= valorResistorCompartilhadoF[l]; //armazena a soma dos valores de todos os resistores compartilhados da matriz em questão com a matriz ao lado
                        }
                    }
                    else if (i==(nMalha-1)) //última malha
                    {
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i) + "? ");
                        nResistorCompartilhadoL = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoL = new float[nResistorCompartilhadoL];
                        for (int l = 0; l < nResistorCompartilhadoL; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado: ");

                            valorResistorCompartilhadoL[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhado -= valorResistorCompartilhadoL[l];
                        }
                    }
                    else //malhas quaisquer que não sejam nem a primeira e nem a última
                    {
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i + 2) + "? ");
                        nResistorCompartilhadoM1 = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoM1 = new float[nResistorCompartilhadoM1];
                        for (int l = 0; l < nResistorCompartilhadoM1; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado com a malha " + (i + 2) + ": ");

                            valorResistorCompartilhadoM1[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhado -= valorResistorCompartilhadoM1[l];
                        }
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i) + "? ");
                        nResistorCompartilhadoM2 = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoM2 = new float[nResistorCompartilhadoM2];
                        for (int l = 0; l < nResistorCompartilhadoM2; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado com a malha " + (i) + ": ");

                            valorResistorCompartilhadoM2[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhado -= valorResistorCompartilhadoM2[l];
                        }
                    }
                }
                Console.WriteLine(somaResistor); //apenas para informar o cálculo
                Console.WriteLine(somaResistorCompartilhado); //apenas para informar o cálculo
                Console.WriteLine("---------------------------------------------------------------------------------------\n");

            /*for (int m = 0; m<nMalha; m++)
            {
                for (int n = 0; n < nMalha; n++)
                {
                    matrizConta[m,n] = somaResistor;
                    matrizConta[m,(n+1)] = somaResistorCompartilhado;
                } 
            }*/
            }

            Console.ReadKey();
        }
    }
}
