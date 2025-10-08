using System;
using System.Collections.Generic;

public class Tasks
{
    /// <summary>
    ///1. Возвращает дробную часть числа.
    /// </summary>
    private double Fraction(double x)
    {
        return x - (int)x;
    }

    public void FractionTask()
    {
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine($"Дробная часть: {Fraction(x)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///2. Возвращает код символа (по таблице ASCII).
    /// </summary>
    private int CharToNum(char x)
    {
        return x;
    }

    public void CharToNumTask()
    {
        Console.Write("Введите символ: ");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine($"Код символа: {CharToNum(input[0])}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///3. Проверяет, является ли число двузначным.
    /// </summary>
    private bool Is2Digits(int x)
    {
        return x >= 10 && x <= 99 || x <= -10 && x >= -99;
    }

    public void Is2DigitsTask()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine(Is2Digits(x)
                ? "Число двузначное." : "Число не двузначное.");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///4. Проверяет, входит ли число в диапазон [a, b].
    /// </summary>
    private bool IsInRange(int a, int b, int num)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        return num >= min && num <= max;
    }

    public void IsInRangeTask()
    {
        Console.Write("Введите границы диапазона и число (a b num): ");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length == 3 &&
            int.TryParse(input[0], out int a) &&
            int.TryParse(input[1], out int b) &&
            int.TryParse(input[2], out int num))
        {
            Console.WriteLine(IsInRange(a, b, num)
                ? "Число входит в диапазон."
                : "Число не входит в диапазон.");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///5. Проверяет равенство трёх чисел.
    /// </summary>
    private bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    public void IsEqualTask()
    {
        Console.Write("Введите три числа (a b c): ");
        string[] parts = Console.ReadLine().Split(' ');

        if (parts.Length == 3 &&
            int.TryParse(parts[0], out int a) &&
            int.TryParse(parts[1], out int b) &&
            int.TryParse(parts[2], out int c))
        {
            Console.WriteLine(IsEqual(a, b, c)
                ? "Все числа равны."
                : "Числа не равны.");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///6. Возвращает модуль числа.
    /// </summary>
    private int Abs(int x)
    {
        return x < 0 ? -x : x;
    }

    public void AbsTask()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine($"Модуль числа: {Abs(x)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///7. Проверяет делимость на 3 или 5.
    /// </summary>
    private bool Is35(int x)
    {
        bool div3 = x % 3 == 0;
        bool div5 = x % 5 == 0;
        return div3 ^ div5; // XOR — истина, если только одно условие верно
    }

    public void Is35Task()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine(Is35(x)
                ? "Число делится на 3 или 5 (но не на оба)."
                : "Условие не выполняется.");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///8. Возвращает максимум из трёх чисел.
    /// </summary>
    private int Max3(int x, int y, int z)
    {
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
        return max;
    }

    public void Max3Task()
    {
        Console.Write("Введите три числа (x y z): ");
        string[] parts = Console.ReadLine().Split(' ');

        if (parts.Length == 3 &&
            int.TryParse(parts[0], out int x) &&
            int.TryParse(parts[1], out int y) &&
            int.TryParse(parts[2], out int z))
        {
            Console.WriteLine($"Максимум: {Max3(x, y, z)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///9. Возвращает сумму чисел x и y, но если она от 10 до 19 — возвращает 20.
    /// </summary>
    private int Sum2(int x, int y)
    {
        int sum = x + y;
        return sum >= 10 && sum <= 19 ? 20 : sum;
    }

    public void Sum2Task()
    {
        Console.Write("Введите два числа (x y): ");
        string[] parts = Console.ReadLine().Split(' ');

        if (parts.Length == 2 &&
            int.TryParse(parts[0], out int x) &&
            int.TryParse(parts[1], out int y))
        {
            Console.WriteLine($"Результат: {Sum2(x, y)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///10. Возвращает название дня недели по номеру.
    /// </summary>
    private string Day(int x)
    {
        switch (x)
        {
            case 1: return "Понедельник";
            case 2: return "Вторник";
            case 3: return "Среда";
            case 4: return "Четверг";
            case 5: return "Пятница";
            case 6: return "Суббота";
            case 7: return "Воскресенье";
            default: return "Это не день недели";
        }
    }

    public void DayTask()
    {
        Console.Write("Введите число от 1 до 7: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine(Day(x));
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///11. Возвращает строку со всеми числами от 0 до x.
    /// </summary>
    private string ListNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    public void ListNumsTask()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine(ListNums(x));
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///12. Возвращает строку с чётными числами от 0 до x.
    /// </summary>
    private string Chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i += 2)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    public void ChetTask()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine(Chet(x));
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///13. Возвращает количество цифр в числе.
    /// </summary>
    private int NumLen(long x)
    {
        return x.ToString().Length;
    }

    public void NumLenTask()
    {
        Console.Write("Введите число: ");
        if (long.TryParse(Console.ReadLine(), out long x))
        {
            Console.WriteLine($"Количество цифр: {NumLen(x)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///14. Рисует квадрат из звёздочек.
    /// </summary>
    private void Square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void SquareTask()
    {
        Console.Write("Введите размер квадрата: ");
        if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
        {
            Square(x);
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///15. Рисует прямоугольный треугольник, выровненный по правому краю.
    /// </summary>
    private void RightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine(new string(' ', x - i) + new string('*', i));
        }
    }

    public void RightTriangleTask()
    {
        Console.Write("Введите высоту треугольника: ");
        if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
        {
            RightTriangle(x);
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }

    /// <summary>
    ///16. Возвращает индекс первого вхождения числа в массив.
    /// </summary>
    private int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    public void FindFirstTask()
    {
        Console.Write("Введите элементы массива через пробел: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.Write("Введите число для поиска: ");
        int x = int.Parse(Console.ReadLine());

        int index = FindFirst(arr, x);
        Console.WriteLine(index >= 0
            ? $"Первое вхождение на индексе {index}"
            : "Число не найдено.");
    }

    /// <summary>
    ///17. Возвращает элемент с наибольшим модулем.
    /// </summary>
    private int MaxAbs(int[] arr)
    {
        if (arr.Length == 0) throw new ArgumentException("Массив пустой");

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }
        return max;
    }

    public void MaxAbsTask()
    {
        Console.Write("Введите массив через пробел: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine($"Наибольшее по модулю значение: {MaxAbs(arr)}");
    }

    /// <summary>
    ///18. Возвращает массив с вставкой ins в arr на позицию pos.
    /// </summary>
    private int[] Add(int[] arr, int[] ins, int pos)
    {
        if (pos < 0) pos = 0;
        if (pos > arr.Length) pos = arr.Length;

        int[] result = new int[arr.Length + ins.Length];
        int i = 0;

        for (; i < pos; i++) result[i] = arr[i];
        for (int j = 0; j < ins.Length; j++, i++) result[i] = ins[j];
        for (int j = pos; j < arr.Length; j++, i++) result[i] = arr[j];

        return result;
    }

    public void AddTask()
    {
        Console.Write("Введите основной массив: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.Write("Введите вставляемый массив: ");
        int[] ins = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.Write("Введите позицию вставки: ");
        int pos = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат: " + string.Join(" ", Add(arr, ins, pos)));
    }

    /// <summary>
    ///19. Возвращает массив, записанный задом наперёд.
    /// </summary>
    private int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    public void ReverseBackTask()
    {
        Console.Write("Введите массив: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Реверсированный массив: " + string.Join(" ", ReverseBack(arr)));
    }

    /// <summary>
    ///20. Возвращает индексы всех вхождений числа в массив.
    /// </summary>
    private int[] FindAll(int[] arr, int x)
    {
        List<int> indices = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                indices.Add(i);
        }
        return indices.ToArray();
    }

    public void FindAllTask()
    {
        Console.Write("Введите массив: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.Write("Введите число для поиска: ");
        int x = int.Parse(Console.ReadLine());

        int[] result = FindAll(arr, x);

        Console.WriteLine(result.Length > 0
            ? "Индексы: " + string.Join(" ", result)
            : "Число не найдено.");
    }
}
