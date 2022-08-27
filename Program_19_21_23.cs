/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

14212 -> нет

12821 -> да

23432 -> да

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.WriteLine("Введите номер задачи: 19,21 или 23:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{

case 19: 
    {
        Console.WriteLine("Введите пятизначное число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        
        if (a>99999 || a<10000) {Console.Write("Число не пятизначное");} 
            else 
            {
               int fv_num = a%10; Console.Write($" Пятое число: {fv_num}"); a = a/10;
               int f_num = a%10; Console.Write($" Четвертое число: {f_num}"); a = a/10;
               int t_num = a%10; Console.Write($" Третье число: {t_num}"); a = a/10;
               int s_num = a%10; Console.Write($" Второе число: {s_num}"); a = a/10;
               int fs_num = a%10; Console.WriteLine($" Первое число: {fs_num}");

               if (fs_num==fv_num && s_num==f_num) {Console.Write("Число является палиндромом");} else {Console.Write("Число не является палиндромом");}            
               
            }
        break;    
    } //Zadacha 19

case 21:
    {
        Console.WriteLine("Введите координаты x, y, z точки a:");
        Console.Write("x(a)= "); double xa = Convert.ToDouble(Console.ReadLine());
        Console.Write("y(a)= "); double ya = Convert.ToDouble(Console.ReadLine());
        Console.Write("z(a)= "); double za = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты x, y, z точки b:");
        Console.Write("x(b)= "); double xb = Convert.ToDouble(Console.ReadLine());
        Console.Write("y(b)= "); double yb = Convert.ToDouble(Console.ReadLine());
        Console.Write("z(b)= "); double zb = Convert.ToDouble(Console.ReadLine());
        
        double d_ab = Math.Sqrt( Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2) );
        Console.Write($"Расстояние между точками: {d_ab}");
    
        break;
    } //Zadacha 21
  
case 23:
    {
        Console.WriteLine("Введите целое число N:"); int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=N ; i++)
        {
            Console.Write($" {Math.Pow(i,3)} ,");
        }
        
        break;    
    } //Zadacha 23

}