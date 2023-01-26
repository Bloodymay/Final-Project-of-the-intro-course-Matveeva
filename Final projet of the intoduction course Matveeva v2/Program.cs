int number = ReadData("Сколько строк вы хотите ввести?");
string[] arr = GenArray(number);
PrintData("Сгенерированный массив из введенных строк: ", arr);


//Метод, считывает длину массива, введенную пользователем 
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, считывает строки, введенные пользователем 
string ReadStrings(string msg)
{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}

// Метод генерирует массив из введенных пользователем строк 
string[] GenArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = ReadStrings("Введите данные: ");
    }
    return arr;
}

// Метод выводит данные пользователю 
void PrintData(string res, string[] arr)
{
    Console.WriteLine(res);
    PrintStringArray(arr);
}

// Метод печатает одномерный массив 
void PrintStringArray(string[] arr)
{
    bool x = false;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    { 
        
        
        if ((arr[i].Length <= 3)&&(x))
        {

            Console.Write(", "+ arr[i] );
        }
        if ((arr[i].Length <= 3)&&( x == false))
        {
          x=true;
          Console.Write(arr[i]);  
        }

    }
    Console.Write("]");
}

