void ClearButton()
{
Console.WriteLine();
Console.WriteLine("Для продолжения нажми Enter");
string space = Console.ReadLine();
if (space == " ") {Console.Clear();} else {Console.Clear();}
}

// Задача. Решить методом. Напишите цикл, который приннимает два числа А и В и возводит число А в натуральную степень В
double AvStepenB(double numberA, double stepen)
{
        var result = numberA;
        if (stepen == 0)
        {
            result = 1;
        }
        else if (stepen<0)     
        {
            for (int i = 1; i <= -stepen-1 ; i++)
            {
            result = result*numberA;
            }
            result = 1/result;
            }
        else
        {
            for (int j = 1; j <= stepen-1 ; j++)
            {
            result = result*numberA;
            }
        }
        return result;
}

Console.Clear();
Console.WriteLine("Введите число А");
double digitt = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень:");
double stepenn = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Число {digitt} в степени {stepenn} равно {AvStepenB(digitt , stepenn)}");
ClearButton();


// Напишите программу которая принимает на вход число и выдает сумму чисел в числе

int SumDigits (int number)
{
    int tmp= number;
    int result = 0;
    for (int m = 0; tmp>0; m++)
    {
        result = result + tmp%10;
        tmp = tmp/10;
    }
    return result;
}


Console.WriteLine("Введите число для суммирования его цифр");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($" Сумма цифр числа равна {SumDigits(num)}");
 
ClearButton();

// Напишите программу которая задает массив из 8 элементов и выводит их на экран

Console.Clear();
Console.WriteLine("Введите количество элементов нового массива");
int elements = int.Parse(Console.ReadLine());
int[] array = new int[elements];

void FillArray (int[] fillArray)
{
    int i=0;
    for (; i < fillArray.Length; i++)
    {
        fillArray[i] = new Random().Next(10,100);
    }
}

void PrintArray (int[] printArray)
{
    Console.WriteLine();
    Console.WriteLine("Массив: ");
    int j = 0;
    for (; j < printArray.Length; j++)
    {
        Console.Write($"{printArray[j]} ");
    }

}
Console.Clear();
FillArray(array);
PrintArray(array);
ClearButton();