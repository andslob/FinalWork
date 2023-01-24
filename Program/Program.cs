void InputArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = Convert.ToString(Console.ReadLine());
}
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
Console.Write("Введите элементы массива: ");
InputArray(array1);
string[] array2 = new string[array1.Length];
Console.WriteLine();
SecondArray(array1, array2);
PrintArray(array2);