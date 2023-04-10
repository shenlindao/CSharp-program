public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty)
        {
            value = null;
            return value;
        }
        else
        {
            return value;
        }
    }
    public static void FirstArray(string[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            string? value = String.Empty;
            value = GetValue("Введите строку № " + (i + 1) + ": ");
            if (value != null)
            {
                array1[i] = value;
            }
            else
            {
                Console.WriteLine("Значение не может быть пустым!");
                break;
            }
        }
    }
    public static void SecondArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }
    public static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}