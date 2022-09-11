string[] array1 = new string[5];
string[] array2 = new string[array1.Length];
int count = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Напишите значение {i + 1}");
    array1[i] = Console.ReadLine();
    if (array1[i].Length <= 3)
    {
        count++;
    }
}
void SecondArrayWith(string[] array1, string[] array2)
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
        Console.Write( $"{array2[i] }  ");
    }
    Console.WriteLine();
}
SecondArrayWith(array1, array2);
PrintArray(array2);