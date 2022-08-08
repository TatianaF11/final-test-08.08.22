void ZadachaTest()
{
    Random rand = new Random();
    int numb = rand.Next(3,8);
    string[] array = new string[numb];

    Console.WriteLine("Заполнить массив:");
    FillArray(array);
    Console.WriteLine("Формирование случайного массива:");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Вывод массива до 3х символов:");
    SortArray(array);
}
      
string[] FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}
        
string[] PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    return arr;
}

void SortArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        { 
            Console.Write(arr[i] + "\t");
        }
    }
    Console.WriteLine();
}

ZadachaTest();
