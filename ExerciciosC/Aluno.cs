using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosC
{
    class Aluno
    {
        public double nota1,
                        nota2,
                        nota3,
                        notaExame,
                        media1,
                        mediaExame;

        public Aluno(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public double CalcularMedia(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        public double CalcularMediaExame(double media1, double nExame)
        {
            return (media1 + nExame) / 2;
        }

        public void VerAprovacao()
        {
            this.media1 = CalcularMedia(this.nota1, this.nota2, this.nota3);
            if (this.media1 >= 7)
            {
                Console.WriteLine("PARABÉNS ao aluno que foi APROVADO com média = {0}", Math.Round(this.media1, 2));
            }
            else
            {
                Console.WriteLine("Com media = {0} é necessário informar a nota do exame do aluno: ", Math.Round(media1, 2));
                this.notaExame = Convert.ToDouble(Console.ReadLine());
                mediaExame = CalcularMediaExame(this.media1, this.notaExame);

                switch (mediaExame)
                {
                    case >= 5:
                        Console.WriteLine("Após tanto empenho o aluno foi APROVADO em exame com média = {0}", Math.Round(mediaExame, 2));
                        break;
                    default:
                        Console.WriteLine("Infelizmente o aluno foi REPROVADO com média = {0}", Math.Round(mediaExame, 2));
                        break;
                }
            }

        }
    }
}
