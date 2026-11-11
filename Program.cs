// // CLASS TASK 1

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Bools(a,b));
// bool Bools(int a,int b)
// {
//     if (a % b==0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// // CLASS TASK 2

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Bools(a));
// string Bools(int a)
// {
//     if (a %2==0)
//     {
//         return "Even";
//     }
//     else{
//         return "odd";
//     }
// }

// // CLASS TASK 3

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(cnts(a,b));

// int cnts(int a, int b)
// {
//     int cnt = 0;
//     int min = Math.Min(a, b);
//     int max = Math.Max(a, b);
//     for (int i = min + 1; i < max; i++)
//     {
//          cnt++;
//     }
//     return cnt;

// }


// // CLASS TASK 4

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(intsSum(a));
// int intsSum(int a)
// {
//     int sum = 0;
//     for(int i=1; i<=a; i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }

// // CLASS TASK 5

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(LongsSum(a));
// long LongsSum(int n)
// {
//     if (n <= 1) 
//         return 1;
//     return n * LongsSum(n - 1);
// }

// // CLASS TASK 6

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Palindrov(a));

// int Palindrov(int a)
// {
//     int pal = 0;
//     for(int i=a; i>0; i /= 10)
//     {
//         pal = pal*10;
//         pal+=i%10;
//     }
//     return pal;
// }

// // CLASS TASK 7

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountDigits(a));

// int CountDigits(int a)
// {
//     int cnt = 0;
//     for (int i = a; i != 0; i /= 10)
//     {
//         cnt++;
//     }

//     if (cnt == 0) return 1;
//     return cnt;
// }

// // CLASS TASK 8
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumEvenDigits(a));

// int SumEvenDigits(int a)
// {
//     int sum = 0;
//     for (int i = a; i != 0; i /= 10)
//     {
//         if ((i % 10) % 2 == 0)
//         {
//             sum += i % 10;
//         }
//         else
//         {
//             return 0;
//         }
//     }

//     return sum;
// }

// // CLASS TASK 9

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(MaxDidit(a));
// int MaxDidit (int a)
// {
//     int maxx = int.MinValue;
//     for(int i=a; i>0; i /= 10)
//     {
//         int di = i%10;
//         if(maxx < di)
//         {
//             maxx = di;
//         }
//     }
//    return maxx;
// }

// // CLASS TASK 10

    // int void PrintNumbers(int n)
    // {
    //     if (n < 1)
    //     {
    //         return;
    //     }

    //     Console.Write(n + " ");

    //     PrintNumbers(n - 1);
    // }




// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsPri(a));
// bool IsPri(int a)
// {
//     if(a < 2)
//     {
//         return false;
//     }
//     for(int i = 2; i*i<=a; i++)
//     {
//         if (a % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

// // HOME TASK 1

// int a = Convert.ToInt32(Console.ReadLine());

// Rekurs(a);

// void Rekurs(int a)
// {
//     if(a <= 0 ){return;}
//     Rekurs(a-1);
//     Console.Write(a+" ");
// }

// // HOME TASK 2

// int a = Convert.ToInt32(Console.ReadLine());
// Rekurs(a);
// void Rekurs(int a)
// {
//     if (a <= 0)
//     {
//         return;
//     }
//     Console.Write(a+" ");
//     Rekurs(a-1);
// }

// // HOME TASK 3

// int a =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(a));
// int Sum(int a)
// {
//     if (a <= 1)
//     {
//         return 1;
//     }
//     return a + Sum(a-1);
// }

// // HOME TASK 4

// int a =Convert.ToInt32(Console.ReadLine())
// Digit(a);

// void Digit(int a)
// {
//     if(a<=0){return;}
//     Digit(a/10);
//     Console.Write((a%10)+" ");
// }

// // HOME TASл 5

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Digit(a));

// int Digit(int a)
// {
//     if(a<=0){return 0;}

//     return 1 + Digit(a / 10);
   
// }

// // HOME TASK 6

// string[] parts = Console.ReadLine().Split(' ');
// int a = Convert.ToInt32(parts[0]);
// int b = Convert.ToInt32(parts[1]);

// Console.WriteLine($"All even numbers from {a} to {b} are :");
// Print(a,b);

// Console.WriteLine();

// Console.WriteLine($"All odd numbers from {a} to {b} are :");
// PrintOd(a,b);
// void Print(int a, int b)
// {
//     if (a > b) return; 
//     if (a % 2 == 0)
//     {
//         Console.Write(a + " ");
//     }

//     Print(a + 1, b);
// }

// void PrintOd(int a, int b)
// {
//     if (a > b) return;
//     if (a % 2 != 0)
//     {
//         Console.Write(a + " ");
//     }

//     PrintOd(a + 1, b);
// }