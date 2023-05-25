//***************************************************************************************************
// Структурное программирование. задание №1
//Даны натуральные числа n и k. Составить программу вычисления выражения 1k + 2k +...+ nk. Разработать меню программы. Пункты меню: ввод данных, обработка, просмотр результатов, выход.
//***************************************************************************************************

//int n = 0;
//int k = 0;
//bool inputComplete = false;
//do
//{
//    Console.WriteLine("Меню:\n1. Ввод данных\n2. Обработка\n3. Просмотр результатов\n4. Выход\nВыберите пункт меню (1-4): ");
//    int menuChoice = int.Parse(Console.ReadLine());
//    switch (menuChoice)
//    {
//        case 1:
//            Console.Write("Введите количество чисел (n): ");
//            n = int.Parse(Console.ReadLine());
//            Console.Write("Введите степень (k): ");
//            k = int.Parse(Console.ReadLine());
//            inputComplete = true;
//            break;
//        case 2:
//            if (!inputComplete)
//            {
//                Console.WriteLine("Сначала введите данные!");
//                break;
//            }
//            int sum = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                int poweredNumber = (int)Math.Pow(i, k);
//                sum += poweredNumber;
//            }
//            Console.WriteLine("Сумма степеней чисел от 1 до {0} в степени {1} равна {2}", n, k, sum);
//            break;
//        case 3:
//            if (!inputComplete)
//            {
//                Console.WriteLine("Сначала введите данные!");
//                break;
//            }
//            Console.WriteLine("n = {0}, k = {1}", n, k);
//            break;
//        case 4:
//            Console.WriteLine("До свидания!");
//            return;
//        default:
//            Console.WriteLine("Выберите пункт меню от 1 до 4");
//            break;
//    }
//} 
//while (true);




















//***************************************************************************************************
//Одномерные массивы. задание №2
//Дан целочисленный массив размера N. Проверить, чередуются ли в нем четные
//и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести
//порядковый номер первого элемента, нарушающего закономерность.
//***************************************************************************************************

//int[] mass = { 1, 2, 4, 4, 5, 6, 7, 8 };
//for (int i = 1; i < mass.Length; i++)
//{
//    if ((mass[i] % 2 == 0 && mass[i - 1] % 2 == 0) || (mass[i] % 2 != 0 && mass[i - 1] % 2 != 0))
//    {
//        Console.WriteLine(i);
//        break;
//    }
//    if (i == (mass.Length - 1))
//        Console.WriteLine(0);
//}
//Random random = new Random();
//int n = 10; // размер массива
//int[] arr = new int[n]; // инициализация массива
//for (int i = 0; i < n; i++)
//{
//    arr[i] = random.Next(1, 10); // заполнение массива случайными числами от 1 до 10
//    Console.Write(arr[i] + " ");
//}
//int firstViolationIndex = -1; // индекс первого нарушения закономерности
//for (int i = 1; i < n; i++)
//{
//    if ((arr[i - 1] % 2 == 0 && arr[i] % 2 == 0) || (arr[i - 1] % 2 != 0 && arr[i] % 2 != 0))
//    {
//        firstViolationIndex = i;
//        break;
//    }
//}
//if (firstViolationIndex == -1)
//{
//    Console.WriteLine("\nЧередуются четные и нечетные числа");
//}
//else
//{
//    Console.WriteLine($"\nЗакономерность нарушается на элементе с индексом {firstViolationIndex}");
//}





















//***************************************************************************************************
// Методы сортировки, задание №3
//Создать матрицу вещественных элементов А(n,n) и выполнить сортировку элементов, расположенных под главной диагональю методом «пузырька».
//Отсортированную последовательность вывести на экран
//***************************************************************************************************

//byte N = 10;
//int[,] mass = new int[,]
//{
//{91, 92, 93, 94, 95, 96, 97, 98, 99},
//{81, 82, 83, 84, 85, 86, 87, 88, 89},
//{71, 72, 73, 74, 75, 76, 77, 78, 79},
//{61, 62, 63, 64, 66, 66, 67, 68, 69},
//{51, 52, 53, 54, 55, 56, 57, 58, 59},
//{41, 42, 43, 44, 45, 46, 47, 48, 49},
//{33, 32, 33, 34, 35, 36, 37, 38, 39},
//{21, 22, 23, 24, 25, 26, 27, 28, 29},
//{11, 12, 13, 14, 15, 16, 17, 18, 19},
//{01, 02, 03, 04, 05, 06, 07, 08, 09},
//};
//int[] sortMass = new int[9];
//int bufer;
//for (int i = 1; i < mass.GetLength(0); i++)
//{
//    for (int j = 0; j < mass.GetLength(1); j++)
//    {
//        bufer = mass[i, j];
//        sortMass[i - 1] = bufer;
//        i++;
//    }
//}
//int temp;
//Console.WriteLine("3начения под главной диагональю: ");
//for (int i = 0; i < sortMass.Length; i++)
//{
//    Console.WriteLine(sortMass[i]);
//}
//for (int i = 0; i < sortMass.Length; i++)
//{
//    for (int j = 0; j < sortMass.Length - i - 1; j++)
//    {
//        if (sortMass[j] > sortMass[j + 1])
//        {
//            temp = sortMass[j];
//            sortMass[j] = sortMass[j + 1];
//            sortMass[j + 1] = temp;
//        }
//    }
//}
//Console.WriteLine("Отсортированный массив");
//for (int i = 0;i < sortMass.Length; i++)
//{
//    Console.WriteLine(sortMass[i]);
//}
//Console.ReadLine();




















//***************************************************************************************************
//Двумерные массивы. задание №4
//Дана квадратная матрица A[N, N]. Записать на место отрицательных элементов
//матрицы нули, а на место положительных — единицы. Вывести на печать
//нижнюю треугольную матрицу в общепринятом виде.
//***************************************************************************************************

//int N = 5; // размер матрицы
//int[,] A = new int[N, N];
//// заполнение матрицы случайными значениями
//Random rnd = new Random();
//for (int i = 0; i < N; i++)
//    for (int j = 0; j < N; j++)
//        A[i, j] = rnd.Next(-10, 10);
//// замена отрицательных на 0 и положительных на 1
//for (int i = 0; i < N; i++)
//    for (int j = 0; j < N; j++)
//        A[i, j] = A[i, j] < 0 ? 0 : 1;
//// вывод на печать нижней треугольной матрицы
//for (int i = 0; i < N; i++)
//{
//    for (int j = 0; j <= i; j++)
//        Console.Write(A[i, j] + " ");
//    Console.WriteLine();
//}





















//***************************************************************************************************
//Строки. задание №5
//с клавиатуры вводятся строки s, s1, s2. заменить в строке s все вхождения
//строки s1 на строку s2.
//***************************************************************************************************

//string S = Console.ReadLine();
//string S1 = Console.ReadLine();
//string S2 = Console.ReadLine();

//string result = S.Replace(S1, S2);
//Console.WriteLine(result);





















//***************************************************************************************************
//Работа с файлами №6
//Исходная информация содержится в файле. Определить, сколько слов текста имеют длину 1,2,3,…, 10 и более 10 символов. Вывести эти слова в
//последовательности возрастания их длины. Слова очередной длины вывести с новой строки.
//***************************************************************************************************

//string text = File.ReadAllText($"C:\\1.txt");
//// Разбиваем текст на слова, используя пробелы и знаки препинания как разделители
//string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '"', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
//int[] lengthCount = new int[11]; // Для каждой длины слова от 1 до 10 и более 10 символов храним количество слов
//// Подсчитываем количество слов каждой длины
//foreach (string word in words)
//{
//    int length = word.Length;
//    if (length >= 1 && length <= 10) // Длина от 1 до 10 символов
//        lengthCount[length]++;
//    else if (length > 10) // Длина более 10 символов
//        lengthCount[10]++;
//}
//// Выводим найденные слова для каждой длины на экран, сортируя их по возрастанию длины
//for (int i = 1; i <= 10; i++)
//{
//    if (i <= 9)
//        Console.WriteLine("Слова длины " + i + ": ");
//    else
//        Console.WriteLine("Слова длины более 10 символов: ");
//    var wordsOfLength = from word in words
//                        where word.Length == i
//                        orderby word
//                        select word;
//    foreach (string word in wordsOfLength)
//    {
//        Console.WriteLine(word);
//    }
//    Console.WriteLine("Количество слов длины " + i + ": " + lengthCount[i]);
//    Console.WriteLine();
//}
//Console.ReadLine();





















//***************************************************************************************************
//Методы. задание №7
//В программе обработку данных оформить в качестве метода. Дана символьная строка и символ. Слово - последовательность символов между пробелами,
//не содержащая пробелы внутри себя. Определить количество слов в строке, оканчивающихся на заданный символ.
//***************************************************************************************************

//static int CountWordsEndingWith(char endingSymbol, string sentence)
//{
//    int count = 0;
//    string[] words = sentence.Split(' '); // разбиваем предложение на слова по пробелам
//    foreach (string word in words)
//    {
//        if (word.EndsWith($"{endingSymbol}"))
//            count++;
//    }
//    return count;
//}
//Console.WriteLine("Напишите предложение.");
//string sentence = Console.ReadLine();
//char endingSymbol = 'C';
//int wordCount = CountWordsEndingWith(endingSymbol, sentence);
//Console.WriteLine($"Количество слов, заканчивающихся на букву {endingSymbol}: {wordCount}");
//Console.ReadKey();





















//***************************************************************************************************
//Структуры. задание №8
//Разработать программу, реализующую работу со структурой Аптека. В
//программе необходимо создать базу данных (массив структур) из N записей (N
//– определяется при работе программы), выполнить просмотр и поиск записи по
//заданному критерию (вводится при работе программы). Поля структуры:
//название лекарства, дата изготовления, срок годности.
//***************************************************************************************************

//struct Drug
//{
//    public string name;
//    public DateTime manufactureDate;
//    public DateTime expiryDate;
//}
//class Pharmacy
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите количество записей в базе данных: ");
//        int n = int.Parse(Console.ReadLine());
//        Drug[] drugs = new Drug[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Введите название лекарства: ");
//            drugs[i].name = Console.ReadLine();
//            Console.Write("Введите дату изготовления (в формате dd/mm/yyyy): ");
//            drugs[i].manufactureDate = DateTime.Parse(Console.ReadLine());
//            Console.Write("Введите срок годности (в месяцах): ");
//            int expiryMonths = int.Parse(Console.ReadLine());
//            drugs[i].expiryDate = drugs[i].manufactureDate.AddMonths(expiryMonths);
//        }
//        Console.WriteLine("Список всех записей:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Лекарство: {0}", drugs[i].name);
//            Console.WriteLine("Дата изготовления: {0}", drugs[i].manufactureDate.ToShortDateString());
//            Console.WriteLine("Срок годности: {0}", drugs[i].expiryDate.ToShortDateString());
//            Console.WriteLine();
//        }
//        Console.Write("Введите критерий поиска (название лекарства): ");
//        string searchTerm = Console.ReadLine().ToLowerInvariant();
//        bool found = false;
//        for (int i = 0; i < n; i++)
//        {
//            if (drugs[i].name.ToLowerInvariant().Contains(searchTerm))
//            {
//                Console.WriteLine("Лекарство: {0}", drugs[i].name);
//                Console.WriteLine("Дата изготовления: {0}", drugs[i].manufactureDate.ToShortDateString());
//                Console.WriteLine("Срок годности: {0}", drugs[i].expiryDate.ToShortDateString());
//                Console.WriteLine();
//                found = true;
//            }
//        }
//        if (!found)
//        {
//            Console.WriteLine("Запись с таким критерием не найдена.");
//        }
//        Console.ReadLine();
//    }
//}





















//***************************************************************************************************
//Списки. задание №9
//Разработать программу, реализующую работу с линейным списком. В
//программе необходимо создать базу данных (список) из N записей (N –
//определяется при работе программы), выполнить просмотр, поиск записи по
//заданному критерию. Картинная галерея. Ведётся учёт экспонатов галереи:
//наименование картины, художник, цена.
//***************************************************************************************************

//class Painting
//{
//    public string Name { get; set; }
//    public string Artist { get; set; }
//    public decimal Price { get; set; }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        LinkedList<Painting> gallery = new LinkedList<Painting>();
//        int n;
//        // запрашиваем количество записей в базе данных
//        Console.WriteLine("Введите количество записей в базе данных:");
//        n = int.Parse(Console.ReadLine());
//        // заполняем базу данных случайными записями
//        for (int i = 0; i < n; i++)
//        {
//            Painting painting = new Painting();
//            Console.WriteLine("Заполните информацию о картинах:");
//            Console.WriteLine("Наименование картины:");
//            painting.Name = Console.ReadLine();
//            Console.WriteLine("Художник:");
//            painting.Artist = Console.ReadLine();
//            Console.WriteLine("Цена:");
//            painting.Price = decimal.Parse(Console.ReadLine());
//            gallery.AddLast(painting);
//        }
//        // выводим все записи в базе данных
//        Console.WriteLine("База данных картин:");
//        foreach (Painting painting in gallery)
//        {
//            Console.WriteLine("{0}, {1}, {2}", painting.Name, painting.Artist, painting.Price);
//        }
//        // ищем запись по заданному критерию (например, по художнику)
//        Console.WriteLine("Поиск картины по художнику:");
//        string artist = Console.ReadLine();
//        LinkedListNode<Painting> node = gallery.First;
//        while (node != null)
//        {
//            if (node.Value.Artist == artist)
//            {
//                Console.WriteLine("Найдена картина: {0}, {1}, {2}", node.Value.Name, node.Value.Artist, node.Value.Price);
//                break;
//            }
//            node = node.Next;
//        }
//    }
//}





















//***************************************************************************************************
//Классы. задание №10
//Пример задания:
//Разработать класс для определения одномерных массивов строк фиксированной длины. В классе определить методы создания массива, просмотра и поиска.
//***************************************************************************************************
//using System;
//FixedLengthStringArray myArray = new FixedLengthStringArray(3);
//myArray.CreateArray(new string[] { "one", "two", "three" });
//myArray.ViewArray(); // Выводит "one, two, three"
//Console.WriteLine(myArray.Search("two")); // Выводит "True"
//Console.WriteLine(myArray.Search("four")); // Выводит "False"
//class FixedLengthStringArray
//{
//    private string[] array;
//    // Конструктор класса
//    public FixedLengthStringArray(int length)
//    {
//        array = new string[length];
//    }
//    // Метод создания нового массива
//    public void CreateArray(string[] values)
//    {
//        if (values.Length != array.Length)
//        {
//            throw new ArgumentException("Неверная длина массива");
//        }
//        values.CopyTo(array, 0);
//    }
//    // Метод просмотра массива
//    public void ViewArray()
//    {
//        Console.WriteLine(string.Join(", ", array));
//    }
//    // Метод поиска значения в массиве
//    public bool Search(string value)
//    {
//        return Array.IndexOf(array, value) != -1;
//    }
//}





















//***************************************************************************************************
//12.Многомерные массивы
//Пример задания: Дана квадратная матрица A[N, N]. Записать на место отрицательных элементов матрицы нули,
//а на место положительных — единицы. 
//***************************************************************************************************

//int[,] matrix = new int[5, 5];
//Random rnd = new Random();
//Console.WriteLine("Данная матрица:");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = rnd.Next(-10, 10);
//        Console.Write(matrix[i,j] + "   ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Матрица, состоящая из 1 и 0 (0 = отрицат., 1 = положит)");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (matrix[i,j] >= 0)
//        {
//            Console.Write("1" + "   ");
//        }
//        else if (matrix[i,j] < 0)
//        {
//            Console.Write("0" + "   ");
//        }
//    }
//    Console.WriteLine();
//}




















//***************************************************************************************************
// Строки, задание №13
//***************************************************************************************************

//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//string strInBracket;
//int StartBracket = 123456789;
//int EndBracket = 123456789;
//bool isFirstBracket = true;
//bool isLastBracket = true;
//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == '(')
//    {
//        if (isFirstBracket)
//        {
//            StartBracket = i;
//            isFirstBracket = false;
//        }
//    }
//    if (str[i] == ')')
//    {
//        EndBracket = i;
//    }
//}
//if (StartBracket == 123456789)
//{
//    Console.WriteLine("Скобок нет");
//}
//else
//{
//    for (int i = StartBracket; i < EndBracket + 1; i++)
//    {
//        Console.Write(str[i]);
//    }
//}
//Console.ReadLine();
