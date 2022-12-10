// Интересное число - произведение цифр делится на сумму.
// Программа заполняет массив 10-ю интересными случайными числами от 10 до 1000.
// Каждый элемент массива - сгенерирован случайно.

// 1. Генерируем случайное число из диапазона 10 - 1000.
// 2. Проверяем - "интересное" число или нет.
    // 2.1. Раскладываем число на составляющие цифры.
    // 2.2. Записываем эти цифры в массив.
    // 2.3. Получаем в переменную произведение цифр.
    // 2.4. Получаем в переменную сумму цифр.
    // 2.5. Проверяем остаток от деления первой переменной на вторую.
    //      Если этот остаток равен 0 - то число "интересное".
// 3. Если да (число "интересное") - то записываем его в массив.
// 4. Проверяем - как только массив будет заполнен 10ю элементами - останавливаемся.
// 5. Для убедительности выводим массив на экран.

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

//функция для вывода массива
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    
    while (position < count)
    {
        Console.Write(array[position] + "  ");
        position++;
    }
    return;
}

int newRandomNumber = new Random().Next(10, 1000);
Console.WriteLine(newRandomNumber);

// Инициализируем новый массив InterestingDigits длиной 10 чисел
int[] InterestingDigits = new int[10];

int count = 0;
while (count < InterestingDigits.Length)

{

        // Разложим число на составляющие цифры
        // Для этого, сначала получим его размер numberSize, обратившись к функции GetNumberLength
        int numberSize = GetNumberLength(newRandomNumber);
        Console.WriteLine(numberSize);

        // Теперь раскладываем число на составляющие цифры и записываем в массив
        int[] ComponentsOfNumber = new int[numberSize];
        for(int i = 0; i < numberSize; i++)
        {
            ComponentsOfNumber[i] = newRandomNumber % 10;
            newRandomNumber = newRandomNumber / 10;
        }

        PrintArray(ComponentsOfNumber);

        // Производим вычисления. Вычисляем произведение цифр (multiply) и сумму цифр (sum). Делим первое значение на второе.
        int sum = 0;        // сумма чисел изначально пусть будет 0
        int multiply = 1;   // произведение чисел, чтоб не было 0 в результате произведения на 0, возмем нач. значение 1
        int j = 0;          // счетчик
        // int interestingProperty = 1; 
        while(j < numberSize)
        {
            multiply = ComponentsOfNumber[j] * multiply;
            sum = ComponentsOfNumber[j] + sum;
            j++;
        }
        // interestingProperty = multiply % sum;

        if (multiply % sum == 0)
            {
                Console.WriteLine("Интересное число");
               
                InterestingDigits[count] = newRandomNumber;
            }
            else
            {
            Console.WriteLine("НЕинтересное число");
            }

        Console.WriteLine();
        Console.WriteLine(multiply);
        Console.WriteLine(sum);
        Console.WriteLine(multiply / sum);

        // Console.WriteLine(interestingProperty);



count++;

}



