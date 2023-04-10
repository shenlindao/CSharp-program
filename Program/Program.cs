using static Library;

int sizeArray = Convert.ToInt32(GetValue("Введите количество строк, которое собираетесь добавить: "));

string[] array1 = new string[sizeArray];
string[] array2 = new string[array1.Length];

FirstArray(array1);
SecondArray(array1, array2);
PrintArray(array2);