﻿
    
    
      // Ввод строк с клавиатуры
      // и образование нового массива

      // 1. Объявление переменных
      string[] array; // ссылка на массив строк
      int count; // текущее количество строк в массиве
      string s;
      string[] array2; // дополнительная переменная-ссылка - сохраняет старый массив строк
      
      // 2. Цикл ввода строк
      Console.WriteLine("Введите строки,для окончания ввода введите пустую строку:");

      count = 0; // обнулить количество строк
      array = new string[count]; // выделить память для 0 строк

      do
      {
        // Ввести строку
        s = Console.ReadLine();

        // Проверка, пустая ли строка
        if (s!="")
        {
          // если строка не пустая, то добавить строку в массив
          count++;

          // предварительно выделить память для нового массива
          // в котором на 1 элемент больше
          array2 = new string[count];

          // скопировать старый массив в новый
          for (int i = 0; i < array2.Length - 1; i++)
            array2[i] = array[i];

          // добавить последнюю введенную строку в массив AS2
          array2[count - 1] = s;

          // перенаправить ссылку AS на AS2
          array = array2;
        }
      } while (s != "");

    //   // 3. Вывод массива строк:
    //   for (int i = 0; i < AS.Length; i++)
    //     Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
    //   Console.ReadKey();
    int countOfSearchStr=0;
    string [] searchStrArr = new string [countOfSearchStr];

for (int i = 0; i < array.Length; i++)
if (array[i].Length<=3) 

{
 Console.WriteLine(i);// countOfSearchStr++;
}

//  Console.WriteLine(countOfSearchStr);
    
