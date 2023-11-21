using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace AnaliseCircuito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool respPrincipal = true;
            try
            {
                do
                {
                    Console.WriteLine("----------------------------------------ANÁLISE-DE-CIRCUITOS----------------------------------------\n");
                    Console.WriteLine("   Análise de circuito é o processo de encontrar todas as correntes e tensões em uma rede de componentes conectados. \n   Para um melhor entendimento por parte do usuário, nós definimos alguns termos importantes: ");
                    Console.WriteLine("        - Nesse programa, leve em consideração que as correntes estão sempre no sentido HORÁRIO.");
                    Console.WriteLine("        - Resistor particular: resistor que se encontra em um fio exclusivo de uma malha.");
                    Console.WriteLine("        - Resistor compartilhado: resistor que se encontra no fio entre duas malhas.");
                    Console.WriteLine("        - Cada corrente pertence à sua respectiva malha (I1 - malha 1; I2 - malha 2...).");
                    Console.WriteLine("        - Já as correntes excedentes (por exemplo: I3 em um circuito de 2 malhas) pertencem às conexões das malhas e sua leitura deve ser feita da esquerda para direita.");
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
                    Console.Write("   Digite a quantidade de malhas do circuito: ");
                    int nMalha = int.Parse(Console.ReadLine());
                    float[,] matrizConta = new float[nMalha, nMalha]; //matriz diretamente responsável pela conta das correntes. (matrizConta[i] * matrizSistema[i] = matrizResultado(=somaFonte))
                    float[] somaResistorParticular = new float[nMalha];
                    float[] somaResistorCompartilhadoPro = new float[nMalha]; //soma o valor de todos os resistores compartilhados com a próxima malha
                    float[] somaResistorCompartilhadoAnt = new float[nMalha]; //soma o valor de todos os resistores compartilhados com a malha anterior
                    float[] somaResistor = new float[nMalha]; //soma o valor de todos os resistores na malha
                    float[] somaFonte = new float[nMalha];  //soma o valor de todas as fontes na malha
                    int[] totalResistorMalha = new int[nMalha];
                    int totalResistor = 0;
                    //todos esses vetores acima, armazenam o valor específico de cada malha (somaResistor[0] e somaFonte[0], por exemplo, armazenam os dados apenas da malha 1)

                    for (int i = 0; i < nMalha; i++) //percorre malha por malha
                    {
                        string resp1, resp2;
                        Console.WriteLine("\n");
                        Console.WriteLine("\n-----------------------------------------------MALHA-" + (i + 1) + "----------------------------------------------");
                        Console.Write("\nA malha " + (i + 1) + " possui alguma fonte (s/n)? ");
                        resp1 = Console.ReadLine().ToLower(); //lê a resposta do usuário, para saber se a malha possui alguma fonte ou não

                        if (resp1 == "s") //se a resposta for "s" (sim), o programa continua dentro do if. Caso contrário o programa passa para a próxima etapa
                        {
                            Console.Write("   Há quantas fontes nessa malha? ");
                            int nFonte = int.Parse(Console.ReadLine());
                            float[] valorFonte = new float[nFonte]; //vetor necessário para a soma das fontes pertencentes a matriz
                            somaFonte[i] = 0;
                            for (int j = 0; j < nFonte; j++) //percorre os valores das fontes
                            {
                                Console.Write("      - Informe o valor da " + (j + 1) + "° fonte (v): ");
                                valorFonte[j] = float.Parse(Console.ReadLine());
                                Console.WriteLine("   Qual o sentido dessa fonte?");
                                Console.Write("      Se estiver no mesmo sentido da corrente (horário), digite (1), caso contrário (anti-horário) digite (2): ");
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
                                        Console.Write(" Erro! Digite novamente: ");
                                        resp = false;
                                    }
                                } while (!resp);
                                somaFonte[i] += valorFonte[j]; //soma o valor de todas as fontes para usar na matriz
                            }
                        }

                        Console.Write("\nA malha " + (i + 1) + " possui algum resistor (s/n)? ");
                        resp2 = Console.ReadLine().ToLower(); //To.Lower = pode ser usado letras maiúsculas e minúsculas
                        somaResistor[i] = 0; somaResistorParticular[i] = 0; somaResistorCompartilhadoPro[i] = 0; somaResistorCompartilhadoAnt[i] = 0; //vetores com valor inicial 0, para poder efetuar a soma pedida
                        totalResistorMalha[i] = 0;
                        int nResistor, nResistorCompartilhadoF, nResistorCompartilhadoL, nResistorCompartilhadoM1, nResistorCompartilhadoM2;  //L=last; F=first; M1=mid1; M=mid2
                        if (resp2 == "s")
                        {
                            Console.Write("   Há quantos resistores particulares nessa malha? ");
                            nResistor = int.Parse(Console.ReadLine());
                            totalResistorMalha[i] += nResistor;
                            float[] valorResistorParticular = new float[nResistor]; //vetor necessário para a soma dos resistores pertencentes a matriz
                            for (int k = 0; k < nResistor; k++)
                            {
                                Console.Write("      - Informe o valor do " + (k + 1) + "° resistor (Ohm) particular: ");

                                valorResistorParticular[k] = float.Parse(Console.ReadLine());
                                somaResistorParticular[i] += valorResistorParticular[k]; //armazena a soma dos valores de todos os resistores da matriz em questão
                                                                                         //somaResistor[i] += somaResistorParticular[k];
                            }
                            if (i == 0) //primeira malha
                            {
                                Console.Write("   Há quantos resistores compartilhados com a malha " + (i + 2) + "? ");
                                nResistorCompartilhadoF = int.Parse(Console.ReadLine());
                                totalResistorMalha[i] += nResistorCompartilhadoF;
                                float[] valorResistorCompartilhadoF = new float[nResistorCompartilhadoF];
                                for (int l = 0; l < nResistorCompartilhadoF; l++)
                                {
                                    Console.Write("      - Informe o valor do " + (l + 1) + "° resistor (Ohm) compartilhado com a malha " + (i + 2) + ": ");

                                    valorResistorCompartilhadoF[l] = float.Parse(Console.ReadLine());
                                    somaResistorCompartilhadoPro[i] -= valorResistorCompartilhadoF[l]; //armazena a soma dos valores de todos os resistores compartilhados da matriz em questão com a matriz ao lado
                                                                                                       //somaResistor[i] += somaResistorCompartilhadoPro[l];
                                }
                            }
                            else if (i == (nMalha - 1)) //última malha
                            {
                                Console.Write("   Há quantos resistores compartilhados com a malha " + (i) + "? ");
                                nResistorCompartilhadoL = int.Parse(Console.ReadLine());
                                totalResistorMalha[i] += nResistorCompartilhadoL;
                                float[] valorResistorCompartilhadoL = new float[nResistorCompartilhadoL];
                                for (int l = 0; l < nResistorCompartilhadoL; l++)
                                {
                                    Console.Write("      - Informe o valor do " + (l + 1) + "° resistor (Ohm) compartilhado com a malha " + (i) + ": ");

                                    valorResistorCompartilhadoL[l] = float.Parse(Console.ReadLine());
                                    somaResistorCompartilhadoAnt[i] -= valorResistorCompartilhadoL[l];
                                    //somaResistor[i] += somaResistorCompartilhadoAnt[l];
                                }
                            }
                            else //malhas quaisquer que não sejam nem a primeira e nem a última
                            {
                                Console.Write("   Há quantos resistores compartilhados com a malha " + (i + 2) + "? ");
                                nResistorCompartilhadoM1 = int.Parse(Console.ReadLine());
                                totalResistorMalha[i] += nResistorCompartilhadoM1;
                                float[] valorResistorCompartilhadoM1 = new float[nResistorCompartilhadoM1];
                                for (int l = 0; l < nResistorCompartilhadoM1; l++)
                                {
                                    Console.Write("      - Informe o valor do " + (l + 1) + "° resistor (Ohm) compartilhado com a malha " + (i + 2) + ": ");

                                    valorResistorCompartilhadoM1[l] = float.Parse(Console.ReadLine());
                                    somaResistorCompartilhadoPro[i] -= valorResistorCompartilhadoM1[l];
                                    //somaResistor[i] += somaResistorCompartilhadoPro[l];
                                }
                                Console.Write("   Há quantos resistores compartilhados com a malha " + (i) + "? ");
                                nResistorCompartilhadoM2 = int.Parse(Console.ReadLine());
                                totalResistorMalha[i] += nResistorCompartilhadoM2;
                                float[] valorResistorCompartilhadoM2 = new float[nResistorCompartilhadoM2];
                                for (int l = 0; l < nResistorCompartilhadoM2; l++)
                                {
                                    Console.Write("      - Informe o valor do " + (l + 1) + "° resistor (Ohm) compartilhado com a malha " + (i) + ": ");

                                    valorResistorCompartilhadoM2[l] = float.Parse(Console.ReadLine());
                                    somaResistorCompartilhadoAnt[i] -= valorResistorCompartilhadoM2[l];
                                    //somaResistor[i] += somaResistorCompartilhadoAnt[l];
                                }
                            }
                            somaResistor[i] += somaResistorParticular[i] - somaResistorCompartilhadoAnt[i] - somaResistorCompartilhadoPro[i];
                        }


                        int a = 0; //índice a precisa ser declarado fora do for, para não interferir dentro dele
                        for (int m = 0; m < nMalha; m++) //for para preencher a matrizConta
                        {
                            for (int n = 0; n < nMalha; n++)
                            {
                                if (m == n) //se o índice m for igual ao índice n, ou seja, preenche a diagonal principal (0,0 (somaResistor[0]); 1,1 (somaResistor[1]); 2,2 (somaResistor[2])...)
                                {
                                    matrizConta[m, n] = somaResistor[a];
                                }
                                else if (m > (n + 1) || n > (m + 1)) //índices com uma diferença de 2 números ou mais, são preenchidos com 0 (2,0; 3,0; 1,3; 0,2...)
                                {
                                    matrizConta[m, n] = 0;
                                }
                                else
                                {
                                    if (m > n) //(1,0; 2,1; 3,2...)
                                    {
                                        matrizConta[m, n] = somaResistorCompartilhadoAnt[a]; //apenas a soma de resistores compartilhados com a malha anterior
                                    }
                                    else //(0,1; 1,2; 2,3...)
                                    {
                                        matrizConta[m, n] = somaResistorCompartilhadoPro[a]; //apenas a soma de resistores compartilhados com a próxima malha
                                    }

                                }
                            }
                            a++; //entre os dois for, para que ele some 1 no índice somente quando trocar de linha
                        }

                    }

                    Console.WriteLine("---------------------------------------------------------------------------------------\n");
                    Console.WriteLine("----------------------------------------INFORME----------------------------------------");
                    Console.WriteLine("\n   Digite o número total de resistores compartilhados no circuito: ");
                    int rCompartilhado = int.Parse(Console.ReadLine());

                    for (int i = 0; i < nMalha; i++)
                    {
                        totalResistor += totalResistorMalha[i];
                    }
                    totalResistor = totalResistor - rCompartilhado;

                    int[] nCorrente = new int[(nMalha * 2) - 1];

                    Console.WriteLine("\n---------------------------------------------------------------------------------------");
                    Console.Write("\nMatriz conta: \n");
                    for (int m = 0; m < nMalha; m++)
                    {
                        for (int n = 0; n < nMalha; n++)
                        {
                            Console.Write(matrizConta[m, n] + "   ");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("\n----------------------------------------------------\n");

                    // Coeficientes da matriz           
                    Matrix<double> coefficients = Matrix<double>.Build.Dense(nMalha, nMalha); //matriz preenchida à mão
                    for (int h = 0; h < nMalha; h++)
                    {
                        for (int z = 0; z < nMalha; z++)
                        {
                            coefficients[h, z] = matrizConta[h, z];
                        }
                    }

                    // Coluna das fontes
                    Vector<double> results = Vector<double>.Build.Dense(nMalha); //Coluna da direita do sistema (resultados)

                    for (int g = 0; g < nMalha; g++)
                    {
                        // Atribuir o valor à posição correspondente no vetor
                        results[g] = somaFonte[g];
                    }
                    // Resolver o sistema
                    var correntes = coefficients.Solve(results); // puxa o resultado .Solve

                    // Exibir a solução.
                    Console.WriteLine("   Valores das correntes (A): ");
                    for (int i = 0; i < nMalha; i++)
                    {
                        Console.WriteLine($"I{i + 1}: {correntes[i].ToString("F2")}");
                    }

                    double[] correntes2 = new double[(nMalha * 2 - 1) - nMalha];
                    int x = 0;

                    for (int i = 0; i < correntes2.Length; i++)
                    {
                        if (correntes[x] > correntes[x + 1])
                        {
                            correntes2[i] = correntes[x] - correntes[x + 1];
                        }
                        else
                        {
                            correntes2[i] = correntes[x + 1] - correntes[x];
                        }
                        x++;
                        Console.WriteLine("I" + (nMalha + 1 + i) + ": " + correntes2[i]);
                    }

                    float[] vR = new float[totalResistor];
                    float[] rDesejada = new float[totalResistor];
                    double[] totalvR = new double[totalResistor];
                    int corrente;

                    Console.WriteLine("\n   Você também deseja descobrir as tensões nas resistências? ");
                    Console.Write("      Se sim, digite 1. Caso contrário, digite 2: ");
                    bool resp3 = true;
                    do
                    {
                        int continua = int.Parse(Console.ReadLine());
                        if (continua == 1)
                        {
                            for (int i = 0; i < vR.Length; i++)
                            {
                                Console.Write("\n   Digite o valor do " + (i + 1) + "° resistor desejado: ");
                                rDesejada[i] = float.Parse(Console.ReadLine());
                                Console.Write("   Digite o número da corrente que passa por esse resistor: I");
                                corrente = int.Parse(Console.ReadLine());
                                if (corrente > nMalha)
                                {
                                    totalvR[i] = (rDesejada[i] * correntes2[corrente - nMalha - 1]);
                                }
                                else
                                {
                                    totalvR[i] = (rDesejada[i] * correntes[corrente - 1]);
                                }
                                Console.WriteLine("   O valor da tensão (v) neste resistor é igual a: " + totalvR[i]);
                                Console.WriteLine("---------------------------------------//---------------------------------------");
                            }

                            resp3 = false;
                        }
                        else if (continua == 2)
                        {
                            Console.WriteLine("\n   Ok!");
                            resp3 = false;
                        }
                        else
                        {
                            Console.WriteLine("   ERRO!!! Digite novamente: ");
                            resp3 = true;
                        }
                    } while (resp3);

                    Console.WriteLine("\n   Você deseja iniciar uma nova análise?");
                    Console.Write("      Se sim, digite 1. Caso contrário, digite 2: ");
                    int resp4 = int.Parse(Console.ReadLine());
                    if (resp4 == 1)
                    {
                        respPrincipal = true;
                    }
                    else
                    {
                        Console.WriteLine("   Obrigado! Volte sempre. ");
                        respPrincipal = false;
                    }
                } while (respPrincipal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();                              
        }
    }
}