// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
 // if (number[0]==number[4] || number[1]==number[3]){
    //Console.WriteLine($"Ваше число: {number} - палиндром.");
 // }
  //else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
//}

//if (number!.Length == 5){
 // CheckingNumber(number);
//}
//else Console.WriteLine($"Введи правильное число");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Double x1, x2, y1, y2, z1, z2, distance;

// Console.Write("Введите координаты x1: ");
// x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
//x2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координаты y1: ");
//y1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координаты y2: ");
//y2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координаты z1: ");
//z1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координаты z2: ");
//z2 = Convert.ToInt32(Console.ReadLine());

//distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//Console.WriteLine($"Расстояние равно {distance}");
//Console.ReadKey();

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=N; i++)
{
    Console.WriteLine(i*i*i);
}


