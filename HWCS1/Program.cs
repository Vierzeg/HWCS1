using System;

namespace HWCS1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Integer 24");
             Console.ResetColor();
             int K;
             K = int.Parse(Console.ReadLine());
             K%= 7; // K= K%7;
             switch (K)
             {
                 case 0:
                     Console.WriteLine("Воскресенье");
                     break;
                 case 1:
                     Console.WriteLine("Понедельник");
                     break;
                 case 2:
                     Console.WriteLine("Вторник");
                     break;
                 case 3:
                     Console.WriteLine("Среда");
                     break;
                 case 4:
                     Console.WriteLine("Четверг");
                     break;
                 case 5:
                     Console.WriteLine("Пятница");
                     break;
                 case 6:
                     Console.WriteLine("Суббота");
                     break;
             }
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Integer 29");
             Console.ResetColor();
             Console.WriteLine();
             int A, B, C;
             A = int.Parse(Console.ReadLine());
             B = int.Parse(Console.ReadLine());
             C = int.Parse(Console.ReadLine());

             int S1 = A * B;
             int S2 = C * C;
             int result = S1 / S2;
             Console.WriteLine($"Квадратов в прямоугольнике {result}");

             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Boolean 25");
             Console.ResetColor();

             int x, y;
             x = int.Parse(Console.ReadLine()); 
             y = int.Parse(Console.ReadLine());

            if (x<0&&y>0)
                 Console.WriteLine("Да, Точка лежит во второй координатной плоскости");
             else Console.WriteLine("Нет, Точка не лежит во второй координатной плоскости");

             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Boolean 30");
             Console.ResetColor();

             int a, b, c;
             a = int.Parse(Console.ReadLine());
             b = int.Parse(Console.ReadLine());
             c = int.Parse(Console.ReadLine());

             if (a==b&&a==c)
                 Console.WriteLine("Да,Треугольник равносторонний");
             else Console.WriteLine("Нет, Треугольник не равносторонний");

             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Boolean 35");
             Console.ResetColor();

             int x1, y1, x2, y2;
             x1 = int.Parse(Console.ReadLine());
             y1 = int.Parse(Console.ReadLine());
             x2 = int.Parse(Console.ReadLine());
             y2 = int.Parse(Console.ReadLine());

             if ((x1+y1)%2==(x2+y2)%2)
                 Console.WriteLine("Да, обе клетки одинакового цвета");
             else Console.WriteLine("Нет, клетки разных цветов");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If 20");
            Console.ResetColor();

            int A, B, C;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());

            //int L=0;
            if ((B - A) < (C - A))
            {
                Console.WriteLine($"Точка B ябляется  ближней к точке А на расстоянии {Math.Abs((B - A))}");
            }
            else
            {
                Console.WriteLine($"Точка C ябляется  ближней к точке А на расстоянии {Math.Abs((C - A))}");
            }
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If 23");
            Console.ResetColor();

            int x1, y1, x2, y2, x3, y3;
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());

            if (x2==x3)
                Console.WriteLine($"x4= {x1}");
             else if(x3==x1)
                Console.WriteLine($"x4= {x2}");
            else
                Console.WriteLine($"x4= {x3}");

            if(y2==y3)
                Console.WriteLine($"y4= {y1}");
            else if(y3==y1)
                Console.WriteLine($"y4= {y2}");
            else
                Console.WriteLine($"y4= {y3}");
        */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If 26");
            Console.ResetColor();

            int x;
            x = int.Parse(Console.ReadLine());

            if(x<=0)
                Console.WriteLine($"F(x)= {x*-1}");
            else if(x>0&&x<2)
                Console.WriteLine($"F(x)= {x*x}");
            else if(x>=2)
                Console.WriteLine($"F(x)= {4}");
            else
                Console.WriteLine("Ваши условия не подошли ");
        }
        


    }

    
}
