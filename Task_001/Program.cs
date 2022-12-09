// число a возводим в степень b
// принимаем на вход два числа - а и b
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Мы будем возводить число А в натуральную степень В,");
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

            for (int i = 0; i < B; i++)
            {
                result *= A;
            }
Console.WriteLine(result);