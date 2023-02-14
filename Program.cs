// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.Write("Введите количество чисел в массиве: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];

Console.WriteLine("Вывод массива: ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}
    Console.WriteLine($"Вы ввели массив: ");
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
Console.WriteLine();

    int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        count = count+1;
    }
}
    Console.WriteLine($"Количество чисел в массиве > 0 равно {count}");