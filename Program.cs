/*Task 1. Напишите программу, которая выводит 
случайное трёхзначное число и удаляет вторую цифру этого числа.*/
/*13254/10=1325
13254/100=132
13254/1000=13
13254/10000=1

13254%10=4
13254%100=54
13254%1000=254
13245%10000=3254*/

//сначала создаем метод всегда

/*int CutNumber(int num)
{
    int hundreds = num / 100; //получим сотни
    int units = num%10; // получим единицы
    int result = hundreds*10+units;
    return result;
}

int randNumber= new Random().Next(100,1000);
//первое входит в диапазон, второе- нет
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");*/

//Task 2. 
/*Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно a и b.*/
/*
bool IsDividable(int num, int a, int b)
{
    if (num%a==0 && num%b==0) return true;
    else return false;
}

Console.Write("Input number for checking");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider");
int div2 = Convert.ToInt32(Console.ReadLine());

bool result = IsDividable(number, div1, div2);
Console.Write(result);
*/

/*
Task 3.
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
/*
int HighestNum (int hnum)
{
    int first=hnum/10;
    int second=hnum%10;
    if (first > second) return first;
    else return second;
}

int randNumber=new Random().Next(10,100);
Console.WriteLine(randNumber);
int resultNum = HighestNum(randNumber);
Console.WriteLine(resultNum);
*/

/*Task 4.
Напишите программу, которая принимает на вход два числа и 
проверяет, является ли одно число квадратом другого.
*/

bool QuadResult(int num1, int num2)
{
    if (num1==num2*num2 || num2==num1*num1) return true;
    else return false;
}

Console.Write("Input first number ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int secnum = Convert.ToInt32(Console.ReadLine());

bool result = QuadResult(firstnum, secnum);
Console.WriteLine(result);
