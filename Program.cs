using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21BIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int ex;
            do
            {
                Console.WriteLine("Digite o número do exercício que você deseja verificar. Caso deseje sair do programa, digite 0.");
                ex = int.Parse(Console.ReadLine());

                switch (ex)
                {
                    case 1:
                        {
                            int n;

                            Console.WriteLine("Digite um número inteiro. ");
                            n = int.Parse(Console.ReadLine());

                            if (n < 0)
                                n = n * -1;

                            Console.WriteLine(n);
                        }
                        break;

                    case 2:
                        {
                            int n;

                            Console.WriteLine("Digite um número. ");
                            n = int.Parse(Console.ReadLine());

                            if (((n % 3) == 0) && ((n % 5) == 0))
                                Console.WriteLine("O número que você digitou é divisível por 3 e por 5. ");

                            else if (((n % 4) == 0) && ((n % 7) == 0))
                                Console.WriteLine("O número que você digitou é divisível por 4 e por 7. ");

                            else if ((n % 3) == 0)
                                Console.WriteLine("O número que você digitou é divisível apenas por 3. ");

                            else if ((n % 5) == 0)
                                Console.WriteLine("O número que você digitou é divisível apenas por 5. ");

                            else if ((n % 4) == 0)
                                Console.WriteLine("O número que você digitou é divisível apenas por 4. ");

                            else if ((n % 7) == 0)
                                Console.WriteLine("O número que você digitou é divisível apenas por 7. ");

                            else
                                Console.WriteLine("O número que você digitou não é divisível por 2, 5, 4 e nem por 7.");
                        }
                        break;

                    case 3:
                        {
                            int n1, n2, n3;
                            Console.WriteLine("Digite 3 números, respectivamenete. ");
                            n1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            n3 = int.Parse(Console.ReadLine());

                            if ((n1 > n2) && (n1 > n3))
                                Console.WriteLine("O maior número digitado foi " + n1);

                            else if ((n2 > n1) && (n2 > n3))
                                Console.WriteLine("O maior número digitado foi " + n2);

                            else if ((n3 > n1) && (n3 > n2))
                                Console.WriteLine("O maior número digitado foi " + n3);
                        }
                        break;

                    case 4:
                        {
                            int v;

                            Console.WriteLine("Para saber o que eu faço em cada dia da semana, digite o dia correspondente. (domingo = 1, segunda = 2...)");
                            v = int.Parse(Console.ReadLine());

                            switch (v)
                            {
                                case 1:
                                    Console.WriteLine("Gosto de jogar aos domingos.");
                                    break;

                                case 2:
                                    Console.WriteLine("Tenho Filosofia, Português e Matemática nas segundas.");
                                    break;

                                case 3:
                                    Console.WriteLine("Tenho Química, História e Inglês nas terças.");
                                    break;

                                case 4:
                                    Console.WriteLine("Tenho Biologia, Português e Programação nas quartas.");
                                    break;

                                case 5:
                                    Console.WriteLine("Tenho Física, Redes e Sociologia nas quintas.");
                                    break;

                                case 6:
                                    Console.WriteLine("Tenho Geografia, Matemática e Banco de Dados nas sextas.");
                                    break;

                                case 7:
                                    Console.WriteLine("Gosto de assistir filmes aos sábados.");
                                    break;

                                default:
                                    Console.WriteLine("Número inválido. ");
                                    break;
                            }
                        }
                        break;

                    case 5:
                        {
                            int nm, ne, v, z;

                            Console.WriteLine("Digite uma sequência de números. Caso tenha terminado a sequência, digite 0. ");
                            z = 0;

                            v = int.Parse(Console.ReadLine());
                            nm = v;
                            ne = v;
                            do
                            {
                                v = int.Parse(Console.ReadLine());
                                z = v;

                                if ((v > nm) && (v != 0))
                                    nm = v;

                                if ((v < ne) && (v != 0))
                                    ne = v;
                                
                            }
                            while (z != 0);
                            Console.WriteLine("O maior número digitado foi " + nm);
                            Console.WriteLine("O menor número digitado foi " + ne);
                        }
                        break;

                    case 6:
                        {
                            int n, v, d;

                            Console.WriteLine("Digite um número. ");
                            n = int.Parse(Console.ReadLine());
                            v = 0;
                            d = 0;

                            do
                            {
                                v = v + 1;

                                if (n % v == 0)
                                    d = d + v;
                            }
                            while (v != n);

                            d = d - n;

                            if (d == n)
                                Console.WriteLine("Seu número é perfeito.");

                            else
                                Console.WriteLine("Seu número não é perfeito.");

                        }
                        break;

                    case 7:
                        {
                            int n, m, v, z, s;

                            n = 0;
                            s = 0;
                            Console.WriteLine("Digite uma sequência de números. Caso tenha terminado, digite 0");

                            do
                            {
                                s = s + 1;
                                v = int.Parse(Console.ReadLine());
                                z = v;
                                if (v % 2 == 0)
                                    n = n + v;

                            }

                            while (z != 0);
                            s = s - 1;
                            m = n / s;

                            if (m == 0)
                                Console.WriteLine("Não foi possível calcular a média por falta de números pares.");

                            Console.WriteLine("A média entre os números digitados é igual a " + m);


                        }
                        break;




                }
            } while (ex != 0);
            Console.ReadKey();
        }
    }
}
