using System;

namespace ExerciciosC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acesso aos métodos
            Program program = new Program();
            int exercicio;
            bool refazer = false;
            string resposta;

            //constante
            const double Pi = 3.14;

            Console.WriteLine("---Exercícios C#---\n");

            do
            {
                Console.Write("Escolha o exercício \n" +
                "1- IMC \n" +
                "2- Salário mínimo \n" +
                "3- Volume esfera \n" +
                "4- Média aluno\n" +
                "5- Animais\n");

                Console.Write("Exercício: ");
                //captura string e converte para inteiro
                exercicio = Convert.ToInt32(Console.ReadLine());

                switch (exercicio)
                {
                    case 1:
                        Console.WriteLine("EXERCÍCIO 01");
                        program.Exercicio01();
                        break;
                    case 2:
                        /*
                         * Criar um programa que receba o valor do salário de um funcionário e o valor do salário mínimo 
                          e apresente na <TELA> quantos salários mínimos ganha esse funcionário.
                         */
                        Console.WriteLine("\nEXERCÍCIO 02");
                        Console.WriteLine("***CÁLCULO SALÁRIO MÍNIMO***\n");
                        double salarioFuncionario,
                                salarioMinimo;
                        int inteiroSalariosMinimos;

                        Console.WriteLine("Informe o valor do salário do funcionário: ");
                        //captura string e converte para double
                        salarioFuncionario = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor do salário mínimo atual: ");
                        salarioMinimo = Convert.ToDouble(Console.ReadLine());

                        //chamada do meétodo
                        inteiroSalariosMinimos = Convert.ToInt32(program.CalcularSalariosMinimos(salarioFuncionario, salarioMinimo));

                        Console.WriteLine("O funcionário recebe por volta de {0} salários mínimos", inteiroSalariosMinimos);
                        break;
                    case 3:
                        Console.WriteLine("\nEXERCÍCIO 03");
                        program.Exercicio03(Pi);
                        break;
                    case 4:
                        Console.WriteLine("\nEXERCÍCIO 04");
                        program.Exercicio04();
                        break;
                    case 5:
                        program.Exercicio05();
                        break;
                    default:
                        Console.WriteLine("X Número do exercício é inválido X");
                        break;
                }

                Console.WriteLine("\nDeseja sair? (S/N)");
                resposta = Console.ReadLine().Trim().ToLower();
                if (resposta.Contains("s"))
                {
                    refazer = false;
                }
                else if (resposta.Contains("n"))
                {
                    refazer = true;
                    Console.Clear();
                }
                else
                    Console.WriteLine("Resposta não é válida!!!");

            } while (refazer);
        }

        /*
        Criar um programa que leia o peso e a altura de uma pessoa, calcule o seu IMC
        e apresente na <TELA> uma mensagem informando se a pessoa está ou não no seu peso ideal. 
        A fórmula para calcular o IMC é: IMC = peso / altura²
        */
        public void Exercicio01()
        {
            Console.WriteLine("***CÁLCULO IMC***\n");

            double peso,
                    altura,
                    imc; ;

            Console.Write("Digite o peso (ex: 70,00KG): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura (ex: 1,70m): ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 20)
            {

                Console.WriteLine("***Abaixo do peso!***");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("***Peso ideal!***");
            }
            else
                //não satisfaz nenhuma das anteriores
                Console.WriteLine("***Acima do peso***");
        }

        public double CalcularSalariosMinimos(double salarioFuncionario, double salarioMinimo)
        {
            return salarioFuncionario / salarioMinimo;
        }

        /*
         *Criar um programa que calcule e 
         *apresente na <TELA> o volume de uma esfera de raio R, em que R é um dado fornecido pelo usuário
         */
        public void Exercicio03(double pi)
        {
            Console.WriteLine("***CÁLCULO VOLUME DA ESFERA***\n");
            double raioEsfera,
                    volumeEsfera;

            Console.Write("Qual o raio da esfera em cm? ");
            raioEsfera = Convert.ToDouble(Console.ReadLine());

            volumeEsfera = (4 * pi * Math.Pow(raioEsfera, 3)) / 3;

            Console.WriteLine("O volume da esfera de raio {0} é {1} cm3", raioEsfera, Math.Round(volumeEsfera, 2));
        }

        /*
        Criar um programa que leia o valor de três notas escolares de um aluno. 
        Calcular a média aritmética e apresentar na <TELA> a mensagem “Aprovado” se a média obtida for maior ou igual a 7; caso contrário, 
        o programa deve <TELA> solicitar a nota de exame do aluno e 
        calcular uma nova média aritmética entre a nota do exame e a primeira média aritmética. 
        Se o valor da nova média for maior ou igual a 5, <TELA> apresentar na tela a mensagem “Aprovado em exame”; 
        caso contrário, <TELA> apresentar a mensagem “Reprovado”. 
        OBS: Informar junto com cada mensagem o valor da média obtida.
         */
        public void Exercicio04()
        {
            Console.WriteLine("***CÁLCULO MEDIA***");

            double n1,
                    n2,
                    n3;

            Console.Write("Informe a primeira nota do aluno: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a segunda nota do aluno: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a terceira nota do aluno: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            //instancia e atribui atributos
            Aluno aluno = new Aluno(n1, n2, n3);
            aluno.VerAprovacao();
        }
        /*
         Crie um algoritmo/programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
        O programa deverá exibir na TELA> para o usuário quantos cachorros, gatos e peixes foram informados.
        Regras que deverão ser seguidas para a implementação do algoritmo:
        Os únicos tipos de animais válidos são cachorro, gato e peixe.
        Caso seja informado um tipo diferente, o programa deverá definir o tipo do animal como peixe.
        É obrigatório criar uma classe para representar o animal.
        A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
        A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
         */
        public void Exercicio05()
        {
            Console.WriteLine("***Animais***");

            string[] n = new string[5];
            string[] t = new string[5];
            Animal[] animal = new Animal[5];

            int contadorCachorro = 0,
                contadorGato = 0,
                contadorPeixe = 0;

            Console.WriteLine("VOCÊ DEVE INFORMAR O NOME E TIPO(cachorro, gato ou peixe) DE 5 ANIMAIS");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Animal {0}: ", (i + 1));
                Console.Write("Nome:");
                //retirar espaços
                n[i] = Console.ReadLine().Trim();
                Console.Write("Tipo:");
                //retirar espaços e deixar letra minúscula
                t[i] = Console.ReadLine().Trim().ToLower();

                animal[i] = new Animal(n[i], t[i]);

                //fazer a contagem para cada tipo de animal.
                if (animal[i].GetTipo().Contains("cachorro"))
                {
                    contadorCachorro += 1;
                }
                else if (animal[i].GetTipo().Contains("gato"))
                {
                    contadorGato += 1;
                }
                else
                {
                    contadorPeixe += 1;
                }
            }

            Console.WriteLine("Cachorros = {0} \n" +
                "Gatos = {1} \n" +
                "Peixes = {2}",
                contadorCachorro, contadorGato, contadorPeixe);

        }
    }
}
