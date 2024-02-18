namespace Lab2CSharp
{
    internal class Program
    {
       static private int s = 0;


        static public int Task1() {
            double[] A;
            double[,] B;
            string str;

            int m0, m, n;
            Console.WriteLine(" First part: \n\n");

            Console.WriteLine(" A array length: ");
            do
            {
                str = Console.ReadLine();
            } while (!int.TryParse(str, out m0));
            A = new double[m0];
            Console.WriteLine($"array elements {m0}:(1 per row) ");
            int a = 0;
            foreach (int i in A)
            {
                A[a] = double.Parse(Console.ReadLine());
                a++;
            }
            Console.WriteLine($"result is {A.Average()}");

            Console.WriteLine(" Secong part: \n\n");
            Console.WriteLine("B array length: ");
            do
            {
                Console.Write("N: ");            
            } while (!int.TryParse(Console.ReadLine(), out n));
            {
                Console.Write("M: ");         
            } while (!int.TryParse(Console.ReadLine(), out m));
            B = new double[n,m];
            Console.WriteLine($"array elements {n + " " + m } :(1 per row) ");
            double res = 0;
            for (int i=0; i<n; i++ )
            {  for (int j = 0; j < m; j++)
                {
                    do
                    {    
                        Console.Write($"Element {i + " " + j}  \t");
                    } while (!double.TryParse(Console.ReadLine(), out B[i,j] ));
                    res+= B[i,j];
                }
                
                Console.Write("\n");
            }
            Console.WriteLine($"result is  {res/(m*n)}");
            return 1;
        }
        static public int Task2()
        {
            double[] A;
            string str;


            int m0;
            Console.WriteLine(" A array length: ");
            do
            {
                str = Console.ReadLine();
            } while (!int.TryParse(str, out m0));
            A = new double[m0];
            Console.WriteLine($"array elements {m0}:(1 per row) ");
            int a = 0;
            foreach (int i in A)
            {
                do
                {
                   
                } while (!double.TryParse(Console.ReadLine(), out A[a]));              
                a++;
            }
            double a1 = A.Max();
            Console.WriteLine($"Max element is {a1} and result is: ");
            foreach (double i in A)
            {   if (i < a1)
                    Console.Write(i + "\t");
            }
            Console.WriteLine("\nend of task");
            return 0;
        }
        static public int Task3()
        {
            double[,] A;
            int n, m;
            double mead;
            Console.WriteLine("B array length: ");
            do
            {
                Console.Write("NxN: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
           /* do
            {
                Console.Write("M: ");
            } while (!int.TryParse(Console.ReadLine(), out m)) ;*/
            A = new double[n, n];
            Console.WriteLine($"array elements {n + " " + n} :(1 per row) ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    do
                    {
                        Console.Write($"Element {i + " " + j}  \t");
                    } while (!double.TryParse(Console.ReadLine(), out A[i, j]));
                  
                }

                Console.Write("\n");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{A[i,j]} \t");
                   
                }

                Console.Write("\n");
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (int)n/2; j++)
                {
                    
                    mead = A[i,n-j-1];
                    A[i,n-j-1] = A[i,j];
                    A[i, j] = mead;
                   

                }

                Console.Write("\n");
            }
            Console.WriteLine ("Swapd");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{A[i, j]} \t");

                }

                Console.Write("\n");
            }
            return 0;
        }
        static public int Task4()
        {
            int n, m;
            double Numb;
            Console.WriteLine("Array length: ");
            do
            {
                Console.Write("N:  ");
            } while (!int.TryParse(Console.ReadLine(), out n));
            double[][] jaggedArray = new double[n][];
            //declaration
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"M{i}:  ");
                } while (!int.TryParse(Console.ReadLine(), out m));
                jaggedArray[i] = new double[m];
            }
            //initialization
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    do
                    {
                        Console.Write($"Element {i + " " + j}  \t");
                    } while (!double.TryParse(Console.ReadLine(), out jaggedArray[i][j]));

                }

                Console.Write("\n");
            }
            do
            {
                Console.Write("input your control number:  ");
            } while (!double.TryParse(Console.ReadLine(), out Numb));
            int[] Control= new int [n];
            int count;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j]>Numb)count++;

                }
                Control[i] = count;
                
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int i in Control)
            {
                Console.WriteLine(i);
            }
            return 0;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");

            
            void taskSelect()
            {
                int variant = 5;
                while (variant < 6)
                {
                    Console.WriteLine("Task #?!  (type '0' to STOP)");
                    Console.Write(" N# = ");

                    string? str;
                    bool b0 = false;
                    do
                    {
                        Console.Write(" (1_4) ");
                        str = Console.ReadLine();
                        if (int.TryParse(str, out s)) b0 = true;
                    } while ((str == null) || !b0);

                    switch (s)
                    {
                        case 0:
                            variant = 7;
                            break;
                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        case 3:
                            Task3();
                            break;
                        case 4:
                            Task4();
                            break;
                        default:
                            Console.WriteLine("!!!wrong(1_4)answer!!!");
                            break;
                    }
                    Console.ReadLine();
                }

            }
            Console.WriteLine("Lab 2 !");
            taskSelect();



        }
    }
}
