// Программа принимает на вход число и выдаёт сумму цифр в числе,
// которые являются делителями этого числа

//функция получения длины числа
int GetNumberLength(int val)
{
    int count = 0; // количество цифр
    while(val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}

// запросим число
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

// получаем длину введенного числа, обращаемся к функции GetNumberLength
int size = GetNumberLength(a);

int b = a; //вводим новую переменную, поскольку переменная а использовалась для получения остатка от деления
int sum = 0; //вводим новую переменную sum - её и нужно найти

// нужно разложить число на составляющие цифры и записать в массив
int[] ComponentsOfNumber = new int[size];
for(int i = 0; i < size; i++)
{
    ComponentsOfNumber[i] = a % 10;
    a = a / 10;
}

for (int i = 0; i < size; i++)
{
    if (ComponentsOfNumber[i] != 0 && b % ComponentsOfNumber[i] == 0) //проверяем, чтобы не было деления на 0
    {
        sum = (sum + ComponentsOfNumber[i]);
    }   
}

Console.WriteLine(sum);