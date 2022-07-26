// функция поиска максимального
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


// обьявляем массив
Console.Write("Введите массив через пробел : "); 
 // ввод массива
int[] array = Console.ReadLine().Split(new char[] { ' ' }, 
StringSplitOptions.RemoveEmptyEntries).Select(e => Int32.Parse(e)).ToArray();

//вызываем функцию max
int result = Max(array[0], array[1], array[2]);

Console.Write("Максимальное число "); 
Console.WriteLine(result);