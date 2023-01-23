//Виды функций в программировании (методы)

//Вид 1 (ничего не принимает и ничего не возвращает)
void Method1()
{
    System.Console.WriteLine("Автор ...");
}
//Method1();

//Вид 2 (что-то принимает на вход, но ничего не возвращает)
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("Текст сообщения");

//еще один пример 2 вида функций  с использованием именованных аргументов
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21(count:4, msg:"Текст");

//Вид 3 (ничего не принимает, но что-то возвращает)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//System.Console.WriteLine(year);


//Вид 4 (что-то принимает, что-то возвращает)
string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
//System.Console.WriteLine(res);

//Перепишем 4 вид функции с помощью цикла FOR
string Method41(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(10, "z");
//System.Console.WriteLine(res1);

//Использование цикла в цикле (вывод таблицы умножения на экран)
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //  System.Console.WriteLine($"{i}x{j}={i*j}");   
    }
    // System.Console.WriteLine();
}

//Дан текст. В тексте нужно все пробелы заменить на черточки, 
//маленькие буквы "к" заменить на большие "К", а большие "С" заменить на маленькие "с".
string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде "
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадиде мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'к','К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'с','С');
// System.Console.WriteLine(newText);



//Упорядочивание данных внутри массива (алгоритм сортироваки методом выбора)
//Имеется последовательность чисел, задача выбрать первый элемент и в оставшейся части определить
//минимальный элемент, после того как он найден, нужно поменять выделенный с минимальным и так далее.
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array) //метод, выводящий заданный массив на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine($"{array[i]}");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array) // метод, который упорядочивает массив по возрастанию
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
