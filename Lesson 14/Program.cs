while (true)
{
    //1) Пользователь вводит положительное число (A). Вывести сумму всех цифр у чисел из диапазона от 0 до A.

    Console.WriteLine();
    Console.WriteLine("Программа1");
    Console.WriteLine();
    Console.Write("Введите положительное число: ");

    int number = Convert.ToInt32(Console.ReadLine());

    if (number <= 0)
    {
        Console.WriteLine();
        Console.WriteLine("Введите положительное число!");
    }
    else
    {
        int sum = 0;
        for (int i = 0; i <= number; i++)
        {
            int temp = i;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Cумма всех цифр чисел из диапазона от 0 до {number} = {sum}.");
    }
    Console.WriteLine();


    //2) Пользователь вводит 2 числа(A и B).Вывести количество простых чисел(которые делятся только на 1 и самих себя) в диапазоне от A до B.

    Console.WriteLine();
    Console.WriteLine("Программа2");
    Console.WriteLine();

    Console.Write("Введите число 'A': ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число 'B': ");
    int B = Convert.ToInt32(Console.ReadLine());

    if (A > B || A == B || A < 2)
    {
        Console.WriteLine();
        Console.WriteLine("Число 'A' должно быть меньше числа 'B' и больше или равно 2.");
    }
    else
    {
        int quantity = 0;

        for (int i = A; i <= B; i++)
        {
            int tmp = 0;

            for (int j = 2; j <= (int)Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    tmp++;
                }
            }
            if (tmp == 0)
            {
                quantity++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Количество простых чисел в диапазоне от {A} до {B} = {quantity}.");
    }
    Console.WriteLine();


    //3) Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться “ДА”, а, для пары 500 и 999 - “НЕТ”.

    Console.WriteLine();
    Console.WriteLine("Программа3");
    Console.WriteLine();
    Console.WriteLine("Есть ли в написании двух чисел одинаковые цифры?");
    Console.WriteLine();

    Console.Write("Введите первое число: ");
    int one = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите второе число: ");
    int second = Convert.ToInt32(Console.ReadLine());

    string result1 = "ДА.";
    string result2 = "НЕТ.";

    if (Math.Abs(one) == Math.Abs(second))
    {
        Console.WriteLine();
        Console.WriteLine(result1);
    }
    else
    {
        if (Math.Abs(one) != Math.Abs(second))
        {
            int LED = 0;
            while (one != 0)
            {
                int oneTemp = one % 10;
                one /= 10;
                int secondCopy = second;
                while (secondCopy != 0)
                {
                    int secondTemp = secondCopy % 10;
                    secondCopy /= 10;
                    if (Math.Abs(oneTemp) == Math.Abs(secondTemp))
                    {
                        LED++;
                        break;
                    }
                }
            }
            if (LED > 0)
            {
                Console.WriteLine();
                Console.WriteLine(result1);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(result2);
            }
        }
        
        else
        {
            Console.WriteLine();
            Console.WriteLine(result2);
        }
    }


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Конец!");

    Console.ReadLine();
}