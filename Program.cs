// Задача. из имеющегося массива строк формируем 
// массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры.

Console.Clear();

Console.WriteLine("Введите строки через пробел: ");
string input = Console.ReadLine();

// Разбиваем введенную пользователем строку на массив строк, используя пробел как разделитель
string[] strings = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

// Считаем количество строк длиной не более 3 символов
int count = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        count++;
    }
}

// Создаем новый массив, содержащий только короткие строки
string[] shortStrings = new string[count];
int index = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        // Добавляем короткую строку в новый массив
        shortStrings[index] = strings[i];
        index++;
    }
}

// Уменьшаем размер массива до количества коротких строк
Array.Resize(ref shortStrings, index);

// Выводим новый массив на экран, разделяя его элементы пробелами
Console.Write("Короткие строки: ");
Console.WriteLine(String.Join(" ", shortStrings));