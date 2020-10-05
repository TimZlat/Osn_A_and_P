using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrRab5_1_29
{
    //вычисление значения функции на заданном диапазоне при разных
    //значениях коэффициента а
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа начата: " + System.DateTime.Now);
            StreamWriter f_out = new StreamWriter("out.txt"); //объявили объект f_out для реализации текстового вывода в файл out.txt
            f_out.WriteLine("РЕЗУЛЬТАТ РАБОТЫ");
            f_out.WriteLine("Дата: " + System.DateTime.Now);
            for (float a=1;a<=4;a++) //внешний цикл по а
            {
                f_out.WriteLine("При а= " + a);
                for(float x=-2;x<=2;x+=0.1f) // вложенный цикл, изменяется х и вычисляется y
                {
                    float ax2 = a * x * x;
                    double y = ax2 / Math.Sqrt(1 + ax2);
                    f_out.WriteLine("x={0:f4} \t y={1:0.####}", x, y);
                }
            }
            f_out.Close();
            Console.WriteLine("Запись в файл закончена.\nДля завершения нажмите на любую клавишу...");
            Console.ReadKey();
        }
    }
}
