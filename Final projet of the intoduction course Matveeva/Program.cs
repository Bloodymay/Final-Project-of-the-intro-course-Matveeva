// 1. Объявление переменных
string[] array; // ссылка на массив строк
int count; // текущее количество строк в массиве
string s;
string[] array2; // дополнительная переменная-ссылка - сохраняет старый массив строк
int countOfSearchStr = 0;

int j = 0;
// 2. Цикл ввода строк
Console.WriteLine("Введите строки,для окончания ввода введите пустую строку:");

count = 0; // обнулить количество строк
array = new string[count]; // выделить память для массива

do
{
    // Ввести строку
    s = Console.ReadLine();

    // Проверка, пустая ли строка
    if (s != "")
    {
        // если строка не пустая, то добавить строку в массив
        count++;

        // предварительно выделить память для нового массива
        // в котором на 1 элемент больше
        array2 = new string[count];

        // скопировать старый массив в новый
        for (int i = 0; i < array2.Length - 1; i++)
            array2[i] = array[i];

        // добавить последнюю введенную строку в массив array2
        array2[count - 1] = s;

        // перенаправить ссылку array на array2
        array = array2;
    }
} while (s != "");

//Считаем количество коротких элементов в массиве
for (int i = 0; i < array.Length; i++)
{    if (array[i].Length <= 3) //нахождение элементов массива,имеющих 3 или < знаков
    {
        countOfSearchStr++;// подсчет количества таких элементов
    }
}
string[] searchStrArr = new string[countOfSearchStr];

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) //нахождение элементов массива,имеющих 3 или < знаков

    {
        searchStrArr[j] = array[i]; //запись элементов в новый массив
        j++;
    }

Console.WriteLine(string.Join(", ",searchStrArr));//вывод массива в консоль