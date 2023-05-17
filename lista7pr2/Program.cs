using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista7pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 1, i;
            while (j != 0)
            {
                
                int MENU;

                Console.WriteLine("=======MENU=======");
                Console.WriteLine("Exercicio-1");
                Console.WriteLine("Exercicio-2");
                Console.WriteLine("Exercicio-3");
                Console.WriteLine("Exercicio-4");
                Console.WriteLine("Exercicio-5");
                Console.WriteLine("Exercicio-6");
                Console.WriteLine("Exercicio-7");
               
                MENU = int.Parse(Console.ReadLine());

                switch (MENU)
                {


                    case 1:
                        
                        int QUANTI, SAIDA = 4;
                        double PRECO, VALOR1, VALOR2 = 0;

                        i = 0;
                        while (true)
                        {
                            Console.WriteLine("digite a quantidade de produtos");
                            QUANTI = int.Parse(Console.ReadLine());
                            if (QUANTI == 0)
                            {
                                break;
                            }
                            Console.WriteLine("digite o preco do produto");
                            PRECO = double.Parse(Console.ReadLine());

                            Console.WriteLine("digite 0 para SAIR e 3 para continuar");
                            SAIDA = int.Parse(Console.ReadLine());

                            VALOR1 = QUANTI * PRECO;
                            VALOR2 = VALOR1 + VALOR2;
                            i++;
                        }

                        Console.WriteLine("sua compra custou {0} reais ", VALOR2);
                        break;

                    case 2:

                        string nome, nomeMenor = "", nomeMaior = "";
                        int numItens, parada = 2;
                        float valor, maiorValor, menorValor;

                        maiorValor = float.MinValue;
                        menorValor = float.MaxValue;

                        while (parada != 1)
                        {
                            Console.WriteLine("Qual o nome do pruduto");
                            nome = Console.ReadLine();

                            Console.WriteLine("Qual a quantidade de produtos");
                            numItens = int.Parse(Console.ReadLine());

                            Console.WriteLine("Qual o preço do produto");
                            valor = float.Parse(Console.ReadLine());

                            float total = numItens * valor;
                            if (total > maiorValor)
                            {
                                maiorValor = total;
                                nomeMaior = nome;
                            }

                            if (total < menorValor)
                            {
                                menorValor = total;
                                nomeMenor = nome;
                            }
                            Console.WriteLine("Digite 1 para SAIR ou 2 para continuar");
                            parada = int.Parse(Console.ReadLine());



                        }
               
                    break; 
                    
                    case 3:
                       
                        
                        Console.Write("Digite o número de avaliações planejadas: ");
                       
                        int numAvaliacoes = int.Parse(Console.ReadLine());
                        int I = 1;
                        double somaPesos = 0;
                        while (true)
                            for (I = 1; I <= numAvaliacoes; I++) ;
                        {
                            Console.Write($"Digite o peso da avaliação {i}: ");
                            double Peso = double.Parse(Console.ReadLine());
                            somaPesos += Peso;
                        }

                        if (somaPesos < 100)
                        {
                            Console.WriteLine("A soma dos pesos é insuficiente R$", somaPesos, ".");
                        }
                        else if (somaPesos > 100)
                        {
                            Console.WriteLine("A soma dos pesos é excedente R$", somaPesos, ".");
                        }
                        else
                        {
                            Console.WriteLine("A soma dos pesos é adequada R$", somaPesos, ".");
                        }
                        break;

                    case 4:

                        string estado;

                        Console.WriteLine("digite a sigla do estado");
                        estado = Console.ReadLine();

                        switch (estado)
                        {
                            case "AC":
                                Console.WriteLine("o estado correspondente é: Acre");
                                break;
                            case "AL":
                                Console.WriteLine("o estado correspondente é: Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("o estado correspondente é: Amapá");
                                break;
                            case "AM":
                                Console.WriteLine("o estado correspondente é: Amazonas");
                                break;
                            case "BA":
                                Console.WriteLine("o estado correspondente é: Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("o estado correspondente é: Ceará");
                                break;
                            case "DF":
                                Console.WriteLine("Distrito Federal não é um estado, mas sim uma uniudade autônoma");
                                break;
                            case "ES":
                                Console.WriteLine("o estado correspondente é: Espírito Santo");
                                break;
                            case "GO":
                                Console.WriteLine("o estado correspondente é: Goiás");
                                break;
                            case "MA":
                                Console.WriteLine("o estado correspondente é: Maranhão");
                                break;
                            case "MT":
                                Console.WriteLine("o estado correspondente é: Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("o estado correspondente é: Mato Grosso do Sul");
                                break;
                            case "MG":
                                Console.WriteLine("o estado correspondente é: Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("o estado correspondente é: Pará");
                                break;
                            case "PB":
                                Console.WriteLine("o estado correspondente é: Paraíba");
                                break;
                            case "PR":
                                Console.WriteLine("o estado correspondente é: Paraná");
                                break;
                            case "PE":
                                Console.WriteLine("o estado correspondente é: Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("o estado correspondente é: Piauí");
                                break;
                            case "RJ":
                                Console.WriteLine("o estado correspondente é: Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("o estado correspondente é: Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("o estado correspondente é: Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("o estado correspondente é: Rondônia");
                                break;
                            case "RR":
                                Console.WriteLine("o estado correspondente é: Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("o estado correspondente é: Santa Catarina");
                                break;
                            case "SP":
                                Console.WriteLine("o estado correspondente é: São Paulo");
                                break;
                            case "SE":
                                Console.WriteLine("o estado correspondente é: Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("o estado correspondente é: Tocantins");
                                break;

                            default:
                                Console.WriteLine("nao existe estado com essa sigla");
                                break;
                        }
                        break;

                    case 5:

                        int mes, dia;

                        Console.WriteLine("Digite o número relacionado ao mês: ");
                        mes = int.Parse(Console.ReadLine());

                        switch (mes)
                        {
                            case 1:
                                Console.WriteLine("Verão");
                                break;
                            case 2:
                                Console.WriteLine("Verão");
                                break;
                            case 3:
                                Console.WriteLine("Digite o dia: ");
                                dia = int.Parse(Console.ReadLine());
                                if (dia < 20)
                                    Console.WriteLine("Verão");
                                else
                                    Console.WriteLine("Outono");
                                break;
                            case 4:
                                Console.WriteLine("Outono");
                                break;
                            case 5:
                                Console.WriteLine("Outono");
                                break;
                            case 6:
                                Console.WriteLine("Digite o dia: ");
                                dia = int.Parse(Console.ReadLine());
                                if (dia < 21)
                                    Console.WriteLine("Outono");
                                else
                                    Console.WriteLine("Inverno");
                                break;
                            case 7:
                                Console.WriteLine("Inverno");
                                break;
                            case 8:
                                Console.WriteLine("Inverno");
                                break;
                            case 9:
                                Console.WriteLine("Digite o dia: ");
                                dia = int.Parse(Console.ReadLine());
                                if (dia < 23)
                                    Console.WriteLine("Inverno");
                                else
                                    Console.WriteLine("Primavera");
                                break;
                            case 10:
                                Console.WriteLine("Primavera");
                                break;
                            case 11:
                                Console.WriteLine("Primavera");
                                break;
                            case 12:
                                Console.WriteLine("digite o dia: ");
                                dia = int.Parse(Console.ReadLine());
                                if (dia < 21)
                                    Console.WriteLine("Primavera");
                                else
                                    Console.WriteLine("Verão");
                                break;
                        }
                        Console.ReadKey();
                        break;

                    case 6:


                }
            }  

        }


    }


}
