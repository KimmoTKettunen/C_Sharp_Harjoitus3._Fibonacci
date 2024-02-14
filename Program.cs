namespace fibochatgpt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Function: To display the n Number Fibonacci series :");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Input number of Fibonacci series: ");
            int n = Convert.ToInt16(Console.ReadLine());  // n == käyttäjän syöttämä numero
            Console.WriteLine($"The Fibonacci series of {n} numbers is");


            FibonacciSequence(n);  // suorittaa alemman osion 
        }

        static void FibonacciSequence(int n)
        {
            int aloitus = 0, toinen = 1, summa;

            if (n == 0)         // n == käyttäjän syöttämä numero
            {
                Console.Write("0");    // Fibonacci aloitus F0 ja F1 ei tarvitse laskea, koska ne ovat oletuksena 0 ja 1 joten pelkkä Write / string riittää.
            }
            else if (n == 1)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write(aloitus + " " + toinen + " ");   // Laittaa Fibonaccin ensimmäiset 2 numeroa, eli 0 ja 1, koska F0 = 0, F1 = 1, 
                                                               // Jos n > 1 niin silloin kaava on F(n) = F(n-1) + F(n-2)  

                for (int i = 2; i < n; i++) // Aloitetaan suoraan i=2, koska on jo F1 ja F2 arvot,
                                            // i on functio kuinka monta kertaa toisto tehdään, ja sitä verrataan n eli arvoon, joka laitetaan ohjelman alussa.
                                            // koodi suoritetaan niin kauan, kunnes i => n, ja joka toistolla, i arvoon lisätään 1

                {
                    summa = aloitus + toinen;  // karkea Fibonacci. Summa = 
                    Console.Write(summa + " "); // Joka toistolla ohjelma tulostaa nykyisen Fibonaccin numeron arvon ja tyhjän ruudun.

                    aloitus = toinen;         //Fibonacci alkaa F=0, F1=1
                    toinen = summa;           // kaavio Fn = F(n-1) + F(n-2) jos n>1
                                              // F(2) = F(2-1)[F1=1] + F(2-2)[F0=0] = F2(1)   
                                              // F(3) = F(3-1)[F2=1] + F(3-2)[F1=1] = F3(2)
                                              // F(4) = F(4-1)[F3=2] + F(4-2)[F2=1] = F4(3)
                                              // F(5) = F(5-1)[F4=3] + F(5-2)[F3=2] = F5(5) [F4 + F3 = 5]
                                              // F(6) = F(6-1)[F5=5] + F(6-2)[F4=3] = F6(8) [F5 + F4 = 8]
                                              // Sarjassa siis otetaan aina 2 edellistä lukua, ja lasketaan niiden summa. 
                                              // siirrytään yksi eteenpäin ja lasketaan taas kahden edellisen luvun summa jne.
                }
                Console.ReadLine();

            }

        }
    }
}
