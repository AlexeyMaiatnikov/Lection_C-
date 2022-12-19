int[] array = { 1, 2, 3, 4, 11, 5, 6, 11, 7, 8, 9, 10, 11 };
int n = array.Length;
int find = 11;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
