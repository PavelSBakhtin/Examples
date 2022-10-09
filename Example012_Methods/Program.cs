// // // Вид 1. Ничего не принимают, ничего не возвращают
void Method1() 
{
    Console.WriteLine("Автор ...");
}
// Вызов:
Method1();

// // // Вид2. Аргументы принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Вызов:
Method2("Текст сообщения"); // Не именнованный аргумент

// // Метод с именнованным аргументом (их может быть несколько)
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент (+), декремент (-)
    }
}
// Вызов:
Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// // // Вид 3. Ничего не принимают, результат возвращают
int Method3()
{
    return DateTime.Now.Year;
}
// Вызов:
int year = Method3();
// Console.WriteLine(year);

// // // Вид4. Аргументы принимают, результат возвращают
// string Method4(int count, string text)
// {
//    int i = 0;
//    string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// // Тот же вариант, но с циклом for
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// Вызов:
string res = Method4(4, "xa");
// Console.WriteLine(res);


// // // Цикл в цикле for 
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}"); // $ - интерполяция строк
//     }
//     Console.WriteLine();
// }

// // // Работа с текстом
// string s = "qwerty";
// Console.WriteLine(s[3]); // r

// // Дан текст. В тексте нужно все пробелы заменить черточками, 
// // маленькие буквы “к” заменить большими “К”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

// Вызов:
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Сортировка одномерного массива методом выбора
int[] arr = { 8, 5, 3, 4, 2, 6, 7, 1, 9 };

void PrintArray(int[] array) // выводит массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortFromMin(int[] array) // сортирует элементы массива от min до max
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortFromMax(int[] array) // сортирует элементы массива от max до min
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int maxPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

// Вызов:
PrintArray(arr);
SelectionSortFromMin(arr); // Убрать, если не надо
SelectionSortFromMax(arr); // Убрать, если не надо
PrintArray(arr);
