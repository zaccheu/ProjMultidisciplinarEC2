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
            Console.Write("----------------------------------------ANÁLISE-DE-CIRCUITOS----------------------------------------\n");
            Console.Write("Quantas malhas têm o circuito? \n");
            int nMalha = int.Parse(Console.ReadLine());
            float[,] matrizConta = new float[nMalha, nMalha]; //matriz diretamente responsável pela conta das correntes. (matrizConta[i] * matrizSistema[i] = matrizResultado(=somaFonte))
            float[] somaResistor = new float[nMalha]; //soma o valor de todos os resistores na malha
            float[] somaResistorCompartilhadoPro = new float[nMalha]; //soma o valor de todos os resistores compartilhados com a próxima malha
            float[] somaResistorCompartilhadoAnt = new float[nMalha]; //soma o valor de todos os resistores compartilhados com a malha anterior
            float[] somaFonte = new float[nMalha];  //soma o valor de todas as fontes na malha
            //todos esses vetores acima, armazenam o valor específico de cada malha (somaResistor[0] e somaFonte[0], por exemplo, armazenam os dados apenas da malha 1)

            for (int i = 0; i < nMalha; i++) //percorre malha por malha
            {
                string resp1, resp2;
                Console.Write("----------------------------------------MALHA-" + (i + 1) + "----------------------------------------\n");
                Console.Write("A malha " + (i + 1) + " possui alguma fonte (s/n)? ");
                resp1 = Console.ReadLine().ToLower(); //lê a resposta do usuário, para saber se a malha possui alguma fonte ou não

                if (resp1 == "s") //se a resposta for "s" (sim), o programa continua dentro do if. Caso contrário o programa passa para a próxima etapa
                {
                    Console.Write("   Há quantas fontes nessa malha? ");
                    int nFonte = int.Parse(Console.ReadLine());
                    float[] valorFonte = new float[nFonte]; //vetor necessário para a soma das fontes pertencentes a matriz
                    somaFonte[i] = 0;
                    for (int j = 0; j < nFonte; j++) //percorre os valores das fontes
                    {
                        Console.Write("   Informe o valor da " + (j + 1) + "° fonte: ");
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
                        somaFonte[i] += valorFonte[j]; //soma o valor de todas as fontes para usar na matriz
                    }
                    Console.WriteLine("Soma das fontes: " + somaFonte[i]); //apenas para informar o cálculo
                }

                Console.Write("\nA malha " + (i + 1) + " possui algum resistor (s/n)? ");
                resp2 = Console.ReadLine().ToLower(); //To.Lower = pode ser usado letras maiúsculas e minúsculas
                somaResistor[i] = 0; somaResistorCompartilhadoPro[i] = 0; somaResistorCompartilhadoAnt[i] = 0; //vetores com valor inicial 0, para poder efetuar a soma pedida
                if (resp2 == "s")
                {
                    Console.Write("   Há quantos resistores nessa malha? ");
                    int nResistor = int.Parse(Console.ReadLine());
                    float[] valorResistor = new float[nResistor]; //vetor necessário para a soma dos resistores pertencentes a matriz
                    int nResistorCompartilhadoF, nResistorCompartilhadoL, nResistorCompartilhadoM1, nResistorCompartilhadoM2; //L=last; F=first; M1=mid1; M=mid2
                    for (int k = 0; k < nResistor; k++)
                    {
                        Console.Write("   Informe o valor do " + (k + 1) + "° resistor: ");

                        valorResistor[k] = float.Parse(Console.ReadLine());
                        somaResistor[i] += valorResistor[k]; //armazena a soma dos valores de todos os resistores da matriz em questão

                    }
                    if (i == 0) //primeira malha
                    {
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i + 2) + "? ");
                        nResistorCompartilhadoF = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoF = new float[nResistorCompartilhadoF];
                        for (int l = 0; l < nResistorCompartilhadoF; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado: ");

                            valorResistorCompartilhadoF[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhadoPro[i] -= valorResistorCompartilhadoF[l]; //armazena a soma dos valores de todos os resistores compartilhados da matriz em questão com a matriz ao lado
                        }
                    }
                    else if (i == (nMalha - 1)) //última malha
                    {
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i) + "? ");
                        nResistorCompartilhadoL = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoL = new float[nResistorCompartilhadoL];
                        for (int l = 0; l < nResistorCompartilhadoL; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado: ");

                            valorResistorCompartilhadoL[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhadoAnt[i] -= valorResistorCompartilhadoL[l];
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
                            somaResistorCompartilhadoPro[i] -= valorResistorCompartilhadoM1[l];
                        }
                        Console.Write("   Quantos desses resistores são compartilhados com a malha " + (i) + "? ");
                        nResistorCompartilhadoM2 = int.Parse(Console.ReadLine());
                        float[] valorResistorCompartilhadoM2 = new float[nResistorCompartilhadoM2];
                        for (int l = 0; l < nResistorCompartilhadoM2; l++)
                        {
                            Console.Write("   Informe o valor do " + (l + 1) + "° resistor compartilhado com a malha " + (i) + ": ");

                            valorResistorCompartilhadoM2[l] = float.Parse(Console.ReadLine());
                            somaResistorCompartilhadoAnt[i] -= valorResistorCompartilhadoM2[l];
                        }
                    }
                }
                Console.WriteLine("Soma dos resistores: " + somaResistor[i]); //apenas para informar o cálculo
                Console.WriteLine("Soma dos resistores compartilhados(negativo) com a próxima malha: " + somaResistorCompartilhadoPro[i]); //apenas para informar o cálculo
                Console.WriteLine("Soma dos resistores compartilhados(negativo) com a malha anterior: " + somaResistorCompartilhadoAnt[i]);
                Console.WriteLine("---------------------------------------------------------------------------------------\n");

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

            int[] nCorrente = new int[(nMalha * 2) - 1];
            float[,] matrizResultado = new float[nMalha, 1];

            /*for (int i = 0; i < nMalha; i++) //preenchendo as correntes
            {
                nCorrente[i] = nCorrente[i];
            }
            for (int i = 0; i < nMalha; i++) //criação da matrizSistema
            {
                matrizSistema[i, 0] = nCorrente[i];
            }
            for (int i = 0; i < nMalha; i++) //criação da matrizResultado
            {
                matrizResultado[i, 0] = somaFonte[i];
            }

            for (int i = 0; i < nMalha; i++) //encontrando os números da matrizSistema
            {
                for (int j = 0; j < nMalha; j++)
                {
                    matrizResultado[i, 0] = matrizConta[i, j] * matrizSistema[i, 0];
                }
            }*/

            //----------------------------------------------------------------------
            //Necessário para percorrer os vetores e a matriz para mostrar os dados.
            Console.WriteLine("\nSoma resistores: ");
            for (int i = 0; i < nMalha; i++)
            {
                Console.Write(somaResistor[i] + ";");
            }
            Console.WriteLine("\nSoma resistores compartilhados com a próxima malha: ");
            for (int i = 0; i < nMalha; i++)
            {
                Console.Write(somaResistorCompartilhadoPro[i] + ";");
            }
            Console.WriteLine("\nSoma resistores compartilhados com a malha anterior: ");
            for (int i = 0; i < nMalha; i++)
            {
                Console.Write(somaResistorCompartilhadoAnt[i] + ";");
            }

            Console.Write("\nMatriz conta: \n");
            for (int m = 0; m < nMalha; m++)
            {
                for (int n = 0; n < nMalha; n++)
                {
                    Console.Write(matrizConta[m, n] + "   ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();


            /*TESTANDO O BAGULHO PRA ACHAR A EQUAÇÃO E RESOLVER*/

            // Coeficientes da matriz           
            Matrix<double> coefficients = Matrix<double>.Build.Dense (nMalha, nMalha); //matriz preenchida à mão
            for (int h = 0; h < nMalha; h++)
            {
                for (int z = 0; z <nMalha; z++)
                {
                    coefficients[h, z] = matrizConta[h, z];
                }
            }       
            // Coluna das fontes
            
            Vector<double> results = Vector<double>.Build.Dense(nMalha); //Parte da direita do sistema (resultados)

            for (int g = 0; g < nMalha; g++)
            {
                // Atribuir o valor à posição correspondente no vetor
                results[g] = somaFonte[g];
            }
            // Resolver o sistema
            var solution = coefficients.Solve(results); // puxa o resultado .Solve

            // Exibir a solução
            Console.WriteLine("Solução:");
            Console.WriteLine($"I1 = {solution[0]}");
            Console.WriteLine($"I2 = {solution[1]}");
            Console.WriteLine($"I3 = {solution[2]}");

            Console.ReadKey();                              
        }
    }
}